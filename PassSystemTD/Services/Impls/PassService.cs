﻿using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using PassSystemTD.Constants;
using PassSystemTD.Data;
using PassSystemTD.Entities;
using PassSystemTD.Exceptions;
using PassSystemTD.Mappers;
using PassSystemTD.Models.Enums;
using PassSystemTD.Models.Request;
using PassSystemTD.Models.Response;
using PassSystemTD.Services.Interfaces;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

namespace PassSystemTD.Services.Impls;

public class PassService : IPassService
{
    private readonly Cloudinary _cloudinary;
    private readonly DataContext _db;
    private readonly IAccountService _accountService;

    public PassService(Cloudinary cloudinary, DataContext db, IAccountService accountService)
    {
        _cloudinary = cloudinary;
        _db = db;
        _accountService = accountService;
    }

    private async Task<ImageUploadResult> UploadFileToCloudinary(IFormFile file)
    {
        try
        {
            using (var compressedStream = await CompressImageAsync(file))
            {
                var uploadParams = new ImageUploadParams
                {
                    File = new FileDescription(file.FileName, compressedStream)
                };

                var uploadResult = await _cloudinary.UploadAsync(uploadParams);

                if (uploadResult.Error != null)
                {
                    throw new Exception($"{uploadResult.Error.Message}");
                }

                return uploadResult;
            }
        }
        catch (Exception ex)
        {
            throw new BadRequestException(ErrorMessages.FailedLoadFileError);
        }
    }

    private async Task<Stream> CompressImageAsync(IFormFile file)
    {
        using var image = await Image.LoadAsync(file.OpenReadStream());
        image.Mutate(x => x.Resize(new ResizeOptions
        {
            Size = new SixLabors.ImageSharp.Size(1200, 1200),
            Mode = ResizeMode.Max
        }));

        var memoryStream = new MemoryStream();
        await image.SaveAsJpegAsync(memoryStream);
        memoryStream.Position = 0;
        return memoryStream;
    }

    public async Task<IEnumerable<PassPreviewModel>> CreatePass(string userId, PassCreateModel passCreateModel)
    {
        var user = await _accountService.GetUserById(userId);
        if (user == null) throw new NotFoundException(ErrorMessages.NotFoundUserError);

        if (passCreateModel.StartTime >= passCreateModel.EndTime)
        {
            throw new BadRequestException(ErrorMessages.StartDateError);
        }

        var pass = PassMapper.MapPassCreateModelToEntity(passCreateModel, user);

        foreach (var file in passCreateModel.Proofs)
        {
            var uploadResult = await UploadFileToCloudinary(file);
            var proof = new Proof
            {
                Id = Guid.NewGuid(),
                FileName = file.FileName,
                FileUrl = uploadResult.SecureUrl.ToString(),
                PassId = pass.Id
            };
            pass.Proofs.Add(proof);
        }

        _db.Passes.Add(pass);
        await _db.SaveChangesAsync();

        var passes = _db.Passes.Include(p => p.User).Where(p => p.UserId == user.Id)
            .Select(p => PassMapper.MapEntityToPassPreviewModel(p)).ToList();
        return passes;
    }

    public async Task<PassPagedListModel> GetPasses(string userId, PassStatus? status, string? search,
        DateTime? startDate,
        DateTime? endDate,
        string? groupNumber,
        int page,
        int pageSize)
    {
        if (page <= 0 || pageSize <= 0)
        {
            throw new BadRequestException(ErrorMessages.InvalidPageCountOrPageSizeError);
        }

        var user = await _accountService.GetUserById(userId);
        Console.WriteLine(user.Role.ToString());

        if (!user.Role.IsStudent && !user.Role.IsAdmin && !user.Role.IsDean && !user.Role.IsTeacher)
        {
            throw new BadRequestException("User role is not assigned.");
        }

        var query = _db.Passes.Include(p => p.User).AsQueryable();

        if (!(user.Role.IsAdmin || user.Role.IsDean))
        {
            if (user.Role.IsStudent && user.Role.IsTeacher)
            {
                query = query.Where(p => p.UserId == user.Id || p.PassStatus == PassStatus.Accepted);
            }
            else if (user.Role.IsStudent)
            {
                query = query.Where(p => p.UserId == user.Id);
            }
            else if (user.Role.IsTeacher)
            {
                query = query.Where(p => p.PassStatus == PassStatus.Accepted);
            }
        }

        if (status != null)
        {
            query = query.Where(p => p.PassStatus == status);
        }

        if (!string.IsNullOrWhiteSpace(search))
        {
            var lowerSearch = search.ToLower();
            query = query.Where(p => p.User.Name.ToLower().Contains(lowerSearch));
        }

        if (startDate.HasValue)
        {
            query = query.Where(p => p.StartTime >= startDate.Value);
        }

        if (endDate.HasValue)
        {
            query = query.Where(p => p.EndTime <= endDate.Value);
        }

        if (groupNumber != null)
        {
            query = query.Where(p => p.User.GroupNumber == groupNumber);
        }

        var totalItems = await query.CountAsync();
        var paginatedData = await query
            .OrderByDescending(p => p.StartTime)
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        return new PassPagedListModel
        {
            Passes = paginatedData.Select(PassMapper.MapEntityToPassPreviewModel),
            PageInfoModel = new PageInfoModel
            {
                Size = pageSize,
                Count = totalItems,
                Current = page
            }
        };
    }

    public async Task<PassDetailsModel> GetPassDetailedInfo(Guid passId)
    {
        var pass = await _db.Passes.Include(p => p.Proofs).Include(p => p.User)
            .FirstOrDefaultAsync(p => p.Id == passId);
        if (pass == null)
        {
            throw new NotFoundException(ErrorMessages.NotFoundPassError);
        }

        return PassMapper.MapEntityToPassDetailsModel(pass);
    }


    public async Task<PassDetailsModel> EditPassStatus(Guid passId, PassEditStatusModel statusModel)
    {
        var pass = await GetPassById(passId);

        await CheckIsPassInQueue(pass);

        pass.PassStatus = statusModel.Status;

        _db.Passes.Update(pass);
        await _db.SaveChangesAsync();

        return PassMapper.MapEntityToPassDetailsModel(pass);
    }

    private async Task CheckIsPassInQueue(Pass pass)
    {
        var isPassInQueue = pass.PassStatus == PassStatus.InQueue;

        if (!isPassInQueue)
        {
            throw new BadRequestException(ErrorMessages.PassNotInQueueError);
        }
    }

    public async Task<IEnumerable<PassPreviewModel>> ExtendPass(Guid passId, PassExtendModel passExtendModel,
        string studentId)
    {
        var oldPass = await GetPassById(passId);

        if (oldPass.UserId.ToString() != studentId)
        {
            throw new BadRequestException(ErrorMessages.PassAnotherUserError);
        }

        if (oldPass.PassStatus != PassStatus.Accepted)
        {
            throw new BadRequestException(ErrorMessages.PassIsNotAccepted);
        }

        var newProofs = new List<IFormFile>();

        foreach (var proof in passExtendModel.Proofs)
        {
            newProofs.Add(proof);
        }

        foreach (var proof in oldPass.Proofs)
        {
            var file = await DownloadFileFromUrl(proof.FileUrl);
            newProofs.Add(file);
        }

        var newPassCreateModel = Mappers.PassMapper.MapPassExtendModelToCreateModel(passExtendModel.StartTime,
            passExtendModel.EndTime, oldPass.Reason, newProofs);

        _db.Passes.Remove(oldPass);
        var newPasses = await CreatePass(studentId, newPassCreateModel);

        await _db.SaveChangesAsync();

        return newPasses;
    }

    private async Task<IFormFile> DownloadFileFromUrl(string url)
    {
        using var httpClient = new HttpClient();
        var response = await httpClient.GetAsync(url);
        var stream = await response.Content.ReadAsStreamAsync();
        return new FormFile(stream, 0, stream.Length, "file", Path.GetFileName(url));
    }

    private async Task<Pass> GetPassById(Guid passId)
    {
        var pass = await _db.Passes
            .Include(p => p.User)
            .Include(p => p.Proofs)
            .FirstOrDefaultAsync(p => p.Id == passId);

        if (pass == null)
        {
            throw new NotFoundException(ErrorMessages.NotFoundPassError);
        }

        return pass;
    }

    public async Task<MemoryStream> ExportPasses(DateTime? startDate, DateTime? endDate, string? groupNumber)
    {
        var passes = await GetFilteredPasses(startDate, endDate, groupNumber);

        var memoryStream = new MemoryStream();

        using (var package = new ExcelPackage(memoryStream))
        {
            var worksheet = package.Workbook.Worksheets.Add("Пропуски");

            AddPrimaryCells(worksheet);
            FillCells(worksheet, passes);

            await package.SaveAsync();
        }

        memoryStream.Position = 0;
        return memoryStream;
    }

    private async Task<IEnumerable<PassDetailsModel>> GetFilteredPasses(DateTime? startDate, DateTime? endDate,
        string? groupNumber)
    {
        var query = _db.Passes
            .Include(p => p.Proofs)
            .Include(p => p.User)
            .AsQueryable();

        if (startDate.HasValue)
        {
            query = query.Where(p => p.StartTime >= startDate.Value);
        }

        if (endDate.HasValue)
        {
            query = query.Where(p => p.EndTime <= endDate.Value);
        }

        if (!string.IsNullOrEmpty(groupNumber))
        {
            query = query.Where(p => p.User.GroupNumber == groupNumber);
        }

        var passes = await query.ToListAsync();
        return passes.Select(p => PassMapper.MapEntityToPassDetailsModel(p));
    }

    private void AddPrimaryCells(ExcelWorksheet worksheet)
    {
        worksheet.Cells[1, 1].Value = "Имя пользователя";
        worksheet.Cells[1, 2].Value = "Группа";
        worksheet.Cells[1, 3].Value = "Email пользователя";
        worksheet.Cells[1, 4].Value = "Причина пропуска";
        worksheet.Cells[1, 5].Value = "Начало";
        worksheet.Cells[1, 6].Value = "Окончание";
        worksheet.Cells[1, 7].Value = "Статус";
        worksheet.Cells[1, 8].Value = "Документы";
    }

    private void FillCells(ExcelWorksheet worksheet, IEnumerable<PassDetailsModel> passes)
    {
        int row = 2;
        foreach (var pass in passes)
        {
            worksheet.Cells[row, 1].Value = pass.UserName;
            worksheet.Cells[row, 2].Value = pass.GroupNumber;
            worksheet.Cells[row, 3].Value = pass.UserEmail;
            worksheet.Cells[row, 4].Value = pass.Reason;
            worksheet.Cells[row, 5].Value = pass.StartTime.ToString("yyyy-MM-dd HH:mm");
            worksheet.Cells[row, 6].Value = pass.EndTime.ToString("yyyy-MM-dd HH:mm");
            worksheet.Cells[row, 7].Value = pass.PassStatus.ToString();
            worksheet.Cells[row, 8].Value = pass.Proofs.Select(p => p.FileName);
            worksheet.Cells[row, 9].Value = pass.Proofs.Select(p => p.FileUrl);

            row++;
        }

        worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();
    }
}
using System.Net;
using System.Reflection.Metadata;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.EntityFrameworkCore;
using PassSystemTD.Constants;
using PassSystemTD.Data;
using PassSystemTD.Entities;
using PassSystemTD.Exceptions;
using PassSystemTD.Mappers;
using PassSystemTD.Models.Enums;
using PassSystemTD.Models.Request;
using PassSystemTD.Models.Response;
using PassSystemTD.Services.Interfaces;

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
            if (file == null || file.Length == 0)
            {
                throw new BadRequestException("Файл не может быть пустым.");
            }

            if (file.Length > 10 * 1024 * 1024) 
            {
                throw new BadRequestException("Файл слишком большой. Максимальный размер — 10 МБ.");
            }

            var uploadParams = new ImageUploadParams
            {
                File = new FileDescription(file.FileName, file.OpenReadStream())
            };

            var uploadResult = await _cloudinary.UploadAsync(uploadParams);

            if (uploadResult.Error != null)
            {
                throw new Exception($"Ошибка Cloudinary: {uploadResult.Error.Message}");
            }

            return uploadResult;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при загрузке файла в Cloudinary: {ex.Message}");
            throw new BadRequestException("Не удалось загрузить файл. Пожалуйста, попробуйте снова.");
        }
    }

    public async Task<IEnumerable<PassPreviewModel>> CreatePass(string userId, PassCreateModel passCreateModel)
    {
        var user = await _accountService.GetUserById(userId);
        if (user == null) throw new NotFoundException(ErrorMessages.NotFoundUserError);

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

        var passes = _db.Passes.Include(p => p.User).Where(p => p.UserId == user.Id).
            Select(p => PassMapper.MapEntityToPassPreviewModel(p)).ToList();
        return passes;
    }

    public async Task<IEnumerable<PassPreviewModel>> GetPasses(string userId, PassStatus? status, string? search,
        DateTime? startDate, 
        DateTime? endDate,
        int page,
        int pageSize)
    {
        if (page <= 0 || pageSize <= 0)
        {
            throw new BadRequestException(ErrorMessages.InvalidPageCountOrPageSizeError);
        }

        var user = await _accountService.GetUserById(userId);
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

        query = query.Skip((page - 1) * pageSize).Take(pageSize);
        return await query
            .Select(pass => PassMapper.MapEntityToPassPreviewModel(pass))
            .ToListAsync();
    }

    public async Task<PassDetailsModel> GetPassDetailedInfo(Guid passId)
    {
        var pass = await _db.Passes.Include(p => p.Proofs).Include(p => p.User).
            FirstOrDefaultAsync(p => p.Id == passId);
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

    public async Task<PassPreviewModel> ExtendPass(Guid passId, PassExtendModel passExtendModel, string studentId)
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
        
        var newPass = PassMapper.MapPassExtendModelToEntity(passExtendModel, oldPass, studentId);

        await UploadProofsForPass(newPass, passExtendModel.Proofs);

        _db.Passes.Remove(oldPass);
        _db.Passes.Add(newPass);
        await _db.SaveChangesAsync();

        return PassMapper.MapEntityToPassPreviewModel(newPass);
    }

    private async Task UploadProofsForPass(Pass pass, IEnumerable<IFormFile> proofs)
    {
        foreach (var file in proofs)
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
}

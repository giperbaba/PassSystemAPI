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
        var uploadParams = new ImageUploadParams
        {
            File = new FileDescription(file.FileName, file.OpenReadStream())
        };
        return await _cloudinary.UploadAsync(uploadParams);
    }

    public async Task<IEnumerable<PassPreviewModel>> CreatePass(string userId, PassCreateModel passCreateModel)
    {
        var user = await _accountService.GetUserById(userId);
        if (user == null) throw new UserNotFoundException(ErrorMessages.NotFoundUserError);

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

        var passes = _db.Passes.Include(p => p.Users).Where(p => p.UserId == user.Id).
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
        var query = _db.Passes.Include(p => p.Users).AsQueryable();
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
            query = query.Where(p => p.Users.Name.ToLower().Contains(lowerSearch));
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
}
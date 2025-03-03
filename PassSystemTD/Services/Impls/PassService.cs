using System.Reflection.Metadata;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.EntityFrameworkCore;
using PassSystemTD.Constants;
using PassSystemTD.Data;
using PassSystemTD.Entities;
using PassSystemTD.Exceptions;
using PassSystemTD.Mappers;
using PassSystemTD.Models.Request;
using PassSystemTD.Models.Response;
using PassSystemTD.Services.Interfaces;

namespace PassSystemTD.Services.Impls;

public class PassService : IPassService
{
    private readonly Cloudinary _cloudinary;
    private readonly DataContext _db;
    private readonly IAccountService _accountService;

    public PassService(IConfiguration configuration, DataContext db, IAccountService accountService)
    {
        var cloudinaryConfig = configuration.GetSection("Cloudinary");
        var account = new Account(
            cloudinaryConfig["CloudName"],
            cloudinaryConfig["ApiKey"],
            cloudinaryConfig["ApiSecret"]);
        _cloudinary = new Cloudinary(account);
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

    public async Task<IEnumerable<PassPreviewModel>> CreatePass(string token, PassCreateModel passCreateModel)
    {
        var user = await _accountService.GetUserByToken(token);
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
            Select(p => PassMapper.MapEntityToPassDetailsModel(p)).ToList();
        return passes;

    }

}
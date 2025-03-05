using PassSystemTD.Entities;
using PassSystemTD.Models.Enums;
using PassSystemTD.Models.Request;
using PassSystemTD.Models.Response;

namespace PassSystemTD.Mappers;

public abstract class PassMapper
{
    public static PassPreviewModel MapEntityToPassPreviewModel(Pass pass)
    {
        return new PassPreviewModel()
        {
            Id = pass.Id,
            StartTime = pass.StartTime,
            EndTime = pass.EndTime,
            PassStatus = pass.PassStatus,
            userName = pass.Users.Name
        };
    }
    
    public static Pass MapPassCreateModelToEntity(PassCreateModel passCreateModel, User user)
    {
        return new Pass()
        {
            Id = Guid.NewGuid(),
            UserId = user.Id,
            Reason = passCreateModel.Reason,
            StartTime = passCreateModel.StartTime,
            EndTime = passCreateModel.EndTime,
            PassStatus = PassStatus.InQueue,
            Proofs = new List<Proof>()
        };
    }
    
    public static PassDetailsModel MapEntityToPassDetailsModel(Pass pass)
    {
        return new PassDetailsModel()
        {
            UserName = pass.Users.Name,
            UserEmail = pass.Users.Email,
            Reason = pass.Reason,
            StartTime = pass.StartTime,
            EndTime = pass.EndTime,
            PassStatus = pass.PassStatus,
            Proofs = pass.Proofs.Select(proof => new DocumentModel
            {
                FileName = proof.FileName,
                FileUrl = proof.FileUrl
            }).ToList()
        };
    }
}
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
            userName = pass.User.Name
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
            UserName = pass.User.Name,
            UserEmail = pass.User.Email,
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
    
    public static Pass MapPassExtendModelToEntity(PassExtendModel passExtendModel, Pass passOld, string userId)
    {
        return new Pass()
        {
            Id = passOld.Id,
            UserId = Guid.Parse(userId),
            Reason = passOld.Reason,
            StartTime = passExtendModel.StartTime,
            EndTime = passExtendModel.EndTime,
            PassStatus = PassStatus.InQueue,
            Proofs = passOld.Proofs
        };
    }
}
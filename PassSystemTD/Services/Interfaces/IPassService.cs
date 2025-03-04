using PassSystemTD.Models.Enums;
using PassSystemTD.Models.Request;
using PassSystemTD.Models.Response;

namespace PassSystemTD.Services.Interfaces;

public interface IPassService
{
    public Task<IEnumerable<PassPreviewModel>> CreatePass(string userId, PassCreateModel passCreateModel);
    public Task<IEnumerable<PassPreviewModel>> GetPasses(string userId, PassStatus? status, string? search,DateTime? startDate, 
        DateTime? endDate, int page, int pageSize);
    //public Task<PassPreviewModel> EditPassStatus(Guid passId, PassEditStatusModel statusModel);
    //public Task<PassPreviewModel> ExtendPass(Guid passId, PassExtendModel passExtendModel);
    //public Task<IResult> DeletePass(Guid passId);
    //public Task<PassPreviewModel> GetPassDetailedInfo(Guid passId);
    //public Task<IEnumerable<PassPreviewModel>> GetPasses(SortType? sort, string? search,
        //DateTime? startDate, DateTime? endDate, int page, int pageSize);
}
using PassSystemTD.Models.Enums;
using PassSystemTD.Models.Request;
using PassSystemTD.Models.Response;

namespace PassSystemTD.Services.Interfaces;

public interface IPassService
{
    public Task<IEnumerable<PassPreviewModel>> CreatePass(string userId, PassCreateModel passCreateModel);
    public Task<PassPagedListModel> GetPasses(string userId, PassStatus? status, string? search,DateTime? startDate, 
        DateTime? endDate, int page, int pageSize);
    public Task<PassDetailsModel> EditPassStatus(Guid passId, PassEditStatusModel statusModel);
    public Task<IEnumerable<PassPreviewModel>> ExtendPass(Guid passId, PassExtendModel passExtendModel, string studentId);
    public Task<MemoryStream> ExportPasses();
    public Task<PassDetailsModel> GetPassDetailedInfo(Guid passId);

}
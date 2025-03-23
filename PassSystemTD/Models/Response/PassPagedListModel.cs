namespace PassSystemTD.Models.Response;

public class PassPagedListModel
{
    public IEnumerable<PassPreviewModel> Passes { get; set; }
    
    public PageInfoModel PageInfoModel { get; set; }
}
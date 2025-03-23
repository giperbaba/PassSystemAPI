namespace PassSystemTD.Models.Response;

public class UserPagedListModel
{
    public IEnumerable<UserProfileModel> Users { get; set; }
    
    public PageInfoModel PageInfoModel { get; set; }
}
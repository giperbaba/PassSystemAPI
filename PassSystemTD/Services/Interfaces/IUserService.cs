using PassSystemTD.Models.Enums;
using PassSystemTD.Models.Request;
using PassSystemTD.Models.Response;

namespace PassSystemTD.Services.Interfaces;

public interface IUserService
{
    public Task<IEnumerable<UserProfileModel>> GetUsers(UserRoleRequest? role, int page = 1, int pageSize = 10);
    public Task<UserProfileModel> GiveRole(Guid userId, UserRoleRequest? role, string userIdWhoDoIt);
    public bool IsUserAdmin(string userId);
    public bool IsUserDean(string userId);
    public bool IsUserStudent(string userId);
}

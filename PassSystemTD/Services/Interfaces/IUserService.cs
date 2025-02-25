using PassSystemTD.Models.Response;

namespace PassSystemTD.Services.Interfaces;

public interface IUserService
{
    public Task<IEnumerable<UserProfileModel>> GetUsers();
}
using PassSystemTD.Entities;
using PassSystemTD.Models.Request;
using PassSystemTD.Models.Response;
namespace PassSystemTD.Services.Interfaces;

public interface IAccountService
{
    public Task<TokenResponse> Register(UserRegisterModel userRegisterModel);
    public Task<TokenResponse> Login(UserLoginModel userLoginModel);
    public Task<Response> Logout(string token);
    public Task<UserProfileModel> GetProfile(string? token);
    public Task<User> GetUserByToken(string token);
    public Task<User?> GetUserById(string id);
}
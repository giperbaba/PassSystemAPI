using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PassSystemTD.Configurations;
using PassSystemTD.Constants;
using PassSystemTD.Data;
using PassSystemTD.Entities;
using PassSystemTD.Exceptions;
using PassSystemTD.Mappers;
using PassSystemTD.Models.Request;
using PassSystemTD.Models.Response;
using PassSystemTD.Services.Interfaces;

namespace PassSystemTD.Services.Impls;

public class AccountService : IAccountService
{
    private readonly DataContext _db;
    private readonly ITokenService _tokenService;
    private readonly JwtOptions _jwtOptions;
    public AccountService(DataContext db, ITokenService tokenService, IOptions<JwtOptions> options)
    {
        _db = db;
        _tokenService = tokenService;
        _jwtOptions = options.Value;
    }

    public async Task<TokenResponse> Login(UserLoginModel userLoginModel)
    {
        if (await _db.Users.FirstOrDefaultAsync(user => user.Email == userLoginModel.Email) is null)
        {
            throw new BadRequestException(ErrorMessages.ProfileNotExistsError);
        }
        var user = await _db.Users.FirstOrDefaultAsync(user => user.Email == userLoginModel.Email);
        if (!BCrypt.Net.BCrypt.Verify(userLoginModel.Password, user.Password)) { 
            throw new BadRequestException(ErrorMessages.PasswordNotExistsError);
        }
        var token = new TokenResponse { Token = _tokenService.GenerateToken(user) };
        return token;
    }

    public async Task<Response> Logout(string token)
    {
        token = _tokenService.ExtractTokenFromHeader(token);
        if (await _tokenService.IsTokenBanned(token)) throw new InvalidTokenException(ErrorMessages.UnauthorizedError);
        var tokenExpiresAt = DateTime.UtcNow.AddHours(_jwtOptions.ExpiresHours); 
        _db.BannedTokens.Add(new TokenEntity { Token = token, ExpiresAt = tokenExpiresAt });
        await _db.SaveChangesAsync();
        return await Task.FromResult(new Response("200", "Logout successful"));
    }

    public async Task<User> GetUserByToken(string token)
    {
        if (string.IsNullOrWhiteSpace(token))
        {
            throw new InvalidTokenException(ErrorMessages.UnauthorizedError);
        }

        if (await _tokenService.IsTokenBanned(token))
        {
            throw new InvalidTokenException(ErrorMessages.UnauthorizedError);
        }

        var userId = _tokenService.GetIdByToken(token);
        if (string.IsNullOrWhiteSpace(userId))
        {
            throw new InvalidTokenException(ErrorMessages.UnauthorizedError);
        }

        var user = await _db.Users.FirstOrDefaultAsync(user => user.Id.ToString() == userId);
        if (user == null) throw new BadRequestException(ErrorMessages.ProfileNotExistsError);
        return user;
    }

    public Task<User?> GetUserById(string id)
    {
        return _db.Users.FirstOrDefaultAsync(user => user.Id.ToString() == id);
    }

    public async Task<UserProfileModel> GetProfile(string token)
    {
        if (string.IsNullOrWhiteSpace(token))
        {
            throw new InvalidTokenException(ErrorMessages.UnauthorizedError);
        }

        if (await _tokenService.IsTokenBanned(token))
        {
            throw new InvalidTokenException(ErrorMessages.UnauthorizedError);
        }
        var user = await GetUserByToken(token);
        return UserMapper.MapEntityToUserProfileModel(user);
    }
}
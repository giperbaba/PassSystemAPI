using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using PassSystemTD.Models.Request;
using PassSystemTD.Services.Interfaces;

namespace PassSystemTD.Controllers;

[ApiController]
public class AccountController : ControllerBase
{
    private readonly IAccountService _accountService;
    private readonly ITokenService _tokenService;
    public AccountController(IAccountService accountService, ITokenService tokenService)
    {
        _accountService = accountService;
        _tokenService = tokenService;

    }
    [HttpPost("login")]
    public async Task<IActionResult> Login(UserLoginModel userLoginModel)
    {
        var token = await _accountService.Login(userLoginModel);
        return Ok(token);
    }
    
    [HttpPost("registration")]
    public async Task<IActionResult> Register(UserRegisterModel userRegisterModel)
    {
        return Ok(await _accountService.Register(userRegisterModel));
    }
    
    [Authorize]
    [HttpGet("profile")]
    public async Task<IActionResult> GetProfile()
    {
        var authorizationHeader = Request.Headers["Authorization"].ToString();
        var token = _tokenService.ExtractTokenFromHeader(authorizationHeader);
        return Ok(await _accountService.GetProfile(token));
    }
    
    [Authorize]
    [HttpPost("logout")]
    public async Task<IActionResult> Logout()
    {
        string token = HttpContext.Request.Headers["Authorization"];

        return Ok(await _accountService.Logout(token));
    }
}
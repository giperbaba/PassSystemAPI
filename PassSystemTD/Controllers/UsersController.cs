using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PassSystemTD.Models.Enums;
using PassSystemTD.Services.Interfaces;

namespace PassSystemTD.Controllers;

[ApiController]
public class UsersController: BaseController
{
    private readonly IUserService _userService;

    public UsersController(IUserService userService, IPassService passService):base(userService)
    {
        _userService = userService;
    }
    
    [Authorize]
    [HttpGet("users")]
    public async Task<IActionResult> GetUsers(UserRoleRequest? role,
        string? search = null,
        int page = 1,
        int pageSize = 10)
    {
        await EnsureAdminOrDeanRights(GetUserData(ClaimTypes.Sid));

        var users = await _userService.GetUsers(role, search, page, pageSize);
        return Ok(users);
    }
    
    [Authorize]
    [HttpPost("users/role/{id}")]
    public async Task<IActionResult> GiveRole(Guid id, UserRoleRequest? role)
    {
        await EnsureAdminOrDeanRights(GetUserData(ClaimTypes.Sid));
        
        return Ok(await _userService.GiveRole(id, role, GetUserData(ClaimTypes.Sid)));
    }
}
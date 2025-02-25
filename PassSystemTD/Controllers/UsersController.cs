using Microsoft.AspNetCore.Mvc;
using PassSystemTD.Services.Interfaces;

namespace PassSystemTD.Controllers;

[ApiController]
public class UsersController: ControllerBase
{
    private readonly IUserService _userService;

    public UsersController(IUserService userService)
    {
        _userService = userService;
    }
    
    [HttpGet("users")]
    public async Task<IActionResult> GetUsers()
    {
        return Ok(await _userService.GetUsers());
    }
}
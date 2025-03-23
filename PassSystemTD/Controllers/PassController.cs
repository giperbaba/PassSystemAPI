using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PassSystemTD.Models.Enums;
using PassSystemTD.Models.Request;
using PassSystemTD.Services.Interfaces;

namespace PassSystemTD.Controllers;

[ApiController]
public class PassController: BaseController
{
    private readonly IPassService _passService;
    private readonly ITokenService _tokenService;

    public PassController(IUserService userService, IPassService passService, ITokenService tokenService) : base(userService)
    {
        _passService = passService;
        _tokenService = tokenService;
    }
    
    [Authorize]
    [HttpPost("pass")]
    public async Task<IActionResult> CreatePass([FromForm] PassCreateModel passCreateModel)
    {
        await EnsureStudentsRights(GetUserData(ClaimTypes.Sid));
        return Ok(await _passService.CreatePass(GetUserData(ClaimTypes.Sid), passCreateModel));
    }
    
    [Authorize]
    [HttpGet("pass/list")]
    public async Task<IActionResult> GetPasses(PassStatus? status,
        string? search,
        DateTime? startDate,
        DateTime? endDate,
        string? groupNumber,
        int page = 1,
        int pageSize = 10)
    {
        return Ok(await _passService.GetPasses(GetUserData(ClaimTypes.Sid), status, search, startDate, endDate, groupNumber, page, pageSize)); 
    }
    
    [Authorize]
    [HttpGet("pass/{id}/details")]
    public async Task<IActionResult> GetPassDetailedInfo([FromRoute] Guid id)
    {
        return Ok(await _passService.GetPassDetailedInfo(id));
    }
    
    [Authorize]
    [HttpPut("pass/{id}/status")]
    public async Task<IActionResult> EditPassStatus(Guid id, PassEditStatusModel passEStatusModel)
    {
        await EnsureAdminOrDeanRights(GetUserData(ClaimTypes.Sid));
        return Ok(await _passService.EditPassStatus(id, passEStatusModel));
    }
    
    [Authorize]
    [HttpPut("pass/{id}/extend")]
    public async Task<IActionResult> ExtendPass(Guid id, [FromForm] PassExtendModel passExtendModel)
    {
        await EnsureStudentsRights(GetUserData(ClaimTypes.Sid));
        return Ok(await _passService.ExtendPass(id, passExtendModel, GetUserData(ClaimTypes.Sid)));
    }
    
    [Authorize]
    [HttpGet("pass/export")]
    public async Task<IActionResult> ExportPasses(DateTime? startDate, DateTime? endDate, string? groupNumber)
    {
        await EnsureAdminOrDeanRights(GetUserData(ClaimTypes.Sid));
        var memoryStream = await _passService.ExportPasses(startDate, endDate, groupNumber);
            
        return File(memoryStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", 
            $"passes_export_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx");
    }
    
    /*[HttpDelete("pass/{id}")]
    public async Task<IActionResult> DeletePass(Guid id)
    {
        return Ok(await _passService.DeletePass(id));
    }*/
}
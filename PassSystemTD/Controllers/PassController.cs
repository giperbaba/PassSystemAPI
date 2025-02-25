using Microsoft.AspNetCore.Mvc;
using PassSystemTD.Models.Enums;
using PassSystemTD.Models.Request;
using PassSystemTD.Services.Interfaces;

namespace PassSystemTD.Controllers;

public class PassController: ControllerBase
{
    private readonly IPassService _passService;

    public PassController(IPassService passService)
    {
        _passService = passService;
    }
    
    [HttpPost("pass")]
    public async Task<IActionResult> CreatePass(Guid userId, PassCreateModel passCreateModel)
    {
        return Ok(await _passService.CreatePass(userId, passCreateModel));
    }
    
    [HttpPut("pass/{id}/status")]
    public async Task<IActionResult> EditPassStatus(Guid id, PassEditStatusModel passEStatusModel)
    {
        return Ok(await _passService.EditPassStatus(id, passEStatusModel));
    }
    
    [HttpPut("pass/{id}/extend")]
    public async Task<IActionResult> ExtendPass(Guid id, PassExtendModel passExtendModel)
    {
        return Ok(await _passService.ExtendPass(id, passExtendModel));
    }
    
    [HttpDelete("pass/{id}")]
    public async Task<IActionResult> DeletePass(Guid id)
    {
        return Ok(await _passService.DeletePass(id));
    }
    
    [HttpGet("pass/{id}/details")]
    public async Task<IActionResult> GetPassDetailedInfo(Guid id)
    {
        return Ok(await _passService.GetPassDetailedInfo(id));
    }
    
    [HttpGet("pass/list")]
    public async Task<IActionResult> GetPasses([FromQuery] SortType? sort,
        [FromQuery] string? search,
        [FromQuery] DateTime? startDate,
        [FromQuery] DateTime? endDate,
        [FromQuery] int page = 1,
        [FromQuery] int pageSize = 10)
    {
        return Ok(await _passService.GetPasses(sort, search, startDate, endDate, page, pageSize)); 
    }
}
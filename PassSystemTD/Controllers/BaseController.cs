using Microsoft.AspNetCore.Mvc;
using PassSystemTD.Exceptions;
using PassSystemTD.Services.Interfaces;

namespace PassSystemTD.Controllers;

public class BaseController: ControllerBase
{
    private readonly IUserService _userService;

    protected BaseController(IUserService userService)
    {
        _userService = userService;
    }
    
    protected string GetUserData(string claimType)
    {
        var data = HttpContext.User.Claims.FirstOrDefault(c => c.Type == claimType)?.Value;

        if (data == null) throw new UnauthorizedAccessException();

        return data;
    }
    
    protected async Task EnsureAdminRights(string id)
    {
        var isAdmin = _userService.IsUserAdmin(id);
        if (!isAdmin)
        {
            throw new AccessDeniedException(Constants.ErrorMessages.AccessDeniedAdminError);
        }
    }
    
    protected async Task EnsureAdminOrDeanRights(string id)
    {
        var isAdmin = _userService.IsUserAdmin(id);
        var isDean = _userService.IsUserDean(id);
        
        if (!isDean && !isAdmin)
        {
            throw new AccessDeniedException(Constants.ErrorMessages.AccessDeniedAdminDeanError);
        }
    }
    protected async Task EnsureStudentsRights(string id)
    {
        var isStudent = _userService.IsUserStudent(id);
        
        if (!isStudent)
        {
            throw new AccessDeniedException(Constants.ErrorMessages.AccessDeniedStudentError);
        }
    }
}
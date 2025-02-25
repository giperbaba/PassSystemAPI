using System.ComponentModel.DataAnnotations;
using PassSystemTD.Constants;
using PassSystemTD.Models.Enums;

namespace PassSystemTD.Models.Request;

public class UserRoleChangeModel
{
    [Required(ErrorMessage = ErrorMessages.RequiredField)]
    UserRole Role { get; set; }
}
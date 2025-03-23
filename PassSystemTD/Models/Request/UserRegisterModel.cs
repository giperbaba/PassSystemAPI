using System.ComponentModel.DataAnnotations;
using PassSystemTD.Constants;
using PassSystemTD.Models.Enums;

namespace PassSystemTD.Models.Request;

public class UserRegisterModel
{
    [Required(ErrorMessage = ErrorMessages.RequiredField)]
    [StringLength(1000, MinimumLength = 1, ErrorMessage = ErrorMessages.NameLengthError)]
    public string Name { get; set; }

    [Required(ErrorMessage = ErrorMessages.RequiredField)]
    public DateTime? BirthDate { get; set; }

    [Required(ErrorMessage = ErrorMessages.RequiredField)]
    public Gender Gender { get; set; }

    [EmailAddress(ErrorMessage = ErrorMessages.EmailValidError)]
    [Required(ErrorMessage = ErrorMessages.RequiredField)]
    [StringLength(1000, MinimumLength = 1, ErrorMessage = ErrorMessages.EmailLengthError)]
    public string Email { get; set; }
    
    [Required(ErrorMessage = ErrorMessages.RequiredField)]
    [StringLength(1000, MinimumLength = 6, ErrorMessage = ErrorMessages.PasswordLengthError)]
    [RegularExpression(RegexConstants.PasswordRegex, ErrorMessage = ErrorMessages.PasswordNotValid)]
    public string Password { get; set; }
    
    [Required(ErrorMessage = ErrorMessages.RequiredField)]
    public UserRoleRequest Role { get; set; }
    
    [StringLength(6, ErrorMessage = ErrorMessages.GroupLengthError)]
    [RegularExpression(RegexConstants.GroupRegex, ErrorMessage = ErrorMessages.GroupNotValid)]
    public string? GroupNumber { get; set; }
}
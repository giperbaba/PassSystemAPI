using System.ComponentModel.DataAnnotations;
using PassSystemTD.Constants;

namespace PassSystemTD.Models.Request;

public class UserLoginModel
{
    [Required(ErrorMessage = ErrorMessages.RequiredField)]
    [StringLength(1000, MinimumLength = 1, ErrorMessage = ErrorMessages.EmailLengthError)]
    [EmailAddress(ErrorMessage = ErrorMessages.EmailNotValid)]
    public string Email { get; set; }
    
    [Required(ErrorMessage = ErrorMessages.RequiredField)]
    [StringLength(1000, MinimumLength = 6, ErrorMessage = ErrorMessages.PasswordLengthError)]
    [RegularExpression(RegexConstants.PasswordRegex, ErrorMessage = ErrorMessages.PasswordNotValid)]
    public string Password { get; set; }
}
using System.ComponentModel.DataAnnotations;
using PassSystemTD.Constants;

namespace PassSystemTD.Models.Response;

public class UserProfileModel
{
    [Required(ErrorMessage = ErrorMessages.RequiredField)]
    [StringLength(1000, MinimumLength = 1, ErrorMessage = ErrorMessages.NameLengthError)]
    public string? FullName { get; set; }

    public DateTime? BirthDate { get; set; }


    [Required(ErrorMessage = ErrorMessages.RequiredField)]
    [StringLength(1000, MinimumLength = 1, ErrorMessage = ErrorMessages.EmailLengthError)]
    [EmailAddress(ErrorMessage = ErrorMessages.EmailNotValid)]
    public string? Email { get; set; }
}
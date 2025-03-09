using System.ComponentModel.DataAnnotations;
using PassSystemTD.Constants;
using PassSystemTD.Models.Enums;

namespace PassSystemTD.Models.Response;

public class UserProfileModel
{
    public Guid Id { get; init; }
    
    [Required(ErrorMessage = ErrorMessages.RequiredField)]
    [StringLength(1000, MinimumLength = 1, ErrorMessage = ErrorMessages.NameLengthError)]
    public string? FullName { get; set; }

    public DateTime? BirthDate { get; set; }


    [Required(ErrorMessage = ErrorMessages.RequiredField)]
    [StringLength(1000, MinimumLength = 1, ErrorMessage = ErrorMessages.EmailLengthError)]
    [EmailAddress(ErrorMessage = ErrorMessages.EmailNotValid)]
    public string? Email { get; set; }
    
    public IEnumerable<UserRole>? RoleEnum { get; set; }
    
    public UserRoleRequest UserWantToBe { get; set; }
}
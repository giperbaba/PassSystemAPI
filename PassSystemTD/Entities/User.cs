using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PassSystemTD.Constants;
using PassSystemTD.Models.Enums;

namespace PassSystemTD.Entities;


[Table("Users")]
public class User
{
    [Required(ErrorMessage = ErrorMessages.RequiredField)]
    [Key] public Guid Id { get; set; }

    [Required(ErrorMessage = ErrorMessages.RequiredField)]
    [StringLength(1000, MinimumLength = 1, ErrorMessage = ErrorMessages.NameLengthError)]
    public string Name { get; set; }

    public DateTime? BirthDate { get; set; }

    [Required(ErrorMessage = ErrorMessages.RequiredField)]
    public Gender Gender { get; set; }

    [EmailAddress(ErrorMessage = ErrorMessages.EmailValidError)]
    [Required(ErrorMessage = ErrorMessages.RequiredField)]
    [StringLength(1000, MinimumLength = 1, ErrorMessage = ErrorMessages.EmailLengthError)]
    public string Email { get; set; }
    public string Password { get; set; }
}
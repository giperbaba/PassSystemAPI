using System.ComponentModel.DataAnnotations;
using PassSystemTD.Constants;

namespace PassSystemTD.Entities;

public class TokenEntity
{
    [Key]
    [Required(ErrorMessage = ErrorMessages.TokenError)]
    [StringLength(1000, MinimumLength = 1, ErrorMessage = ErrorMessages.TokenLengthError)]
    public string Token { get; set; }
    public DateTime ExpiresAt { get; set; }
}
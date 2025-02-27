using System.ComponentModel.DataAnnotations;
using PassSystemTD.Constants;

namespace PassSystemTD.Models.Response;

public class TokenResponse
{
    [Required(ErrorMessage = ErrorMessages.TokenError)]
    [StringLength(1000, MinimumLength = 1, ErrorMessage = ErrorMessages.TokenLengthError)]
    public string Token { get; set; }

}
using System.ComponentModel.DataAnnotations;
using PassSystemTD.Constants;

namespace PassSystemTD.Models.Response;

public class DocumentModel
{
    [Required(ErrorMessage = ErrorMessages.RequiredField)]
    string Url {get; set;}
}
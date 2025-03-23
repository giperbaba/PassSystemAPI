using System.ComponentModel.DataAnnotations;
using PassSystemTD.Constants;

namespace PassSystemTD.Models.Response;

public class DocumentModel
{
    [Required(ErrorMessage = ErrorMessages.RequiredField)]
    public string FileName { get; set; }
    
    [Required(ErrorMessage = ErrorMessages.RequiredField)]
    public string FileUrl {get; set;}
}
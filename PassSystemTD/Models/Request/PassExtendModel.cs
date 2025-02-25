using System.ComponentModel.DataAnnotations;
using PassSystemTD.Constants;
using PassSystemTD.Models.Response;

namespace PassSystemTD.Models.Request;

//Продление пропуска
public class PassExtendModel
{
    [Required(ErrorMessage = ErrorMessages.RequiredField)]
    public DateTime StartTime { get; set; }
    
    [Required(ErrorMessage = ErrorMessages.RequiredField)]
    public DateTime EndTime { get; set; }
    
    public IEnumerable<DocumentModel> Documents { get; set; }
}
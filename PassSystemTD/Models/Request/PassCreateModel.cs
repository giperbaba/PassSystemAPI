using System.ComponentModel.DataAnnotations;
using PassSystemTD.Constants;
using PassSystemTD.Models.Enums;
using PassSystemTD.Models.Response;

namespace PassSystemTD.Models.Request;

public class PassCreateModel
{
    [Required(ErrorMessage = ErrorMessages.RequiredField)]
    [StringLength(1000, MinimumLength = 1)]
    public string Reason { get; set; }
    
    [Required(ErrorMessage = ErrorMessages.RequiredField)]
    public DateTime StartTime { get; set; }
    
    [Required(ErrorMessage = ErrorMessages.RequiredField)]
    public DateTime EndTime { get; set; }
    
    [Required(ErrorMessage = ErrorMessages.RequiredField)]
    public IEnumerable<DocumentModel> Documents { get; set; }
}
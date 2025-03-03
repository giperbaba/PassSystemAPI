using System.ComponentModel.DataAnnotations;
using PassSystemTD.Constants;
using PassSystemTD.Entities;

namespace PassSystemTD.Models.Response;

public class PassDetailsModel
{
    [Required(ErrorMessage = ErrorMessages.RequiredField)]
    [StringLength(1000, MinimumLength = 1)]
    public string Reason { get; set; }
    
    [Required(ErrorMessage = ErrorMessages.RequiredField)]
    public DateTime StartTime { get; set; }
    
    [Required(ErrorMessage = ErrorMessages.RequiredField)]
    public DateTime EndTime { get; set; }
    
    public IEnumerable<DocumentModel> Documents { get; set; }
}
using System.ComponentModel.DataAnnotations;
using PassSystemTD.Constants;

namespace PassSystemTD.Models.Response;

public class PassDetailsModel
{
    [Required(ErrorMessage = ErrorMessages.RequiredField)]
    [StringLength(1000, MinimumLength = 1)]
    public string Name { get; set; }
    
    [Required(ErrorMessage = ErrorMessages.RequiredField)]
    public DateTime StartTime { get; set; }
    
    [Required(ErrorMessage = ErrorMessages.RequiredField)]
    public DateTime EndTime { get; set; }
    
    [StringLength(1000, MinimumLength = 1)]
    public string Description { get; set; }
    
    public IEnumerable<DocumentModel> Documents { get; set; }
}
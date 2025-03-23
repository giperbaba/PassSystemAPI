using System.ComponentModel.DataAnnotations;
using PassSystemTD.Constants;
using PassSystemTD.Models.Enums;

namespace PassSystemTD.Models.Response;

public class PassPreviewModel
{
    public Guid Id { get; set; } 
    
    [Required(ErrorMessage = ErrorMessages.RequiredField)]
    [StringLength(1000, MinimumLength = 1)]
    public string userName { get; set; }
    
    [Required(ErrorMessage = ErrorMessages.RequiredField)]
    public DateTime StartTime { get; set; }
    
    [Required(ErrorMessage = ErrorMessages.RequiredField)]
    public DateTime EndTime { get; set; }
    
    [Required(ErrorMessage = ErrorMessages.RequiredField)]
    public PassStatus PassStatus { get; set; }
    
    public string? groupNumber { get; set; }
}
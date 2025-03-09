using System.ComponentModel.DataAnnotations;
using PassSystemTD.Constants;
using PassSystemTD.Entities;
using PassSystemTD.Models.Enums;

namespace PassSystemTD.Models.Response;

public class PassDetailsModel
{   
    public Guid Id { get; set; } 
    
    [Required(ErrorMessage = ErrorMessages.RequiredField)]
    [StringLength(1000, MinimumLength = 1)]
    public string UserName { get; set; }
    
    [Required(ErrorMessage = ErrorMessages.RequiredField)]
    [StringLength(1000, MinimumLength = 1, ErrorMessage = ErrorMessages.EmailLengthError)]
    [EmailAddress(ErrorMessage = ErrorMessages.EmailNotValid)]
    public string UserEmail { get; set; }
    
    [Required(ErrorMessage = ErrorMessages.RequiredField)]
    [StringLength(1000, MinimumLength = 1)]
    public string Reason { get; set; }
    
    [Required(ErrorMessage = ErrorMessages.RequiredField)]
    public DateTime StartTime { get; set; }
    
    [Required(ErrorMessage = ErrorMessages.RequiredField)]
    public DateTime EndTime { get; set; }
    
    [Required(ErrorMessage = ErrorMessages.RequiredField)]
    public PassStatus PassStatus { get; set; }
    public IEnumerable<DocumentModel> Proofs { get; set; }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;
using PassSystemTD.Constants;
using PassSystemTD.Models.Enums;

namespace PassSystemTD.Entities;

public class Pass
{
    [Key]  public Guid Id { get; set; } 
    
    [Required(ErrorMessage = ErrorMessages.RequiredField)]
    [StringLength(1000, MinimumLength = 1)]
    public string Reason { get; set; }
    
    [Required(ErrorMessage = ErrorMessages.RequiredField)]
    public DateTime StartTime { get; set; }
    
    [Required(ErrorMessage = ErrorMessages.RequiredField)]
    public DateTime EndTime { get; set; }
    
    [Required(ErrorMessage = ErrorMessages.RequiredField)]
    public PassStatus PassStatus { get; set; }
    
    public Guid UserId { get; set; }
    public User Users { get; set; }
    
    [Required(ErrorMessage = ErrorMessages.RequiredField)]
    public ICollection<Proof> Proofs { get; set; } = new List<Proof>();
}
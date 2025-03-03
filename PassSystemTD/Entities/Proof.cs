using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PassSystemTD.Constants;

namespace PassSystemTD.Entities;

public class Proof
{
    [Key]
    public Guid Id { get; set; }

    [Required(ErrorMessage = ErrorMessages.RequiredField)]
    public string FileName { get; set; }

    [Required(ErrorMessage = ErrorMessages.RequiredField)]
    public string FileUrl { get; set; }
    
    [ForeignKey("Pass")]
    public Guid PassId { get; set; }
    public Pass Pass { get; set; }
}
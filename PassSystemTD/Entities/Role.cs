using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PassSystemTD.Entities;

[Table("Role")]
public class Role
{
    public Role(Guid id, bool isAdmin, bool isStudent, bool isTeacher, bool isDean)
    {
        Id = id;
        IsAdmin = isAdmin;
        IsStudent = isStudent;
        IsTeacher = isTeacher;
        IsDean = isDean;
    }

    [Key]  public Guid Id { get; set; } 
    public bool IsAdmin { get; set; } = false;
    public bool IsStudent { get; set; } = false;
    public bool IsTeacher { get; set; } = false;
    public bool IsDean { get; set; } = false;
    
    
    
    [ForeignKey("Id")]
    public User User { get; set; }
}
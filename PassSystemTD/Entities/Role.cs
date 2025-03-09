using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PassSystemTD.Models.Enums;

namespace PassSystemTD.Entities;

[Table("Role")]
public class Role
{
    public Role(Guid userId, bool isAdmin, bool isStudent, bool isTeacher, bool isDean)
    {
        Id = Guid.NewGuid(); 
        UserId = userId; 
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
    
    public UserRoleRequest UserWantToBe{ get; set; } = UserRoleRequest.Student;
    
    public Guid UserId { get; set; }  
    [ForeignKey("UserId")]
    public User User { get; set; }
}
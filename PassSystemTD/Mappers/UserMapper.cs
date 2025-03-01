using PassSystemTD.Entities;
using PassSystemTD.Models.Enums;
using PassSystemTD.Models.Response;

namespace PassSystemTD.Mappers;

public abstract class UserMapper
{
    public static UserProfileModel MapEntityToUserProfileModel(User user)
    {
        return new UserProfileModel()
        {
            Id = user.Id,
            FullName = user.Name,
            BirthDate = user.BirthDate,
            Email = user.Email,
            RoleEnum = MapEntityToRoleModel(user.Role),
        };
    }

    public static IList<UserRole>? MapEntityToRoleModel(Role role)
    { 
        IList<UserRole> roles = new List<UserRole>();
        
       if (role.IsAdmin) { roles.Add(UserRole.Admin); }
       if (role.IsDean) { roles.Add(UserRole.Dean); }
       if (role.IsStudent) { roles.Add(UserRole.Student); }
       if (role.IsTeacher) { roles.Add(UserRole.Teacher); } 
       
       return roles.Count > 0 ? roles : null;
    }
}
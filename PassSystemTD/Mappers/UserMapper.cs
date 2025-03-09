using PassSystemTD.Entities;
using PassSystemTD.Models.Enums;
using PassSystemTD.Models.Request;
using PassSystemTD.Models.Response;
using PassSystemTD.Utils;

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
    
    public static User MapUserFromRegisterModelToEntity(UserRegisterModel userRequest)
    {
        var hashedPassword = PasswordHasher.Hash(userRequest.Password);

        return new User(){
            BirthDate = userRequest.BirthDate,
            Email = userRequest.Email,
            Name = userRequest.Name,
            Gender = userRequest.Gender,
            Password = hashedPassword,
            };
    }

    public static UserRoleRequest? MapRoleEntityToRoleRequest(UserRole role)
    {
        if (role == UserRole.Dean)
        {
            return UserRoleRequest.Dean;
        }

        if (role == UserRole.Student)
        {
            return UserRoleRequest.Student;
        }

        if (role == UserRole.Teacher)
        {
            return UserRoleRequest.Teacher;
        }

        return null;
    }
}
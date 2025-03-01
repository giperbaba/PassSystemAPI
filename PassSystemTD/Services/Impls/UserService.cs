using System.Net;
using Microsoft.EntityFrameworkCore;
using PassSystemTD.Constants;
using PassSystemTD.Data;
using PassSystemTD.Entities;
using PassSystemTD.Exceptions;
using PassSystemTD.Mappers;
using PassSystemTD.Models.Enums;
using PassSystemTD.Models.Response;
using PassSystemTD.Services.Interfaces;

namespace PassSystemTD.Services.Impls;

public class UserService : IUserService
{
    private readonly DataContext _db;

    public UserService(DataContext db)
    {
        _db = db;
    }

    public async Task<IEnumerable<UserProfileModel>> GetUsers(UserRoleRequest? role, int page, int pageSize)
    //Если роль не указана, а то есть равна null, то отправляем всех пользователей
    {
        if (page <= 0 || pageSize <= 0)
        {
            throw new BadRequestException(ErrorMessages.InvalidPageCountOrPageSizeError);
        }
        
        var query = _db.Users.Include(r => r.Role).AsQueryable();

        if (role != null)
        {
            if (role.ToString() == UserRole.Student.ToString())
            {
                query = query.Where(u => u.Role.IsStudent == true);
            }
            else if (role.ToString() == UserRole.Teacher.ToString())
            {
                query = query.Where(u => u.Role.IsTeacher == true);
            }
            else if (role.ToString() == UserRole.Dean.ToString())
            {
                query = query.Where(u => u.Role.IsDean == true);
            }
        }
        
        query = query.Skip((page - 1) * pageSize).Take(pageSize);
        
        return await query
            .Select(user => UserMapper.MapEntityToUserProfileModel(user))
            .ToListAsync();
    }

    public async Task<UserProfileModel> GiveRole(Guid userId, UserRoleRequest? role = null, string userIdWhoDoIt = "")
    {
        var user = GetUserById(userId.ToString());

        if (IsUserAdmin(userIdWhoDoIt))
        {
            SetUserRole(user, role);
        }
        else if (IsUserDean(userIdWhoDoIt))
        {
            if (role == UserRoleRequest.Dean)
            {
                throw new AccessDeniedException(ErrorMessages.AccessDeniedAdminError);
            }
            SetUserRole(user, role);
        }
        await _db.SaveChangesAsync();

        return UserMapper.MapEntityToUserProfileModel(user);
    }

    private void SetUserRole(User user, UserRoleRequest? role)
    {
        if (role == UserRoleRequest.Student)
        {
            user.Role.IsStudent = true;
        }
        else if (role == UserRoleRequest.Teacher)
        {
            user.Role.IsTeacher = true;
        }
        else if (role == UserRoleRequest.Dean)
        {
            user.Role.IsDean = true;
        }
        else
        {
            user.Role.IsStudent = false;
            user.Role.IsTeacher = false;
            user.Role.IsDean = false;
        }
    }

    public bool IsUserAdmin(string userId)
    {
        User user = GetUserById(userId);
        return user.Role.IsAdmin;
    }

    public bool IsUserDean(string userId)
    {
        User user = GetUserById(userId);
        return user.Role.IsDean;
    }
    
    private User GetUserById(string id)
    {
        var user = _db.Users.Include(r => r.Role).FirstOrDefault(u => u.Id.ToString() == id);
        if (user == null)
        {
            throw new UserNotFoundException(ErrorMessages.NotFoundUserError);
        }
        
        return user;
    }
}

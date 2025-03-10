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

    public async Task<IEnumerable<UserProfileModel>> GetUsers(UserRoleRequest? role, string? search, string? groupNumber, int page, int pageSize)
    //Если роль не указана, а то есть равна null, то отправляем всех пользователей
    {
        if (page <= 0 || pageSize <= 0)
        {
            throw new BadRequestException(ErrorMessages.InvalidPageCountOrPageSizeError);
        }
        
        var query = _db.Users.Include(u => u.Role).AsQueryable();

        if (role != null)
        {
            if (role == UserMapper.MapRoleEntityToRoleRequest(UserRole.Student))
            {
                query = query.Where(u => u.Role.IsStudent == true);
            }
            if (role == UserMapper.MapRoleEntityToRoleRequest(UserRole.Teacher))
            {
                query = query.Where(u => u.Role.IsTeacher == true);
            }
            if (role == UserMapper.MapRoleEntityToRoleRequest(UserRole.Dean))
            {
                query = query.Where(u => u.Role.IsDean == true);
            }
        }
        
        if (!string.IsNullOrWhiteSpace(groupNumber))
        {
            query = query.Where(u => u.GroupNumber == groupNumber);
        }
        
        if (!string.IsNullOrWhiteSpace(search))
        {
            var lowerSearch = search.ToLower();
            query = query.Where(u => u.Name.ToLower().Contains(lowerSearch) || u.Email.ToLower().Contains(lowerSearch));
        }
        
        query = query.Skip((page - 1) * pageSize).Take(pageSize);
        
        return await query
            .Select(user => UserMapper.MapEntityToUserProfileModel(user, user.Role.UserWantToBe))
            .ToListAsync();
    }

    public async Task<UserProfileModel> GiveRole(Guid userId, UserRoleRequest? role = null, string userIdWhoDoIt = "")
    {
        var user = GetUserById(userId.ToString());

        if (IsUserAdmin(userIdWhoDoIt))
        {
            SetUserRole(user, role);
            
            if (user.Role.UserWantToBe == role)
            {
                user.Role.UserWantToBe = UserRoleRequest.Student;
            }
        }
        else if (IsUserDean(userIdWhoDoIt))
        {
            if (role == UserRoleRequest.Dean)
            {
                throw new AccessDeniedException(ErrorMessages.AccessDeniedAdminError);
            }
            SetUserRole(user, role);
            
            if (user.Role.UserWantToBe == role)
            {
                user.Role.UserWantToBe = UserRoleRequest.Student;
            }
        }
        
        await _db.SaveChangesAsync();

        return UserMapper.MapEntityToUserProfileModel(user,  user.Role.UserWantToBe);
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

        user.RoleId = user.Role.Id;
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
    public bool IsUserStudent(string userId)
    {
        User user = GetUserById(userId);
        return user.Role.IsStudent;
    }
    
    private User GetUserById(string id)
    {
        var user = _db.Users.Include(r => r.Role).FirstOrDefault(u => u.Id.ToString() == id);
        if (user == null)
        {
            throw new NotFoundException(ErrorMessages.NotFoundUserError);
        }
        
        return user;
    }
}

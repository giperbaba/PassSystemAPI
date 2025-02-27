using PassSystemTD.Entities;
using PassSystemTD.Models.Response;

namespace PassSystemTD.Mappers;

public abstract class UserMapper
{
    public static UserProfileModel MapEntityToUserProfileModel(User user)
    {
        return new UserProfileModel()
        {
            FullName = user.Name,
            BirthDate = user.BirthDate,
            Email = user.Email,
        };
    }
}
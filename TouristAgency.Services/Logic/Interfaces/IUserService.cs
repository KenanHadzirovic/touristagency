using System.Collections.Generic;
using TouristAgency.Contracts;

namespace TouristAgency.Services
{
    public interface IUserService
    {
        ICollection<User> GetUsers();
        User GetUser(int userId);
        User UpdateUser(User user);
        User CreateUser(User user);
        bool DeleteUser(int userId);
    }
}

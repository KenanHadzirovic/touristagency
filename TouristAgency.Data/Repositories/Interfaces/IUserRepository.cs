using System.Collections.Generic;

namespace TouristAgency.Data.Repositories
{
    /// <summary>
    /// Repository for data manipulation on User table / class
    /// </summary>
    public interface IUserRepository
    {
        /// <summary>
        /// Retrieve one User by Id
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        User GetUser(int userId);
        /// <summary>
        /// Get all of the Users in the database
        /// </summary>
        /// <returns></returns>
        ICollection<User> GetAllUsers();
        /// <summary>
        /// Remove the user with passed id from database
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        bool DeleteUser(int userId);
        /// <summary>
        /// Update User with passed data
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        User UpdateUser(User user);
        /// <summary>
        /// Add a new User to the database
        /// </summary>
        /// <param name="user">User to be added</param>
        /// <returns>Newly added User</returns>
        User CreateUser(User user);
    }
}

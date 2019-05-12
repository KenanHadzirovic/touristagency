using System.Collections.Generic;
using System.Linq;

namespace TouristAgency.Data.Repositories
{
    /// <inheritdoc/>
    public class UserRepository : IUserRepository
    {
        private DataModel _context;

        UserRepository(DataModel context)
        {
            _context = context;
        }

        /// <inheritdoc/>
        public bool DeleteUser(int userId)
        {
            
            return true;
        }

        /// <inheritdoc/>
        public ICollection<User> GetAllUsers()
        {
            return _context.User.ToList();
        }

        /// <inheritdoc/>
        public User GetUser(int userId)
        {
            return _context.User.FirstOrDefault(x => x.UserId == userId);
        }

        ///<inheritdoc/>
        public User CreateUser(User user)
        {
            _context.User.Add(user);
            return user;
        }

        /// <inheritdoc/>
        public User UpdateUser(User user)
        {
            return Update(_context.User.FirstOrDefault(x => x.UserId == user.UserId), user);
        }

        private User Update(User user, User newUser)
        {
            user.RoleId = newUser.RoleId;
            user.UserId = newUser.UserId;
            user.Username = newUser.Username;
            return user;
        }
    }
}

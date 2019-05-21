using System.Collections.Generic;
using System.Linq;

namespace TouristAgency.Data.Repositories
{
    /// <inheritdoc/>
    public class UserAccountRepository : IUserAccountRepository
    {
        private DataModel _context;

        public UserAccountRepository(DataModel context)
        {
            _context = context;
        }

        /// <inheritdoc/>
        public bool DeleteUserAccount(int userAccountId)
        {
            
            return true;
        }

        /// <inheritdoc/>
        public ICollection<UserAccount> GetAllUserAccounts()
        {
            return _context.UserAccount.ToList();
        }

        /// <inheritdoc/>
        public UserAccount GetUserAccount(int userAccountId)
        {
            return _context.UserAccount.FirstOrDefault(x => x.UserAccountId == userAccountId);
        }

        ///<inheritdoc/>
        public UserAccount CreateUserAccount(UserAccount userAccount)
        {
            _context.UserAccount.Add(userAccount);
            _context.SaveChanges();
            return userAccount;
        }

        /// <inheritdoc/>
        public UserAccount UpdateUserAccount(UserAccount userAccount)
        {
            return Update(_context.UserAccount.FirstOrDefault(x => x.UserAccountId == userAccount.UserAccountId), userAccount);
        }

        private UserAccount Update(UserAccount userAccount, UserAccount newUserAccount)
        {
            userAccount.UserAccountId = newUserAccount.UserAccountId;
            userAccount.Username = newUserAccount.Username;
            userAccount.Password = newUserAccount.Password;
            return userAccount;
        }
    }
}

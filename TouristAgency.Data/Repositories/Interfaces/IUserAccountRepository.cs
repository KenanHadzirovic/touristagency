using System.Collections.Generic;

namespace TouristAgency.Data.Repositories
{
    /// <summary>
    /// Repository for data manipulation on UserAccount table / class
    /// </summary>
    public interface IUserAccountRepository
    {
        /// <summary>
        /// Retrieve one UserAccount by Id
        /// </summary>
        /// <param name="UserAccountId"></param>
        /// <returns></returns>
        UserAccount GetUserAccount(int UserAccountId);
        /// <summary>
        /// Get all of the UserAccounts in the database
        /// </summary>
        /// <returns></returns>
        ICollection<UserAccount> GetAllUserAccounts();
        /// <summary>
        /// Remove the UserAccount with passed id from database
        /// </summary>
        /// <param name="UserAccountId"></param>
        /// <returns></returns>
        bool DeleteUserAccount(int UserAccountId);
        /// <summary>
        /// Update UserAccount with passed data
        /// </summary>
        /// <param name="UserAccount"></param>
        /// <returns></returns>
        UserAccount UpdateUserAccount(UserAccount UserAccount);
        /// <summary>
        /// Add a new UserAccount to the database
        /// </summary>
        /// <param name="UserAccount">UserAccount to be added</param>
        /// <returns>Newly added UserAccount</returns>
        UserAccount CreateUserAccount(UserAccount UserAccount);
    }
}

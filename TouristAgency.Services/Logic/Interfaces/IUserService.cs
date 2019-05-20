using System.Collections.Generic;
using TouristAgency.Contracts;

namespace TouristAgency.Services
{
    public interface IUserAccountService
    {
        ICollection<UserAccount> GetUserAccounts();
        UserAccount GetUserAccount(int UserAccountId);
        UserAccount UpdateUserAccount(UserAccount UserAccount);
        UserAccount CreateUserAccount(UserAccount UserAccount);
        bool DeleteUserAccount(int UserAccountId);
    }
}

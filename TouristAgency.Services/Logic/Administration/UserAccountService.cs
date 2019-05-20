using AutoMapper;
using System.Collections.Generic;
using TouristAgency.Data.Repositories;
using Model = TouristAgency.Data;

namespace TouristAgency.Services
{
    public class UserAccountService : IUserAccountService
    {
        private IUserAccountRepository _UserAccountRepository;

        public UserAccountService(IUserAccountRepository UserAccountRepository)
        {
            _UserAccountRepository = UserAccountRepository;
        }

        public Contracts.UserAccount CreateUserAccount(Contracts.UserAccount UserAccount)
        {
            Model.UserAccount efUserAccount = Mapper.Map<Contracts.UserAccount, Model.UserAccount>(UserAccount);
            efUserAccount = _UserAccountRepository.CreateUserAccount(efUserAccount);
            return Mapper.Map<Model.UserAccount, Contracts.UserAccount>(efUserAccount);
        }

        public Contracts.UserAccount UpdateUserAccount(Contracts.UserAccount UserAccount)
        {
            Model.UserAccount efUserAccount = Mapper.Map<Contracts.UserAccount, Model.UserAccount>(UserAccount);
            _UserAccountRepository.UpdateUserAccount(efUserAccount);
            return UserAccount;
        }

        public ICollection<Contracts.UserAccount> GetUserAccounts()
        {
            return Mapper.Map<ICollection<Model.UserAccount>, ICollection<Contracts.UserAccount>>(_UserAccountRepository.GetAllUserAccounts());
        }

        public Contracts.UserAccount GetUserAccount(int UserAccountId)
        {
            return Mapper.Map<Model.UserAccount, Contracts.UserAccount>(_UserAccountRepository.GetUserAccount(UserAccountId));
        }

        public bool DeleteUserAccount(int UserAccountId)
        {
            return _UserAccountRepository.DeleteUserAccount(UserAccountId);
        }
    }
}

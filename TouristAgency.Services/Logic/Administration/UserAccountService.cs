using AutoMapper;
using System.Collections.Generic;
using TouristAgency.Data.Repositories;
using Model = TouristAgency.Data;

namespace TouristAgency.Services
{
    public class UserAccountService : IUserAccountService
    {
        private IUserAccountRepository _userAccountRepository;
        private IMapper _mapper;

        public UserAccountService(IUserAccountRepository UserAccountRepository, IMapper mapper)
        {
            _userAccountRepository = UserAccountRepository;
            _mapper = mapper;
        }

        public Contracts.UserAccount CreateUserAccount(Contracts.UserAccount UserAccount)
        {
            Model.UserAccount efUserAccount = _mapper.Map<Contracts.UserAccount, Model.UserAccount>(UserAccount);
            efUserAccount = _userAccountRepository.CreateUserAccount(efUserAccount);
            return _mapper.Map<Model.UserAccount, Contracts.UserAccount>(efUserAccount);
        }

        public Contracts.UserAccount UpdateUserAccount(Contracts.UserAccount UserAccount)
        {
            Model.UserAccount efUserAccount = _mapper.Map<Contracts.UserAccount, Model.UserAccount>(UserAccount);
            _userAccountRepository.UpdateUserAccount(efUserAccount);
            return UserAccount;
        }

        public ICollection<Contracts.UserAccount> GetUserAccounts()
        {
            return _mapper.Map<ICollection<Model.UserAccount>, ICollection<Contracts.UserAccount>>(_userAccountRepository.GetAllUserAccounts());
        }

        public Contracts.UserAccount GetUserAccount(int UserAccountId)
        {
            return _mapper.Map<Model.UserAccount, Contracts.UserAccount>(_userAccountRepository.GetUserAccount(UserAccountId));
        }

        public bool DeleteUserAccount(int UserAccountId)
        {
            return _userAccountRepository.DeleteUserAccount(UserAccountId);
        }
    }
}

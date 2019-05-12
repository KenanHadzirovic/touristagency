using AutoMapper;
using System.Collections.Generic;
using TouristAgency.Data.Repositories;
using Model = TouristAgency.Data;

namespace TouristAgency.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;

        UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Contracts.User CreateUser(Contracts.User user)
        {
            Model.User efUser = Mapper.Map<Contracts.User, Model.User>(user);
            efUser = _userRepository.CreateUser(efUser);
            return Mapper.Map<Model.User, Contracts.User>(efUser);
        }

        public Contracts.User UpdateUser(Contracts.User user)
        {
            Model.User efUser = Mapper.Map<Contracts.User, Model.User>(user);
            _userRepository.UpdateUser(efUser);
            return user;
        }

        public ICollection<Contracts.User> GetUsers()
        {
            return Mapper.Map<ICollection<Model.User>, ICollection<Contracts.User>>(_userRepository.GetAllUsers());
        }

        public Contracts.User GetUser(int userId)
        {
            return Mapper.Map<Model.User, Contracts.User>(_userRepository.GetUser(userId));
        }

        public bool DeleteUser(int userId)
        {
            return _userRepository.DeleteUser(userId);
        }
    }
}

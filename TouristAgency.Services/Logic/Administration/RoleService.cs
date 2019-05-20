using AutoMapper;
using System.Collections.Generic;
using TouristAgency.Data.Repositories;
using Model = TouristAgency.Data;

namespace TouristAgency.Services
{
    public class RoleService : IRoleService
    {
        private IRoleRepository _roleRepository;

        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public Contracts.Role CreateRole(Contracts.Role role)
        {
            Model.Role efRole = Mapper.Map<Contracts.Role, Model.Role>(role);
            efRole = _roleRepository.CreateRole(efRole);
            return Mapper.Map<Model.Role, Contracts.Role>(efRole);
        }

        public Contracts.Role UpdateRole(Contracts.Role role)
        {
            Model.Role efRole = Mapper.Map<Contracts.Role, Model.Role>(role);
            _roleRepository.UpdateRole(efRole);
            return role;
        }

        public ICollection<Contracts.Role> GetRoles()
        {
            return Mapper.Map<ICollection<Model.Role>, ICollection<Contracts.Role>>(_roleRepository.GetAllRoles());
        }

        public Contracts.Role GetRole(int roleId)
        {
            return Mapper.Map<Model.Role,Contracts.Role>(_roleRepository.GetRole(roleId));
        }

        public bool DeleteRole(int roleId)
        {
            return _roleRepository.DeleteRole(roleId);
        }
    }
}

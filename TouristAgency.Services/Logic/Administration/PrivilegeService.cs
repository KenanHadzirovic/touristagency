using AutoMapper;
using System.Collections.Generic;
using TouristAgency.Data.Repositories;
using Model = TouristAgency.Data;

namespace TouristAgency.Services
{
    public class PrivilegeService : IPrivilegeService
    {
        private IPrivilegeRepository _privilegeRepository;

        public PrivilegeService(IPrivilegeRepository privilegeRepository)
        {
            _privilegeRepository = privilegeRepository;
        }

        public Contracts.Privilege CreatePrivilege(Contracts.Privilege privilege)
        {
            Model.Privilege efPrivilege = Mapper.Map<Contracts.Privilege, Model.Privilege>(privilege);
            efPrivilege = _privilegeRepository.CreatePrivilege(efPrivilege);
            return Mapper.Map<Model.Privilege, Contracts.Privilege>(efPrivilege);
        }

        public Contracts.Privilege UpdatePrivilege(Contracts.Privilege privilege)
        {
            Model.Privilege efPrivilege = Mapper.Map<Contracts.Privilege, Model.Privilege>(privilege);
            _privilegeRepository.UpdatePrivilege(efPrivilege);
            return privilege;
        }

        public ICollection<Contracts.Privilege> GetPrivileges()
        {
            return Mapper.Map<ICollection<Model.Privilege>, ICollection<Contracts.Privilege>>(_privilegeRepository.GetAllPrivileges());
        }

        public Contracts.Privilege GetPrivilege(int privilegeId)
        {
            return Mapper.Map<Model.Privilege, Contracts.Privilege>(_privilegeRepository.GetPrivilege(privilegeId));
        }

        public bool DeletePrivilege(int privilegeId)
        {
            return _privilegeRepository.DeletePrivilege(privilegeId);
        }
    }
}

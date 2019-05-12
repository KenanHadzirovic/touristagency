using System.Collections.Generic;
using TouristAgency.Contracts;

namespace TouristAgency.Services
{
    public interface IPrivilegeService
    {
        ICollection<Privilege> GetPrivileges();
        Privilege GetPrivilege(int privilegeId);
        Privilege UpdatePrivilege(Privilege privilege);
        Privilege CreatePrivilege(Privilege privilege);
        bool DeletePrivilege(int privilegeId);
    }
}

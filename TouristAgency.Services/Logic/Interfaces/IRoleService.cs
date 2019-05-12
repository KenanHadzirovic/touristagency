using System.Collections.Generic;
using TouristAgency.Contracts;

namespace TouristAgency.Services
{
    public interface IRoleService
    {
        ICollection<Role> GetRoles();
        Role GetRole(int roleId);
        Role UpdateRole(Role role);
        Role CreateRole(Role role);
        bool DeleteRole(int roleId);
    }
}

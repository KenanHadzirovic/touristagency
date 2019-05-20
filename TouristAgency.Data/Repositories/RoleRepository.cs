using System.Collections.Generic;
using System.Linq;

namespace TouristAgency.Data.Repositories
{
    /// <inheritdoc/>
    public class RoleRepository : IRoleRepository
    {
        private DataModel _context;

        public RoleRepository(DataModel context)
        {
            _context = context;
        }

        /// <inheritdoc/>
        public bool DeleteRole(int RoleId)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public ICollection<Role> GetAllRoles()
        {
            return _context.Role.ToList();
        }

        /// <inheritdoc/>
        public Role GetRole(int roleId)
        {
            return _context.Role.FirstOrDefault(x => x.RoleId == roleId);
        }

        /// <inheritdoc/>
        public Role UpdateRole(Role role)
        {
            return Update(_context.Role.FirstOrDefault(x => x.RoleId == role.RoleId), role);
        }

        /// <inheritdoc/>
        public Role CreateRole(Role role)
        {
            _context.Role.Add(role);
            return role;
        }

        private Role Update(Role role, Role newRole)
        {
            role.RoleId = newRole.RoleId;
            role.RoleName = newRole.RoleName;

            return role;
        }
    }
}

using System.Collections.Generic;
using System.Linq;

namespace TouristAgency.Data.Repositories
{
    /// <inheritdoc/>
    public class PrivilegeRepository : IPrivilegeRepository
    {
        private DataModel _context;

        public PrivilegeRepository(DataModel context)
        {
            _context = context;
        }

        /// <inheritdoc/>
        public bool DeletePrivilege(int PrivilegeId)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public ICollection<Privilege> GetAllPrivileges()
        {
            return _context.Privilege.ToList();
        }

        /// <inheritdoc/>
        public Privilege GetPrivilege(int privilegeId)
        {
            return _context.Privilege.FirstOrDefault(x => x.PrivilegeId == privilegeId);
        }

        /// <inheritdoc/>
        public Privilege CreatePrivilege(Privilege privilege)
        {
            _context.Privilege.Add(privilege);
            return privilege;
        }

        /// <inheritdoc/>
        public Privilege UpdatePrivilege(Privilege privilege)
        {
            return Update(_context.Privilege.FirstOrDefault(x => x.PrivilegeId == privilege.PrivilegeId), privilege);
        }

        private Privilege Update(Privilege privilege, Privilege newPrivilege)
        {
            privilege.PrivilegeId = newPrivilege.PrivilegeId;
            privilege.Name = newPrivilege.Name;
            privilege.Description = newPrivilege.Description;

            return privilege;
        }
    }
}

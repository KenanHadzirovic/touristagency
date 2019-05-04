using System.Collections.Generic;

namespace TouristAgency.Data.Repositories
{
    /// <summary>
    /// Repository for data manipulation on Privilege table / class
    /// </summary>
    public interface IPrivilegeRepository
    {
        /// <summary>
        /// Retrieve one Privilege by Id
        /// </summary>
        /// <param name="privilegeId"></param>
        /// <returns></returns>
        Privilege GetPrivilege(int privilegeId);
        /// <summary>
        /// Get all of the Privileges in the database
        /// </summary>
        /// <returns></returns>
        ICollection<Privilege> GetAllPrivileges();
        /// <summary>
        /// Remove the Privilege with passed id from database
        /// </summary>
        /// <param name="privilegeId"></param>
        /// <returns></returns>
        bool DeletePrivilege(int privilegeId);
        /// <summary>
        /// Update Privilege with passed data
        /// </summary>
        /// <param name="privilege"></param>
        /// <returns></returns>
        Privilege UpdatePrivilege(Privilege privilege);
    }
}

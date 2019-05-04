using System.Collections.Generic;

namespace TouristAgency.Data.Repositories
{
    /// <summary>
    /// Repository for data manipulation on Role table / class
    /// </summary>
    public interface IRoleRepository
    {
        /// <summary>
        /// Retrieve one Role by Id
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns></returns>
        Role GetRole(int roleId);
        /// <summary>
        /// Get all of the Roles in the database
        /// </summary>
        /// <returns></returns>
        ICollection<Role> GetAllRoles();
        /// <summary>
        /// Remove the Role with passed id from database
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns></returns>
        bool DeleteRole(int roleId);
        /// <summary>
        /// Update Role with passed data
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        Role UpdateRole(Role role);
    }
}

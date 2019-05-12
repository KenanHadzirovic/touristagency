using System.Collections.Generic;

namespace TouristAgency.Data.Repositories
{
    /// <summary>
    /// Repository for data manipulation on Employee table / class
    /// </summary>
    public interface IEmployeeRepository
    {
        /// <summary>
        /// Retrieve one Employee by Id
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        Employee GetEmployee(int employeeId);
        /// <summary>
        /// Get all of the Employees in the database
        /// </summary>
        /// <returns></returns>
        ICollection<Employee> GetAllEmployees();
        /// <summary>
        /// Remove the Employee with passed id from database
        /// </summary>
        /// <param name="employeeId">Id of the employee</param>
        /// <returns></returns>
        bool DeleteEmployee(int employeeId);
        /// <summary>
        /// Update Employee with passed data
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        Employee UpdateEmployee(Employee employee);
        /// <summary>
        /// Add a new Employee to the database
        /// </summary>
        /// <param name="employee">Employee to be added</param>
        /// <returns>Newly added Employee</returns>
        Employee CreateEmployee(Employee employee);
    }
}

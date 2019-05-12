using System.Collections.Generic;
using TouristAgency.Contracts;

namespace TouristAgency.Services
{
    public interface IEmployeeService
    {
        ICollection<Employee> GetEmployees();
        Employee GetEmployee(int employeeId);
        Employee UpdateEmployee(Employee employee);
        Employee CreateEmployee(Employee employee);
        bool DeleteEmployee(int employeeId);
    }
}

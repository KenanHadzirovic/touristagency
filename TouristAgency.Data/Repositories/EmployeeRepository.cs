using System.Collections.Generic;
using System.Linq;

namespace TouristAgency.Data.Repositories
{
    /// <inheritdoc/>
    public class EmployeeRepository : IEmployeeRepository
    {
        private DataModel _context;

        public EmployeeRepository(DataModel context)
        {
            _context = context;
        }

        /// <inheritdoc/>
        public bool DeleteEmployee(int employeeId)
        {
            //_context.Employee.Remove(x => x.Id == employeeId);
            return true;
        }

        /// <inheritdoc/>
        public ICollection<Employee> GetAllEmployees()
        {
            return _context.Employee.ToList();
        }

        /// <inheritdoc/>
        public Employee GetEmployee(int employeeId)
        {
            return _context.Employee.FirstOrDefault(x => x.EmployeeId == employeeId);
        }

        /// <inheritdoc/>
        public Employee UpdateEmployee(Employee employee)
        {
            return Update(_context.Employee.FirstOrDefault(x => x.EmployeeId == employee.EmployeeId), employee);
        }

        ///<inheritdoc/>
        public Employee CreateEmployee(Employee employee)
        {
            _context.Employee.Add(employee);
            return employee;
        }

        private Employee Update(Employee employee, Employee newEmployee)
        {
            employee.Address = newEmployee.Address;
            employee.DateOfBirth = newEmployee.DateOfBirth;
            employee.FirstName = newEmployee.FirstName;
            employee.LastName = newEmployee.LastName;
            employee.UserAccountId = newEmployee.UserAccountId;
            return employee;
        }
    }
}

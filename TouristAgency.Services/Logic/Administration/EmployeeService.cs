using AutoMapper;
using System.Collections.Generic;
using TouristAgency.Data.Repositories;
using Model = TouristAgency.Data;

namespace TouristAgency.Services
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository _employeeRepository;
        
        EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public Contracts.Employee CreateEmployee(Contracts.Employee employee)
        {
            Model.Employee efEmployee = Mapper.Map<Contracts.Employee, Model.Employee>(employee);
            efEmployee = _employeeRepository.CreateEmployee(efEmployee);
            return Mapper.Map<Model.Employee, Contracts.Employee>(efEmployee);
        }

        public Contracts.Employee UpdateEmployee(Contracts.Employee employee)
        {
            Model.Employee efEmployee = Mapper.Map<Contracts.Employee, Model.Employee>(employee);
            _employeeRepository.UpdateEmployee(efEmployee);
            return employee;
        }

        public ICollection<Contracts.Employee> GetEmployees()
        {
            return Mapper.Map<ICollection<Model.Employee>, ICollection<Contracts.Employee>>(_employeeRepository.GetAllEmployees());
        }

        public Contracts.Employee GetEmployee(int employeeId)
        {
            return Mapper.Map<Model.Employee, Contracts.Employee>(_employeeRepository.GetEmployee(employeeId));
        }

        public bool DeleteEmployee(int employeeId)
        {
            return _employeeRepository.DeleteEmployee(employeeId);
        }
    }
}

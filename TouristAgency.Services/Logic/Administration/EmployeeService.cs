using AutoMapper;
using System.Collections.Generic;
using TouristAgency.Data.Repositories;
using Model = TouristAgency.Data;

namespace TouristAgency.Services
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository _employeeRepository;
        private IMapper _mapper;
        
        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _mapper = mapper;
            _employeeRepository = employeeRepository;
        }

        public Contracts.Employee CreateEmployee(Contracts.Employee employee)
        {
            Model.Employee efEmployee = _mapper.Map<Contracts.Employee, Model.Employee>(employee);
            efEmployee = _employeeRepository.CreateEmployee(efEmployee);
            return _mapper.Map<Model.Employee, Contracts.Employee>(efEmployee);
        }

        public Contracts.Employee UpdateEmployee(Contracts.Employee employee)
        {
            Model.Employee efEmployee = _mapper.Map<Contracts.Employee, Model.Employee>(employee);
            _employeeRepository.UpdateEmployee(efEmployee);
            return employee;
        }

        public ICollection<Contracts.Employee> GetEmployees()
        {
            return _mapper.Map<ICollection<Model.Employee>, ICollection<Contracts.Employee>>(_employeeRepository.GetAllEmployees());
        }

        public Contracts.Employee GetEmployee(int employeeId)
        {
            return _mapper.Map<Model.Employee, Contracts.Employee>(_employeeRepository.GetEmployee(employeeId));
        }

        public bool DeleteEmployee(int employeeId)
        {
            return _employeeRepository.DeleteEmployee(employeeId);
        }
    }
}

using EmployeeManagerApp.Data.Repositories;
using EmployeeManagerApp.Entities;

namespace EmployeeManagerApp.Services
{
    public class EmployeeService
    {
        private readonly EmployeeRepository _repository;
        
        public EmployeeService(EmployeeRepository repository)
        {
            _repository = repository;
        }

        public bool AddEmployee(Employee employee)
        {
            return _repository.AddEmployee(employee);
        }

        public bool DeleteEmployee(int id)
        {
            return _repository.DeleteEmployee(id);
        }

        public Employee? GetEmployeeById(int id)
        {
            return _repository.GetEmployeeById(id);
        }

        public List<Employee> GetAllEmployees()
        {
            return _repository.GetAllEmployees();
        }

        public bool UpdateEmployee(Employee employee)
        {
            return _repository.UpdateEmployee(employee);
        }

    }
}
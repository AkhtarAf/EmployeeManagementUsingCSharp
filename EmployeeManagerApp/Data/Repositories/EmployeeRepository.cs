using EmployeeManagerApp.Entities;

namespace EmployeeManagerApp.Data.Repositories
{
    public class EmployeeRepository
    {
        private List<Employee> _employees;

        public EmployeeRepository()
        {
            _employees = new List<Employee>();
        }

        public bool AddEmployee(Employee employee)
        {
            if (employee != null)
            {
                _employees.Add(employee);
                return true;
            }
            return false;
        }

        public bool DeleteEmployee(int id)
        {
            Employee? employee = _employees.Find(e => e.Id == id);
            if (employee != null)
            {
                _employees.Remove(employee);
                return true;
            }
            return false;
        }

        public Employee? GetEmployeeById(int id)
        {
            return _employees.Find(e => e.Id == id);
        }

        public List<Employee> GetAllEmployees()
        {
            return _employees;
        }

        public bool UpdateEmployee(Employee employee)
        {
            Employee? employeeToUpdate = _employees.Find(e => e.Id == employee.Id);
            if (employeeToUpdate != null)
            {
                employeeToUpdate.Name = employee.Name;
                employeeToUpdate.Department = employee.Department;
                return true;
            }
            return false;
        }
    }
}
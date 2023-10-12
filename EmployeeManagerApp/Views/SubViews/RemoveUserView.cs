using EmployeeManagerApp.Utils;
using EmployeeManagerApp.Data.Repositories;
using EmployeeManagerApp.Services;

namespace EmployeeManagerApp.Views.SubViews
{
    public class RemoveUserView
    {
        private readonly EmployeeRepository _employeeRepository;
        private readonly EmployeeService employeeService;

        public RemoveUserView(EmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;

            employeeService = new EmployeeService(_employeeRepository);
        }

        public void Show()
        {
            int id = InputUtil.GetInt("Enter Employee ID to Remove");
            var employee = employeeService.GetEmployeeById(id);

            if (employee == null)
            {
                OutputUtil.Print("Employee not found");
            }
            else
            {
                OutputUtil.Print("The details of the employee that is going to get deleted:");
                OutputUtil.Print(employee.ToString());
                if (InputUtil.GetString("Are you sure you want to delete this employee? (y/n)") == "y")
                {
                    employeeService.DeleteEmployee(id);
                    OutputUtil.Print($"Employee {id} deleted");
                }
                else
                {
                    OutputUtil.Print("Employee not deleted");
                }
            }
        }
    }
}
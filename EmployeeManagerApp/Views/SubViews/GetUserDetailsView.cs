using EmployeeManagerApp.Utils;
using EmployeeManagerApp.Data.Repositories;
using EmployeeManagerApp.Services;

namespace  EmployeeManagerApp.Views.SubViews
{
    public class GetUserDetailsView
    {
        private readonly EmployeeRepository _employeeRepository;
        private readonly EmployeeService employeeService;

        public GetUserDetailsView(EmployeeRepository employeeRepository) {
            _employeeRepository = employeeRepository;

            employeeService = new EmployeeService(_employeeRepository);
        }

        public void Show() {
            int id = InputUtil.GetInt("Enter Employee ID");
            var employee = employeeService.GetEmployeeById(id);

            if(employee != null) {
                OutputUtil.Print("\nEmployee Details:\n");
                OutputUtil.Print(employee.ToString());
            } else {
                OutputUtil.Print($"\nEmployee with ID: {id}  Not Found!\n");
            }
        }
    }
    
}
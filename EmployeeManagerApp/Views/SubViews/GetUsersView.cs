using EmployeeManagerApp.Utils;
using EmployeeManagerApp.Data.Repositories;
using EmployeeManagerApp.Services;

namespace EmployeeManagerApp.Views.SubViews
{
    public class GetUsersView
    {
        private readonly EmployeeRepository _employeeRepository;
        private readonly EmployeeService employeeService;

        public GetUsersView(EmployeeRepository employeeRepository) {
            _employeeRepository = employeeRepository;

            employeeService = new EmployeeService(_employeeRepository);
        }

        public void Show()
        {
            OutputUtil.Print("\nAll Employees:\n");
            OutputUtil.PrintTable(employeeService.GetAllEmployees());
        }
    }
}
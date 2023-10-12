using EmployeeManagerApp.Utils;
using EmployeeManagerApp.Data.Repositories;
using EmployeeManagerApp.Services;

namespace EmployeeManagerApp.Views.SubViews
{
    public class UpdateUserView
    {
        private readonly EmployeeRepository _employeeRepository;
        private readonly EmployeeService employeeService;

        public UpdateUserView(EmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;

            employeeService = new EmployeeService(_employeeRepository);
        }

        public void ShowSubMenu () {

        }
        public void Show()
        {
           
        }
    }
}
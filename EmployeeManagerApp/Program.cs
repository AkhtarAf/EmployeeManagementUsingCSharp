using EmployeeManagerApp.Data.Repositories;
using EmployeeManagerApp.Views;

EmployeeRepository employeeRepository = new EmployeeRepository();
MainView mainView = new MainView(employeeRepository);

mainView.Show();


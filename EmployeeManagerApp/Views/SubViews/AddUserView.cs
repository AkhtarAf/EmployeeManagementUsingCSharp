using EmployeeManagerApp.Utils;
using EmployeeManagerApp.Data.Repositories;
using EmployeeManagerApp.Services;
using EmployeeManagerApp.Entities;

namespace EmployeeManagerApp.Views.SubViews
{
    public class AddUserView
    {   
        private readonly EmployeeRepository _employeeRepository;
        private readonly EmployeeService employeeService;

        private string? name;
        private string? department;
        private Employee? employee;

        public AddUserView(EmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;

            employeeService = new EmployeeService(_employeeRepository);
        }

        public void Show()
        {
            
            const string menu = "1. Add Salary Employee\n" +
                                "2. Add Commission Based Employee\n" +
                                "3. Add Hourly Based Employee\n" +
                                "4. Back to Main Menu\n";

            OutputUtil.Print(menu);
            int choice = InputUtil.GetInt("Enter your choice");
            
            switch (choice)
            {
                case 1:
                    name = InputUtil.GetString("Enter Employee Name");
                    department = InputUtil.GetString("Enter Employee Department");
                    double salary = InputUtil.GetDouble("Enter Employee Salary");
                    double incentive = InputUtil.GetDouble("Enter Employee Incentive");

                    employee = new SalariedEmployee(0, name, department, salary, incentive);
                    
                    if(employeeService.AddEmployee(employee)) {
                        OutputUtil.Print("\nEmployee Added Successfully!\n");
                    } else {
                        OutputUtil.Print("\nEmployee Not Added!\n");
                    }

                    break;
                case 2:
                    name = InputUtil.GetString("Enter Employee Name");
                    department = InputUtil.GetString("Enter Employee Department");
                    double commission = InputUtil.GetDouble("Enter Employee Commission");
                    double sales = InputUtil.GetDouble("Enter Employee Sales");

                    employee = new CommissionBasedEmployee(0, name, department, commission, sales);

                    if(employeeService.AddEmployee(employee)) {
                        OutputUtil.Print("\nEmployee Added Successfully!\n");
                    } else {
                        OutputUtil.Print("\nEmployee Not Added!\n");
                    }

                    break;
                case 3:
                    name = InputUtil.GetString("Enter Employee Name");
                    department = InputUtil.GetString("Enter Employee Department");
                    double hourlyRate = InputUtil.GetDouble("Enter Employee Hourly Rate");
                    double hoursWorked = InputUtil.GetDouble("Enter Employee Hours Worked");

                    employee = new HourlyEmployee(0, name, department, hourlyRate, hoursWorked);

                    if(employeeService.AddEmployee(employee)) {
                        OutputUtil.Print("\nEmployee Added Successfully!\n");
                    } else {
                        OutputUtil.Print("\nEmployee Not Added!\n");
                    }

                    break;
                case 4:
                    Console.WriteLine("Back to Main Menu");
                    MainView mainView = new MainView(_employeeRepository);
                    mainView.Show();
                    break;
                default:
                    OutputUtil.Print("Invalid choice. Please try again.");
                    Show();
                    break;
            }
        }
    }
}
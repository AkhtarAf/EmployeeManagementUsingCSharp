using EmployeeManagerApp.Utils;
using EmployeeManagerApp.Data.Repositories;
using EmployeeManagerApp.Views.SubViews;

namespace EmployeeManagerApp.Views
{
    public class MainView
    {
        private readonly EmployeeRepository _employeeRepository;
        private readonly AddUserView addUserView;
        private readonly GetUserDetailsView getUserDetailsView;
        private readonly GetUsersView getUsersView;
        private readonly UpdateUserView updateUserView;
        private readonly RemoveUserView removeUserView;

        public MainView(EmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
            
            addUserView = new AddUserView(_employeeRepository);
            getUserDetailsView = new GetUserDetailsView(_employeeRepository);
            getUsersView = new GetUsersView(_employeeRepository);
            updateUserView = new UpdateUserView(_employeeRepository);
            removeUserView = new RemoveUserView(_employeeRepository);

        }

        public void Show()
        {
            const string menu = "1. Add Employee\n" +
                                "2. Update Employee\n" +
                                "3. Delete Employee\n" +
                                "4. List All Employees\n" +
                                "5. Exit\n";

            OutputUtil.Print(menu);
            int choice = InputUtil.GetInt("Enter your choice");

            switch (choice)
            {
                case 1:
                    addUserView.Show();
                    break;
                case 2:
                    updateUserView.Show();
                    break;
                case 3:
                    removeUserView.Show();
                    break;
                case 4:
                    getUsersView.Show();
                    break;
                case 5:
                    Console.WriteLine("Exit");
                    break;
                default:
                    OutputUtil.Print("\nInvalid choice. Please try again.\n");
                    Show();
                    break;
            }
        }
    }
}
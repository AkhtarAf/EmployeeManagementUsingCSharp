using EmployeeManagerApp.Entities;

namespace EmployeeManagerApp.Entities
{
    public abstract class Employee
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public TypeOfEmployees TypeOfEmployee { get; set; }

        public Employee(int id, string name, string department, TypeOfEmployees typeOfEmployee)
        {
            Id = id;
            Name = name;
            Department = department;
            TypeOfEmployee = typeOfEmployee;
        }

        protected Employee(int id, string name, string department)
        {
            Id = id;
            Name = name;
            Department = department;
        }

        public abstract double Earning();
        
    }
}
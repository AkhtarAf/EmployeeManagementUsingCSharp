using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1AfshanAkhtar
{
    public enum TypeOfEmployee
    {
        HourlyEmployee,
        SalariedEmployee,
        CommisionBasedEmployee
    }
    internal abstract class Employee
    {
        public TypeOfEmployee employeeType { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }

        public Employee(TypeOfEmployee employeeType, int id, string name, string department)
        {
            EmployeeType = employeeType;
            Id = id;
            Name = name;
            Department = department;
        }

        public abstract double Earning();

        public abstract override string ToString();
    }
}

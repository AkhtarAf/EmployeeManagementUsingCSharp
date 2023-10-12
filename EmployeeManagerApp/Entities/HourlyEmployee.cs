namespace EmployeeManagerApp.Entities
{
    public class HourlyEmployee : Employee
    {
        public double HourlyRate { get; set; }
        public double HoursWorked { get; set; }

        public HourlyEmployee(int id, string name, string department, double hourlyRate, double hoursWorked) : base(id, name, department)
        {
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
            TypeOfEmployee = TypeOfEmployees.HourlyEmployee;
        }

        public override double Earning()
        {
            return HourlyRate * HoursWorked;
        }

        public override string ToString()
        {
            return  $"Id : {Id} " +
                    $"\n Name : {Name} " +
                    $"\n Hourly Rate : {HourlyRate}" +
                    $"\n Hours Worked : {HoursWorked} " +
                    $"\n Total Earning : {Earning()}";
        }
    }
}
namespace EmployeeManagerApp.Entities
{

    public class SalariedEmployee : Employee
    {
        public double MonthlySalary { get; set; }
        public double MonthlyIncentive { get; set; }

        public SalariedEmployee(int id, string name, string department, double monthlySalary, double monthlyIncentive) : base(id, name, department)
        {
            MonthlySalary = monthlySalary;
            MonthlyIncentive = monthlyIncentive;
            TypeOfEmployee = TypeOfEmployees.SalariedEmployee;
        }

        public override double Earning()
        {
            return MonthlySalary + MonthlyIncentive;
        }

        public override string ToString()
        {
            return  $"Id : {Id} " +
                    $"\n Name : {Name} " +
                    $"\n Monthly Salary : {MonthlySalary}" +
                    $"\n Monthly Incentive : {MonthlyIncentive} " +
                    $"\n Total Earning : {Earning()}";
        }
    }
}


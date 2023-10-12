namespace EmployeeManagerApp.Entities
{
    public class CommissionBasedEmployee : Employee
    {
        public double CommissionRate { get; set; }
        public double SalesAmount { get; set; }

        public CommissionBasedEmployee(int id, string name, string department, double commissionRate, double salesAmount) : base(id, name, department)
        {
            CommissionRate = commissionRate;
            SalesAmount = salesAmount;
            TypeOfEmployee = TypeOfEmployees.CommissionBasedEmployee;
        }

        public override double Earning()
        {
            return CommissionRate * SalesAmount;
        }

        public override string ToString()
        {
            return  $"Id : {Id} " +
                    $"\n Name : {Name} " +
                    $"\n Commission Rate : {CommissionRate}" +
                    $"\n Sales Amount : {SalesAmount} " +
                    $"\n Total Earning : {Earning()}";
        }
    }
}
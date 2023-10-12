using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace A1AfshanAkhtar
{
    internal class SalariedEmployee : Employee
    {
        public double MonthlySalary {  get; set; }
        public double MonthlyIncentive { get; set; }
        public SalariedEmployee(TypeOfEmployee employeeType, int id, string name, string department, double monthlySalary, double monthlyIncentive) : base(employeeType, id, name, department)
        {
            MonthlySalary = monthlySalary;
            MonthlyIncentive = monthlyIncentive;
        }

        public override double Earning()
        {
            return (MonthlySalary +  MonthlyIncentive);
        }

        public override string ToString()
        {
            return $"Id : {Id} " +
                $"\n Name : {Name} " +
                $"\n Department : {Department} " +
                $"\n Monthly Salary : {MonthlySalary} " +
                $"\n Monthly Incentive : {MonthlyIncentive} " +
                $"\n Total Earning : {Earning()}";
        }
    }
}

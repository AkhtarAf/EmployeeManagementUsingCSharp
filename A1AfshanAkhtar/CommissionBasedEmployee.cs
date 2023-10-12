using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1AfshanAkhtar
{
    internal class CommissionBasedEmployee : Employee
    
    {
        private double salesAmount;
        public double SalesAmount
        {
            get { return salesAmount; }
            set
            {
                if (value < 0)
                    throw new Exception("Sales amount must be more than 0");
                salesAmount = value;
            }
        }

        private double commissionRate;
        public double CommissionRate
        {
            get { return commissionRate; }
            set
            {
                if (value > 0.10 || value < 0.50)
                    throw new Exception("Commission rate must be between 0.10 and 0.50");
                commissionRate = value;
            }
        }

        public CommissionBasedEmployee(TypeOfEmployee employeeType, int id, string name,string department, int commissionRate, double salesAmount) : base(employeeType, id, name, department)
        {
            CommissionRate = commissionRate;
            SalesAmount = salesAmount;
        }

        public override double Earning()
        {
            return CommissionRate * SalesAmount;
        }

        public override string ToString()
        {
            return $"Id : {Id} " +
                $"\n Name : {Name} " +
                $"\n Commission Rate : {CommissionRate}" +
                $"\n Sales Amount : {SalesAmount} " +
                $"\n Total Earning : {Earning()}";
        }
    }
}

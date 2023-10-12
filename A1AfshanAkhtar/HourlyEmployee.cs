using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace A1AfshanAkhtar
{
    internal class HourlyEmployee : Employee
    {
        public double Wage {  get; set; }
        public int Hours { get; set; }

        public HourlyEmployee(TypeOfEmployee employeeType, int id, string name, string department, double wage, int hours) : base(employeeType, id, name, department)
        {
            Wage = wage;
            Hours = hours;
        }

        public override double Earning()
        {
            if(Hours <= 40)
            {
                return Wage * Hours;
            }
            else
            {
                return (Wage * 40) + (Hours - 40) * (Wage * 1.5);
            }
        }

        public override string ToString()
        {
            return $"Id : {Id} " +
                $"\n Name : {Name} " +
                $"\n Department : {Department} " +
                $"\n Wage : {Wage} " +
                $"\n Hours : {Hours} " +
                $"\n Total Earnings : {Earning()}";
        }
    }
}

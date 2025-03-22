using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Types.Concrete
{
    public sealed class SalaryEmployee : Employee
    {
        public double Salary { get; set; }

        public override double AdjustSalary(double percentage)
        {
            Salary += Salary * percentage;
            return Salary;
        }

        public override double GetRate()
        {
            return Salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()} - {Salary}/year";
        }
    }
}
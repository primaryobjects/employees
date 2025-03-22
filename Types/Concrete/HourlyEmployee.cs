using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Types.Concrete
{
    public sealed class HourlyEmployee : Employee
    {
        public double HourlyRate { get; set; }

        public override double AdjustSalary(double percentage)
        {
            HourlyRate += HourlyRate * percentage;
            return HourlyRate;
        }

        public override double GetRate()
        {
            return HourlyRate;
        }

        override public string ToString()
        {
            return $"{base.ToString()} - {HourlyRate}/hour";
        }
    }
}
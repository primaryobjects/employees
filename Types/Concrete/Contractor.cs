using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Types.Concrete
{
    public class Contractor : Employee
    {
        public int ContractLength { get; set; }
        public double Rate { get; set; }

        public override double AdjustSalary(double percentage)
        {
            throw new NotImplementedException("Unable to change a contract's payment terms.");
        }

        public override double GetRate()
        {
            return Rate;
        }

        override public string ToString()
        {
            return $"{base.ToString()} - {Rate}/{ContractLength} weeks";
        }
    }
}
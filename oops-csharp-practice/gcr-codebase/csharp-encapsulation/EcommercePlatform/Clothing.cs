using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Encapsulation.EcommercePlatform
{
    public class Clothing : Product, ITaxable
    {
        public override double CalculateDiscount()
        {
            return Price * 0.20;
        }
        public double CalculateTax()
        {
            return Price * 0.05;
        }
        public string GetTaxDetails()
        {
            return "Tax on Clothing  5%";
        }

    }
}

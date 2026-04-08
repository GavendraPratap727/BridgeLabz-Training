using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Encapsulation.EcommercePlatform
{
    public class Groceries : Product
    {
        public override double CalculateDiscount()
        {
            return Price * 0.05;
        }
        public string GetTaxDetails()
        {
            return "Tax on Groceries 5%";
        }
    }
}

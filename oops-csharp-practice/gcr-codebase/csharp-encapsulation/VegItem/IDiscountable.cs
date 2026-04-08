using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Encapsulation.VegItem
{
    public interface IDiscountable
    {
        double ApplyDiscount();
        string GetDiscountDetails();
    }

}

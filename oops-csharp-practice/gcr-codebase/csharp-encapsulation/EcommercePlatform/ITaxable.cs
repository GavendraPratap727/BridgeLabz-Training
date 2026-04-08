using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Encapsulation.EcommercePlatform
{
    public interface ITaxable
    {
        double CalculateTax();
        string GetTaxDetails();
    }
}

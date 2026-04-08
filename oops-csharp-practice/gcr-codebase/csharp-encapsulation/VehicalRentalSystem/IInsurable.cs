using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Encapsulation.VehicalRentalSystem
{
    public interface IInsurable
    {

        public double calculateInsurance();

        public string getInsuranceDetails();

    }
}

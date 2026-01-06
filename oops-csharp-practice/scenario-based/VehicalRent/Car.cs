using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Opps_senario.VehicalRent
{
    class Car : Vehical, IRental
    {
        public Car()
        {
            vehicalName = "Honda City";
            rentPerDay = 2250;
        }

        public override double CalculateRent(int days)
        {
            return days * rentPerDay;
        }
    }
}

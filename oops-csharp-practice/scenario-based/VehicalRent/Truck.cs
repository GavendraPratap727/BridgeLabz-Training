using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Opps_senario.VehicalRent
{
    class Truck : Vehical, IRental
    {
        public Truck()
        {
            vehicalName = "Truck";
            rentPerDay = 10250;
        }

        public override double CalculateRent(int days)
        {
            return days * rentPerDay;
        }
    }
}

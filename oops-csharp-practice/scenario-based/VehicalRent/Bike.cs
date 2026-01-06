using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Opps_senario.VehicalRent
{
    class Bike : Vehical, IRental
    {
        public Bike()
        {
            vehicalName = "Bike";
            rentPerDay = 250;
        }
        public override double CalculateRent(int days)
        {
            return days * rentPerDay;
        }
    }
}

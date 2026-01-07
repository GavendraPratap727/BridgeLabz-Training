using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Encapsulation.RideHandaling
{
    class Auto:Vehical,IGPS
    {
        public Auto(int id, string name, double rate) : base(id, name, rate)
        {
        }
        public override double CalculateFare(double distance)
        {
            return distance * ratePerKm + 20;
        }
        public string GetCurrentLocation()
        {
            return Location;
        }

        public void UpdateLocation(string location)
        {
            Location = location;
        }
    }
}

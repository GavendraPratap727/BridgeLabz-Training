using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Encapsulation.RideHandaling
{
     class Car:Vehical,IGPS
    {
        public Car(int id, string name , double rate):base(id,name,rate)
        {
        }
        public override double CalculateFare(double distance)
        {
            return distance * ratePerKm + 50;
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

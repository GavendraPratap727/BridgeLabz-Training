using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Encapsulation.RideHandaling
{
    internal class RideHandaling
    {
        static void Main(string[] args)
        {
            Vehical v1 = new Car(101, "Rahul", 15);
            Vehical v2 = new Bike(102, "Amit", 8);
            Vehical v3 = new Auto(103, "Suresh", 10);
            double distance = 10;
            v1.GetVehicalDetails();
            Console.WriteLine("Fare " + v1.CalculateFare(distance));
            v2.GetVehicalDetails();
            Console.WriteLine("Fare: " + v2.CalculateFare(distance));
            v3.GetVehicalDetails();
            Console.WriteLine("Fare: " + v3.CalculateFare(distance));
        }
    }
}

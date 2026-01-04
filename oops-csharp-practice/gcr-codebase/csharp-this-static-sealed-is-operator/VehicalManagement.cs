using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Seiled_class
{
    // Sealed class Vehicle
    public class Vehicle
    {
        public static double RegistrationFee = 5000;
        public readonly string RegistrationNumber;
        public string OwnerName;
        public string VehicleType;
        // Constructor
        public Vehicle(string OwnerName, string VehicleType, string RegistrationNumber)
        {
            this.OwnerName = OwnerName;
            this.VehicleType = VehicleType;
            this.RegistrationNumber = RegistrationNumber;
        }
        // Static method to update registration fee
        public static void UpdateFee(double newFee)
        {
            RegistrationFee = newFee;
            Console.WriteLine("Updated Registration Fee: " + RegistrationFee);
        }
        //  Method to display vehicle details
        public void VehicleDetails(object vehicle)
        {
            if (vehicle is Vehicle)
            {
                Console.WriteLine("Owner Name " + OwnerName);
                Console.WriteLine("Vehicle Type " + VehicleType);
                Console.WriteLine("Registration Number " + RegistrationNumber);
                Console.WriteLine("Registration Fee " + RegistrationFee);
            }
            else  Console.WriteLine("Invalid vehicle ");
        }
    }

    class VehicleManagemtent
    {
        static void Main(string[] args)
        {
            Vehicle vehicle1 = new Vehicle("Love", "Car", "UP8115234");
            Vehicle vehicle2 = new Vehicle("Gavendra", "Bike", "UP18CD5678");
            vehicle1.VehicleDetails(vehicle1);
            Console.WriteLine();
            vehicle2.VehicleDetails(vehicle2);
            Console.WriteLine();
            Vehicle.UpdateFee(7000);
            Console.WriteLine();
            vehicle1.VehicleDetails(vehicle1);

        }
    }
}

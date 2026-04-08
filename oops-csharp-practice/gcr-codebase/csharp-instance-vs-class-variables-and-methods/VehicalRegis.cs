using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Instance
{
    // Instance class Vehicle
    class Vehicle
    {
         static float registrationFee = 5000;
         string ownerName;
         string vehicleType;
        public Vehicle(string ownerName, string vehicleType)
        {
            this.ownerName = ownerName;
            this.vehicleType = vehicleType;
        }
        // Method to display vehicle details
        public void VehicleDetails()
        {
            Console.WriteLine();
            Console.WriteLine("Vehicle details:- ");
            Console.WriteLine("Owner Name " + ownerName);
            Console.WriteLine("Vehicle Type " + vehicleType);
            Console.WriteLine("Registration Fee: " + registrationFee);
        }
        // Static method to update registration fee
        public static void UpdateFee(float updatedRegistrationFee)
        {
            registrationFee = updatedRegistrationFee;
            Console.WriteLine("Registration Fees Updated");
        }
    }
    // Main class
    class VehicleRegis
    {

        // Main Method
        static void Main(string[] args)
        {
            Vehicle vehicle1 = new Vehicle("gavendra", "Bike");
            Vehicle vehicle2 = new Vehicle("Luv", "Car");
            vehicle1.VehicleDetails();
            vehicle2.VehicleDetails();
            Vehicle.UpdateFee(10000);
            vehicle1.VehicleDetails();
            vehicle2.VehicleDetails();
        }
    }
}

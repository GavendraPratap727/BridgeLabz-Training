using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Encapsulation.VehicalRentalSystem
{
    public class VehicleRentalSystem
    {
        public static void Main(string[] args)
        {

            Vehicle[] vehicles = new Vehicle[3];
            Bike bike = new Bike();
            bike.VehicleNumber = "Up817211";
            bike.Type = "Bike";
            bike.RentalRate = 700;
            bike.InsurancePolicyNumber = "BIKE-225";
            Car car = new Car();
            car.VehicleNumber = "UP81 5749";
            car.Type = "Car";
            car.RentalRate = 5000;
            car.InsurancePolicyNumber = "CAR-INS-14";
            Truck truck = new Truck();
            truck.VehicleNumber = "TRUCK2103";
            truck.Type = "Truck";
            truck.RentalRate = 100000;
            truck.InsurancePolicyNumber = "TRUCK-INS-15";
            vehicles[0] = car;
            vehicles[1] = bike;
            vehicles[2] = truck;
            VehicleProcessor processor = new VehicleProcessor();
            processor.displayVehicles(vehicles, 3);
        }
    }
}

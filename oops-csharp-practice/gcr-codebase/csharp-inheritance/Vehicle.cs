//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace bridge.Inheritance
//{
//    class Vehicle
//    {
//        public int maxSpeed;
//        public string fuelType;
//        public Vehicle(int maxSpeed, string fuelType)
//        {
//            this.maxSpeed = maxSpeed;
//            this.fuelType = fuelType;
//        }
//        public virtual void Display()
//        {
//            Console.WriteLine("Max Speed: " + maxSpeed);
//            Console.WriteLine("Fuel Type: " + fuelType);
//        }
//    }
//    class Car : Vehicle
//    {
//        public int seatCapacity;
//        public Car(int maxSpeed, String fuelType, int seatCapacity) : base(maxSpeed, fuelType)
//        {
//            this.seatCapacity = seatCapacity;

//        }
//        public override void Display()
//        {
//            base.Display();
//            Console.WriteLine("Max seating Capacity " + seatCapacity);
//        }
//    }
//    class Truck : Vehicle
//    {
//        public int payLoadCapacity;
//        public Truck(int maxSpeed, String fuelType, int payLoadCapacity) : base(maxSpeed, fuelType)
//        {
//            this.payLoadCapacity = payLoadCapacity;

//        }
//        public override void Display()
//        {
//            base.Display();
//            Console.WriteLine("Pay Load Capacity " + payLoadCapacity);
//        }
//    }
//    class MoterCycle : Vehicle
//    {
//        public bool hasSidecar;
//        public MoterCycle(int maxSpeed, String fuelType, bool hasSidecar) : base(maxSpeed, fuelType)
//        {
//            this.hasSidecar = hasSidecar;

//        }
//        public override void Display()
//        {
//            base.Display();
//            Console.WriteLine("Bike have Side Car ? " + hasSidecar);
//        }
//    }
//    class Program
//    {
//        static void Main(String[] agrs)
//        {
//            Console.WriteLine("Enter car details maxSpeed, fuel type,seats");
//            int cmaxSpeed = int.Parse(Console.ReadLine());
//            string cfuelType = Console.ReadLine();
//            int seats = int.Parse(Console.ReadLine());
//            Console.WriteLine();
//            Console.WriteLine("Enter Truck details maxSpeed, fuel type,Load Capacity");
//            int tmaxSpeed = int.Parse(Console.ReadLine());
//            string tfuelType = Console.ReadLine();
//            int capacity = int.Parse(Console.ReadLine());
//            Console.WriteLine();
//            Console.WriteLine("Enter motercycle details maxSpeed, fuel type,Is bike have side car");
//            int mmaxSpeed = int.Parse(Console.ReadLine());
//            string mfuelType = Console.ReadLine();
//            bool sidecar = bool.Parse(Console.ReadLine());
//            Vehicle[] veh = new Vehicle[3];
//            veh[0] = new Car(cmaxSpeed, cfuelType, seats);
//            veh[1] = new Truck(tmaxSpeed, tfuelType, capacity);
//            veh[2] = new MoterCycle(mmaxSpeed, mfuelType, sidecar);
//            Console.WriteLine("Vehicals details");
//            foreach (Vehicle v in veh)
//            {
//                v.Display();
//                Console.WriteLine();
//            }
//        }


//    }
//}

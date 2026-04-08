using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Opps_senario.VehicalRent
{
   public  class Menu
    {
        public static void ShowMenu()
        {
            Console.WriteLine("Welcome to Vehical rental");
            Console.WriteLine("Enter number of days ");
            int days = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Customer Name");
            ICustomer c = new Customer(Console.ReadLine());
            while (true)
            {



                Console.WriteLine("PRESS 1 : Rent a Bike");
                Console.WriteLine("PRESS 2 : Rent a Car");
                Console.WriteLine("PRESS 3 : FOR RENT A TRUCK");
                Console.WriteLine("PRESS 4 : EXIT");
                int choice = int.Parse(Console.ReadLine());



                IRental r;
                switch (choice)
                {
                    case 1:
                        r = new Bike();
                        break;
                    case 2:
                        r = new Car();

                        break;
                    case 3:
                        r = new Truck();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid Choice");
                        return;
                }
                c.ShowCustomer();
                r.ShowVehical();
                Console.WriteLine("Total Rent for " + days + " days: " + r.CalculateRent(days));
            }




        }
    }
}

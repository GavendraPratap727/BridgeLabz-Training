using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Senario.HospitalSystemApp
{
    

    public static class HospitalMenu
    {
        public static void Start()
        {
            IHospitalNavigation route = new AmbulanceRouteUtility();
            int choice;

            do
            {
                Console.WriteLine("\n--- Ambulance Route Management ---");
                Console.WriteLine("1. Add Hospital Unit");
                Console.WriteLine("2. Remove Unit (Maintenance)");
                Console.WriteLine("3. Set Unit Availability");
                Console.WriteLine("4. Find Next Available Unit");
                Console.WriteLine("5. Display Route");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter unit name: ");
                        route.AddUnit(Console.ReadLine());
                        break;

                    case 2:
                        Console.Write("Enter unit name to remove: ");
                        route.RemoveUnit(Console.ReadLine());
                        break;

                    case 3:
                        Console.Write("Enter unit name: ");
                        string name = Console.ReadLine();
                        Console.Write("Is Available (true/false): ");
                        bool status = bool.Parse(Console.ReadLine());
                        route.SetAvailability(name, status);
                        break;

                    case 4:
                        Console.Write("Enter starting unit: ");
                        Console.WriteLine(route.FindNextAvailable(Console.ReadLine()));
                        break;

                    case 5:
                        route.DisplayRoute();
                        break;

                    case 0:
                        Console.WriteLine("System closed.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

            } while (choice != 0);
        }
    }

}

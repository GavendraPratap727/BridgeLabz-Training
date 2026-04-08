using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.DSA_Senario.FitnessManagerApp
{
    class Menu
    {
        public void Run()
        {
            FitnessManagerImpl manager = new FitnessManagerImpl();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine();
                Console.WriteLine("--- Fitness Tracker Menu ---");
                Console.WriteLine("1. Add User Steps");
                Console.WriteLine("2. Update Ranking");
                Console.WriteLine("3. Display Ranking");
                Console.WriteLine("4. Exit");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter user name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter steps taken: ");
                        int steps = int.Parse(Console.ReadLine());

                        manager.AddUser(name, steps);
                        break;

                    case 2:
                        manager.SortBySteps();
                        break;

                    case 3:
                        manager.DisplayRanking();
                        break;

                    case 4:
                        exit = true;
                        Console.WriteLine("Exiting Fitness Tracker...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Opps_senario.HospitalManagement
{
    internal class NurseMenu : INurseMenu
    {
        public static Nurse[] nurses = new Nurse[10];
        public static int ncount = 0;
        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("PRESS 1 : FOR ADD NURSE");
                Console.WriteLine("PRESS 2 : FOR VIEW NURSE");
                Console.WriteLine("PRESS 3 : EXIT");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Nurse n = new Nurse();
                    Console.WriteLine("enter nurse name");
                    n.name = Console.ReadLine();
                    Console.WriteLine("Enter nurse ward");
                    n.ward = Console.ReadLine();
                    nurses[ncount++] = n;
                    Console.WriteLine("New nurse added");
                }
                else if (choice == 2)
                {
                    for (int i = 0; i < ncount; i++)
                    {
                        Console.WriteLine(nurses[i].name + "   " + nurses[i].ward);
                    }
                }
                else if (choice == 3) return;
                else Console.WriteLine("Invalid Choice");

            }
        }
    }
}

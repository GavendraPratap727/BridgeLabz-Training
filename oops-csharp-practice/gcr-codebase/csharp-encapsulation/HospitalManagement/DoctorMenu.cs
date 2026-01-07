using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Opps_senario.HospitalManagement
{
   public  class DoctorMenu:IDoctorMenu
    {
        public static Doctor[] doctors = new Doctor[10];
        public static int dcount = 0;
        public void ShowMenu()
        {
            while (true) { 
            Console.WriteLine();
            Console.WriteLine("PRESS 1 : FOR ADD DOCOTOR");
            Console.WriteLine("PRESS 2 : FOR VIEW DOCOTOR");
            Console.WriteLine("PRESS 3 : EXIT");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Doctor d = new Doctor();
                    Console.WriteLine("enter doctor name");
                    d.name = Console.ReadLine();
                    Console.WriteLine("Enter doctor specialiaztion");
                    d.specialization = Console.ReadLine();
                    doctors[dcount++] = d;
                    Console.WriteLine("New doctor added");
                }
                else if (choice == 2)
                {
                    for (int i = 0; i < dcount; i++)
                    {
                        Console.WriteLine(doctors[i].name + "   " + doctors[i].specialization);
                    }
                }
                else if (choice == 3) return;
                else Console.WriteLine("Invalid Choice");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Opps_senario.HospitalManagement
{
    class Menu
    {
        public static  void ShowMenu()
        {
            IDoctorMenu dm = new DoctorMenu();
            INurseMenu nm = new NurseMenu();
            IPatientMenu pm = new PatientMenu();
            Console.WriteLine("Welcome to our Hospital");
            while (true) 
            {



                Console.WriteLine(" HOSPITAL MANAGEMENT SYSTEM ");
                Console.WriteLine("1 Doctor");
                Console.WriteLine("2 Nurse");
                Console.WriteLine("3 Patient");
                Console.WriteLine("4 Exit");
           
                int ch = int.Parse(Console.ReadLine());
                if (ch == 1) dm.ShowMenu();
                else if (ch == 2) nm.ShowMenu();
                else if (ch == 3) pm.ShowMenu();
                else break;


            }
        }
    }
}




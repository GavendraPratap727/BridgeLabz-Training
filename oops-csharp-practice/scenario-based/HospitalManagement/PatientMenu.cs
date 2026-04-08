using System;

namespace bridge.Opps_senario.HospitalManagement
{
    class PatientMenu : IPatientMenu
    {
        Patient[] patients = new Patient[50];
        int pCount = 0;

        public void ShowMenu()
        {
            Console.WriteLine("\n--- PATIENT MENU ---");
            Console.WriteLine("1. Add Patient");
            Console.WriteLine("2. View Patients");
            Console.Write("Choice: ");
            int ch = int.Parse(Console.ReadLine());

            if (ch == 1)
            {
                if (DoctorMenu.dcount == 0 || NurseMenu.ncount == 0)
                {
                    Console.WriteLine("Please add Doctor and Nurse first.");
                    return;
                }

                if (pCount >= patients.Length)
                {
                    Console.WriteLine("Patient limit reached.");
                    return;
                }

                Console.WriteLine("1. In-Patient");
                Console.WriteLine("2. Out-Patient");
                Console.Write("Select Type: ");
                int type = int.Parse(Console.ReadLine());

                Console.Write("Patient Name: ");
                string name = Console.ReadLine();

                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine());

                Console.WriteLine("\nSelect Doctor (enter index):");
                for (int i = 0; i < DoctorMenu.dcount; i++)
                    Console.WriteLine(i + ". " + DoctorMenu.doctors[i].name);

                int dIndex = int.Parse(Console.ReadLine());
                if (dIndex < 0 || dIndex >= DoctorMenu.dcount)
                {
                    Console.WriteLine("Invalid Doctor Selection");
                    return;
                }
                Doctor d = DoctorMenu.doctors[dIndex];

                Console.WriteLine("Select Nurse (enter index):");
                for (int i = 0; i < NurseMenu.ncount; i++)
                    Console.WriteLine(i + " " + NurseMenu.nurses[i].name);

                int nIndex = int.Parse(Console.ReadLine());
                if (nIndex < 0 || nIndex >= NurseMenu.ncount)
                {
                    Console.WriteLine("Invalid Nurse Selection");
                    return;
                }
                Nurse n = NurseMenu.nurses[nIndex];

                if (type == 1)
                {
                    InPatient p = new InPatient();
                    p.name = name;
                    p.age = age;
                    p.Doctor = d;
                    p.Nurse = n;

                    Console.Write("Room No: ");
                    p.room = int.Parse(Console.ReadLine());

                    Console.Write("Days: ");
                    p.days = int.Parse(Console.ReadLine());

                    Console.Write("Charge/Day: ");
                    p.charge = double.Parse(Console.ReadLine());

                    patients[pCount++] = p;
                }
                else if (type == 2)
                {
                    OutPatient p = new OutPatient();
                    p.name = name;
                    p.age = age;
                    p.Doctor = d;
                    p.Nurse = n;

                    Console.Write("Doctor Fee: ");
                    p.fee = double.Parse(Console.ReadLine());

                    patients[pCount++] = p;
                }
                else
                {
                    Console.WriteLine("Invalid Patient Type");
                    return;
                }

                Console.WriteLine("Patient Added & Bill Generated");
            }
            else if (ch == 2)
            {
                if (pCount == 0)
                {
                    Console.WriteLine("No Patients Found.");
                    return;
                }

                for (int i = 0; i < pCount; i++)
                {
                    Console.WriteLine(" Patient " + (i + 1));
                    patients[i].Display();
                }
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }
        }
    }
}

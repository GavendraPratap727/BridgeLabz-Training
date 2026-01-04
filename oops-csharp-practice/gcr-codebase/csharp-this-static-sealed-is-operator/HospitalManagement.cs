using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Seiled_class
{
    // Sealed class Patient
    public class Patient //it cannot be inherated
    {
        public static string HospitalName = "Krishna Hospital";
        private static int totalPatient = 0;
        public readonly int patientID;
        public string name;
        public int age;
        public string ailment;
        // Parameterized constructor
        public Patient(string Name, int Age, int PatientID, string Ailment)
        {
            this.name = Name;
            this.age = Age;
            this.patientID = PatientID;
            this.ailment = Ailment;
            totalPatient++;
        }
        // Static method to get total patients
        public static int TotalPatients()
        {

            return totalPatient;
        }
        public void PatientDetails(object patient)
        {

            if (patient is Patient)

            {
                Console.WriteLine("Hospital Name  " + HospitalName);
                Console.WriteLine("Patient Name  " + name);
                Console.WriteLine("Age " + age);
                Console.WriteLine("Patient iD " + patientID);
                Console.WriteLine("Ailment  " + ailment);
            }
            else
            {

                Console.WriteLine("Invalid patient object");
            }
        }
    }
    // Main class

    class HospitalManagement
    {
        //  Main method
        static void Main(string[] args)
        {
            Patient patient1 = new Patient("Gavendra", 22, 501, "Fever");
            Patient patient2 = new Patient("Luv", 22, 102, "Fracture");

            patient1.PatientDetails(patient1);
            Console.WriteLine();

            patient2.PatientDetails(patient2);
            Console.WriteLine();

            Console.WriteLine("Total Patients Admitted " + Patient.TotalPatients());
        }
    }
}

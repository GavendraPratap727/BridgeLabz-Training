using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.lkfdghkjf
{
    class Patient
    {
        public string Name { get; set; }
        public Patient(string inputName)
        {
            Name = inputName;
        }
    }

    class Doctor
    {
        public string Name { get; set; }
        private List<Patient> patientList = new List<Patient>();
        public Doctor(string inputName)
        {
            Name = inputName;
        }
        public void StartConsultation(Patient pat)
        {
            if (!patientList.Contains(pat))
            {
                patientList.Add(pat);
            }
            Console.WriteLine("Doctor " + Name + " is consulting patient " + pat.Name);
        }
        public void DisplayPatients()
        {
            Console.WriteLine("Patients consulted by Dr." + Name);
            foreach (Patient pt in patientList)
            {
                Console.WriteLine(pt.Name);
            }
            Console.WriteLine();
        }
    }

    class Hospital
    {
        public string HospitalName { get; set; }
        private List<Doctor> doctorList = new List<Doctor>();
        private List<Patient> patientList = new List<Patient>();
        public Hospital(string hospitalTitle)
        {
            HospitalName = hospitalTitle;
        }
        public void AddDoctor(Doctor doc)
        {
            doctorList.Add(doc);
        }
        public void AddPatient(Patient pat)
        {
            patientList.Add(pat);
        }
        public void ShowHospitalDetails()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(HospitalName);
            Console.ResetColor();
            Console.WriteLine("Doctors:");
            foreach (Doctor d in doctorList)
            {
                Console.WriteLine("Dr. " + d.Name);
            }
            Console.WriteLine("Patients:");
            foreach (Patient p in patientList)
            {
                Console.WriteLine(p.Name);
            }
            Console.WriteLine();
        }
    }

    class AssociationAndComposition
    {
        public static void Main(string[] args)
        {
            Hospital hospital = new Hospital("Krishan Hospital");
            Doctor doc1 = new Doctor("Gavnedra");
            Doctor doc2 = new Doctor("Luv");
            Patient p1 = new Patient("hati");
            Patient p2 = new Patient("Sathi");
            hospital.AddDoctor(doc1);
            hospital.AddDoctor(doc2);
            hospital.AddPatient(p1);
            hospital.AddPatient(p2);
            hospital.ShowHospitalDetails();
            doc1.StartConsultation(p1);
            doc1.StartConsultation(p2);
            doc2.StartConsultation(p1);
            Console.WriteLine();
            doc1.DisplayPatients();
            doc2.DisplayPatients();
        }
    }
}

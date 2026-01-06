using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Opps_senario.HospitalManagement
{
     class Patient
    {
        public string name;
        public int age;
        public Doctor Doctor;
        public Nurse Nurse;
        public virtual void Display() {
            Console.WriteLine("Patient Name: " + name);
            Console.WriteLine("Patient Age: " + age);
            Console.WriteLine("Doctor name "+ Doctor.name);
            Console.WriteLine("Nurse name " + Nurse.name);
        }


    }
}

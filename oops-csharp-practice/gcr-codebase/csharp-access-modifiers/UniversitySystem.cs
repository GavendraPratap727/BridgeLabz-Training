using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Access_modifiers
{
    // Base class
    public class Student
        {
        // Access modifiers: public, protected, private
        public int rollNumber;
            protected string name;
            private double cgpa;
        // Parameterized constructor
        public Student(int rollNumber, string name, double cgpa)
            {
                this.rollNumber = rollNumber;
                this.name = name;
                this.cgpa = cgpa;
            }
        // Getter and Setter for private member cgpa
        public double GetCgpa()
            {
                return cgpa;
            }
        // Setter method to update cgpa
        public void UpdateCgpa(double newCgpa)
            {
                if (newCgpa >= 0.0 && newCgpa <= 10.0)
                {
                    cgpa = newCgpa;
                }
                else
                {
                    Console.WriteLine("Invalid CGPA");
                }
            }
        }
    // Derived class
    public class PostGraduateStudent : Student
        {
            private string courseName;
            public PostGraduateStudent(int rollNumber, string name, double cgpa, string courseName) : base(rollNumber, name, cgpa)
            {
                this.courseName = courseName;
            }
            public void StudentDetails()
            {
                Console.WriteLine("Roll number "+rollNumber);
                Console.WriteLine("name "+name);
                Console.WriteLine("cgpa "+GetCgpa());
                Console.WriteLine("Course Name "+courseName);
            }
        }
    // Main class
    public class UniversitySystem
        {
        // Main method
        static void Main(string[] args)
            {
                PostGraduateStudent postGraduateStudent1 = new PostGraduateStudent(1, "Aman", 9.4, "B.Tech");
                postGraduateStudent1.StudentDetails();
                postGraduateStudent1.UpdateCgpa(9.8);
                Console.WriteLine("Update Cgpa " + postGraduateStudent1.GetCgpa());
            }
        }
    }

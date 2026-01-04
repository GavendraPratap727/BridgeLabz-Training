using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Seiled_class
{
    public class Student
    {
        public static string universityName = "GLA University";
        private static int totalStudents = 0;
        public readonly int rollNumber;
        public string name;
        public char marks;
        public Student(string Name, int RollNumber, char Grade)
        {
            this.name = Name;
            this.rollNumber = RollNumber;
            this.marks = Grade;
            totalStudents++;
        }

        public static void TotalStudents()
        {
            Console.WriteLine("Total Students Enrolled: " + totalStudents);
        }

        public void StudentDetail(object student)
        {
            if (student is Student)
            {
                Console.WriteLine("University Name " + universityName);
                Console.WriteLine("Student Name " + name);
                Console.WriteLine("Roll Number " + rollNumber);
                Console.WriteLine("Marks " + marks);
            }
            else   Console.WriteLine("Invalid student ");
        }

        public void UpdateMarks(object student, char newGrade)
        {
            if (student is Student)
            {
                marks = newGrade;
                Console.WriteLine("marks updated successfully.");
            }
            else   Console.WriteLine("Grade update failed. Invalid student .");
            
        }
    }
    class UniversityManagement
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Amit", 101, 'A');
            Student student2 = new Student("Raghav", 102, 'B');
            student1.StudentDetail(student1);
            Console.WriteLine();
            student2.StudentDetail(student2);
            Console.WriteLine();
            student1.UpdateMarks(student1, 'A');
            student1.StudentDetail(student1);
            Console.WriteLine();
            Student.TotalStudents();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Instance
{
    // Instance class Course
    class Course
    {
        static string instituteName = "GLA  Univesity";
        private string courseName;
        private int duration;
        private float fee;
        internal Course(string courseName, int duration, float fee)
        {
            this.courseName = courseName;
            this.duration = duration;
            this.fee = fee;
        }

        internal void CourseDetails()
        {
            Console.WriteLine();
            Console.WriteLine("Given below are the course details ");
            Console.WriteLine("Institute Name " + instituteName);
            Console.WriteLine("Course Name " + courseName);
            Console.WriteLine("Duration " + duration + " Years");
            Console.WriteLine("Fee = Rs " + fee);
        }

        internal static void UpdateInstituteName(string instituteUpdatedName)
        {
            instituteName = instituteUpdatedName;
            Console.WriteLine();
            Console.WriteLine("Univeristy Name Updated");
        }
    }
    // Main class
    class OnlineCourseManagement
    {
        // Main Method
        static void Main(String[] args)
        {
            Course course1 = new Course("B-Tech", 4, 120000);
            Course course2 = new Course("M-Tech", 2, 400000);
            course1.CourseDetails(); // Display course 1 details
            course2.CourseDetails();// Display course 2 details
            Course.UpdateInstituteName("G.L.A University"); 
            course1.CourseDetails(); // Display course 1 details after update
            course2.CourseDetails();//Display course 2 details after update
        }
    }
}

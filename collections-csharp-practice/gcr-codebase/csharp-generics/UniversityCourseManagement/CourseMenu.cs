using System;

namespace CG_Practice.dsascenario.UniversityCourseManagement
{
    public class CourseMenu
    {
        public static void Start()
        {
            Course<ExamCourse> examCourses = new Course<ExamCourse>();
            Course<AssignmentCourse> assignmentCourses = new Course<AssignmentCourse>();

            bool running = true;

            while (running)
            {
                Console.WriteLine("\n===== UNIVERSITY COURSE MANAGEMENT =====");
                Console.WriteLine("1. Add Exam Course");
                Console.WriteLine("2. Add Assignment Course");
                Console.WriteLine("3. Show Exam Courses");
                Console.WriteLine("4. Show Assignment Courses");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddExamCourse(examCourses);
                        break;

                    case 2:
                        AddAssignmentCourse(assignmentCourses);
                        break;

                    case 3:
                        Console.WriteLine("\n--- Exam Courses ---");
                        examCourses.Show();
                        break;

                    case 4:
                        Console.WriteLine("\n--- Assignment Courses ---");
                        assignmentCourses.Show();
                        break;

                    case 5:
                        running = false;
                        Console.WriteLine("Exiting Course Management...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }

        private static void AddExamCourse(Course<ExamCourse> examCourses)
        {
            Console.Write("Enter course title: ");
            string title = Console.ReadLine();

            Console.Write("Enter credits: ");
            int credit = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks: ");
            int marks = Convert.ToInt32(Console.ReadLine());

            ExamCourse course = new ExamCourse(title, credit, marks);
            examCourses.Add(course);
        }

        private static void AddAssignmentCourse(Course<AssignmentCourse> assignmentCourses)
        {
            Console.Write("Enter course title: ");
            string title = Console.ReadLine();

            Console.Write("Enter credits: ");
            int credit = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter score: ");
            int score = Convert.ToInt32(Console.ReadLine());

            AssignmentCourse course = new AssignmentCourse(title, credit, score);
            assignmentCourses.Add(course);
        }
    }
}

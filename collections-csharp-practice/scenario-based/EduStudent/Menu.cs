using BridgeLabz.Collections.Senario.EduStudent;
using System;

class Menu
{
    public static void Start()
    {
        Console.Write("Enter number of students: ");
        int n = int.Parse(Console.ReadLine());

        Student[] students = new Student[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nStudent " + (i + 1));
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Console.Write("Enter marks: ");
            int marks = int.Parse(Console.ReadLine());

            students[i] = new Student(name, marks);
        }

        ISortUtility sorter = new MergeSortUtility();
        sorter.Sort(students);

        Console.WriteLine("\nFinal State-wise Rank List:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(
                (i + 1) + ". " +
                students[i].GetName() + " - " +
                students[i].GetMarks()
            );
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.LinkedListttt
{
    internal class StudentRecord
    {
        static LinkedList<(int Rollno,string name,int age,char grade)> students = new LinkedList<(int,string,int ,char)>();
        static void Main(String[] args) {
            AddAtStart(101, "Rahul", 22, 'B');
            AddAtEnd(103, "Sonu", 21, 'A');
            AddAtPosition(2,102, "Ram", 20, 'C');
            Console.WriteLine("Student Details");
            Display();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Search roll number 101 details");
            Search(101);
            Console.WriteLine("Upgrade grade of Roll number 102");
            UpgradeGrade(102, 'A');
            Console.WriteLine("Delete Roll number 101");
            DeleteRollNo(101);
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Final details");
            Display();
        }
        static void AddAtStart(int rollno, string name, int age, char grade) {
            students.AddFirst((rollno, name,age, grade));
        }
        static void AddAtEnd(int rollno, string name, int age, char grade)
        {
            students.AddLast((rollno, name, age, grade));
        }
        static void AddAtPosition(int position,int rollno, string name, int age, char grade)
        {
            if (position <= 1)
            {
                AddAtStart(rollno, name, age, grade);
                return;
            }
            var s= students.First;
           for(int i=1;i<position-1 && s!=null;i++)
            {
                s = s.Next;
            }
            if(s==null)
            {
                Console.WriteLine("Invalid position");
                return;
            }
          
                students.AddAfter(s, (rollno, name, age, grade));
        }
        static void DeleteRollNo(int rollno) {
            var s = students.First;
            while(s!=null)
            {
                if(s.Value.Rollno==rollno)
                {
                    students.Remove(s);
                    Console.WriteLine("Record deleted");
                    return;
                }
                s = s.Next;
            }
            Console.WriteLine("Roll number not found");
        }
        static void Search(int rollno) {
            foreach (var s in students) {
                if (s.Rollno == rollno)
                {
                    Console.WriteLine($"Roll No  {s.Rollno}, Name  {s.name}, Age  {s.age}, Grade {s.grade}");
                    return;
                }
            }
            Console.WriteLine("Roll number not found");

        }
        static void UpgradeGrade(int rollno,char newgrade) {
            var s = students.First;
            while (s != null)
            {
                if (s.Value.Rollno == rollno)
                {
                    s.Value = (s.Value.Rollno, s.Value.name, s.Value.age, newgrade);
                    Console.WriteLine("Grade upgraded");
                    return;
                }
                s = s.Next;
            }
            Console.WriteLine("Roll number not found");
        }
        static void Display() {
            if(students.Count==0)
            {
                Console.WriteLine("No records found");
                return;
            }
            foreach (var s in students)
            {
                Console.WriteLine($"Roll No  {s.Rollno}, Name  {s.name}, Age  {s.age}, Grade {s.grade}");
            }
        }


    }
}

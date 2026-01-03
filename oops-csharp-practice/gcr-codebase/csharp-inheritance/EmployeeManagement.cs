//using bridge.Inheritance;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace bridge.Inheritance
//{
//    class Employee
//    {
//        public string name;
//        public int id;
//        public double salary;
//        public Employee(string name, int id, double salary)
//        {
//            this.name = name;
//            this.id = id;
//            this.salary = salary;
//        }
//        public virtual void Display()
//        {
//            Console.WriteLine("Name " + name);
//            Console.WriteLine("ID " + id);
//            Console.WriteLine("Salary " + salary);
//        }
//    }
//    class Manager : Employee
//    {
//        public int teamsize;
//        public Manager(string name, int id, double salary, int teamsize) : base(name, id, salary)
//        {
//            this.teamsize = teamsize;

//        }
//        public override void Display()
//        {
//            base.Display();
//            Console.WriteLine("Team Size " + teamsize);
//        }

//    }
//    class Developer : Employee
//    {
//        public string languages;
//        public Developer(string name, int id, double salary, string languages) : base(name, id, salary)
//        {
//            this.languages = languages;
//        }
//        public override void Display()
//        {
//            base.Display();
//            Console.WriteLine("Languages " + languages);
//        }
//    }


//    class Intern : Employee
//    {
//        public string duration;
//        public Intern(string name, int id, double salary, string duration) : base(name, id, salary)
//        {
//            this.duration = duration;
//        }
//        public override void Display()
//        {
//            base.Display();
//            Console.WriteLine("Internship Duration " + duration);
//        }
//    }



//    class EmployeeManagement
//    {
//        static void Main(String[] args)
//        {
//            Console.WriteLine("Enter manager name ,id ,salary and team size");
//            string mName= Console.ReadLine();
//            int mId= int.Parse( Console.ReadLine());
//            double mSalary= double.Parse( Console.ReadLine());
//            int mTeamSize= int.Parse( Console.ReadLine());
//            Manager manager = new Manager( mName, mId, mSalary, mTeamSize);
//            Console.WriteLine("Enter developer name ,id ,salary and languages");
//            string dName = Console.ReadLine();
//            int dId = int.Parse(Console.ReadLine());
//            double dSalary = double.Parse(Console.ReadLine());
//             string salary = Console.ReadLine();
//            Developer developer = new Developer(dName, dId, dSalary, salary);
//            Console.WriteLine("Enter intern name ,id ,salary and duration");
//            string iName = Console.ReadLine();
//            int iId = int.Parse(Console.ReadLine());
//            double iSalary = double.Parse(Console.ReadLine());
//            string duration = Console.ReadLine();
//            Intern intern = new Intern(iName, iId, iSalary, duration);
//            Console.WriteLine();
//            Console.WriteLine("Manager details ");
//            manager.Display();
//            Console.WriteLine();
//            Console.WriteLine("Developer details ");
//            developer.Display();
//            Console.WriteLine();
//            Console.WriteLine("Intern details ");
//            intern.Display();




//        }
//    }
//}

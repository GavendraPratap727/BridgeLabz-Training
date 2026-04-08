using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.lkfdghkjf
{
    class Faculty
    {
        public string Name { get; set; }
        public Faculty(string inputName)
        {
            Name = inputName;
        }
        public void ShowFaculty()
        {
            Console.WriteLine("Faculty Name: " + Name);
        }
    }

    class Department
    {
        public string DeptName { get; set; }
        public Department(string inputDeptName)
        {
            DeptName = inputDeptName;
        }
        public void ShowDepartment()
        {
            Console.WriteLine("Department name : " + DeptName);
        }
    }

    class University
    {
        public string UniName { get; set; }
        private List<Department> deptList = new List<Department>();
        private List<Faculty> facultyList = new List<Faculty>();
        public University(string inputUniName)
        {
            UniName = inputUniName;
        }
        public void AddDept(string deptName)
        {
            deptList.Add(new Department(deptName));
        }
        public void AddFacultyMember(Faculty fac)
        {
            facultyList.Add(fac);
        }
        public void DisplayUniversity()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(UniName);
            Console.ResetColor();
            Console.WriteLine("Departments:");
            foreach (Department d in deptList)
            {
                d.ShowDepartment();
            }
            Console.WriteLine("Faculty Members:");
            foreach (Faculty f in facultyList)
            {
                f.ShowFaculty();
            }
        }
    }

    class CompositionaAndAggregation
    {
        public static void Main(string[] args)
        {
            Faculty fac1 = new Faculty("Shail kumar");
            Faculty fac2 = new Faculty("Chirag kumar");
            University uni = new University("GLA University");
            uni.AddDept("Computer Science and Engineering");
            uni.AddDept("Civil Engineering");
            uni.AddFacultyMember(fac1);
            uni.AddFacultyMember(fac2);
            uni.DisplayUniversity();
            Console.WriteLine("University is deleted");
            uni = null;
            fac1.ShowFaculty();
            fac2.ShowFaculty();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.lkfdghkjf
{
    class Employee
    {
        public string EmpName;
        public Employee(string inputName)
        {
            EmpName = inputName;
        }
    }

    class Department
    {
        public string DeptName;
        public List<Employee> EmpList;
        public Department(string inputDeptName)
        {
            DeptName = inputDeptName;
            EmpList = new List<Employee>();
        }
        public void AddEmp(string empName)
        {
            EmpList.Add(new Employee(empName));
        }
    }

    class Company
    {
        public string CompName;
        public List<Department> DeptList;
        public Company(string inputCompName)
        {
            CompName = inputCompName;
            DeptList = new List<Department>();
        }
        public void AddDept(Department dept)
        {
            DeptList.Add(dept);
        }
        public void DisplayCompanyDetails()
        {
            Console.WriteLine("Company: " + CompName);
            foreach (Department d in DeptList)
            {
                Console.WriteLine("Department: " + d.DeptName);
                foreach (Employee e in d.EmpList)
                {
                    Console.WriteLine("Employee: " + e.EmpName);
                }
            }
        }
    }

    class Composition
    {
        public static void Main(string[] args)
        {
            Company comp = new Company("BridgeLabz");
            Department itDept = new Department("IT");
            Department hrDept = new Department("HR");
            itDept.AddEmp("Gavnedra");
            itDept.AddEmp("Luv");
            hrDept.AddEmp("Raja");
            hrDept.AddEmp("Love");
            comp.AddDept(itDept);
            comp.AddDept(hrDept);
            comp.DisplayCompanyDetails();
        }
    }
}

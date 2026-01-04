using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Seiled_class
{
    public class Employee
    {
        public static string CompanyName = "BridgeLabz ";
        private static int totalEmployees = 0;

        public readonly int id;
        public string name;
        public string designation;

        public Employee(string Name, int Id, string Designation)
        {
            this.name = Name;
            this.id = Id;
            this.designation = Designation;
            totalEmployees++;
        }

        public static void TotalEmployees()
        {
            Console.WriteLine("Total Employees: " + totalEmployees);
        }

        //      Method to display employee details
        public void EmployeeDetails(object emp)
        {
            if (emp is Employee)
            {
                Console.WriteLine("Company name " + CompanyName);
                Console.WriteLine("Employee name " + name);
                Console.WriteLine("Employee id " + id);
                Console.WriteLine("Designation " + designation);
            }
            else Console.WriteLine("Invalid employee ");
            
        }
    }

    //  Main class
    class EmployeeManagement
    {
        //main method 
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("Gavendra", 1, "Software Developer");
            Employee emp2 = new Employee("Geet", 2, "QA Engineer");
            emp1.EmployeeDetails(emp1);
            Console.WriteLine();
            emp2.EmployeeDetails(emp2);
            Console.WriteLine();
            Employee.TotalEmployees();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.class_and_object
{
    public class Employee
    {
        private int id;
        private string name;
        private double salary;
        public Employee(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        // Method to display employee details

        public void DisplayDetails()
        {
            Console.WriteLine("Details of the employee");
            Console.WriteLine("Name " + this.name);
            Console.WriteLine("Id" + this.id);
            Console.WriteLine("Salary " + this.salary);
            Console.WriteLine();
        }
    }
    // Main class
    public class EmployeeDetails
    {
        // Main Method
        public static void Main(string[] args)
        {
            Employee employee1 = new Employee(1, "Anand", 24000);
            Employee employee2 = new Employee(2, "Shank", 50000);
            employee1.DisplayDetails(); // Display employee 1 details
            employee2.DisplayDetails();//Display employee 2 details
        }
    }
}

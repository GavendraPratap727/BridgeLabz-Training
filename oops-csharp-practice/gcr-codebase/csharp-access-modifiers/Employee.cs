using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Access_modifiers
{
    public class Employee
    {

        string name;

        int id;

        double salary;

        //parameterized constructor
        public Employee(string eName, int eId, double eSalary)
        {

            this.name = eName;
            this.id = eId;
            this.salary = eSalary;
        }
        //method to display employee details
        public void ShowDetails()
        {
            Console.WriteLine("All Employee Details");
            Console.WriteLine("The employee name is " + name);
            Console.WriteLine("Employee id is " + id);
            Console.WriteLine("Employee salary is " + salary);
        }
        //main method
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Rohan", 1234, 20154.256);
            employee1.ShowDetails();
        }


    }
}

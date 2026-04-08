using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Encapsulation.EmployeeManagement
{
    abstract  class Employee:IEmployee,IDepartment
    {
        int empId;
        string empName;
        string department;
        protected double baseSalary;

        public int EmpId { 

            get { return empId; } 
            set { empId = value; }
        }
        public string empNmae {
            get { return empName; }
            set { empName = value; }
        }
        public Employee(int empId, string empName,double baseSalary)
        {
            this.empId = empId;
            this.empName = empName;
            this.baseSalary = baseSalary;
        }
        public abstract double CalculateSalary();
        public void AssignDepartment(string dept) {
            this.department = dept;
        }
        public string GetDepartmentDetails() {
            return department;
        }
        public void DisplayDetails() {
            Console.WriteLine("Employee ID "+empId);
            Console.WriteLine("Employee Name " + empName);
            Console.WriteLine("Department " + department);
            Console.WriteLine("Salary " + CalculateSalary());
        }



    }
}

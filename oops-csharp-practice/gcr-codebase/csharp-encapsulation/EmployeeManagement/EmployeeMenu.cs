using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Encapsulation.EmployeeManagement
{
     class EmployeeMenu
    {
        Employee[] empArr = new Employee[10] ;
        int count = 0;
        public void Menu() {
            while (true)
            {
                Console.WriteLine("PRESS 1 : FOR ADD FULLTIME EMPLOYEE");
                Console.WriteLine("PRESS 2 : FOR ADD PartTIME EMPLOYEE");
                Console.WriteLine("PRESS 3 : TO VIEW EMPLOYEE DETAILS");
                Console.WriteLine("PRESS 4 : EXIT");

                int choice = int.Parse(Console.ReadLine());
                switch (choice) {
                    case 1:
                        AddFullTime();
                        break;
                    case 2:
                        AddPartTime();
                        break;
                    case 3:
                        ShowAllEmployeeDetails();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }

        }
        void AddFullTime() {
            Console.WriteLine("Enter Employee id");
            int id=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee name");
            string name=Console.ReadLine();
            Console.WriteLine("Enter base salary");
            double salary=double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Department");
            string dept=Console.ReadLine();
            Employee e= new FullTimeEmplouee(id, name, salary);
            e.AssignDepartment(dept);
            empArr[count++] = e;
        }
        void AddPartTime() {
            Console.WriteLine("Enter id of employee");
            int id=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter name of employee");
            string name=Console.ReadLine();
            Console.WriteLine("Enter hourly rate");
            double r=double.Parse(Console.ReadLine());
            Console.WriteLine("Enter hour");
            int h= int.Parse(Console.ReadLine());
            Employee e=new PartTimeEmployee(id, name, h, r);
            empArr[count++] = e;

        }
        void ShowAllEmployeeDetails() {
            for (int i = 0; i < count; i++) {
                Console.WriteLine("----------------------------");
                empArr[i].DisplayDetails();
                Console.WriteLine("----------------------------");
            }
        }


    }
}

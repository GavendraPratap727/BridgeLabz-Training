using System;

class EmployeeMenu
{
    IEmployee service = new EmployeeUtilityImpl();

    public void EmployeeChoice()
    {
        while (true)
        {
            Console.WriteLine("\n1. Add Employee");
            Console.WriteLine("2. Check Attendance");
            Console.WriteLine("3. Exit");
            Console.Write("Enter choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                service.AddEmployee();
            }
            else if (choice == 2)
            {
                service.CheckAttendance();
            }
            else if (choice == 3)
            {
                break;
            }
            else
            {
                Console.WriteLine("Wrong choice.");
            }
        }
    }
}

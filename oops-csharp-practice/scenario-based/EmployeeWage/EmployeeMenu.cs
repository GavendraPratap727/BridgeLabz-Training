using System;

class EmployeeMenu
{
    IEmployee service = new EmployeeUtilityImpl();

    public void EmployeeChoice()
    {
        while (true)
        {
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Check Attendance");
            Console.WriteLine("3. Print Daily Wage");
            Console.WriteLine("4. Exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
                service.AddEmployee();
            else if (choice == 2)
                service.CheckAttendance();
            else if (choice == 3)
                service.PrintDailyWage();
            else if (choice == 4)
                break;
            else
                Console.WriteLine("Wrong choice.");
        }
    }
}

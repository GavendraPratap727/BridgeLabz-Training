using System;

class EmployeeMenu
{
    IEmployee service = new EmployeeUtilityImpl();

    public void EmployeeChoice()
    {
        while (true)
        {
            Console.WriteLine("PRESS 1 -: Add Employee");
            Console.WriteLine("PRESS 2 -: Check Attendance");
            Console.WriteLine("PRESS 3 -: Print Daily Wage");
            Console.WriteLine("PRESS 4 -: Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    service.AddEmployee();
                    break;

                case 2:
                    service.CheckAttendance();
                    break;

                case 3:
                    service.PrintDailyWage();
                    break;

                case 4:
                    return;

                default:
                    Console.WriteLine("Wrong choice.");
                    break;
            }
        }
    }
}

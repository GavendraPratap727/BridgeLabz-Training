using System;

class EmployeeUtilityImpl : IEmployee
{
    Employee[] fullEmpArray = new Employee[5];
    Employee[] partEmpArray = new Employee[5];
    int fullCount = 0;
    int partCount = 0;
    Random r = new Random();
    public void AddEmployee()
    {
        Console.Write("Enter Employee Id: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Enter Employee Name: ");
        string name = Console.ReadLine();
        bool isPresent = r.Next(0, 2) == 1;
        bool isFullTime = r.Next(0, 2) == 1;
        if (isFullTime)
        {
            if (fullCount == 5)
            {
                Console.WriteLine("Full time employee limit reached.");
                return;
            }
            fullEmpArray[fullCount] = new Employee();
            fullEmpArray[fullCount].SetEmployee(id, name, isPresent, 8);
            fullCount++;
            Console.WriteLine("Employee added as Full Time.");
        }
        else
        {
            if (partCount == 5)
            {
                Console.WriteLine("Part time employee limit reached.");
                return;
            }

            partEmpArray[partCount] = new Employee();
            partEmpArray[partCount].SetEmployee(id, name, isPresent, 4);
            partCount++;
            Console.WriteLine("Employee added as Part Time.");
        }
    }

    public void CheckAttendance()
    {
        Console.WriteLine("1. Full Time Employee");
        Console.WriteLine("2. Part Time Employee");
        Console.Write("Enter choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());
        if (choice == 1)
        {
            if (fullCount == 0)
            {
                Console.WriteLine("No full time employee added.");
                return;
            }

            for (int i = 0; i < fullCount; i++)
                Console.WriteLine(" Employee Id : " + fullEmpArray[i].empId + " Employee Name : " + fullEmpArray[i].empName + " Attendance : " + (fullEmpArray[i].present ? "Present" : "Absent"));
        }
        else if (choice == 2)
        {
            if (partCount == 0)
            {
                Console.WriteLine("No part time employee added.");
                return;
            }
            for (int i = 0; i < partCount; i++)
                Console.WriteLine(" Employee Id : " + partEmpArray[i].empId + " Employee Name  " + partEmpArray[i].empName + " Attendance  " + (partEmpArray[i].present ? "Present" : "Absent"));
        }
        else
        {
            Console.WriteLine("Wrong choice.");
        }
    }
    public void PrintDailyWage()
    {
        Console.WriteLine("1. Full Time Employee");
        Console.WriteLine("2. Part Time Employee");
        int choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            if (fullCount == 0)
            {
                Console.WriteLine("No full time employee added.");
                return;
            }
            for (int i = 0; i < fullCount; i++)
                Console.WriteLine(" Employee Id : " + fullEmpArray[i].empId + " Employee Name : " + fullEmpArray[i].empName + " Daily Wage : " + fullEmpArray[i].dailyWage);
        }
        else if (choice == 2)
        {
            if (partCount == 0)
            {
                Console.WriteLine("No part time employee added.");
                return;
            }
            for (int i = 0; i < partCount; i++)
                Console.WriteLine(" Employee Id   " + partEmpArray[i].empId + " Employee Name : " + partEmpArray[i].empName + " Daily Wage : " + partEmpArray[i].dailyWage);
        }
        else
        {
            Console.WriteLine("Wrong choice.");
        }
    }
}

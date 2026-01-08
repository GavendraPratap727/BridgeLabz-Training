using System;

class EmployeeUtilityImpl : IEmployee
{
    Employee[] empArray = new Employee[5];
    int count = 0;

    public void AddEmployee()
    {
        if (count == 5)
        {
            Console.WriteLine("Cannot add more employees.");
            return;
        }

        empArray[count] = new Employee();

        Console.Write("Enter Employee Id: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter Employee Name: ");
        string name = Console.ReadLine();

        Random r = new Random();
        int rand = r.Next(0, 2);

        bool status;
        if (rand == 1)
            status = true;
        else
            status = false;

        empArray[count].SetEmployee(id, name, status);
        count++;

        Console.WriteLine("Employee added successfully.");
    }

    public void CheckAttendance()
    {
        if (count == 0)
        {
            Console.WriteLine("No employee added yet.");
            return;
        }

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(empArray[i]);
        }
    }

    public void PrintDailyWage()
    {
        if (count == 0)
        {
            Console.WriteLine("No employee added yet.");
            return;
        }

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("  Employee Id  " + empArray[i].empId + "     -------   Employee Name : " + empArray[i].empName + " --------  Daily Wage : " + empArray[i].dailyWage);


        }
    }
}

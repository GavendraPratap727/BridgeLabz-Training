using System;

class Employee
{
    public int empId;
    public string empName;
    public bool present;
    public int dailyWage;
    public int monthlyWage;

    public void SetEmployee(int id, string name, bool status, int hours)
    {
        empId = id;
        empName = name;
        present = status;

        if (present)
            dailyWage = hours * 20;
        else
            dailyWage = 0;
    }

    public void CalculateMonthlyWage(int hours)
    {
        monthlyWage = 0;
        Random r = new Random();
        int workingDays = 20;

        for (int day = 1; day <= workingDays; day++)
        {
            bool isPresent = r.Next(0, 2) == 1;

            if (isPresent)
                monthlyWage = monthlyWage + (hours * 20);
            else
                monthlyWage = monthlyWage + 0;
        }
    }

    public override string ToString()
    {
        return present ? " Employee Id : " + empId + " Employee Name : " + empName + " Attendance : Present Daily Wage : " + dailyWage
                       : " Employee Id : " + empId + " Employee Name : " + empName + " Attendance : Absent Daily Wage : " + dailyWage;
    }
}

using System;

class Employee
{
    public int empId;
    public string empName;
    bool present;
    public int dailyWage;

    public void SetEmployee(int id, string name, bool status)
    {
        empId = id;
        empName = name;
        present = status;

        if (present)
            dailyWage = 8 * 20;
        else
            dailyWage = 0;
    }

    public override string ToString()
    {
        return present ? " Employee Id : " + empId + " Employee Name : " + empName + " Attendance : Present   Daily Wage : " + dailyWage
                       : " Employee Id : " + empId + " Employee Name : " + empName + " Attendance : Absent     Daily Wage : " + dailyWage;
    }
}

using System;

class Employee
{
    int empId;
    string empName;
    bool present;

    public void SetEmployee(int id, string name, bool status)
    {
        empId = id;
        empName = name;
        present = status;
    }

    public override string ToString()
    {
        return present ? "  Employee Id : " + empId + "  Employee Name : " + empName + " Attendance  Present " : "  Employee Id : " + empId + "   Employee Name : " + empName + "  Attendance : Absent";







    }
}


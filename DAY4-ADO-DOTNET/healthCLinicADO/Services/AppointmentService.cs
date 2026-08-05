using Microsoft.Data.SqlClient;
using System.Data;
using HealthClinicApp.Entities;

namespace HealthClinicApp.Services;

public class AppointmentService
{
    private string connectionString = @"Server=localhost\SQLEXPRESS;Database=HealthClinic;Trusted_Connection=True;TrustServerCertificate=True;";

    // Insert Appointment
    public void InsertAppointment()
    {
        Appointment appointment = new Appointment();

        Console.Write("Enter Doctor ID : ");
        appointment.DoctorID = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Patient ID : ");
        appointment.PatientID = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Appointment Date (yyyy-MM-dd) : ");
        appointment.AppointmentDate = Convert.ToDateTime(Console.ReadLine());

        Console.Write("Enter Status : ");
        appointment.Status = Console.ReadLine()!;

        Console.Write("Enter Reason : ");
        appointment.Reason = Console.ReadLine()!;

        SqlConnection con = new SqlConnection(connectionString);

        SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Appointment", con);

        SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

        DataTable table = new DataTable();

        adapter.Fill(table);

        DataRow row = table.NewRow();

        row["DoctorID"] = appointment.DoctorID;
        row["PatientID"] = appointment.PatientID;
        row["AppointmentDate"] = appointment.AppointmentDate;
        row["Status"] = appointment.Status;
        row["Reason"] = appointment.Reason;

        table.Rows.Add(row);

        adapter.Update(table);

        Console.WriteLine("Appointment Inserted Successfully.");
    }

    // Update Appointment
    public void UpdateAppointment()
    {
        Console.Write("Enter Appointment ID : ");
        int appointmentId = Convert.ToInt32(Console.ReadLine());

        SqlConnection con = new SqlConnection(connectionString);

        SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Appointment", con);

        SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

        DataTable table = new DataTable();

        adapter.Fill(table);

        bool found = false;

        foreach (DataRow row in table.Rows)
        {
            if ((int)row["AppointmentID"] == appointmentId)
            {
                Console.Write("Enter New Doctor ID : ");
                row["DoctorID"] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter New Patient ID : ");
                row["PatientID"] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter New Appointment Date (yyyy-MM-dd) : ");
                row["AppointmentDate"] = Convert.ToDateTime(Console.ReadLine());

                Console.Write("Enter New Status : ");
                row["Status"] = Console.ReadLine()!;

                Console.Write("Enter New Reason : ");
                row["Reason"] = Console.ReadLine()!;

                found = true;
                break;
            }
        }

        if (found)
        {
            adapter.Update(table);
            Console.WriteLine("Appointment Updated Successfully.");
        }
        else
        {
            Console.WriteLine("Appointment Not Found.");
        }
    }

    // Delete Appointment
    public void DeleteAppointment()
    {
        Console.Write("Enter Appointment ID : ");
        int appointmentId = Convert.ToInt32(Console.ReadLine());

        SqlConnection con = new SqlConnection(connectionString);

        SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Appointment", con);

        SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

        DataTable table = new DataTable();

        adapter.Fill(table);

        bool found = false;

        foreach (DataRow row in table.Rows)
        {
            if ((int)row["AppointmentID"] == appointmentId)
            {
                row.Delete();
                found = true;
                break;
            }
        }

        if (found)
        {
            adapter.Update(table);
            Console.WriteLine("Appointment Deleted Successfully.");
        }
        else
        {
            Console.WriteLine("Appointment Not Found.");
        }
    }

    // Display Appointment
    public void DisplayAppointments()
    {
        SqlConnection con = new SqlConnection(connectionString);

        SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Appointment", con);

        DataTable table = new DataTable();

        adapter.Fill(table);

        foreach (DataRow row in table.Rows)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Appointment ID : " + row["AppointmentID"]);
            Console.WriteLine("Doctor ID      : " + row["DoctorID"]);
            Console.WriteLine("Patient ID     : " + row["PatientID"]);
            Console.WriteLine("Date           : " + row["AppointmentDate"]);
            Console.WriteLine("Status         : " + row["Status"]);
            Console.WriteLine("Reason         : " + row["Reason"]);
        }
    }
}
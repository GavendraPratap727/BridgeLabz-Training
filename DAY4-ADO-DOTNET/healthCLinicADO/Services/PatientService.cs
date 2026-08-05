using Microsoft.Data.SqlClient;
using System.Data;
using HealthClinicApp.Entities;

namespace HealthClinicApp.Services;

public class PatientService
{
    private string connectionString = @"Server=localhost\SQLEXPRESS;Database=HealthClinic;Trusted_Connection=True;TrustServerCertificate=True;";

    // Insert Patient
    public void InsertPatient()
    {
        Patient patient = new Patient();

        Console.Write("Enter Patient Name : ");
        patient.Name = Console.ReadLine()!;

        Console.Write("Enter DOB (yyyy-mm-dd) : ");
        patient.DOB = Convert.ToDateTime(Console.ReadLine());

        Console.Write("Enter Gender (M/F/O) : ");
        patient.Gender = Console.ReadLine()!;

        Console.Write("Enter Phone : ");
        patient.Phone = Console.ReadLine()!;

        Console.Write("Enter Description : ");
        patient.PDescription = Console.ReadLine()!;

        Console.Write("Enter Address : ");
        patient.Address = Console.ReadLine()!;

        Console.Write("Enter Doctor ID : ");
        patient.DoctorID = Convert.ToInt32(Console.ReadLine());

        SqlConnection con = new SqlConnection(connectionString);
        con.Open();

        SqlCommand cmd = new SqlCommand("sp_InsertPatient", con);
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@Name", patient.Name);
        cmd.Parameters.AddWithValue("@DOB", patient.DOB);
        cmd.Parameters.AddWithValue("@Gender", patient.Gender);
        cmd.Parameters.AddWithValue("@Phone", patient.Phone);
        cmd.Parameters.AddWithValue("@PDescription", patient.PDescription);
        cmd.Parameters.AddWithValue("@Address", patient.Address);
        cmd.Parameters.AddWithValue("@DoctorID", patient.DoctorID);

        int rows = cmd.ExecuteNonQuery();

        Console.WriteLine($"{rows} Patient Inserted Successfully.");

        con.Close();
    }

    // Update Patient
    public void UpdatePatient()
    {
        Patient patient = new Patient();

        Console.Write("Enter Patient ID : ");
        patient.PatientID = Convert.ToInt32(Console.ReadLine());

        if (!PatientExists(patient.PatientID))
        {
            Console.WriteLine("Patient Not Found.");
            return;
        }

        Console.Write("Enter New Name : ");
        patient.Name = Console.ReadLine()!;

        Console.Write("Enter DOB (yyyy-mm-dd) : ");
        patient.DOB = Convert.ToDateTime(Console.ReadLine());

        Console.Write("Enter Gender (M/F/O) : ");
        patient.Gender = Console.ReadLine()!;

        Console.Write("Enter Phone : ");
        patient.Phone = Console.ReadLine()!;

        Console.Write("Enter Description : ");
        patient.PDescription = Console.ReadLine()!;

        Console.Write("Enter Address : ");
        patient.Address = Console.ReadLine()!;

        Console.Write("Enter Doctor ID : ");
        patient.DoctorID = Convert.ToInt32(Console.ReadLine());

        SqlConnection con = new SqlConnection(connectionString);
        con.Open();

        SqlCommand cmd = new SqlCommand("sp_UpdatePatient", con);
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@PatientID", patient.PatientID);
        cmd.Parameters.AddWithValue("@Name", patient.Name);
        cmd.Parameters.AddWithValue("@DOB", patient.DOB);
        cmd.Parameters.AddWithValue("@Gender", patient.Gender);
        cmd.Parameters.AddWithValue("@Phone", patient.Phone);
        cmd.Parameters.AddWithValue("@PDescription", patient.PDescription);
        cmd.Parameters.AddWithValue("@Address", patient.Address);
        cmd.Parameters.AddWithValue("@DoctorID", patient.DoctorID);

        int rows = cmd.ExecuteNonQuery();

        Console.WriteLine($"{rows} Patient Updated Successfully.");

        con.Close();
    }

    // Delete Patient
    public void DeletePatient()
    {
        Console.Write("Enter Patient ID : ");
        int patientId = Convert.ToInt32(Console.ReadLine());

        if (!PatientExists(patientId))
        {
            Console.WriteLine("Patient Not Found.");
            return;
        }

        SqlConnection con = new SqlConnection(connectionString);
        con.Open();

        SqlCommand cmd = new SqlCommand("sp_DeletePatient", con);
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@PatientID", patientId);

        int rows = cmd.ExecuteNonQuery();

        Console.WriteLine($"{rows} Patient Deleted Successfully.");

        con.Close();
    }

    // Check Patient Exists
    private bool PatientExists(int patientId)
    {
        SqlConnection con = new SqlConnection(connectionString);
        con.Open();
        string query = "SELECT COUNT(*) FROM Patient WHERE PatientID=@PatientID";
        SqlCommand cmd = new SqlCommand(query, con);
        cmd.Parameters.AddWithValue("@PatientID", patientId);
        int count = (int)cmd.ExecuteScalar();
        con.Close();
        return count > 0;
    }
}
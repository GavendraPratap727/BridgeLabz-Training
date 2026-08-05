using Microsoft.Data.SqlClient;
namespace HealthClinicApp.Services;
using HealthClinicApp.Entities;

public class DoctorService
{
    
private string connectionString = @"Server=localhost\SQLEXPRESS;Database=HealthClinic;Trusted_Connection=True;TrustServerCertificate=True;";

//insert doctor

 public void InsertDoctor()
    {
        Doctor doctor = new Doctor();

        Console.Write("Enter Doctor Name : ");
        doctor.Name = Console.ReadLine()!;

        Console.Write("Enter Expertise : ");
        doctor.Expertise = Console.ReadLine()!;

        Console.Write("Enter Phone : ");
        doctor.Phone = Console.ReadLine()!;

        Console.Write("Enter Room ID : ");
        doctor.RoomID = Convert.ToInt32(Console.ReadLine());

        SqlConnection con = new SqlConnection(connectionString);

        con.Open();

        string query = @"INSERT INTO Doctor (Name,Expertise,Phone,RoomID)
                        VALUES
                        (@Name,@Expertise,@Phone,@RoomID)";

        SqlCommand cmd = new SqlCommand(query, con);

        cmd.Parameters.AddWithValue("@Name", doctor.Name);
        cmd.Parameters.AddWithValue("@Expertise", doctor.Expertise);
        cmd.Parameters.AddWithValue("@Phone", doctor.Phone);
        cmd.Parameters.AddWithValue("@RoomID", doctor.RoomID);

        int rows = cmd.ExecuteNonQuery();

        Console.WriteLine($"{rows} Doctor Inserted Successfully.");

        con.Close();
    }


//update doctor



  public void UpdateDoctor()
    {
        Doctor doctor = new Doctor();

        Console.Write("Enter Doctor ID : ");
        doctor.DoctorID = Convert.ToInt32(Console.ReadLine());

        if (!DoctorExists(doctor.DoctorID))
        {
            Console.WriteLine("Doctor Not Found.");
            return;
        }

        Console.Write("Enter New Name : ");
        doctor.Name = Console.ReadLine()!;

        Console.Write("Enter New Expertise : ");
        doctor.Expertise = Console.ReadLine()!;

        Console.Write("Enter New Phone : ");
        doctor.Phone = Console.ReadLine()!;
        SqlConnection con = new SqlConnection(connectionString);
        con.Open();
        string query = @"UPDATE Doctor
                         SET Name=@Name,
                             Expertise=@Expertise,
                             Phone=@Phone
                         WHERE DoctorID=@DoctorID";
        SqlCommand cmd = new SqlCommand(query, con);
        cmd.Parameters.AddWithValue("@Name", doctor.Name);
        cmd.Parameters.AddWithValue("@Expertise", doctor.Expertise);
        cmd.Parameters.AddWithValue("@Phone", doctor.Phone);
        cmd.Parameters.AddWithValue("@DoctorID", doctor.DoctorID);

        int rows = cmd.ExecuteNonQuery();

        Console.WriteLine($"{rows} Doctor Updated Successfully.");

        con.Close();
    }

    public void DeleteDoctor()
    {
        Doctor doctor = new Doctor();

        Console.Write("Enter Doctor ID : ");
        doctor.DoctorID = Convert.ToInt32(Console.ReadLine());

        if (!DoctorExists(doctor.DoctorID))
        {
            Console.WriteLine("Doctor Not Found.");
            return;
        }

        SqlConnection con = new SqlConnection(connectionString);

        con.Open();

        string query = "DELETE FROM Doctor WHERE DoctorID=@DoctorID";

        SqlCommand cmd = new SqlCommand(query, con);

        cmd.Parameters.AddWithValue("@DoctorID", doctor.DoctorID);

        int rows = cmd.ExecuteNonQuery();

        Console.WriteLine($"{rows} Doctor Deleted Successfully.");

        con.Close();
    }







//to check weather the dr is exist or not
private bool DoctorExists(int doctorId)
    {
        SqlConnection con = new SqlConnection(connectionString);

        con.Open();

        string query = "SELECT COUNT(*) FROM Doctor WHERE DoctorID=@DoctorID";

        SqlCommand cmd = new SqlCommand(query, con);

        cmd.Parameters.AddWithValue("@DoctorID", doctorId);

        int count = (int)cmd.ExecuteScalar();

        con.Close();

        return count > 0;
    }
}
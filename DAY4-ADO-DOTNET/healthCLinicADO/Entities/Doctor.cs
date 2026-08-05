namespace HealthClinicApp.Entities;

public class Doctor
{
    public int DoctorID { get; set; }
    public string Name { get; set; } = "";
    public string Expertise { get; set; } = "";
    public string Phone { get; set; } = "";
    public int? RoomID { get; set; }
}
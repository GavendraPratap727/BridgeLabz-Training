namespace HealthClinicApp.Entities;

public class Patient
{
    public int PatientID { get; set; }
    public string Name { get; set; } = "";
    public DateTime DOB { get; set; }
    public string Gender { get; set; } = "";
    public string Phone { get; set; } = "";
    public string PDescription { get; set; } = "";
    public string Address { get; set; } = "";
    public int DoctorID { get; set; }
}
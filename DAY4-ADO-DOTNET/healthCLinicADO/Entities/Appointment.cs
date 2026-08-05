namespace HealthClinicApp.Entities;

public class Appointment
{
    public int AppointmentID { get; set; }
    public int DoctorID { get; set; }
    public int PatientID { get; set; }
    public DateTime AppointmentDate { get; set; }
    public string Status { get; set; } = "";
    public string Reason { get; set; } = "";
}
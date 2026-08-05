using HealthClinicApp.Services;

namespace HealthClinicApp.Menu;

public class Menu
{
    DoctorService doctorService = new DoctorService();
    PatientService patientService = new PatientService();
    AppointmentService appointmentService = new AppointmentService();

    public void ShowMenu()
    {
        while (true)
        {
            Console.WriteLine("\n========== Health Clinic Management ==========");
            Console.WriteLine("1. Insert Doctor");
            Console.WriteLine("2. Update Doctor");
            Console.WriteLine("3. Delete Doctor");
            Console.WriteLine("4. Insert Patient");
            Console.WriteLine("5. Update Patient");
            Console.WriteLine("6. Delete Patient");
            Console.WriteLine("7. Insert Appointment");
            Console.WriteLine("8. Update Appointment");
            Console.WriteLine("9. Delete Appointment");
            Console.WriteLine("10. Display Appointments");
            Console.WriteLine("11. Exit");
            Console.Write("Enter Your Choice : ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    doctorService.InsertDoctor();
                    break;

                case 2:
                    doctorService.UpdateDoctor();
                    break;

                case 3:
                    doctorService.DeleteDoctor();
                    break;

                case 4:
                    patientService.InsertPatient();
                    break;

                case 5:
                    patientService.UpdatePatient();
                    break;

                case 6:
                    patientService.DeletePatient();
                    break;

                case 7:
                    appointmentService.InsertAppointment();
                    break;

                case 8:
                    appointmentService.UpdateAppointment();
                    break;

                case 9:
                    appointmentService.DeleteAppointment();
                    break;

                case 10:
                    appointmentService.DisplayAppointments();
                    break;

                case 11:
                    Console.WriteLine("Thank You!");
                    return;

                default:
                    Console.WriteLine("Invalid Choice.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
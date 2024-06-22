using System;
using _3.HospitalManagement;


namespace MainHospitalManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Hospital hospital = new Hospital();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nHospital Management Menu:");
                Console.WriteLine("1. Add Doctor");
                Console.WriteLine("2. View All Doctors");
                Console.WriteLine("3. Schedule Appointment");
                Console.WriteLine("4. View Appointments of Doctor");
                Console.WriteLine("0. Exit");
                Console.Write("Select an option: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter doctor name: ");
                        string doctorName = Console.ReadLine();
                        hospital.AddDoctor(doctorName);
                        break;

                    case "2":
                        hospital.DisplayDoctors();
                        break;

                    case "3":
                        Console.Write("Enter doctor name: ");
                        string appointmentDoctorName = Console.ReadLine();
                        Console.Write("Enter patient name: ");
                        string patientName = Console.ReadLine();
                        Console.Write("Enter appointment date and time (yyyy-mm-dd hh:mm): ");
                        DateTime appointmentDate = DateTime.Parse(Console.ReadLine());
                        hospital.ScheduleAppointment(appointmentDoctorName, patientName, appointmentDate);
                        break;

                    case "4":
                        Console.Write("Enter doctor name: ");
                        string viewAppointmentsDoctorName = Console.ReadLine();
                        hospital.DisplayAppointments(viewAppointmentsDoctorName);
                        break;

                    case "0":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}

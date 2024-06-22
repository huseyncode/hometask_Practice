using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.HospitalManagement
{
    public class Doctor
    {
        private static int NextId = 1;
        public int Id { get; private set; }
        public string Name { get; set; }
        private List<Appointment> Appointments { get; set; } = new List<Appointment>();

        public Doctor()
        {
            Id = NextId++;
        }

        public void ScheduleAppointment(string patientName, DateTime date)
        {
            if (Appointments.Any(a => a.Date == date))
            {
                Console.WriteLine("Appointment slot is already booked.");
                return;
            }
            Appointments.Add(new Appointment { PatientName = patientName, Date = date });
            Console.WriteLine("Appointment scheduled.");
        }

        public void DisplayAppointments()
        {
            foreach (var appointment in Appointments)
            {
                Console.WriteLine($"Patient: {appointment.PatientName}, Date: {appointment.Date}");
            }
        }
    }
}

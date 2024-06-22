using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _3.HospitalManagement
{
    public class Hospital
    {
        private List<Doctor> Doctors { get; set; } = new List<Doctor>();

        public void AddDoctor(string name)
        {
            if (Doctors.Any(d => d.Name == name))
            {
                Console.WriteLine("Doctor with this name already exists.");
                return;
            }
            Doctors.Add(new Doctor { Name = name });
            Console.WriteLine("Doctor added.");
        }

        public void DisplayDoctors()
        {
            foreach (var doctor in Doctors)
            {
                Console.WriteLine($"ID: {doctor.Id}, Name: {doctor.Name}");
            }
        }

        public Doctor GetDoctorByName(string name)
        {
            return Doctors.FirstOrDefault(d => d.Name == name);
        }

        public void ScheduleAppointment(string doctorName, string patientName, DateTime date)
        {
            var doctor = GetDoctorByName(doctorName);
            if (doctor != null)
            {
                doctor.ScheduleAppointment(patientName, date);
            }
            else
            {
                Console.WriteLine("Doctor not found.");
            }
        }

        public void DisplayAppointments(string doctorName)
        {
            var doctor = GetDoctorByName(doctorName);
            if (doctor != null)
            {
                doctor.DisplayAppointments();
            }
            else
            {
                Console.WriteLine("Doctor not found.");
            }
        }
    }
}

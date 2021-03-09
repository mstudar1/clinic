using System;

namespace Clinic.Model
{
    /// <summary>
    /// Class representing an appointment.
    /// </summary>
    public class Appointment
    {
        public int PatientId { get; set; }

        public DateTime DateAndTime { get; set; }

        public int DoctorId { get; set; }

        public string ReasonForVisit { get; set; }
    }
}
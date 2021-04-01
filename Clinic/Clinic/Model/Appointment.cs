using System;

namespace Clinic.Model
{
    /// <summary>
    /// Class representing an appointment.
    /// </summary>
    public class Appointment
    {
        public int PatientId { get; set; }

        public DateTime StartDateTime { get; set; }

        public DateTime EndDateTime { get; set; }

        public int DoctorId { get; set; }

        public string ReasonForVisit { get; set; }
    }
}
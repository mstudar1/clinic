using System;

namespace Clinic.Model
{
    /// <summary>
    /// Class representing an appointment.
    /// </summary>
    public class Appointment
    {
        public int AppointmentId { get; set; }

        public int PatientId { get; set; }

        public DateTime StartDateTime { get; set; }

        public DateTime EndDateTime { get; set; }

        public int DoctorId { get; set; }

        public string ReasonForVisit { get; set; }

        public string PatientLastName { get; set; }

        public string PatientFirstName { get; set; }

        public string DoctorFirstName { get; set; }

        public string DoctorLastName { get; set; }
    }
}
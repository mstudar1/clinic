using Clinic.DAL;
using Clinic.Model;
using System;

namespace Clinic.Controller
{
    /// <summary>
    /// Class serving as a controller for appointments.
    /// </summary>
    public class AppointmentController
    {
        private readonly AppointmentDAL appointmentSource;

        /// <summary>
        /// Constructor for the AppointmentController class.
        /// </summary>
        public AppointmentController()
        {
            this.appointmentSource = new AppointmentDAL();
        }

        /// <summary>
        /// Method that adds the specified Appointment object to the database.
        /// </summary>
        /// <param name="theAppointment">The Appointment object being added to the database.</param>
        public void AddAppointment(Appointment theAppointment)
        {
            if (theAppointment == null)
            {
                throw new ArgumentNullException("theAppointment", "The appointment cannot be null.");
            }

            this.appointmentSource.AddAppointment(theAppointment);
        }

        /// <summary>
        /// Method that returns true if the specified doctor is unavailable at the specified time.
        /// </summary>
        /// <param name="doctorId">The ID of the doctor in question.</param>
        /// <param name="appointmentDateAndTime">The date and time of the appointment in question.</param>
        /// <returns>True if the specified doctor is booked at the specified time, false otherwise.</returns>
        public bool DoctorIsBooked(int doctorId, DateTime appointmentDateAndTime)
        {
            if (doctorId < 0)
            {
                throw new ArgumentException("The doctor's ID cannot be negative.", "doctorId");
            }

            if (appointmentDateAndTime == null)
            {
                throw new ArgumentNullException("appointmentDateAndTime", "The date and time of the appointment cannot be null.");
            }

            return this.appointmentSource.DoctorIsBooked(doctorId, appointmentDateAndTime);
        }
    }
}
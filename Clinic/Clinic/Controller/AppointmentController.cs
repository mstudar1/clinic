using Clinic.DAL;
using Clinic.Model;
using System;
using System.Collections.Generic;

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
        /// <param name="startDateTime">The start date and time of the appointment in question.</param>
        /// <param name="endDateTime">The end date and time of the appointment in question.</param>
        /// <returns>True if the specified doctor is booked at the specified time, false otherwise.</returns>
        public bool DoctorIsBooked(int doctorId, DateTime startDateTime, DateTime endDateTime)
        {
            if (doctorId < 0)
            {
                throw new ArgumentException("The doctor's ID cannot be negative.", "doctorId");
            }
            if (startDateTime == null)
            {
                throw new ArgumentNullException("startDateTime", "The start date and time of the appointment cannot be null.");
            }
            if (startDateTime == null)
            {
                throw new ArgumentNullException("endDateTime", "The end date and time of the appointment cannot be null.");
            }

            return this.appointmentSource.DoctorIsBooked(doctorId, startDateTime, endDateTime);
        }

        /// <summary>
        /// Method that revises a record for an appointment in the database.
        /// Requires that the record has not been changed since it was retrieved.
        /// </summary>
        /// <param name="originalAppointment">The Appointment object that was originally retrieved.</param>
        /// <param name="revisedAppointment">The Appointment object with the revised values.</param>
        /// <returns>True if the operation is successful, false otherwise.</returns>
        public bool EditAppointment(Appointment originalAppointment, Appointment revisedAppointment)
        {
            if (originalAppointment == null)
            {
                throw new ArgumentNullException("originalAppointment", "The original appointment cannot be null.");
            }

            if (revisedAppointment == null)
            {
                throw new ArgumentNullException("revisedAppointment", "The revised appointment cannot be null.");
            }

            return this.appointmentSource.EditAppointment(originalAppointment, revisedAppointment);
        }

        /// <summary>
        /// Method that returns a list of all appointments for the specified patient.
        /// </summary>
        /// <param name="patientId">The ID of the patient being searched for.</param>
        /// <returns>A list of all appointments for the specified patient.</returns>
        public List<Appointment> FindAppointments(int patientId)
        {
            if (patientId < 0)
            {
                throw new ArgumentException("The patient ID cannot be negative.", "patientId");
            }

            return this.appointmentSource.FindAppointments(patientId);
        }

        /// <summary>
        /// Gets a list of appointments that have been made for the specified date
        /// </summary>
        /// <param name="date">the date for the appointments</param>
        /// <returns>List of Appointment objects</returns>
        public List<Appointment> GetAppointmentsOnDate(DateTime date)
        {
            if (date == null)
            {
                throw new ArgumentNullException("date", "The date cannot be null.");
            }
            return this.appointmentSource.GetAppointmentsOnDate(date);
        }

        public List<Appointment> GetAppointmentsForDoctorOnDate(int doctorId, DateTime date)
        {
            if (date == null)
            {
                throw new ArgumentNullException("date", "The date cannot be null.");
            }
            return this.appointmentSource.GetAppointmentsForDoctorOnDate(doctorId, date);
        }
    }
}
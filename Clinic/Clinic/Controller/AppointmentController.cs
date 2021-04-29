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
        private readonly VisitDAL visitSource;

        /// <summary>
        /// Constructor for the AppointmentController class.
        /// </summary>
        public AppointmentController()
        {
            this.appointmentSource = new AppointmentDAL();
            this.visitSource = new VisitDAL();
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
        /// <returns>True if the specified doctor is booked at the specified time, false otherwise.</returns>
        public bool DoctorIsBooked(int doctorId, DateTime startDateTime)
        {
            return this.appointmentSource.DoctorIsBooked(doctorId, startDateTime);
        }

        /// <summary>
        /// Method that returns true if the specified doctor is unavailable at the specified time.  This method
        /// includes a check to prevent a false positive for an appointment overlapping itself when being edited.
        /// This also assumes that appointment time structure is such that start time is sufficient to check for appointment
        /// overlaps (i.e. all appointments are 30 minutes long and start on hour or half hour).
        /// </summary>
        /// <param name="originalAppointment">original appointment object</param>
        /// <param name="revisedAppointment">revised appointment object</param>
        /// <returns>true if a conflict exists</returns>
        public bool DoctorIsBookedForAppointmentEdit(Appointment originalAppointment, Appointment revisedAppointment)
        {
            return this.appointmentSource.DoctorIsBookedForAppointmentEdit(originalAppointment, revisedAppointment);
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
            return this.appointmentSource.GetAppointmentsOnDate(date);
        }

        /// <summary>
        /// Get list of Appointment objects for a given doctor on a given date
        /// </summary>
        /// <param name="doctorId">the doctorId</param>
        /// <param name="date">the desired date</param>
        /// <returns>List of Appointment objects</returns>
        public List<Appointment> GetAppointmentsForDoctorOnDate(int doctorId, DateTime date)
        {
            return this.appointmentSource.GetAppointmentsForDoctorOnDate(doctorId, date);
        }

        /// <summary>
        /// Get list of Appointment objects that match the desired last name and date of birth
        /// </summary>
        /// <param name="lastName">the last name to search for</param>
        /// <param name="dob">the date of birth to search for</param>
        /// <returns>List of Appointment objects/returns>
        public List<Appointment> GetAppointmentsForPatientLastNameAndDOB(String lastName, DateTime dob)
        {
            return this.appointmentSource.GetAppointmentsForPatientLastNameAndDOB(lastName, dob);
        }

        /// <summary>
        /// Retrieves an Appointment object matching the appoitnmentId
        /// </summary>
        /// <param name="appointmentId">The Id of the appointment</param>
        /// <returns>Appointment object matching the id</returns>
        public Appointment GetAppointment(int appointmentId)
        {
            return this.appointmentSource.GetAppointment(appointmentId);
        }

        /// <summary>
        /// Method that deletes the specified appointment from the database.
        /// </summary>
        /// <param name="appointmentId">The ID of the appointment being deleted from the database.</param>
        public void DeleteAppointment(int appointmentId)
        {
            if (appointmentId < 0)
            {
                throw new ArgumentException("The appointment ID cannot be negative.", "appointmentId");
            }

            if (this.visitSource.IsVisitPresent(appointmentId))
            {
                throw new ArgumentException("The specified appointment already has a visit associated with it; therefore, it cannot be deleted.", "appointmentId");
            }

            //this.appointmentSource.DeleteAppointment(appointmentId);
        }
    }
}
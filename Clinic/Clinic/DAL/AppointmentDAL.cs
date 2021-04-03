using Clinic.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Clinic.DAL
{
    /// <summary>
    /// Class for accessing appointment information in the Clinic database.
    /// </summary>
    public class AppointmentDAL
    {
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

            string insertStatement =
                "INSERT Appointment (patientId, startDateTime, endDateTime, doctorId, reasonForVisit) " +
                "VALUES (@PatientId, @StartDateTime, @EndDateTime, @DoctorId, @ReasonForVisit)";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@PatientId", theAppointment.PatientId);
                    insertCommand.Parameters.AddWithValue("@StartDateTime", theAppointment.StartDateTime);
                    insertCommand.Parameters.AddWithValue("@EndDateTime", theAppointment.EndDateTime);
                    insertCommand.Parameters.AddWithValue("@DoctorId", theAppointment.DoctorId);
                    insertCommand.Parameters.AddWithValue("@ReasonForVisit", theAppointment.ReasonForVisit);
                    insertCommand.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Method that returns true if the specified doctor is unavailable at the specified time.
        /// </summary>
        /// <param name="doctorId">The ID of the doctor in question.</param>
        /// <param name="appointmentDateAndTime">The date and time of the appointment in question.</param>
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
            if (endDateTime == null)
            {
                throw new ArgumentNullException("endDateTime", "The end date and time of the appointment cannot be null.");
            }
            if (DateTime.Compare(startDateTime, endDateTime) >= 0)
            {
                throw new ArgumentException("endDateTime", "The end date and time of appointment must be after the start date and time");
            }

            string selectStatement =
                "SELECT @NumberOfAppointments = COUNT(appointmentId) " +
                "FROM Appointment " +
                "WHERE doctorId = @DoctorId " +
                "AND " +
                "((startDateTime <= @StartDateTime AND endDateTime > @StartDateTime) " +
                "OR " +
                "(startDateTime < @EndDateTime AND endDateTime >= @EndDateTime))";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    SqlParameter countParameter = new SqlParameter("@NumberOfAppointments", SqlDbType.Int, 1)
                    {
                        Direction = ParameterDirection.Output
                    };
                    selectCommand.Parameters.Add(countParameter);
                    selectCommand.Parameters.AddWithValue("@DoctorId", doctorId);
                    selectCommand.Parameters.AddWithValue("@StartDateTime", startDateTime);
                    selectCommand.Parameters.AddWithValue("@EndDateTime", endDateTime);
                    selectCommand.ExecuteNonQuery();
                    if (Convert.ToInt32(countParameter.Value) == 0)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
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

            string updateStatement =
                "UPDATE Appointment SET " +
                    "patientId = @RevisedPatientId, " +
                    "startDateTime = @RevisedStartDateTime, " +
                    "endDateTime = @RevisedEndDateTime, " +
                    "doctorId = @RevisedDoctorId, " +
                    "reasonForVisit = @RevisedReasonForVisit " +
                "WHERE patientId = @OriginalPatientId " +
                    "AND startDateTime = @OriginalStartDatetime " +
                    "AND endDateTime = @OriginalEndDateTime " +
                    "AND doctorId = @OriginalDoctorId " +
                    "AND reasonForVisit = @OriginalReasonForVisit";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                {
                    updateCommand.Parameters.AddWithValue("@OriginalPatientId", originalAppointment.PatientId);
                    updateCommand.Parameters.AddWithValue("@OriginalStartDateTime", originalAppointment.StartDateTime);
                    updateCommand.Parameters.AddWithValue("@OriginalEndDateTime", originalAppointment.EndDateTime);
                    updateCommand.Parameters.AddWithValue("@OriginalDoctorId", originalAppointment.DoctorId);
                    updateCommand.Parameters.AddWithValue("@OriginalReasonForVisit", originalAppointment.ReasonForVisit);
                    updateCommand.Parameters.AddWithValue("@RevisedPatientId", revisedAppointment.PatientId);
                    updateCommand.Parameters.AddWithValue("@RevisedStartDatetime", revisedAppointment.StartDateTime);
                    updateCommand.Parameters.AddWithValue("@RevisedEndDateTime", revisedAppointment.EndDateTime);
                    updateCommand.Parameters.AddWithValue("@RevisedDoctorId", revisedAppointment.DoctorId);
                    updateCommand.Parameters.AddWithValue("@RevisedReasonForVisit", revisedAppointment.ReasonForVisit);

                    int count = updateCommand.ExecuteNonQuery();
                    if (count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
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

            List<Appointment> appointmentList = new List<Appointment>();

            string selectStatement =
                "SELECT startDateTime, endDateTime, doctorId, reasonForVisit " +
                "FROM Appointment " +
                "WHERE patientId = @PatientId " +
                "ORDER BY dateAndTime ASC";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@PatientId", patientId);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        int startDateTimeOrdinal = reader.GetOrdinal("startDateTime");
                        int endDateTimeOrdinal = reader.GetOrdinal("endDateTime");
                        int doctorIdOrdinal = reader.GetOrdinal("doctorId");
                        int reasonForVisitOrdinal = reader.GetOrdinal("reasonForVisit");
                        while (reader.Read())
                        {
                            Appointment theAppointment = new Appointment { PatientId = patientId };
                            if (!reader.IsDBNull(startDateTimeOrdinal)) { theAppointment.StartDateTime = reader.GetDateTime(startDateTimeOrdinal); }
                            if (!reader.IsDBNull(endDateTimeOrdinal)) { theAppointment.EndDateTime = reader.GetDateTime(endDateTimeOrdinal); }
                            if (!reader.IsDBNull(doctorIdOrdinal)) { theAppointment.DoctorId = reader.GetInt32(doctorIdOrdinal); }
                            if (!reader.IsDBNull(reasonForVisitOrdinal)) { theAppointment.ReasonForVisit = reader.GetString(reasonForVisitOrdinal); }
                            appointmentList.Add(theAppointment);
                        }
                    }
                }
            }
            return appointmentList;
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
            List<Appointment> appointmentList = new List<Appointment>();

            string selectStatement =
                "SELECT startDateTime, endDateTime, a.doctorId, reasonForVisit, a.patientId, per.firstName, per.lastName " +
                "FROM Appointment a " +
                "LEFT JOIN Doctor d ON a.doctorId = d.doctorId " +
                "LEFT JOIN Patient pat ON a.patientId = pat.patientId " +
                "LEFT JOIN Person per ON d.personId = per.personId " +
                "LEFT JOIN Person ON pat.personId = per.personId " +
                "WHERE datediff(day, startDateTime, @searchDate) = 0  " +
                "ORDER BY startDateTime ASC";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@searchDate", date);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        int startDateTimeOrdinal = reader.GetOrdinal("startDateTime");
                        int endDateTimeOrdinal = reader.GetOrdinal("endDateTime");
                        int doctorIdOrdinal = reader.GetOrdinal("doctorId");
                        int doctorfirstNameOrdinal = reader.GetOrdinal("firstName");
                        int doctorlastNameOrdinal = reader.GetOrdinal("lastName");
                        int reasonForVisitOrdinal = reader.GetOrdinal("reasonForVisit");
                        int patientIdOrdinal = reader.GetOrdinal("patientId");
                        //int patientfirstNameOrdinal = reader.GetOrdinal("firstName");
                        //int patientlastNameOrdinal = reader.GetOrdinal("lastName");
                        while (reader.Read())
                        {
                            Appointment theAppointment = new Appointment();
                            if (!reader.IsDBNull(startDateTimeOrdinal)) { theAppointment.StartDateTime = reader.GetDateTime(startDateTimeOrdinal); }
                            if (!reader.IsDBNull(endDateTimeOrdinal)) { theAppointment.EndDateTime = reader.GetDateTime(endDateTimeOrdinal); }
                            if (!reader.IsDBNull(doctorIdOrdinal)) { theAppointment.DoctorId = reader.GetInt32(doctorIdOrdinal); }
                            if (!reader.IsDBNull(doctorfirstNameOrdinal)) { theAppointment.DoctorFirstName = reader.GetString(doctorfirstNameOrdinal); }
                            if (!reader.IsDBNull(doctorlastNameOrdinal)) { theAppointment.DoctorLastName = reader.GetString(doctorlastNameOrdinal); }
                            if (!reader.IsDBNull(reasonForVisitOrdinal)) { theAppointment.ReasonForVisit = reader.GetString(reasonForVisitOrdinal); }
                            if (!reader.IsDBNull(patientIdOrdinal)) { theAppointment.PatientId = reader.GetInt32(patientIdOrdinal); }
                            //if (!reader.IsDBNull(patientfirstNameOrdinal)) { theAppointment.PatientFirstName = reader.GetString(patientfirstNameOrdinal); }
                            //if (!reader.IsDBNull(patientlastNameOrdinal)) { theAppointment.PatientLastName = reader.GetString(patientlastNameOrdinal); }
                            appointmentList.Add(theAppointment);
                        }
                    }
                }
            }
            return appointmentList;
        }

        /// <summary>
        /// Gets a list of appointments that have been made for the specified date for a specified doctor
        /// </summary>
        /// <param name="date">the date for the appointments</param>
        /// <param name="doctorId">the doctorId for the appointments</param>
        /// <returns>List of Appointment objects</returns>
        public List<Appointment> GetAppointmentsForDoctorOnDate(int doctorId, DateTime date)
        {
            if (date == null)
            {
                throw new ArgumentNullException("date", "The date cannot be null.");
            }
            List<Appointment> appointmentList = new List<Appointment>();

            string selectStatement =
                "SELECT startDateTime, endDateTime, doctorId, reasonForVisit " +
                "FROM Appointment " +
                "WHERE datediff(day, startDateTime, @searchDate) = 0  " +
                "AND doctorId = @doctorId " +
                "ORDER BY startDateTime ASC";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@searchDate", date);
                    selectCommand.Parameters.AddWithValue("@doctorId", doctorId);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        int startDateTimeOrdinal = reader.GetOrdinal("startDateTime");
                        int endDateTimeOrdinal = reader.GetOrdinal("endDateTime");
                        int doctorIdOrdinal = reader.GetOrdinal("doctorId");
                        int reasonForVisitOrdinal = reader.GetOrdinal("reasonForVisit");
                        while (reader.Read())
                        {
                            Appointment theAppointment = new Appointment();
                            if (!reader.IsDBNull(startDateTimeOrdinal)) { theAppointment.StartDateTime = reader.GetDateTime(startDateTimeOrdinal); }
                            if (!reader.IsDBNull(endDateTimeOrdinal)) { theAppointment.EndDateTime = reader.GetDateTime(endDateTimeOrdinal); }
                            if (!reader.IsDBNull(doctorIdOrdinal)) { theAppointment.DoctorId = reader.GetInt32(doctorIdOrdinal); }
                            if (!reader.IsDBNull(reasonForVisitOrdinal)) { theAppointment.ReasonForVisit = reader.GetString(reasonForVisitOrdinal); }
                            appointmentList.Add(theAppointment);
                        }
                    }
                }
            }
            return appointmentList;
        }
    }
}
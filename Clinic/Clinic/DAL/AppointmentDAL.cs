using Clinic.Model;
using System;
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
                "INSERT Appointment (patientId, dateAndTime, doctorId, reasonForVisit) " +
                "VALUES (@PatientId, @DateAndTime, @DoctorId, @ReasonForVisit)";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@PatientId", theAppointment.PatientId);
                    insertCommand.Parameters.AddWithValue("@DateAndTime", theAppointment.DateAndTime);
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

            string selectStatement =
                "SELECT @NumberOfAppointments = COUNT(username) " +
                "FROM Appointment " +
                "WHERE doctorId = @DoctorId " +
                "AND dateAndTime = @AppointmentDateAndTime";

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
                    selectCommand.Parameters.AddWithValue("@AppointmentDateAndTime", appointmentDateAndTime);
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
                    "dateAndTime = @RevisedDateAndTime, " +
                    "doctorId = @RevisedDoctorId, " +
                    "reasonForVisit = @RevisedReasonForVisit " +
                "WHERE patientId = @OriginalPatientId " +
                    "AND dateAndTime = @OriginalDateAndTime " +
                    "AND doctorId = @OriginalDoctorId " +
                    "AND reasonForVisit = @OriginalReasonForVisit";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                {
                    updateCommand.Parameters.AddWithValue("@OriginalPatientId", originalAppointment.PatientId);
                    updateCommand.Parameters.AddWithValue("@OriginalDateAndTime", originalAppointment.DateAndTime);
                    updateCommand.Parameters.AddWithValue("@OriginalDoctorId", originalAppointment.DoctorId);
                    updateCommand.Parameters.AddWithValue("@OriginalReasonForVisit", originalAppointment.ReasonForVisit);
                    updateCommand.Parameters.AddWithValue("@RevisedPatientId", revisedAppointment.PatientId);
                    updateCommand.Parameters.AddWithValue("@RevisedDateAndTime", revisedAppointment.DateAndTime);
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
    }
}
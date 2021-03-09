using Clinic.Model;
using System;
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
    }
}
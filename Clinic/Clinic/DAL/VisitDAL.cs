using Clinic.Model;
using System;
using System.Data.SqlClient;

namespace Clinic.DAL
{
    /// <summary>
    /// Class for accessing visit information in the Clinic database.
    /// </summary>
    public class VisitDAL
    {
        /// <summary>
        /// Method that adds the specified Visit object to the database.
        /// </summary>
        /// <param name="theVisit">The Visit object being added to the database.</param>
        public void AddVisit(Visit theVisit)
        {
            if (theVisit == null)
            {
                throw new ArgumentNullException("theVisit", "The visit cannot be null.");
            }

            string insertStatement =
                "INSERT Visit (appointmentId, weight, systolicBloodPressure, diastolicBloodPressure, bodyTemperature, pulse, symptoms, nurseId) " +
                "VALUES (@AppointmentId, @Weight, @SystolicBloodPressure, @DiastolicBloodPressure, @BodyTemperature, @Pulse, @Symptoms, @NurseId)";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@AppointmentId", theVisit.AppointmentId);
                    insertCommand.Parameters.AddWithValue("@Weight", theVisit.Weight);
                    insertCommand.Parameters.AddWithValue("@SystolicBloodPressure", theVisit.SystolicBloodPressure);
                    insertCommand.Parameters.AddWithValue("@DiastolicBloodPressure", theVisit.DiastolicBloodPressure);
                    insertCommand.Parameters.AddWithValue("@BodyTemperature", theVisit.BodyTemperature);
                    insertCommand.Parameters.AddWithValue("@Pulse", theVisit.Pulse);
                    insertCommand.Parameters.AddWithValue("@Symptoms", theVisit.Symptoms);
                    insertCommand.Parameters.AddWithValue("@NurseId", theVisit.NurseId);
                    insertCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
using Clinic.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Clinic.DAL
{
    /// <summary>
    /// Class for accessing diagnosis information in the Clinic database.
    /// </summary>
    public class DiagnosisDAL
    {
        /// <summary>
        /// Method that can be used to add a diagnosis to the database.
        /// </summary>
        /// <param name="appointmentId">The ID of the appointment.</param>
        /// <param name="diagnosisName">A string describing the diagnosis.</param>
        /// <param name="isFinal">A boolean value indicating if the diagnosis is final.</param>
        public void AddDiagnosis(int appointmentId, string diagnosisName, bool isFinal)
        {
            if (appointmentId < 0)
            {
                throw new ArgumentException("The appointment ID cannot be negative.", "appointmentId");
            }

            if (string.IsNullOrEmpty(diagnosisName))
            {
                throw new ArgumentNullException("diagnosisName", "The diagnosis name cannot be null or empty.");
            }

            string insertStatement =
                "INSERT Diagnosis (appointmentId, diagnosisName, isFinal) " +
                "VALUES (@AppointmentId, @DiagnosisName, @IsFinal)";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@AppointmentId", appointmentId);
                    insertCommand.Parameters.AddWithValue("@DiagnosisName", diagnosisName);
                    insertCommand.Parameters.AddWithValue("@IsFinal", isFinal);
                    insertCommand.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Method that gets all of the diagnoses associated with a specific appointment.
        /// </summary>
        /// <param name="appointmentId">The ID of the appointment.</param>
        /// <returns>A list of diagnoses associated with the appointment.</returns>
        public List<Diagnosis> GetDiagnoses(int appointmentId)
        {
            if (appointmentId < 0)
            {
                throw new ArgumentException("The appointment ID cannot be negative.", "appointmentId");
            }

            List<Diagnosis> diagnoses = new List<Diagnosis>();

            string selectStatement =
                "SELECT appointmentId, diagnosisName, isFinal " +
                "FROM Diagnosis " +
                "WHERE appointmentId = @AppointmentId";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@AppointmentId", appointmentId);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        int appointmentIdOrdinal = reader.GetOrdinal("appointmentId");
                        int diagnosisNameOrdinal = reader.GetOrdinal("diagnosisName");
                        int isFinalOrdinal = reader.GetOrdinal("isFinal");
                        while (reader.Read())
                        {
                            Diagnosis diagnosis = new Diagnosis();
                            if (!reader.IsDBNull(appointmentIdOrdinal)) { diagnosis.AppointmentId = reader.GetInt32(appointmentIdOrdinal); }
                            if (!reader.IsDBNull(diagnosisNameOrdinal)) { diagnosis.DiagnosisName = reader.GetString(diagnosisNameOrdinal); }
                            if (!reader.IsDBNull(isFinalOrdinal)) { diagnosis.IsFinal = reader.GetBoolean(isFinalOrdinal); }
                            diagnoses.Add(diagnosis);
                        }
                    }
                }
            }
            return diagnoses;
        }
    }
}
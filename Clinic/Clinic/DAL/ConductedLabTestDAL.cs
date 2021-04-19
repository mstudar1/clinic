using Clinic.Model;
using System;
using System.Data.SqlClient;

namespace Clinic.DAL
{
    /// <summary>
    /// Class for accessing conducted lab test information in the Clinic database.
    /// </summary>
    public class ConductedLabTestDAL
    {
        /// <summary>
        /// Method that orders lab tests.
        /// </summary>
        /// <param name="appointmentId">The ID of the appointment.</param>
        /// <param name="labTest">An object representing the type of test that is being ordered.</param>
        public void OrderLabTest(int appointmentId, LabTest labTest)
        {
            if (appointmentId < 0)
            {
                throw new ArgumentException("The appointment ID cannot be negative.", "appointmentId");
            }

            if (labTest == null)
            {
                throw new ArgumentNullException("labTest", "The lab test cannot be null.");
            }

            string insertStatement =
                "INSERT ConductedLabTest (appointmentId, testCode) " +
                "VALUES (@AppointmentId, @TestCode)";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@AppointmentId", appointmentId);
                    insertCommand.Parameters.AddWithValue("@TestCode", labTest.TestCode);
                    insertCommand.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Method that adds test results for a lab test that has already been ordered.
        /// </summary>
        /// <param name="appointmentId">The ID of the appointment.</param>
        /// <param name="labTest">An object representing the type of test that is being ordered.</param>
        /// <param name="datePerformed">The date that the test was performed.</param>
        /// <param name="results">A string describing the results of the test.</param>
        /// <param name="isNormal">A bool indicating if the results are normal.</param>
        public void AddLabTestResults(int appointmentId, LabTest labTest, DateTime datePerformed, string results, bool isNormal)
        {
            if (appointmentId < 0)
            {
                throw new ArgumentException("The appointment ID cannot be negative.", "appointmentId");
            }

            if (labTest == null)
            {
                throw new ArgumentNullException("labTest", "The lab test cannot be null.");
            }

            if (datePerformed == null)
            {
                throw new ArgumentNullException("datePerformed", "The date performed cannot be null.");
            }

            if (string.IsNullOrEmpty(results))
            {
                throw new ArgumentNullException("results", "The results cannot be null or empty.");
            }

            string insertStatement =
                "UPDATE ConductedLabTest " +
                "SET datePerformed = @DatePerformed, results = @Results, isNormal = @IsNormal " +
                "WHERE appointmentId = @AppointmentId AND testCode = @TestCode";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@AppointmentId", appointmentId);
                    insertCommand.Parameters.AddWithValue("@TestCode", labTest.TestCode);
                    insertCommand.Parameters.AddWithValue("@DatePerformed", datePerformed);
                    insertCommand.Parameters.AddWithValue("@Results", results);
                    insertCommand.Parameters.AddWithValue("@IsNormal", isNormal);
                    insertCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
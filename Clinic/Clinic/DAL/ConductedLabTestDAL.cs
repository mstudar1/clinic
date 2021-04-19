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
    }
}
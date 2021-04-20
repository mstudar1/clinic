using Clinic.Model;
using System;
using System.Collections.Generic;
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

            string updateStatement =
                "UPDATE ConductedLabTest " +
                "SET datePerformed = @DatePerformed, results = @Results, isNormal = @IsNormal " +
                "WHERE appointmentId = @AppointmentId AND testCode = @TestCode";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand insertCommand = new SqlCommand(updateStatement, connection))
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

        /// <summary>
        /// Method that returns all of the conducted lab tests for the specified appointment.
        /// </summary>
        /// <param name="appointmentId">The ID of the appointment.</param>
        /// <returns>A list of the conducted lab tests for the specified appointment.</returns>
        public List<ConductedLabTest> GetConductedLabTests(int appointmentId)
        {
            if (appointmentId < 0)
            {
                throw new ArgumentException("The appointment ID cannot be negative.", "appointmentId");
            }

            List<ConductedLabTest> conductedLabTests = new List<ConductedLabTest>();

            string selectStatement =
                "SELECT clt.appointmentId, clt.testCode, lt.name, clt.datePerformed, clt.results, clt.isNormal, pers.firstName, pers.lastName " +
                "FROM ConductedLabTest clt " +
                "JOIN LabTest lt ON lt.testCode = clt.testCode " +
                "JOIN Appointment a ON clt.appointmentId = a.appointmentId " +
                "JOIN Patient pat ON a.patientId = pat.patientId " +
                "JOIN Person pers ON pat.personId = pers.personId " +
                "WHERE clt.appointmentId = @AppointmentId";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@AppointmentId", appointmentId);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        int appointmentIdOrdinal = reader.GetOrdinal("appointmentId");
                        int testCodeOrdinal = reader.GetOrdinal("testCode");
                        int testNameOrdinal = reader.GetOrdinal("name");
                        int datePerformedOrdinal = reader.GetOrdinal("datePerformed");
                        int resultsOrdinal = reader.GetOrdinal("results");
                        int isNormalOrdinal = reader.GetOrdinal("isNormal");
                        int firstNameOrdinal = reader.GetOrdinal("firstName");
                        int lastNameOrdinal = reader.GetOrdinal("lastName");
                        while (reader.Read())
                        {
                            LabTest labTest = new LabTest();
                            if (!reader.IsDBNull(testCodeOrdinal)) { labTest.TestCode = reader.GetInt32(testCodeOrdinal); }
                            if (!reader.IsDBNull(testNameOrdinal)) { labTest.Name = reader.GetString(testNameOrdinal); }

                            ConductedLabTest conductedLabTest = new ConductedLabTest
                            {
                                LabTest = labTest
                            };

                            if (!reader.IsDBNull(appointmentIdOrdinal)) { conductedLabTest.AppointmentId = reader.GetInt32(appointmentIdOrdinal); }
                            if (!reader.IsDBNull(datePerformedOrdinal)) { conductedLabTest.DatePerformed = reader.GetDateTime(datePerformedOrdinal); }
                            if (!reader.IsDBNull(resultsOrdinal)) { conductedLabTest.Results = reader.GetString(resultsOrdinal); }
                            if (!reader.IsDBNull(isNormalOrdinal)) { conductedLabTest.IsNormal = reader.GetBoolean(isNormalOrdinal); }
                            if (!reader.IsDBNull(firstNameOrdinal)) { conductedLabTest.FirstName = reader.GetString(firstNameOrdinal); }
                            if (!reader.IsDBNull(lastNameOrdinal)) { conductedLabTest.LastName = reader.GetString(lastNameOrdinal); }
                            conductedLabTests.Add(conductedLabTest);
                        }
                    }
                }
            }
            return conductedLabTests;
        }
    }
}
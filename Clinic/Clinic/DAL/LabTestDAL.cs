using Clinic.Model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Clinic.DAL
{
    /// <summary>
    /// Class for accessing lab test information in the Clinic database.
    /// </summary>
    public class LabTestDAL
    {
        /// <summary>
        /// Method that returns a list of all the LabTest objects in the database.
        /// </summary>
        /// <returns>A list of all the LabTest objects.</returns>
        public List<LabTest> GetAllLabTests()
        {
            List<LabTest> labTests = new List<LabTest>();

            string selectStatement =
                "SELECT testCode, name " +
                "FROM LabTest " +
                "ORDER BY name";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        int testCodeOrdinal = reader.GetOrdinal("testCode");
                        int nameOrdinal = reader.GetOrdinal("name");
                        while (reader.Read())
                        {
                            LabTest labTest = new LabTest();
                            if (!reader.IsDBNull(testCodeOrdinal)) { labTest.TestCode = reader.GetInt32(testCodeOrdinal); }
                            if (!reader.IsDBNull(nameOrdinal)) { labTest.Name = reader.GetString(nameOrdinal); }
                            labTests.Add(labTest);
                        }
                    }
                }
            }
            return labTests;
        }
    }
}
using System.Data.SqlClient;

namespace Clinic.DAL
{
    /// <summary>
    /// Class that can be used to get a SqlConnection object for the Clinic database.
    /// </summary>
    public static class ClinicDBConnection
    {
        /// <summary>
        /// Method that can be used to get a SqlConnection object for the Clinic database.
        /// </summary>
        /// <returns>A SqlConnection object for the Clinic database.</returns>
        public static SqlConnection GetConnection()
        {
            string connectionString =
                "Data Source=localhost;Initial Catalog=Clinic;" +
                "Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
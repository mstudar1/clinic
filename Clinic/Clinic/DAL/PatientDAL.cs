using Clinic.Model;
using System;
using System.Data.SqlClient;

namespace Clinic.DAL
{
    /// <summary>
    /// Class for accessing patient information in the Clinic database.
    /// </summary>
    public class PatientDAL
    {
        private readonly PersonDAL thePersonDAL;

        /// <summary>
        /// Constructor for the PatientDAL class.
        /// </summary>
        public PatientDAL()
        {
            this.thePersonDAL = new PersonDAL();
        }

        /// <summary>
        /// Method that adds the specified Patient object to the Person and Patient tables in the database.
        /// </summary>
        /// <param name="thePatient">The Patient object being added to the database.</param>
        public void AddPatient(Patient thePatient)
        {
            if (thePatient == null)
            {
                throw new ArgumentNullException("thePatient", "The patient cannot be null.");
            }

            int personId = this.thePersonDAL.AddPerson(thePatient);

            string insertStatement =
                "INSERT Patient (personId, patientId) " +
                "VALUES (@PersonId, @PatientId)";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@PersonId", personId);
                    insertCommand.Parameters.AddWithValue("@PatientId", thePatient.PatientId);
                    insertCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
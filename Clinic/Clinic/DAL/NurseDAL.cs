using Clinic.Model;
using System;
using System.Data.SqlClient;

namespace Clinic.DAL
{
    class NurseDAL
    {
        private readonly PersonDAL thePersonDAL;

        /// <summary>
        /// Constructor for the PatientDAL class.
        /// </summary>
        public NurseDAL()
        {
            this.thePersonDAL = new PersonDAL();
        }

        /// <summary>
        /// Method that adds the specified Patient object to the Person and Patient tables in the database.
        /// </summary>
        /// <param name="thePatient">The Patient object being added to the database.</param>
        public void AddPatient(Nurse theNurse)
        {
            if (theNurse == null)
            {
                throw new ArgumentNullException("theNurse", "The nurse cannot be null.");
            }

            if (theNurse.NurseId != default)
            {
                throw new ArgumentException("The Nurse object being passed in cannot have an ID, because one will be assigned by the database.");
            }

            int personId = this.thePersonDAL.AddPerson(theNurse);

            string insertStatement =
                "INSERT Nurse (personId) " +
                "VALUES (@PersonId)";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@PersonId", personId);
                    insertCommand.ExecuteNonQuery();
                }
            }
        }
    }
}

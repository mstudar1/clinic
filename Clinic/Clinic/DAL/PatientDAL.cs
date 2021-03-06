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

        /// <summary>
        /// Method that revises a record for a patient in the database.
        /// Edits the Person and Patient tables.
        /// Requires that the record has not been changed since it was retrieved.
        /// </summary>
        /// <param name="originalPatient">The Patient object that was originally retrieved.</param>
        /// <param name="revisedPatient">A Patient object with the revised values.</param>
        /// <returns>True if the operation is successful, false otherwise.</returns>
        public bool EditPatient(Patient originalPatient, Patient revisedPatient)
        {
            if (originalPatient == null)
            {
                throw new ArgumentNullException("originalPatient", "The original patient cannot be null.");
            }

            if (revisedPatient == null)
            {
                throw new ArgumentNullException("revisedPatient", "The revised patient cannot be null.");
            }

            if (originalPatient.PersonId != revisedPatient.PersonId)
            {
                throw new ArgumentException("The ID must be the same for both Patient objects.");
            }

            this.thePersonDAL.EditPerson(originalPatient, revisedPatient);

            string updateStatement =
                "UPDATE Patient SET " +
                    "patientId = @RevisedPatientId, " +
                "WHERE personId = @PersonId " +
                    "AND patientId = @OriginalPatientId";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                {
                    updateCommand.Parameters.AddWithValue("@PersonId", originalPatient.PersonId);
                    updateCommand.Parameters.AddWithValue("@OriginalPatientId", originalPatient.PatientId);
                    updateCommand.Parameters.AddWithValue("@RevisedPatientId", revisedPatient.PatientId);

                    int count = updateCommand.ExecuteNonQuery();
                    if (count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
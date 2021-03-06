using Clinic.Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Clinic.DAL
{
    /// <summary>
    /// Class for accessing person information in the Clinic database.
    /// </summary>
    public class PersonDAL
    {
        /// <summary>
        /// Method that adds the specified Person object to the database, and returns the ID of the newly created record.
        /// </summary>
        /// <param name="thePerson">The Person object being added to the database.</param>
        /// <returns>The ID of the newly created Person record.</returns>
        public int AddPerson(Person thePerson)
        {
            if (thePerson == null)
            {
                throw new ArgumentNullException("thePerson", "The person cannot be null.");
            }

            string insertStatement =
                "INSERT Person (lastName, firstName, dateOfBirth, ssn, gender, phoneNumber, addressLine1, addressLine2, city, state, zipCode) " +
                "VALUES (@LastName, @FirstName, @DateOfBirth, @SocialSecurityNumber, @Gender, @PhoneNumber, @AddressLine1, @AddressLine2, @City, @State, @ZipCode) " +
                "SET @PersonId = SCOPE_IDENTITY()";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@LastName", thePerson.LastName);
                    insertCommand.Parameters.AddWithValue("@FirstName", thePerson.FirstName);
                    insertCommand.Parameters.AddWithValue("@DateOfBirth", thePerson.DateOfBirth);
                    insertCommand.Parameters.AddWithValue("@SocialSecurityNumber", thePerson.SocialSecurityNumber);
                    insertCommand.Parameters.AddWithValue("@Gender", thePerson.Gender);
                    insertCommand.Parameters.AddWithValue("@PhoneNumber", thePerson.PhoneNumber);
                    insertCommand.Parameters.AddWithValue("@AddressLine1", thePerson.AddressLine1);
                    insertCommand.Parameters.AddWithValue("@AddressLine2", thePerson.AddressLine2);
                    insertCommand.Parameters.AddWithValue("@City", thePerson.City);
                    insertCommand.Parameters.AddWithValue("@State", thePerson.State);
                    insertCommand.Parameters.AddWithValue("@ZipCode", thePerson.ZipCode);
                    insertCommand.Parameters.Add("@PersonId", SqlDbType.Int);
                    insertCommand.Parameters["@PersonId"].Direction = ParameterDirection.Output;
                    insertCommand.ExecuteNonQuery();
                    return Convert.ToInt32(insertCommand.Parameters["@PersonId"].Value);
                }
            }
        }
    }
}
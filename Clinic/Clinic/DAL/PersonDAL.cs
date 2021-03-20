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
                    if (thePerson.PhoneNumber == default)
                    {
                        insertCommand.Parameters.AddWithValue("@PhoneNumber", DBNull.Value);
                    } else
                    {
                        insertCommand.Parameters.AddWithValue("@PhoneNumber", thePerson.PhoneNumber);
                    }
                    insertCommand.Parameters.AddWithValue("@AddressLine1", thePerson.AddressLine1);
                    if (thePerson.AddressLine2 == default)
                    {
                        insertCommand.Parameters.AddWithValue("@AddressLine2", DBNull.Value);
                    } else
                    {
                        insertCommand.Parameters.AddWithValue("@AddressLine2", thePerson.AddressLine2);
                    }
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

        /// <summary>
        /// Method that revises a record for a person in the database.
        /// Requires that the record has not been changed since it was retrieved.
        /// </summary>
        /// <param name="originalPerson">The Person object that was originally retrieved.</param>
        /// <param name="revisedPerson">A Person object with the revised values.</param>
        /// <returns>True if the operation is successful, false otherwise.</returns>
        public bool EditPerson(Person originalPerson, Person revisedPerson)
        {
            if (originalPerson == null)
            {
                throw new ArgumentNullException("originalPerson", "The original person cannot be null.");
            }

            if (revisedPerson == null)
            {
                throw new ArgumentNullException("revisedPerson", "The revised person cannot be null.");
            }

            if (originalPerson.PersonId != revisedPerson.PersonId)
            {
                throw new ArgumentException("The ID must be the same for both Person objects.");
            }

            string updateStatement =
                "UPDATE Person SET " +
                    "lastName = @RevisedLastName, " +
                    "firstName = @RevisedFirstName, " +
                    "dateOfBirth = @RevisedDateOfBirth, " +
                    "ssn = @RevisedSocialSecurityNumber, " +
                    "gender = @RevisedGender, " +
                    "phoneNumber = @RevisedPhoneNumber, " +
                    "addressLine1 = @RevisedAddressLine1, " +
                    "addressLine2 = @RevisedAddressLine2, " +
                    "city = @RevisedCity, " +
                    "state = @RevisedState, " +
                    "zipCode = @RevisedZipCode " +
                "WHERE personId = @PersonId " +
                    "AND lastName = @OriginalLastName " +
                    "AND firstName = @OriginalFirstName " +
                    "AND dateOfBirth = @OriginalDateOfBirth " +
                    "AND ssn = @OriginalSocialSecurityNumber " +
                    "AND gender = @OriginalGender " +
                    "AND phoneNumber = @OriginalPhoneNumber " +
                    "AND addressLine1 = @OriginalAddressLine1 " +
                    "AND (addressLine2 = @OriginalAddressLine2 OR addressLine2 IS NULL AND @OriginalAddressLine2 IS NULL) " +
                    "AND city = @OriginalCity " +
                    "AND state = @OriginalState " +
                    "AND zipCode = @OriginalZipCode";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                {
                    updateCommand.Parameters.AddWithValue("@PersonId", originalPerson.PersonId);
                    updateCommand.Parameters.AddWithValue("@OriginalLastName", originalPerson.LastName);
                    updateCommand.Parameters.AddWithValue("@OriginalFirstName", originalPerson.FirstName);
                    updateCommand.Parameters.AddWithValue("@OriginalDateOfBirth", originalPerson.DateOfBirth);
                    updateCommand.Parameters.AddWithValue("@OriginalSocialSecurityNumber", originalPerson.SocialSecurityNumber);
                    updateCommand.Parameters.AddWithValue("@OriginalGender", originalPerson.Gender);
                    updateCommand.Parameters.AddWithValue("@OriginalAddressLine1", originalPerson.AddressLine1);
                    updateCommand.Parameters.AddWithValue("@OriginalCity", originalPerson.City);
                    updateCommand.Parameters.AddWithValue("@OriginalState", originalPerson.State);
                    updateCommand.Parameters.AddWithValue("@OriginalZipCode", originalPerson.ZipCode);
                    updateCommand.Parameters.AddWithValue("@RevisedLastName", revisedPerson.LastName);
                    updateCommand.Parameters.AddWithValue("@RevisedFirstName", revisedPerson.FirstName);
                    updateCommand.Parameters.AddWithValue("@RevisedDateOfBirth", revisedPerson.DateOfBirth);
                    updateCommand.Parameters.AddWithValue("@RevisedSocialSecurityNumber", revisedPerson.SocialSecurityNumber);
                    updateCommand.Parameters.AddWithValue("@RevisedGender", revisedPerson.Gender);
                    updateCommand.Parameters.AddWithValue("@RevisedAddressLine1", revisedPerson.AddressLine1);
                    updateCommand.Parameters.AddWithValue("@RevisedCity", revisedPerson.City);
                    updateCommand.Parameters.AddWithValue("@RevisedState", revisedPerson.State);
                    updateCommand.Parameters.AddWithValue("@RevisedZipCode", revisedPerson.ZipCode);

                    if (originalPerson.PhoneNumber == default)
                    {
                        updateCommand.Parameters.AddWithValue("@OriginalPhoneNumber", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@OriginalPhoneNumber", originalPerson.PhoneNumber);
                    }

                    if (revisedPerson.PhoneNumber == default)
                    {
                        updateCommand.Parameters.AddWithValue("@RevisedPhoneNumber", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@RevisedPhoneNumber", revisedPerson.PhoneNumber);
                    }

                    if (originalPerson.AddressLine2 == default)
                    {
                        updateCommand.Parameters.AddWithValue("@OriginalAddressLine2", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@OriginalAddressLine2", originalPerson.AddressLine2);
                    }

                    if (revisedPerson.AddressLine2 == default)
                    {
                        updateCommand.Parameters.AddWithValue("@RevisedAddressLine2", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@RevisedAddressLine2", revisedPerson.AddressLine2);
                    }

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
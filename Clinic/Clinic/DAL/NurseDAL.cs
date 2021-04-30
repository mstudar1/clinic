using Clinic.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Clinic.DAL
{
    /// <summary>
    /// Class for accessing nurse information in the Clinic database.
    /// </summary>
    public class NurseDAL
    {
        /// <summary>
        /// Method that adds the specified Nurse object to the Person and Nurse tables in the database.
        /// </summary>
        /// <param name="theNurse">The Nurse object being added to the database.</param>
        public void AddNurse(Nurse theNurse)
        {
            if (theNurse == null)
            {
                throw new ArgumentNullException("theNurse", "The nurse cannot be null.");
            }

            if (theNurse.NurseId != default)
            {
                throw new ArgumentException("The Nurse object being passed in cannot have an ID, because one will be assigned by the database.");
            }

            string insertPersonStatement =
                "INSERT Person (lastName, firstName, dateOfBirth, ssn, gender, phoneNumber, addressLine1, addressLine2, city, state, zipCode) " +
                "VALUES (@LastName, @FirstName, @DateOfBirth, @SocialSecurityNumber, @Gender, @PhoneNumber, @AddressLine1, @AddressLine2, @City, @State, @ZipCode) ";


            string insertNurseStatement =
                "INSERT Nurse (personId, isActive) " +
                "VALUES (@@identity, @IsActive)";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                SqlCommand insertCommand = connection.CreateCommand();
                SqlTransaction transaction;

                //Start a local transaction
                transaction = connection.BeginTransaction("InsertPatient");

                insertCommand.Connection = connection;
                insertCommand.Transaction = transaction;
                insertCommand.Parameters.AddWithValue("@IsActive", theNurse.IsActive);
                insertCommand.Parameters.AddWithValue("@LastName", theNurse.LastName);
                insertCommand.Parameters.AddWithValue("@FirstName", theNurse.FirstName);
                insertCommand.Parameters.AddWithValue("@DateOfBirth", theNurse.DateOfBirth);
                insertCommand.Parameters.AddWithValue("@SocialSecurityNumber", theNurse.SocialSecurityNumber);
                insertCommand.Parameters.AddWithValue("@Gender", theNurse.Gender);
                if (theNurse.PhoneNumber == default)
                {
                    insertCommand.Parameters.AddWithValue("@PhoneNumber", DBNull.Value);
                }
                else
                {
                    insertCommand.Parameters.AddWithValue("@PhoneNumber", theNurse.PhoneNumber);
                }
                insertCommand.Parameters.AddWithValue("@AddressLine1", theNurse.AddressLine1);
                if (theNurse.AddressLine2 == default)
                {
                    insertCommand.Parameters.AddWithValue("@AddressLine2", DBNull.Value);
                }
                else
                {
                    insertCommand.Parameters.AddWithValue("@AddressLine2", theNurse.AddressLine2);
                }
                insertCommand.Parameters.AddWithValue("@City", theNurse.City);
                insertCommand.Parameters.AddWithValue("@State", theNurse.State);
                insertCommand.Parameters.AddWithValue("@ZipCode", theNurse.ZipCode);


                try
                {
                    insertCommand.CommandText = insertPersonStatement;
                    insertCommand.ExecuteNonQuery();
                    insertCommand.CommandText = insertNurseStatement;
                    insertCommand.ExecuteNonQuery();

                    //Attemp to commit the transaction
                    transaction.Commit();
                    Console.WriteLine("Data was inserted in both tables");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                    Console.WriteLine("   Message: {0}", ex.Message);

                    // Attemp to roll back the transaction
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                        Console.WriteLine("    Message: {0}", ex2.Message);
                    }
                }
            }
        }

        /// <summary>
        /// Method that finds all nurses in the database with the specified last name.
        /// </summary>
        /// <param name="lastName">The last name of the nurse(s).</param>
        /// <returns>A list of nurses with the specified last name.</returns>
        public List<Nurse> FindNurses(string lastName)
        {
            if (string.IsNullOrEmpty(lastName))
            {
                throw new ArgumentNullException("lastName", "The last name cannot be null or empty.");
            }

            List<Nurse> nurseList = new List<Nurse>();

            string selectStatement =
                "SELECT Nurse.nurseId, " +
                    "Nurse.isActive, " +
                    "Person.personId, " +
                    "Person.lastName, " +
                    "Person.firstName, " +
                    "Person.dateOfBirth, " +
                    "Person.ssn, " +
                    "Person.gender, " +
                    "Person.phoneNumber, " +
                    "Person.addressLine1, " +
                    "Person.addressLine2, " +
                    "Person.city, " +
                    "Person.state, " +
                    "Person.zipCode " +
                "FROM Nurse " +
                    "LEFT JOIN Person ON Nurse.personId = Person.personId " +
                "WHERE Person.lastName = @LastName";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@LastName", lastName);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        int personIdOrdinal = reader.GetOrdinal("personId");
                        int nurseIdOrdinal = reader.GetOrdinal("nurseId");
                        int isActiveOrdinal = reader.GetOrdinal("isActive");
                        int lastNameOrdinal = reader.GetOrdinal("lastName");
                        int firstNameOrdinal = reader.GetOrdinal("firstName");
                        int dateOfBirthOrdinal = reader.GetOrdinal("dateOfBirth");
                        int ssnOrdinal = reader.GetOrdinal("ssn");
                        int genderOrdinal = reader.GetOrdinal("gender");
                        int phoneNumberOrdinal = reader.GetOrdinal("phoneNumber");
                        int addressLine1Ordinal = reader.GetOrdinal("addressLine1");
                        int addressLine2Ordinal = reader.GetOrdinal("addressLine2");
                        int cityOrdinal = reader.GetOrdinal("city");
                        int stateOrdinal = reader.GetOrdinal("state");
                        int zipCodeOrdinal = reader.GetOrdinal("zipCode");
                        while (reader.Read())
                        {
                            Nurse theNurse = new Nurse();
                            if (!reader.IsDBNull(personIdOrdinal)) { theNurse.PersonId = reader.GetInt32(personIdOrdinal); }
                            if (!reader.IsDBNull(nurseIdOrdinal)) { theNurse.NurseId = reader.GetInt32(nurseIdOrdinal); }
                            if (!reader.IsDBNull(isActiveOrdinal)) { theNurse.IsActive = reader.GetBoolean(isActiveOrdinal); }
                            if (!reader.IsDBNull(lastNameOrdinal)) { theNurse.LastName = reader.GetString(lastNameOrdinal); }
                            if (!reader.IsDBNull(firstNameOrdinal)) { theNurse.FirstName = reader.GetString(firstNameOrdinal); }
                            if (!reader.IsDBNull(dateOfBirthOrdinal)) { theNurse.DateOfBirth = reader.GetDateTime(dateOfBirthOrdinal); }
                            if (!reader.IsDBNull(ssnOrdinal)) { theNurse.SocialSecurityNumber = reader.GetString(ssnOrdinal); }
                            if (!reader.IsDBNull(genderOrdinal)) { theNurse.Gender = reader.GetString(genderOrdinal); }
                            if (!reader.IsDBNull(phoneNumberOrdinal)) { theNurse.PhoneNumber = reader.GetString(phoneNumberOrdinal); }
                            if (!reader.IsDBNull(addressLine1Ordinal)) { theNurse.AddressLine1 = reader.GetString(addressLine1Ordinal); }
                            if (!reader.IsDBNull(addressLine2Ordinal)) { theNurse.AddressLine2 = reader.GetString(addressLine2Ordinal); }
                            if (!reader.IsDBNull(cityOrdinal)) { theNurse.City = reader.GetString(cityOrdinal); }
                            if (!reader.IsDBNull(stateOrdinal)) { theNurse.State = reader.GetString(stateOrdinal); }
                            if (!reader.IsDBNull(zipCodeOrdinal)) { theNurse.ZipCode = reader.GetString(zipCodeOrdinal); }
                            nurseList.Add(theNurse);
                        }
                    }
                }
            }
            return nurseList;
        }

        /// <summary>
        /// Method that gets a list of all nurses.
        /// </summary>
        /// <returns>A list of all the nurses.</returns>
        public List<Nurse> GetAllNurses()
        {
            List<Nurse> nurseList = new List<Nurse>();

            string selectStatement =
                "SELECT Nurse.nurseId, " +
                    "Nurse.isActive, " +
                    "Person.personId, " +
                    "Person.lastName, " +
                    "Person.firstName, " +
                    "Person.dateOfBirth, " +
                    "Person.ssn, " +
                    "Person.gender, " +
                    "Person.phoneNumber, " +
                    "Person.addressLine1, " +
                    "Person.addressLine2, " +
                    "Person.city, " +
                    "Person.state, " +
                    "Person.zipCode " +
                "FROM Nurse " +
                    "LEFT JOIN Person ON Nurse.personId = Person.personId " +
                "ORDER BY Person.firstName, Person.lastName";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        int personIdOrdinal = reader.GetOrdinal("personId");
                        int nurseIdOrdinal = reader.GetOrdinal("nurseId");
                        int isActiveOrdinal = reader.GetOrdinal("isActive");
                        int lastNameOrdinal = reader.GetOrdinal("lastName");
                        int firstNameOrdinal = reader.GetOrdinal("firstName");
                        int dateOfBirthOrdinal = reader.GetOrdinal("dateOfBirth");
                        int ssnOrdinal = reader.GetOrdinal("ssn");
                        int genderOrdinal = reader.GetOrdinal("gender");
                        int phoneNumberOrdinal = reader.GetOrdinal("phoneNumber");
                        int addressLine1Ordinal = reader.GetOrdinal("addressLine1");
                        int addressLine2Ordinal = reader.GetOrdinal("addressLine2");
                        int cityOrdinal = reader.GetOrdinal("city");
                        int stateOrdinal = reader.GetOrdinal("state");
                        int zipCodeOrdinal = reader.GetOrdinal("zipCode");
                        while (reader.Read())
                        {
                            Nurse theNurse = new Nurse();
                            if (!reader.IsDBNull(personIdOrdinal)) { theNurse.PersonId = reader.GetInt32(personIdOrdinal); }
                            if (!reader.IsDBNull(nurseIdOrdinal)) { theNurse.NurseId = reader.GetInt32(nurseIdOrdinal); }
                            if (!reader.IsDBNull(isActiveOrdinal)) { theNurse.IsActive = reader.GetBoolean(isActiveOrdinal); }
                            if (!reader.IsDBNull(lastNameOrdinal)) { theNurse.LastName = reader.GetString(lastNameOrdinal); }
                            if (!reader.IsDBNull(firstNameOrdinal)) { theNurse.FirstName = reader.GetString(firstNameOrdinal); }
                            if (!reader.IsDBNull(dateOfBirthOrdinal)) { theNurse.DateOfBirth = reader.GetDateTime(dateOfBirthOrdinal); }
                            if (!reader.IsDBNull(ssnOrdinal)) { theNurse.SocialSecurityNumber = reader.GetString(ssnOrdinal); }
                            if (!reader.IsDBNull(genderOrdinal)) { theNurse.Gender = reader.GetString(genderOrdinal); }
                            if (!reader.IsDBNull(phoneNumberOrdinal)) { theNurse.PhoneNumber = reader.GetString(phoneNumberOrdinal); }
                            if (!reader.IsDBNull(addressLine1Ordinal)) { theNurse.AddressLine1 = reader.GetString(addressLine1Ordinal); }
                            if (!reader.IsDBNull(addressLine2Ordinal)) { theNurse.AddressLine2 = reader.GetString(addressLine2Ordinal); }
                            if (!reader.IsDBNull(cityOrdinal)) { theNurse.City = reader.GetString(cityOrdinal); }
                            if (!reader.IsDBNull(stateOrdinal)) { theNurse.State = reader.GetString(stateOrdinal); }
                            if (!reader.IsDBNull(zipCodeOrdinal)) { theNurse.ZipCode = reader.GetString(zipCodeOrdinal); }
                            nurseList.Add(theNurse);
                        }
                    }
                }
            }
            return nurseList;
        }

        /// <summary>
        /// Method that revises a record for a Nurse in the database.
        /// Edits the Person and Nurse tables.
        /// Requires that the record has not been changed since it was retrieved.
        /// </summary>
        /// <param name="originalNurse">The Nurse object that was originally retrieved.</param>
        /// <param name="revisedNurse">A Nurse object with the revised values.</param>
        /// <returns>True if the operation is successful, false otherwise.</returns>
        public bool EditNurse(Nurse originalNurse, Nurse revisedNurse)
        {
            if (originalNurse == null)
            {
                throw new ArgumentNullException("originalPatient", "The original nurse cannot be null.");
            }

            if (revisedNurse == null)
            {
                throw new ArgumentNullException("revisedPatient", "The revised nurse cannot be null.");
            }

            if (originalNurse.PersonId != revisedNurse.PersonId)
            {
                throw new ArgumentException("The person ID must be the same for both Nurse objects.");
            }

            if (originalNurse.NurseId != revisedNurse.NurseId)
            {
                throw new ArgumentException("The nurse ID must be the same for both Nurse objects.");
            }

            string updatePersonStatement =
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

            string updateNurseStatement =
                "UPDATE Nurse SET " +
                    "isActive = @IsActive, " +
                "WHERE nurseId = @NurseId";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand updateCommand = connection.CreateCommand())
                {
                    SqlTransaction transaction = connection.BeginTransaction();
                    updateCommand.Connection = connection;
                    updateCommand.Transaction = transaction;
                    updateCommand.Parameters.AddWithValue("@PersonId", originalNurse.PersonId);
                    updateCommand.Parameters.AddWithValue("@OriginalLastName", originalNurse.LastName);
                    updateCommand.Parameters.AddWithValue("@OriginalFirstName", originalNurse.FirstName);
                    updateCommand.Parameters.AddWithValue("@OriginalDateOfBirth", originalNurse.DateOfBirth);
                    updateCommand.Parameters.AddWithValue("@OriginalSocialSecurityNumber", originalNurse.SocialSecurityNumber);
                    updateCommand.Parameters.AddWithValue("@OriginalGender", originalNurse.Gender);
                    updateCommand.Parameters.AddWithValue("@OriginalAddressLine1", originalNurse.AddressLine1);
                    updateCommand.Parameters.AddWithValue("@OriginalCity", originalNurse.City);
                    updateCommand.Parameters.AddWithValue("@OriginalState", originalNurse.State);
                    updateCommand.Parameters.AddWithValue("@OriginalZipCode", originalNurse.ZipCode);
                    updateCommand.Parameters.AddWithValue("@RevisedLastName", revisedNurse.LastName);
                    updateCommand.Parameters.AddWithValue("@RevisedFirstName", revisedNurse.FirstName);
                    updateCommand.Parameters.AddWithValue("@RevisedDateOfBirth", revisedNurse.DateOfBirth);
                    updateCommand.Parameters.AddWithValue("@RevisedSocialSecurityNumber", revisedNurse.SocialSecurityNumber);
                    updateCommand.Parameters.AddWithValue("@RevisedGender", revisedNurse.Gender);
                    updateCommand.Parameters.AddWithValue("@RevisedAddressLine1", revisedNurse.AddressLine1);
                    updateCommand.Parameters.AddWithValue("@RevisedCity", revisedNurse.City);
                    updateCommand.Parameters.AddWithValue("@RevisedState", revisedNurse.State);
                    updateCommand.Parameters.AddWithValue("@RevisedZipCode", revisedNurse.ZipCode);

                    if (originalNurse.PhoneNumber == default)
                    {
                        updateCommand.Parameters.AddWithValue("@OriginalPhoneNumber", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@OriginalPhoneNumber", originalNurse.PhoneNumber);
                    }

                    if (revisedNurse.PhoneNumber == default)
                    {
                        updateCommand.Parameters.AddWithValue("@RevisedPhoneNumber", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@RevisedPhoneNumber", revisedNurse.PhoneNumber);
                    }

                    if (originalNurse.AddressLine2 == default)
                    {
                        updateCommand.Parameters.AddWithValue("@OriginalAddressLine2", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@OriginalAddressLine2", originalNurse.AddressLine2);
                    }

                    if (revisedNurse.AddressLine2 == default)
                    {
                        updateCommand.Parameters.AddWithValue("@RevisedAddressLine2", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@RevisedAddressLine2", revisedNurse.AddressLine2);
                    }

                    try
                    {
                        updateCommand.CommandText = updatePersonStatement;
                        updateCommand.ExecuteNonQuery();
                        updateCommand.CommandText = updateNurseStatement;
                        updateCommand.ExecuteNonQuery();
                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }
    }
}
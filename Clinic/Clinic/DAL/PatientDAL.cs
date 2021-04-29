using Clinic.Model;
using System;
using System.Collections.Generic;
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

            if (thePatient.PatientId != default)
            {
                throw new ArgumentException("The Patient object being passed in cannot have an ID, because one will be assigned by the database.");
            }

            string insertPersonStatement =
                "INSERT Person (lastName, firstName, dateOfBirth, ssn, gender, phoneNumber, addressLine1, addressLine2, city, state, zipCode) " +
                "VALUES (@LastName, @FirstName, @DateOfBirth, @SocialSecurityNumber, @Gender, @PhoneNumber, @AddressLine1, @AddressLine2, @City, @State, @ZipCode) ";
                
            
            string insertPatientStatement =
                "INSERT Patient (personId) " +
                "VALUES (@@identity)";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                SqlCommand insertCommand = connection.CreateCommand();
                SqlTransaction transaction;

                //Start a local transaction
                transaction = connection.BeginTransaction("InsertPatient");

                insertCommand.Connection = connection;
                insertCommand.Transaction = transaction;
                insertCommand.Parameters.AddWithValue("@LastName", thePatient.LastName);
                insertCommand.Parameters.AddWithValue("@FirstName", thePatient.FirstName);
                insertCommand.Parameters.AddWithValue("@DateOfBirth", thePatient.DateOfBirth);
                insertCommand.Parameters.AddWithValue("@SocialSecurityNumber", thePatient.SocialSecurityNumber);
                insertCommand.Parameters.AddWithValue("@Gender", thePatient.Gender);
                if (thePatient.PhoneNumber == default)
                {
                    insertCommand.Parameters.AddWithValue("@PhoneNumber", DBNull.Value);
                }
                else
                {
                    insertCommand.Parameters.AddWithValue("@PhoneNumber", thePatient.PhoneNumber);
                }
                insertCommand.Parameters.AddWithValue("@AddressLine1", thePatient.AddressLine1);
                if (thePatient.AddressLine2 == default)
                {
                    insertCommand.Parameters.AddWithValue("@AddressLine2", DBNull.Value);
                }
                else
                {
                    insertCommand.Parameters.AddWithValue("@AddressLine2", thePatient.AddressLine2);
                }
                insertCommand.Parameters.AddWithValue("@City", thePatient.City);
                insertCommand.Parameters.AddWithValue("@State", thePatient.State);
                insertCommand.Parameters.AddWithValue("@ZipCode", thePatient.ZipCode);


                try
                {
                    insertCommand.CommandText = insertPersonStatement;
                    insertCommand.ExecuteNonQuery();
                    insertCommand.CommandText = insertPatientStatement;
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
                    throw new ArgumentException("The patient was not added.");
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
                throw new ArgumentException("The person ID must be the same for both Patient objects.");
            }

            if (originalPatient.PatientId != revisedPatient.PatientId)
            {
                throw new ArgumentException("The patient ID must be the same for both Patient objects.");
            }

            return this.thePersonDAL.EditPerson(originalPatient, revisedPatient);
        }

        /// <summary>
        /// Method that finds all patients in the database with the specified date of birth.
        /// </summary>
        /// <param name="dateOfBirth">The date of birth being searched for.</param>
        /// <returns>A list of patients with the specified date of birth.</returns>
        public List<Patient> FindPatients(DateTime dateOfBirth)
        {
            if (dateOfBirth == null)
            {
                throw new ArgumentNullException("dateOfBirth", "The date of birth cannot be null.");
            }

            List<Patient> patientList = new List<Patient>();

            string selectStatement =
                "SELECT Patient.patientId, " +
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
                "FROM Patient " +
                    "LEFT JOIN Person ON Patient.personId = Person.personId " +
                "WHERE Person.dateOfBirth = @DateOfBirth";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        int personIdOrdinal = reader.GetOrdinal("personId");
                        int patientIdOrdinal = reader.GetOrdinal("patientId");
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
                            Patient thePatient = new Patient();
                            if (!reader.IsDBNull(personIdOrdinal)) { thePatient.PersonId = reader.GetInt32(personIdOrdinal); }
                            if (!reader.IsDBNull(patientIdOrdinal)) { thePatient.PatientId = reader.GetInt32(patientIdOrdinal); }
                            if (!reader.IsDBNull(lastNameOrdinal)) { thePatient.LastName = reader.GetString(lastNameOrdinal); }
                            if (!reader.IsDBNull(firstNameOrdinal)) { thePatient.FirstName = reader.GetString(firstNameOrdinal); }
                            if (!reader.IsDBNull(dateOfBirthOrdinal)) { thePatient.DateOfBirth = reader.GetDateTime(dateOfBirthOrdinal); }
                            if (!reader.IsDBNull(ssnOrdinal)) { thePatient.SocialSecurityNumber = reader.GetString(ssnOrdinal); }
                            if (!reader.IsDBNull(genderOrdinal)) { thePatient.Gender = reader.GetString(genderOrdinal); }
                            if (!reader.IsDBNull(phoneNumberOrdinal)) { thePatient.PhoneNumber = reader.GetString(phoneNumberOrdinal); }
                            if (!reader.IsDBNull(addressLine1Ordinal)) { thePatient.AddressLine1 = reader.GetString(addressLine1Ordinal); }
                            if (!reader.IsDBNull(addressLine2Ordinal)) { thePatient.AddressLine2 = reader.GetString(addressLine2Ordinal); }
                            if (!reader.IsDBNull(cityOrdinal)) { thePatient.City = reader.GetString(cityOrdinal); }
                            if (!reader.IsDBNull(stateOrdinal)) { thePatient.State = reader.GetString(stateOrdinal); }
                            if (!reader.IsDBNull(zipCodeOrdinal)) { thePatient.ZipCode = reader.GetString(zipCodeOrdinal); }
                            patientList.Add(thePatient);
                        }
                    }
                }
            }
            return patientList;
        }

        /// <summary>
        /// Method that finds all patients in the database with the specified last and first names.
        /// </summary>
        /// <param name="lastName">The last name of the patient(s).</param>
        /// <param name="firstName">The first name of the patient(s).</param>
        /// <returns>A list of patients with the specified names.</returns>
        public List<Patient> FindPatients(string lastName, string firstName)
        {
            if (string.IsNullOrEmpty(lastName))
            {
                throw new ArgumentNullException("lastName", "The last name cannot be null or empty.");
            }

            if (string.IsNullOrEmpty(firstName))
            {
                throw new ArgumentNullException("firstname", "The first name cannot be null or empty.");
            }

            List<Patient> patientList = new List<Patient>();

            string selectStatement =
                "SELECT Patient.patientId, " +
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
                "FROM Patient " +
                    "LEFT JOIN Person ON Patient.personId = Person.personId " +
                "WHERE Person.lastName = @LastName " +
                    "AND Person.firstName = @FirstName";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@LastName", lastName);
                    selectCommand.Parameters.AddWithValue("@FirstName", firstName);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        int personIdOrdinal = reader.GetOrdinal("personId");
                        int patientIdOrdinal = reader.GetOrdinal("patientId");
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
                            Patient thePatient = new Patient();
                            if (!reader.IsDBNull(personIdOrdinal)) { thePatient.PersonId = reader.GetInt32(personIdOrdinal); }
                            if (!reader.IsDBNull(patientIdOrdinal)) { thePatient.PatientId = reader.GetInt32(patientIdOrdinal); }
                            if (!reader.IsDBNull(lastNameOrdinal)) { thePatient.LastName = reader.GetString(lastNameOrdinal); }
                            if (!reader.IsDBNull(firstNameOrdinal)) { thePatient.FirstName = reader.GetString(firstNameOrdinal); }
                            if (!reader.IsDBNull(dateOfBirthOrdinal)) { thePatient.DateOfBirth = reader.GetDateTime(dateOfBirthOrdinal); }
                            if (!reader.IsDBNull(ssnOrdinal)) { thePatient.SocialSecurityNumber = reader.GetString(ssnOrdinal); }
                            if (!reader.IsDBNull(genderOrdinal)) { thePatient.Gender = reader.GetString(genderOrdinal); }
                            if (!reader.IsDBNull(phoneNumberOrdinal)) { thePatient.PhoneNumber = reader.GetString(phoneNumberOrdinal); }
                            if (!reader.IsDBNull(addressLine1Ordinal)) { thePatient.AddressLine1 = reader.GetString(addressLine1Ordinal); }
                            if (!reader.IsDBNull(addressLine2Ordinal)) { thePatient.AddressLine2 = reader.GetString(addressLine2Ordinal); }
                            if (!reader.IsDBNull(cityOrdinal)) { thePatient.City = reader.GetString(cityOrdinal); }
                            if (!reader.IsDBNull(stateOrdinal)) { thePatient.State = reader.GetString(stateOrdinal); }
                            if (!reader.IsDBNull(zipCodeOrdinal)) { thePatient.ZipCode = reader.GetString(zipCodeOrdinal); }
                            patientList.Add(thePatient);
                        }
                    }
                }
            }
            return patientList;
        }

        /// <summary>
        /// Method that finds all patients in the database with the specified date of birth and last name.
        /// </summary>
        /// <param name="dateOfBirth">The date of birth being searched for.</param>
        /// <param name="lastName">The last name of the patient(s).</param>
        /// <returns>A list of patients with the specified date of birth and last name.</returns>
        public List<Patient> FindPatients(DateTime dateOfBirth, string lastName)
        {
            if (dateOfBirth == null)
            {
                throw new ArgumentNullException("dateOfBirth", "The date of birth cannot be null.");
            }

            if (string.IsNullOrEmpty(lastName))
            {
                throw new ArgumentNullException("lastName", "The last name cannot be null or empty.");
            }

            List<Patient> patientList = new List<Patient>();

            string selectStatement =
                "SELECT Patient.patientId, " +
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
                "FROM Patient " +
                    "LEFT JOIN Person ON Patient.personId = Person.personId " +
                "WHERE Person.dateOfBirth = @DateOfBirth " +
                    "AND Person.lastName = @LastName";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                    selectCommand.Parameters.AddWithValue("@LastName", lastName);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        int personIdOrdinal = reader.GetOrdinal("personId");
                        int patientIdOrdinal = reader.GetOrdinal("patientId");
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
                            Patient thePatient = new Patient();
                            if (!reader.IsDBNull(personIdOrdinal)) { thePatient.PersonId = reader.GetInt32(personIdOrdinal); }
                            if (!reader.IsDBNull(patientIdOrdinal)) { thePatient.PatientId = reader.GetInt32(patientIdOrdinal); }
                            if (!reader.IsDBNull(lastNameOrdinal)) { thePatient.LastName = reader.GetString(lastNameOrdinal); }
                            if (!reader.IsDBNull(firstNameOrdinal)) { thePatient.FirstName = reader.GetString(firstNameOrdinal); }
                            if (!reader.IsDBNull(dateOfBirthOrdinal)) { thePatient.DateOfBirth = reader.GetDateTime(dateOfBirthOrdinal); }
                            if (!reader.IsDBNull(ssnOrdinal)) { thePatient.SocialSecurityNumber = reader.GetString(ssnOrdinal); }
                            if (!reader.IsDBNull(genderOrdinal)) { thePatient.Gender = reader.GetString(genderOrdinal); }
                            if (!reader.IsDBNull(phoneNumberOrdinal)) { thePatient.PhoneNumber = reader.GetString(phoneNumberOrdinal); }
                            if (!reader.IsDBNull(addressLine1Ordinal)) { thePatient.AddressLine1 = reader.GetString(addressLine1Ordinal); }
                            if (!reader.IsDBNull(addressLine2Ordinal)) { thePatient.AddressLine2 = reader.GetString(addressLine2Ordinal); }
                            if (!reader.IsDBNull(cityOrdinal)) { thePatient.City = reader.GetString(cityOrdinal); }
                            if (!reader.IsDBNull(stateOrdinal)) { thePatient.State = reader.GetString(stateOrdinal); }
                            if (!reader.IsDBNull(zipCodeOrdinal)) { thePatient.ZipCode = reader.GetString(zipCodeOrdinal); }
                            patientList.Add(thePatient);
                        }
                    }
                }
            }
            return patientList;
        }

        /// <summary>
        /// Method that returns all patients as a list
        /// </summary>
        /// <returns>The Patients List</returns>
        public List<Patient> GetPatientsList()
        {

            List<Patient> patientList = new List<Patient>();

            string selectStatement =
               "SELECT Patient.patientId, " +
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
               "FROM Patient " +
                   "LEFT JOIN Person ON Patient.personId = Person.personId ";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        int personIdOrdinal = reader.GetOrdinal("personId");
                        int patientIdOrdinal = reader.GetOrdinal("patientId");
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
                            Patient thePatient = new Patient();
                            if (!reader.IsDBNull(personIdOrdinal)) { thePatient.PersonId = reader.GetInt32(personIdOrdinal); }
                            if (!reader.IsDBNull(patientIdOrdinal)) { thePatient.PatientId = reader.GetInt32(patientIdOrdinal); }
                            if (!reader.IsDBNull(lastNameOrdinal)) { thePatient.LastName = reader.GetString(lastNameOrdinal); }
                            if (!reader.IsDBNull(firstNameOrdinal)) { thePatient.FirstName = reader.GetString(firstNameOrdinal); }
                            if (!reader.IsDBNull(dateOfBirthOrdinal)) { thePatient.DateOfBirth = reader.GetDateTime(dateOfBirthOrdinal); }
                            if (!reader.IsDBNull(ssnOrdinal)) { thePatient.SocialSecurityNumber = reader.GetString(ssnOrdinal); }
                            if (!reader.IsDBNull(genderOrdinal)) { thePatient.Gender = reader.GetString(genderOrdinal); }
                            if (!reader.IsDBNull(phoneNumberOrdinal)) { thePatient.PhoneNumber = reader.GetString(phoneNumberOrdinal); }
                            if (!reader.IsDBNull(addressLine1Ordinal)) { thePatient.AddressLine1 = reader.GetString(addressLine1Ordinal); }
                            if (!reader.IsDBNull(addressLine2Ordinal)) { thePatient.AddressLine2 = reader.GetString(addressLine2Ordinal); }
                            if (!reader.IsDBNull(cityOrdinal)) { thePatient.City = reader.GetString(cityOrdinal); }
                            if (!reader.IsDBNull(stateOrdinal)) { thePatient.State = reader.GetString(stateOrdinal); }
                            if (!reader.IsDBNull(zipCodeOrdinal)) { thePatient.ZipCode = reader.GetString(zipCodeOrdinal); }
                            patientList.Add(thePatient);
                        }
                    }
                }
            }
            return patientList;
        }

        /// <summary>
        /// Method that deletes the specified patient from the Person and Patient tables in the database.
        /// </summary>
        /// <param name="thePatient">An object representing the patient being deleted from the database.</param>
        public void DeletePatient(Patient thePatient)
        {
            if (thePatient == null)
            {
                throw new ArgumentNullException("thePatient", "The patient object cannot be null.");
            }

            string deletePersonStatement =
                "DELETE FROM Person " +
                "WHERE personId = @PersonId";

            string deletePatientStatement =
                "DELETE FROM Patient " +
                "WHERE patientId = @PatientId";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                SqlCommand deleteCommand = connection.CreateCommand();
                SqlTransaction transaction;

                //Start a local transaction
                transaction = connection.BeginTransaction("DeletePatient");

                deleteCommand.Connection = connection;
                deleteCommand.Transaction = transaction;
                deleteCommand.Parameters.AddWithValue("@PersonId", thePatient.PersonId);
                deleteCommand.Parameters.AddWithValue("@PatientId", thePatient.PatientId);

                try
                {
                    deleteCommand.CommandText = deletePatientStatement;
                    deleteCommand.ExecuteNonQuery();
                    deleteCommand.CommandText = deletePersonStatement;
                    deleteCommand.ExecuteNonQuery();

                    //Attemp to commit the transaction
                    transaction.Commit();
                    Console.WriteLine("Data was deleted from both tables.");
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
                    throw new ArgumentException("The patient was not deleted.");
                }
            }
        }
    }
}
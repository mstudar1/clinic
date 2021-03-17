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
    }
}
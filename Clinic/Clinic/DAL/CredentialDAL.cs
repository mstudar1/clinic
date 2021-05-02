using Clinic.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace Clinic.DAL
{
    /// <summary>
    /// Class for accessing credential information from the Clinic database.
    /// </summary>
    public class CredentialDAL
    {
        /// <summary>
        /// Method for checking if the specified credentials are valid.
        /// </summary>
        /// <param name="username">The username being checked.</param>
        /// <param name="passwordHash">The SHA 256 hashed password being checked.</param>
        /// <returns>True if the specified credentials are valid.  False if the specified credentials are invalid.</returns>
        public bool CredentialsAreValid(string username, string passwordHash)
        {
            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentNullException("username", "The username cannot be null or empty.");
            }

            if (string.IsNullOrEmpty(passwordHash))
            {
                throw new ArgumentNullException("password", "The password cannot be null or empty.");
            }

            string selectStatement =
                "SELECT @NumberOfMatchingUsers = COUNT(username) " +
                "FROM Credential " +
                "WHERE userName = @Username " +
                "AND passwordHash = @PasswordHash";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    SqlParameter countParameter = new SqlParameter("@NumberOfMatchingUsers", SqlDbType.Int, 1)
                    {
                        Direction = ParameterDirection.Output
                    };
                    selectCommand.Parameters.Add(countParameter);
                    selectCommand.Parameters.AddWithValue("@Username", username);
                    selectCommand.Parameters.AddWithValue("@PasswordHash", passwordHash);
                    selectCommand.ExecuteNonQuery();
                    if (Convert.ToInt32(countParameter.Value) == 0)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }

        /// <summary>
        /// Method that returns an object that is a subtype of the Person class.
        /// The returned object represents the user with the specified username.
        /// If the specified user has a role of "Nurse", then an object of the Nurse type is returned.
        /// Similarly, if the specified user has a role of "Administrator", then an object of the Administrator type is returned.
        /// If the specified user does not have rights to log in to the system, then an ArgumentException is thrown.
        /// </summary>
        /// <param name="username">The username of the user that is attempting to log in to the system.</param>
        /// <returns>An object that is a subtype of the Person class which represents the user with the specified username.</returns>
        public Person GetUser(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentNullException("username", "The username cannot be null or empty.");
            }

            if (this.GetRole(username).Equals("Nurse"))
            {
                return this.GetNurse(username);
            } else if (this.GetRole(username).Equals("Admin"))
            {
                return this.GetAdministrator(username);
            } else
            {
                throw new ArgumentException("The specified user does not have rights to log in to the system.");
            }
        }

        /// <summary>
        /// Method returns the role of the person for the given username. 
        /// The role can be nurse or administrator.
        /// </summary>
        /// <param name="username">username of the person</param>
        /// <returns>the role of the person</returns>
        public string GetRole(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentNullException("username", "The username cannot be null or empty.");
            }

            string selectStatement =
                "SELECT @Role = role " +
                "FROM Credential " +
                "WHERE userName = @Username";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    SqlParameter roleParameter = new SqlParameter("@Role", SqlDbType.VarChar, 25)
                    {
                        Direction = ParameterDirection.Output
                    };
                    selectCommand.Parameters.Add(roleParameter);
                    selectCommand.Parameters.AddWithValue("@Username", username);
                    selectCommand.ExecuteNonQuery();
                    return roleParameter.Value.ToString();
                }
            }
        }

        /// <summary>
        /// Method that can be called to add a user to the database.
        /// </summary>
        /// <param name="username">Username for the new user.</param>
        /// <param name="personId">Person ID of the new user.</param>
        /// <param name="role">Role of the new user.</param>
        /// <param name="unhashedPassword">Unhashed password for the new user.</param>
        public void AddUser(string username, int personId, string role, string unhashedPassword)
        {
            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentNullException("username", "The username cannot be null or empty.");
            }

            if (personId < 0)
            {
                throw new ArgumentException("The person ID cannot be negative.", "personId");
            }

            if (string.IsNullOrEmpty(role))
            {
                throw new ArgumentNullException("role", "The role cannot be null or empty.");
            }

            if (string.IsNullOrEmpty(unhashedPassword))
            {
                throw new ArgumentNullException("unhashedPassword", "The unhashed password cannot be null or empty.");
            }

            string hashedPassword;
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(unhashedPassword));
                hashedPassword = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }

            string insertStatement =
                "INSERT Credential (userName, personId, role, passwordHash) " +
                "VALUES (@Username, @PersonId, @Role, @HashedPassword)";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@Username", username);
                    insertCommand.Parameters.AddWithValue("@PersonId", personId);
                    insertCommand.Parameters.AddWithValue("@Role", role);
                    insertCommand.Parameters.AddWithValue("@HashedPassword", hashedPassword);
                    insertCommand.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Method that can be called to change a user's credentials.
        /// </summary>
        /// <param name="originalUsername">The username of the user before the change is made.</param>
        /// <param name="newUsername">The new username for the user.</param>
        /// <param name="newUnhashedPassword">The new unhashed password for the user.</param>
        /// <returns>True if the operation is successful, false otherwise.</returns>
        public bool EditCredentials(string originalUsername, string newUsername, string newUnhashedPassword)
        {
            if (string.IsNullOrEmpty(originalUsername)) {
                throw new ArgumentNullException("originalUsername", "The original username cannot be null.");
            }

            if (string.IsNullOrEmpty(newUsername))
            {
                throw new ArgumentNullException("newUsername", "The new username cannot be null.");
            }

            if (string.IsNullOrEmpty(newUnhashedPassword))
            {
                throw new ArgumentNullException("newUnhashedPassword", "The new password cannot be null.");
            }

            string hashedPassword;
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(newUnhashedPassword));
                hashedPassword = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }

            string updateStatement =
                "UPDATE Credential SET " +
                    "username = @NewUsername, " +
                    "password = @NewHashedPassword " +
                "WHERE username = @OriginalUsername";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                {
                    updateCommand.Parameters.AddWithValue("@OriginalUsername", originalUsername);
                    updateCommand.Parameters.AddWithValue("@NewUsername", newUsername);
                    updateCommand.Parameters.AddWithValue("@NewHashedPassword", hashedPassword);

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

        private Nurse GetNurse(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentNullException("username", "The username cannot be null or empty.");
            }

            Nurse theNurse = new Nurse();

            string selectStatement =
                "SELECT @NurseId = n.nurseId, " +
                "@PersonId = p.personId, " +
                "@LastName = p.lastName, " +
                "@FirstName = p.firstName, " +
                "@DateOfBirth = p.dateOfBirth, " +
                "@SocialSecurityNumber = p.ssn, " +
                "@Gender = p.gender, " +
                "@PhoneNumber = p.phoneNumber, " +
                "@AddressLine1 = p.addressLine1, " +
                "@AddressLine2 = p.addressLine2, " +
                "@City = p.city, " +
                "@State = p.state, " +
                "@ZipCode = p.zipCode " +
                "FROM Credential c " +
                "JOIN Nurse n ON c.personId = n.personId " +
                "JOIN Person p ON c.personId = p.personId " +
                "WHERE c.username = @Username";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@Username", username);

                    SqlParameter nurseIdParameter = new SqlParameter("@NurseId", SqlDbType.Int, 1);
                    SqlParameter personIdParameter = new SqlParameter("@PersonId", SqlDbType.Int, 1);
                    SqlParameter lastNameParameter = new SqlParameter("@LastName", SqlDbType.VarChar, 50);
                    SqlParameter firstNameParameter = new SqlParameter("@FirstName", SqlDbType.VarChar, 50);
                    SqlParameter dateOfBirthParameter = new SqlParameter("@DateOfBirth", SqlDbType.DateTime);
                    SqlParameter socialSecurityNumberParameter = new SqlParameter("@SocialSecurityNumber", SqlDbType.VarChar, 11);
                    SqlParameter genderParameter = new SqlParameter("@Gender", SqlDbType.Char, 1);
                    SqlParameter phoneNumberParameter = new SqlParameter("@PhoneNumber", SqlDbType.Char, 20); 
                    SqlParameter addressLine1Parameter = new SqlParameter("@AddressLine1", SqlDbType.VarChar, 100);
                    SqlParameter addressLine2Parameter = new SqlParameter("@AddressLine2", SqlDbType.VarChar, 100);
                    SqlParameter cityParameter = new SqlParameter("@City", SqlDbType.VarChar, 50);
                    SqlParameter stateParameter = new SqlParameter("@State", SqlDbType.Char, 2);
                    SqlParameter zipCodeParameter = new SqlParameter("@ZipCode", SqlDbType.Char, 5);

                    nurseIdParameter.Direction = ParameterDirection.Output;
                    personIdParameter.Direction = ParameterDirection.Output;
                    lastNameParameter.Direction = ParameterDirection.Output;
                    firstNameParameter.Direction = ParameterDirection.Output;
                    dateOfBirthParameter.Direction = ParameterDirection.Output;
                    socialSecurityNumberParameter.Direction = ParameterDirection.Output;
                    genderParameter.Direction = ParameterDirection.Output;
                    phoneNumberParameter.Direction = ParameterDirection.Output;
                    addressLine1Parameter.Direction = ParameterDirection.Output;
                    addressLine2Parameter.Direction = ParameterDirection.Output;
                    cityParameter.Direction = ParameterDirection.Output;
                    stateParameter.Direction = ParameterDirection.Output;
                    zipCodeParameter.Direction = ParameterDirection.Output;

                    selectCommand.Parameters.Add(nurseIdParameter);
                    selectCommand.Parameters.Add(personIdParameter);
                    selectCommand.Parameters.Add(lastNameParameter);
                    selectCommand.Parameters.Add(firstNameParameter);
                    selectCommand.Parameters.Add(dateOfBirthParameter);
                    selectCommand.Parameters.Add(socialSecurityNumberParameter);
                    selectCommand.Parameters.Add(genderParameter);
                    selectCommand.Parameters.Add(phoneNumberParameter);
                    selectCommand.Parameters.Add(addressLine1Parameter);
                    selectCommand.Parameters.Add(addressLine2Parameter);
                    selectCommand.Parameters.Add(cityParameter);
                    selectCommand.Parameters.Add(stateParameter);
                    selectCommand.Parameters.Add(zipCodeParameter);

                    selectCommand.ExecuteNonQuery();

                    if (!nurseIdParameter.Value.Equals(DBNull.Value)) { theNurse.NurseId = int.Parse(nurseIdParameter.Value.ToString()); }
                    if (!personIdParameter.Value.Equals(DBNull.Value)) { theNurse.PersonId = int.Parse(personIdParameter.Value.ToString()); }
                    if (!lastNameParameter.Value.Equals(DBNull.Value)) { theNurse.LastName = lastNameParameter.Value.ToString(); }
                    if (!firstNameParameter.Value.Equals(DBNull.Value)) { theNurse.FirstName = firstNameParameter.Value.ToString(); }
                    if (!dateOfBirthParameter.Value.Equals(DBNull.Value)) { theNurse.DateOfBirth = (DateTime)dateOfBirthParameter.Value; }
                    if (!socialSecurityNumberParameter.Value.Equals(DBNull.Value)) { theNurse.SocialSecurityNumber = socialSecurityNumberParameter.Value.ToString(); }
                    if (!genderParameter.Value.Equals(DBNull.Value)) { theNurse.Gender = genderParameter.Value.ToString(); }
                    if (!phoneNumberParameter.Value.Equals(DBNull.Value)) { theNurse.PhoneNumber = phoneNumberParameter.Value.ToString(); }
                    if (!addressLine1Parameter.Value.Equals(DBNull.Value)) { theNurse.AddressLine1 = addressLine1Parameter.Value.ToString(); }
                    if (!addressLine2Parameter.Value.Equals(DBNull.Value)) { theNurse.AddressLine2 = addressLine2Parameter.Value.ToString(); }
                    if (!cityParameter.Value.Equals(DBNull.Value)) { theNurse.City = cityParameter.Value.ToString(); }
                    if (!stateParameter.Value.Equals(DBNull.Value)) { theNurse.State = stateParameter.Value.ToString(); }
                    if (!zipCodeParameter.Value.Equals(DBNull.Value)) { theNurse.ZipCode = zipCodeParameter.Value.ToString(); }
                }
            }
            return theNurse;
        }

        private Administrator GetAdministrator(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentNullException("username", "The username cannot be null or empty.");
            }

            Administrator theAdministrator = new Administrator();

            string selectStatement =
                "SELECT @AdministratorId = a.administratorId, " +
                "@PersonId = p.personId, " +
                "@LastName = p.lastName, " +
                "@FirstName = p.firstName, " +
                "@DateOfBirth = p.dateOfBirth, " +
                "@SocialSecurityNumber = p.ssn, " +
                "@Gender = p.gender, " +
                "@PhoneNumber = p.phoneNumber, " +
                "@AddressLine1 = p.addressLine1, " +
                "@AddressLine2 = p.addressLine2, " +
                "@City = p.city, " +
                "@State = p.state, " +
                "@ZipCode = p.zipCode " +
                "FROM Credential c " +
                "JOIN Administrator a ON c.personId = a.personId " +
                "JOIN Person p ON c.personId = p.personId " +
                "WHERE c.username = @Username";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@Username", username);

                    SqlParameter administratorIdParameter = new SqlParameter("@AdministratorId", SqlDbType.Int, 1);
                    SqlParameter personIdParameter = new SqlParameter("@PersonId", SqlDbType.Int, 1);
                    SqlParameter lastNameParameter = new SqlParameter("@LastName", SqlDbType.VarChar, 50);
                    SqlParameter firstNameParameter = new SqlParameter("@FirstName", SqlDbType.VarChar, 50);
                    SqlParameter dateOfBirthParameter = new SqlParameter("@DateOfBirth", SqlDbType.DateTime);
                    SqlParameter socialSecurityNumberParameter = new SqlParameter("@SocialSecurityNumber", SqlDbType.VarChar, 11);
                    SqlParameter genderParameter = new SqlParameter("@Gender", SqlDbType.Char, 1);
                    SqlParameter phoneNumberParameter = new SqlParameter("@PhoneNumber", SqlDbType.Char, 20);
                    SqlParameter addressLine1Parameter = new SqlParameter("@AddressLine1", SqlDbType.VarChar, 100);
                    SqlParameter addressLine2Parameter = new SqlParameter("@AddressLine2", SqlDbType.VarChar, 100);
                    SqlParameter cityParameter = new SqlParameter("@City", SqlDbType.VarChar, 50);
                    SqlParameter stateParameter = new SqlParameter("@State", SqlDbType.Char, 2);
                    SqlParameter zipCodeParameter = new SqlParameter("@ZipCode", SqlDbType.Char, 5);

                    administratorIdParameter.Direction = ParameterDirection.Output;
                    personIdParameter.Direction = ParameterDirection.Output;
                    lastNameParameter.Direction = ParameterDirection.Output;
                    firstNameParameter.Direction = ParameterDirection.Output;
                    dateOfBirthParameter.Direction = ParameterDirection.Output;
                    socialSecurityNumberParameter.Direction = ParameterDirection.Output;
                    genderParameter.Direction = ParameterDirection.Output;
                    phoneNumberParameter.Direction = ParameterDirection.Output;
                    addressLine1Parameter.Direction = ParameterDirection.Output;
                    addressLine2Parameter.Direction = ParameterDirection.Output;
                    cityParameter.Direction = ParameterDirection.Output;
                    stateParameter.Direction = ParameterDirection.Output;
                    zipCodeParameter.Direction = ParameterDirection.Output;

                    selectCommand.Parameters.Add(administratorIdParameter);
                    selectCommand.Parameters.Add(personIdParameter);
                    selectCommand.Parameters.Add(lastNameParameter);
                    selectCommand.Parameters.Add(firstNameParameter);
                    selectCommand.Parameters.Add(dateOfBirthParameter);
                    selectCommand.Parameters.Add(socialSecurityNumberParameter);
                    selectCommand.Parameters.Add(genderParameter);
                    selectCommand.Parameters.Add(phoneNumberParameter);
                    selectCommand.Parameters.Add(addressLine1Parameter);
                    selectCommand.Parameters.Add(addressLine2Parameter);
                    selectCommand.Parameters.Add(cityParameter);
                    selectCommand.Parameters.Add(stateParameter);
                    selectCommand.Parameters.Add(zipCodeParameter);

                    selectCommand.ExecuteNonQuery();

                    if (!administratorIdParameter.Value.Equals(DBNull.Value)) { theAdministrator.AdministratorId = int.Parse(administratorIdParameter.Value.ToString()); }
                    if (!personIdParameter.Value.Equals(DBNull.Value)) { theAdministrator.PersonId = int.Parse(personIdParameter.Value.ToString()); }
                    if (!lastNameParameter.Value.Equals(DBNull.Value)) { theAdministrator.LastName = lastNameParameter.Value.ToString(); }
                    if (!firstNameParameter.Value.Equals(DBNull.Value)) { theAdministrator.FirstName = firstNameParameter.Value.ToString(); }
                    if (!dateOfBirthParameter.Value.Equals(DBNull.Value)) { theAdministrator.DateOfBirth = (DateTime)dateOfBirthParameter.Value; }
                    if (!socialSecurityNumberParameter.Value.Equals(DBNull.Value)) { theAdministrator.SocialSecurityNumber = socialSecurityNumberParameter.Value.ToString(); }
                    if (!genderParameter.Value.Equals(DBNull.Value)) { theAdministrator.Gender = genderParameter.Value.ToString(); }
                    if (!phoneNumberParameter.Value.Equals(DBNull.Value)) { theAdministrator.PhoneNumber = phoneNumberParameter.Value.ToString(); }
                    if (!addressLine1Parameter.Value.Equals(DBNull.Value)) { theAdministrator.AddressLine1 = addressLine1Parameter.Value.ToString(); }
                    if (!addressLine2Parameter.Value.Equals(DBNull.Value)) { theAdministrator.AddressLine2 = addressLine2Parameter.Value.ToString(); }
                    if (!cityParameter.Value.Equals(DBNull.Value)) { theAdministrator.City = cityParameter.Value.ToString(); }
                    if (!stateParameter.Value.Equals(DBNull.Value)) { theAdministrator.State = stateParameter.Value.ToString(); }
                    if (!zipCodeParameter.Value.Equals(DBNull.Value)) { theAdministrator.ZipCode = zipCodeParameter.Value.ToString(); }
                }
            }
            return theAdministrator;
        }
    }
}
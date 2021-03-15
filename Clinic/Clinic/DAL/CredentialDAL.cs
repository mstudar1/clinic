using Clinic.Model;
using System;
using System.Data;
using System.Data.SqlClient;

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
        /// <param name="password">The password being checked.</param>
        /// <returns>True if the specified credentials are valid.  False if the specified credentials are invalid.</returns>
        public bool CredentialsAreValid(string username, string password)
        {
            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentNullException("username", "The username cannot be null or empty.");
            }

            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentNullException("password", "The password cannot be null or empty.");
            }

            string selectStatement =
                "SELECT @NumberOfMatchingUsers = COUNT(username) " +
                "FROM Credential " +
                "WHERE username = @Username " +
                "AND password = @Password";

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
                    selectCommand.Parameters.AddWithValue("@Password", password);
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

        private string GetRole(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentNullException("username", "The username cannot be null or empty.");
            }

            string selectStatement =
                "SELECT @Role = role " +
                "FROM Credential " +
                "WHERE username = @Username ";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    SqlParameter roleParameter = new SqlParameter("@Role", SqlDbType.VarChar)
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
                    SqlParameter socialSecurityNumberParameter = new SqlParameter("@SocialSecurityNumber", SqlDbType.VarChar, 50);
                    SqlParameter genderParameter = new SqlParameter("@Gender", SqlDbType.Char, 1);
                    SqlParameter phoneNumberParameter = new SqlParameter("@PhoneNumber", SqlDbType.Char, 10);
                    SqlParameter addressLine1Parameter = new SqlParameter("@AddressLine1", SqlDbType.VarChar, 50);
                    SqlParameter addressLine2Parameter = new SqlParameter("@AddressLine2", SqlDbType.VarChar, 50);
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
    }
}
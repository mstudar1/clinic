using Clinic.DAL;
using Clinic.Model;
using System;

namespace Clinic.Controller
{
    /// <summary>
    /// Class serving as a controller for credential data.
    /// </summary>
    public class CredentialController
    {
        private readonly CredentialDAL credentialSource;

        /// <summary>
        /// Constructor for the CredentialController class.
        /// </summary>
        public CredentialController()
        {
            this.credentialSource = new CredentialDAL();
        }

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

            return this.credentialSource.CredentialsAreValid(username, password);
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

            return this.credentialSource.GetUser(username);
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

            this.credentialSource.AddUser(username, personId, role, unhashedPassword);
        }
    }
}
using Clinic.DAL;
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
    }
}
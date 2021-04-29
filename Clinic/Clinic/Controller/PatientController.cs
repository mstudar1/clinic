using Clinic.DAL;
using Clinic.Model;
using System;
using System.Collections.Generic;

namespace Clinic.Controller
{
    /// <summary>
    /// Class serving as a controller for patients.
    /// </summary>
    public class PatientController
    {
        private readonly PatientDAL patientSource;

        /// <summary>
        /// Constructor for the PatientController class.
        /// </summary>
        public PatientController()
        {
            this.patientSource = new PatientDAL();
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

            this.patientSource.AddPatient(thePatient);
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

            return this.patientSource.EditPatient(originalPatient, revisedPatient);
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

            return this.patientSource.FindPatients(dateOfBirth);
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

            return this.patientSource.FindPatients(lastName, firstName);
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

            return this.patientSource.FindPatients(dateOfBirth, lastName);
        }

        /// <summary>
        /// Method that finds all patients in the database.
        /// </summary>
        /// <returns>A list of patients.</returns>
        public List<Patient> GetPatientsList()
        {
            return this.patientSource.GetPatientsList();
        }

        /// <summary>
        /// Method that deletes the specified patient from the Person and Patient tables in the database.
        /// </summary>
        /// <param name="patientId">The patient ID of the patient being deleted from the database.</param>
        public void DeletePatient(int patientId)
        {
            if (patientId < 0)
            {
                throw new ArgumentNullException("patientId", "The patient ID cannot be negative.");
            }

            //this.patientSource.DeletePatient(patientId);
        }
    }
}
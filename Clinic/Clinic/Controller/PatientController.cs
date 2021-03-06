using Clinic.DAL;
using Clinic.Model;
using System;

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
    }
}
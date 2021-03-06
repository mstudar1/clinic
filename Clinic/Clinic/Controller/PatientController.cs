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
    }
}
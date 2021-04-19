using Clinic.DAL;
using Clinic.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Clinic.Controller
{
    /// <summary>
    /// Class serving as a controller for diagnosis.
    /// </summary>
    public class DiagnosisController
    {
        private readonly DiagnosisDAL diagnosisSource;

        public DiagnosisController()
        {
            this.diagnosisSource = new DiagnosisDAL();
        }

        /// <summary>
        /// Method that can be used to add a diagnosis to the database.
        /// </summary>
        /// <param name="appointmentId">The ID of the appointment.</param>
        /// <param name="diagnosisName">A string describing the diagnosis.</param>
        /// <param name="isFinal">A boolean value indicating if the diagnosis is final.</param>
        public void AddDiagnosis(int appointmentId, string diagnosisName, bool isFinal)
        {
            if (appointmentId < 0)
            {
                throw new ArgumentException("The appointment ID cannot be negative.", "appointmentId");
            }

            if (string.IsNullOrEmpty(diagnosisName))
            {
                throw new ArgumentNullException("diagnosisName", "The diagnosis name cannot be null or empty.");
            }

            this.diagnosisSource.AddDiagnosis(appointmentId, diagnosisName, isFinal);
        }

        /// <summary>
        /// Method that gets all of the diagnoses associated with a specific appointment.
        /// </summary>
        /// <param name="appointmentId">The ID of the appointment.</param>
        /// <returns>A list of diagnoses associated with the appointment.</returns>
        public List<Diagnosis> GetDiagnoses(int appointmentId)
        {
            if (appointmentId < 0)
            {
                throw new ArgumentException("The appointment ID cannot be negative.", "appointmentId");
            }

            return this.diagnosisSource.GetDiagnoses(appointmentId);
        }
    }
}
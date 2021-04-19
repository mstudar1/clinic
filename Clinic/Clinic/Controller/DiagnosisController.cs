﻿using System.Windows.Forms;

namespace Clinic.Controller
{
    /// <summary>
    /// Class serving as a controller for diagnosis.
    /// </summary>
    public class DiagnosisController
    {
        /// <summary>
        /// Method that can be used to add a diagnosis to the database.
        /// </summary>
        /// <param name="appointmentId">The ID of the appointment.</param>
        /// <param name="diagnosisName">A string describing the diagnosis.</param>
        /// <param name="isFinal">A boolean value indicating if the diagnosis is final.</param>
        public void AddDiagnosis(int appointmentId, string diagnosisName, bool isFinal)
        {
            MessageBox.Show("The DiagnosisController#AddDiagnosis method was called.");
        }
    }
}
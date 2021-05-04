using Clinic.DAL;
using Clinic.Model;
using System;
using System.Collections.Generic;

namespace Clinic.Controller
{
    /// <summary>
    /// Class serving as a controller for conducted lab tests.
    /// </summary>
    public class ConductedLabTestController
    {
        private readonly ConductedLabTestDAL conductedLabTestSource;

        /// <summary>
        /// Constructor for the ConductedLabTestController class.
        /// </summary>
        public ConductedLabTestController()
        {
            this.conductedLabTestSource = new ConductedLabTestDAL();
        }

        /// <summary>
        /// Method that orders lab tests.
        /// </summary>
        /// <param name="appointmentId">The ID of the appointment.</param>
        /// <param name="labTest">An object representing the type of test that is being ordered.</param>
        public void OrderLabTest(int appointmentId, LabTest labTest)
        {
            if (appointmentId < 0)
            {
                throw new ArgumentException("The appointment ID cannot be negative.", "appointmentId");
            }

            if (labTest == null)
            {
                throw new ArgumentNullException("labTest", "The lab test cannot be null.");
            }

            this.conductedLabTestSource.OrderLabTest(appointmentId, labTest);
        }

        /// <summary>
        /// Method that adds test results for a lab test that has already been ordered.
        /// </summary>
        /// <param name="appointmentId">The ID of the appointment.</param>
        /// <param name="labTest">An object representing the type of test that is being ordered.</param>
        /// <param name="datePerformed">The date that the test was performed.</param>
        /// <param name="results">A string describing the results of the test.</param>
        /// <param name="isNormal">A bool indicating if the results are normal.</param>
        public void AddLabTestResults(int appointmentId, LabTest labTest, DateTime datePerformed, string results, bool isNormal)
        {
            if (appointmentId < 0)
            {
                throw new ArgumentException("The appointment ID cannot be negative.", "appointmentId");
            }

            if (labTest == null)
            {
                throw new ArgumentNullException("labTest", "The lab test cannot be null.");
            }

            if (datePerformed == null)
            {
                throw new ArgumentNullException("datePerformed", "The date performed cannot be null.");
            }

            if (string.IsNullOrEmpty(results))
            {
                throw new ArgumentNullException("results", "The results cannot be null or empty.");
            }

            this.conductedLabTestSource.AddLabTestResults(appointmentId, labTest, datePerformed, results, isNormal);
        }

        /// <summary>
        /// Method that returns all of the conducted lab tests for the specified appointment.
        /// </summary>
        /// <param name="appointmentId">The ID of the appointment.</param>
        /// <returns>A list of the conducted lab tests for the specified appointment.</returns>
        public List<ConductedLabTest> GetConductedLabTests(int appointmentId)
        {
            if (appointmentId < 0)
            {
                throw new ArgumentException("The appointment ID cannot be negative.", "appointmentId");
            }

            return this.conductedLabTestSource.GetConductedLabTests(appointmentId);
        }
    }
}
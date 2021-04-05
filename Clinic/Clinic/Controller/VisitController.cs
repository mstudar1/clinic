using Clinic.DAL;
using Clinic.Model;
using System;
using System.Collections.Generic;

namespace Clinic.Controller
{
    /// <summary>
    /// Class serving as a controller for visits.
    /// </summary>
    public class VisitController
    {
        private readonly VisitDAL visitSource;

        /// <summary>
        /// Constructor for the VisitController class.
        /// </summary>
        public VisitController()
        {
            this.visitSource = new VisitDAL();
        }

        /// <summary>
        /// Method that adds the specified Visit object to the database.
        /// </summary>
        /// <param name="theVisit">The Visit object being added to the database.</param>
        public void AddVisit(Visit theVisit)
        {
            if (theVisit == null)
            {
                throw new ArgumentNullException("theVisit", "The visit cannot be null.");
            }

            this.visitSource.AddVisit(theVisit);
        }

        /// <summary>
        /// Method that finds all of the visits for the specified patient.
        /// </summary>
        /// <param name="patientId">The ID of the patient.</param>
        /// <returns>A list of Visit objects associated with the specified patient.</returns>
        public List<Visit> FindVisits(int patientId)
        {
            if (patientId < 0)
            {
                throw new ArgumentException("The patient ID cannot be negative.", "patientId");
            }

            return this.visitSource.FindVisits(patientId);
        }

        /// <summary>
        /// Method that finds all of the visits for patients with the specified last name.
        /// </summary>
        /// <param name="lastName">The last name of the patient(s).</param>
        /// <returns>A list of Visit objects associated with the specified patient(s).</returns>
        public List<Visit> FindVisits(string lastName)
        {
            if (string.IsNullOrEmpty(lastName))
            {
                throw new ArgumentNullException("lastName", "The last name cannot be null or empty.");
            }

            return this.visitSource.FindVisits(lastName);
        }
    }
}
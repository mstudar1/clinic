using Clinic.DAL;
using Clinic.Model;
using System;

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
    }
}
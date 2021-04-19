using Clinic.DAL;
using Clinic.Model;
using System.Collections.Generic;

namespace Clinic.Controller
{
    /// <summary>
    /// Class serving as a controller for lab tests.
    /// </summary>
    public class LabTestController
    {
        private readonly LabTestDAL labTestSource;

        public LabTestController()
        {
            this.labTestSource = new LabTestDAL();
        }

        /// <summary>
        /// Method that returns a list of all the LabTest objects in the database.
        /// </summary>
        /// <returns>A list of all the LabTest objects.</returns>
        public List<LabTest> GetAllLabTests()
        {
            return this.labTestSource.GetAllLabTests();
        }
    }
}
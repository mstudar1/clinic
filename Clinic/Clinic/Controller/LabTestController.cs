using Clinic.Model;
using System.Collections.Generic;

namespace Clinic.Controller
{
    /// <summary>
    /// Class serving as a controller for lab tests.
    /// </summary>
    public class LabTestController
    {
        /// <summary>
        /// Method that returns a list of all the LabTest objects in the database.
        /// </summary>
        /// <returns>A list of all the LabTest objects.</returns>
        public List<LabTest> GetAllLabTests()
        {
            List<LabTest> dummyList = new List<LabTest>();

            LabTest firstLabTest = new LabTest
            {
                TestCode = 1,
                Name = "X-ray"
            };
            dummyList.Add(firstLabTest);

            LabTest secondLabTest = new LabTest
            {
                TestCode = 2,
                Name = "MRI"
            };
            dummyList.Add(secondLabTest);

            LabTest thirdLabTest = new LabTest
            {
                TestCode = 3,
                Name = "Strep Test"
            };
            dummyList.Add(thirdLabTest);

            return dummyList;
        }
    }
}
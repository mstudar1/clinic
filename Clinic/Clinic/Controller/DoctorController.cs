using Clinic.DAL;
using Clinic.Model;
using System.Collections.Generic;

namespace Clinic.Controller
{
    /// <summary>
    /// Controller class for managing data flow from DAL to view for Doctor data
    /// </summary>
    class DoctorController       
    {
        private readonly DoctorDAL doctorSource;

        /// <summary>
        /// Constructor for the class
        /// </summary>
        public DoctorController()
        {
            this.doctorSource = new DoctorDAL();
        }

        /// <summary>
        /// Gets a list of all Doctors
        /// </summary>
        /// <returns>List of Doctor objects</returns>
        public List<Doctor> GetAllDoctors()
        {
            return this.doctorSource.GetAllDoctors();
        }
    }
}

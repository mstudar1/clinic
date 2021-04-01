using Clinic.DAL;
using Clinic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return this.doctorSource.getAllDoctors();
        }
    }
}

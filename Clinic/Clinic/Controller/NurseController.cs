﻿using Clinic.DAL;
using Clinic.Model;
using System;

namespace Clinic.Controller
{
    class NurseController
    {
        private readonly NurseDAL nurseSource;

        /// <summary>
        /// Constructor for the PatientController class.
        /// </summary>
        public NurseController()
        {
            this.nurseSource = new NurseDAL();
        }

        /// <summary>
        /// Method that adds the specified Nurse object to the Person and Nurse tables in the database.
        /// </summary>
        /// <param name="thePatient">The Patient object being added to the database.</param>
        public void AddNurse(Nurse theNurse)
        {
            if (theNurse == null)
            {
                throw new ArgumentNullException("theNurse", "The nurse cannot be null.");
            }

            this.nurseSource.AddNurse(theNurse);
        }
    }
}


﻿using Clinic.DAL;
using Clinic.Model;
using System;
using System.Collections.Generic;

namespace Clinic.Controller
{
    /// <summary>
    /// Class serving as a controller for nurses.
    /// </summary>
    public class NurseController
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
        public int AddNurse(Nurse theNurse)
        {
            if (theNurse == null)
            {
                throw new ArgumentNullException("theNurse", "The nurse cannot be null.");
            }

            return this.nurseSource.AddNurse(theNurse);
        }

        /// <summary>
        /// Method that finds all nurses in the database with the specified last name.
        /// </summary>
        /// <param name="lastName">The last name of the nurse(s).</param>
        /// <returns>A list of nurses with the specified last name.</returns>
        public List<Nurse> FindNurses(string lastName)
        {
            if (string.IsNullOrEmpty(lastName))
            {
                throw new ArgumentNullException("lastName", "The last name cannot be null or empty.");
            }

            return this.nurseSource.FindNurses(lastName);
        }

        /// <summary>
        /// Method that gets a list of all nurses.
        /// </summary>
        /// <returns>A list of all the nurses.</returns>
        public List<Nurse> GetAllNurses()
        {
            return this.nurseSource.GetAllNurses();
        }

        /// <summary>
        /// Method that revises a record for a Nurse in the database.
        /// Edits the Person and Nurse tables.
        /// Requires that the record has not been changed since it was retrieved.
        /// </summary>
        /// <param name="originalNurse">The Nurse object that was originally retrieved.</param>
        /// <param name="revisedNurse">A Nurse object with the revised values.</param>
        /// <returns>True if the operation is successful, false otherwise.</returns>
        public bool EditNurse(Nurse originalNurse, Nurse revisedNurse)
        {
            return this.nurseSource.EditNurse(originalNurse, revisedNurse);
        }
    }
}
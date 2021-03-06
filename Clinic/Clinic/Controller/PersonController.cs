using Clinic.DAL;
using Clinic.Model;
using System;

namespace Clinic.Controller
{
    /// <summary>
    /// Class serving as a controller for people.
    /// </summary>
    public class PersonController
    {
        private readonly PersonDAL personSource;

        /// <summary>
        /// Constructor for the PersonController class.
        /// </summary>
        public PersonController()
        {
            this.personSource = new PersonDAL();
        }

        /// <summary>
        /// Class that adds the specified Person object to the database, and returns the ID of the newly created record.
        /// </summary>
        /// <param name="thePerson">The Person object being added to the database.</param>
        /// <returns>The ID of the newly created Person record.</returns>
        public int AddPerson(Person thePerson)
        {
            if (thePerson == null)
            {
                throw new ArgumentNullException("thePerson", "The person cannot be null.");
            }

            return this.personSource.AddPerson(thePerson);
        }
    }
}
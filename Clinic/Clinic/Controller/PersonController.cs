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
        /// Method that adds the specified Person object to the database, and returns the ID of the newly created record.
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

        /// <summary>
        /// Method that revises a record for a person in the database.
        /// Requires that the record has not been changed since it was retrieved.
        /// </summary>
        /// <param name="originalPerson">The Person object that was originally retrieved.</param>
        /// <param name="revisedPerson">A Person object with the revised values.</param>
        /// <returns>True if the operation is successful, false otherwise.</returns>
        public bool EditPerson(Person originalPerson, Person revisedPerson)
        {
            if (originalPerson == null)
            {
                throw new ArgumentNullException("originalPerson", "The original person cannot be null.");
            }

            if (revisedPerson == null)
            {
                throw new ArgumentNullException("revisedPerson", "The revised person cannot be null.");
            }

            if (originalPerson.PersonId != revisedPerson.PersonId)
            {
                throw new ArgumentException("The ID must be the same for both Person objects.");
            }

            return this.personSource.EditPerson(originalPerson, revisedPerson);
        }
    }
}
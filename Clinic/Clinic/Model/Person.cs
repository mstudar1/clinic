using System;

namespace Clinic.Model
{
    /// <summary>
    /// Class representing a person.
    /// </summary>
    public class Person
    {
        public int PersonId { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string SocialSecurityNumber { get; set; }

        public string Gender { get; set; }

        public string PhoneNumber { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        /// <summary>
        /// Constructor for Peron objects
        /// </summary>
        /// <param name="personId">the person ID (should be retrieved from DB)</param>
        /// <param name="lastName">Last Name</param>
        /// <param name="firstName">First Name</param>
        /// <param name="dob">Date of Birth</param>
        /// <param name="ssn">Social Security Number</param>
        /// <param name="gender">Gender</param>
        /// <param name="phone">10 digit phone number</param>
        /// <param name="address1">Address line 1</param>
        /// <param name="address2">Address line 2</param>
        /// <param name="city">City</param>
        /// <param name="state">State</param>
        /// <param name="zip">Zip Code</param>
        public Person(
            int personId,
            string lastName,
            string firstName,
            DateTime dob,
            string ssn,
            string gender,
            string phone,
            string address1,
            string address2,
            string city,
            string state,
            string zip
            )
        {
            if (personId < 0)
                throw new ArgumentException("PersonID must be a positive integer");
            if (string.IsNullOrEmpty(lastName))
                throw new ArgumentException("Last name cannot be empty");
            if (string.IsNullOrEmpty(firstName))
                throw new ArgumentException("Last name cannot be empty");
            if (dob == null)
                throw new ArgumentException("Date of birth cannot be null");
            if (string.IsNullOrEmpty(ssn))
                throw new ArgumentException("Social security number cannot be empty");
            if (string.IsNullOrEmpty(gender))
                throw new ArgumentException("Gender cannot be empty");
            if (string.IsNullOrEmpty(phone))
                throw new ArgumentException("Phone number cannot be empty");
            if (string.IsNullOrEmpty(address1))
                throw new ArgumentException("Address 1 cannot be empty");
            if (string.IsNullOrEmpty(city))
                throw new ArgumentException("City cannot be empty");
            if (string.IsNullOrEmpty(state))
                throw new ArgumentException("State cannot be empty");
            if (string.IsNullOrEmpty(zip))
                throw new ArgumentException("Zip code cannot be empty");

            this.PersonId = personId;
            this.LastName = lastName;
            this.FirstName = firstName;
            this.DateOfBirth = dob;
            this.SocialSecurityNumber = ssn;
            this.Gender = gender;
            this.PhoneNumber = phone;
            this.AddressLine1 = address1;
            this.AddressLine2 = address2;
            this.City = city;
            this.State = state;
            this.ZipCode = zip;
        }
    }
}
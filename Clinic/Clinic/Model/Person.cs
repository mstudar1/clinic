using System;

namespace Clinic.Model
{
    /// <summary>
    /// Class representing a person.
    /// </summary>
    public class Person
    {
        private string socialSecurityNumber;
        private string gender;
        private string phoneNumber;

        public int PersonId { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string SocialSecurityNumber
        {
            get
            {
                return socialSecurityNumber;
            }
            set
            {
                if (!IsValidSocialSecurityNumber(value))
                {
                    throw new ArgumentException("The specified social security number is not formatted properly.  A format of ###-##-#### must be used.");
                }
                socialSecurityNumber = value;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                if (!IsValidGender(value))
                {
                    throw new ArgumentException("The specified gender is not formatted properly.  'M' and 'F' are the only two characters that are allowed.");
                }
                gender = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                if (!IsValidPhoneNumber(value))
                {
                    throw new ArgumentException("The specified phone number is not formatted properly.  A format of (###) ###-#### must be used.");
                }
            }
        }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        private bool IsValidSocialSecurityNumber(string socialSecurityNumber)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(socialSecurityNumber, @"^\d{3}-\d{2}-\d{4}$");
        }

        private bool IsValidGender(string gender)
        {
            return gender.Equals("M") || gender.Equals("F");
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"^\(\d{3}\)\s\d{3}-\d{4}$");
        }
    }
}
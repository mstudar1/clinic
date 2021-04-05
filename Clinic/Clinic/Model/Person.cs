using System;

namespace Clinic.Model
{
    /// <summary>
    /// Class representing a person.
    /// </summary>
    public class Person
    {
        private string firstName;
        private string lastName;
        private string socialSecurityNumber;
        private string gender;
        private string phoneNumber;
        private string city;
        private string state;
        private string zipCode;

        public int PersonId { get; set; }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (!IsValidName(value))
                {
                    throw new ArgumentException("Names must begin with a capital letter.");
                }
                lastName = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (!IsValidName(value))
                {
                    throw new ArgumentException("Names must begin with a capital letter.");
                }
                firstName = value;
            }
        }

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
                phoneNumber = value;
            }
        }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string City
        {
            get
            {
                return city;
            }
            set
            {
                if (!IsValidCity(value))
                {
                    throw new ArgumentException("The specified city is not formatted properly.  The first character must be capitalized.");
                }
                city = value;
            }
        }

        public string State
        {
            get
            {
                return state;
            }
            set
            {
                if (!IsValidState(value))
                {
                    throw new ArgumentException("The state is not formatted properly.  Only two character postal abbreviations are allowed (all caps).");
                }
                state = value;
            }
        }

        public string ZipCode
        {
            get
            {
                return zipCode;
            }
            set
            {
                if (!IsValidZipCode(value))
                {
                    throw new ArgumentException("The zip code is not formatted properly.  Five digits are required.");
                }
                zipCode = value;
            }
        }

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
            return System.Text.RegularExpressions.Regex.IsMatch(phoneNumber.Trim(), @"^\(\d{3}\)\s\d{3}-\d{4}$");
        }

        private bool IsValidCity(string city)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(city, @"^[A-Z]");
        }

        private bool IsValidState(string state)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(state, @"^[A-Z]{2}$");
        }

        private bool IsValidZipCode(string zipCode)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(zipCode, @"^\d{5}$");
        }

        private bool IsValidName(string name)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(name, @"^[A-Z]");
        }
    }
}
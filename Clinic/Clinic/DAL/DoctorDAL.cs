using Clinic.Model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Clinic.DAL
{
    /// <summary>
    /// This class will provide methods for data access for the Doctor table
    /// </summary>
    class DoctorDAL
    {
        private readonly PersonDAL thePersonDAL;

        /// <summary>
        /// Constructor for the DoctorDAL class
        /// </summary>
        public DoctorDAL()
        {
            this.thePersonDAL = new PersonDAL();
        }

        /// <summary>
        /// Method that returns a list of all the doctors.
        /// </summary>
        /// <returns>A list of all the doctors.</returns>
        public List<Doctor> GetAllDoctors()
        {
            List<Doctor> doctorList = new List<Doctor>();

            string selectStatement =
                "SELECT Doctor.doctorId, " +
                    "Doctor.personId, " +
                    "Person.lastName, " +
                    "Person.firstName, " +
                    "Person.dateOfBirth, " +
                    "Person.ssn, " +
                    "Person.gender, " +
                    "Person.phoneNumber, " +
                    "Person.addressLine1, " +
                    "Person.addressLine2, " +
                    "Person.city, " +
                    "Person.state, " +
                    "Person.zipCode " +
                "FROM Doctor " +
                    "LEFT JOIN Person ON Doctor.personId = Person.personId ";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        int personIdOrdinal = reader.GetOrdinal("personId");
                        int doctorIdOrdinal = reader.GetOrdinal("doctorId");
                        int lastNameOrdinal = reader.GetOrdinal("lastName");
                        int firstNameOrdinal = reader.GetOrdinal("firstName");
                        int dateOfBirthOrdinal = reader.GetOrdinal("dateOfBirth");
                        int ssnOrdinal = reader.GetOrdinal("ssn");
                        int genderOrdinal = reader.GetOrdinal("gender");
                        int phoneNumberOrdinal = reader.GetOrdinal("phoneNumber");
                        int addressLine1Ordinal = reader.GetOrdinal("addressLine1");
                        int addressLine2Ordinal = reader.GetOrdinal("addressLine2");
                        int cityOrdinal = reader.GetOrdinal("city");
                        int stateOrdinal = reader.GetOrdinal("state");
                        int zipCodeOrdinal = reader.GetOrdinal("zipCode");
                        while (reader.Read())
                        {
                            Doctor theDoctor = new Doctor();
                            if (!reader.IsDBNull(personIdOrdinal)) { theDoctor.PersonId = reader.GetInt32(personIdOrdinal); }
                            if (!reader.IsDBNull(doctorIdOrdinal)) { theDoctor.DoctorId = reader.GetInt32(doctorIdOrdinal); }
                            if (!reader.IsDBNull(lastNameOrdinal)) { theDoctor.LastName = reader.GetString(lastNameOrdinal); }
                            if (!reader.IsDBNull(firstNameOrdinal)) { theDoctor.FirstName = reader.GetString(firstNameOrdinal); }
                            if (!reader.IsDBNull(dateOfBirthOrdinal)) { theDoctor.DateOfBirth = reader.GetDateTime(dateOfBirthOrdinal); }
                            if (!reader.IsDBNull(ssnOrdinal)) { theDoctor.SocialSecurityNumber = reader.GetString(ssnOrdinal); }
                            if (!reader.IsDBNull(genderOrdinal)) { theDoctor.Gender = reader.GetString(genderOrdinal); }
                            if (!reader.IsDBNull(phoneNumberOrdinal)) { theDoctor.PhoneNumber = reader.GetString(phoneNumberOrdinal); }
                            if (!reader.IsDBNull(addressLine1Ordinal)) { theDoctor.AddressLine1 = reader.GetString(addressLine1Ordinal); }
                            if (!reader.IsDBNull(addressLine2Ordinal)) { theDoctor.AddressLine2 = reader.GetString(addressLine2Ordinal); }
                            if (!reader.IsDBNull(cityOrdinal)) { theDoctor.City = reader.GetString(cityOrdinal); }
                            if (!reader.IsDBNull(stateOrdinal)) { theDoctor.State = reader.GetString(stateOrdinal); }
                            if (!reader.IsDBNull(zipCodeOrdinal)) { theDoctor.ZipCode = reader.GetString(zipCodeOrdinal); }
                            doctorList.Add(theDoctor);
                        }
                    }
                }
            }
            return doctorList;
        }
    }
}

using Clinic.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Clinic.DAL
{
    /// <summary>
    /// Class for accessing visit information in the Clinic database.
    /// </summary>
    public class VisitDAL
    {
        /// <summary>
        /// Method that adds the specified Visit object to the database.
        /// </summary>
        /// <param name="theVisit">The Visit object being added to the database.</param>
        public void AddVisit(Visit theVisit)
        {
            if (theVisit == null)
            {
                throw new ArgumentNullException("theVisit", "The visit cannot be null.");
            }

            string insertStatement =
                "INSERT Visit (appointmentId, weight, systolicBloodPressure, diastolicBloodPressure, bodyTemperature, pulse, symptoms, nurseId) " +
                "VALUES (@AppointmentId, @Weight, @SystolicBloodPressure, @DiastolicBloodPressure, @BodyTemperature, @Pulse, @Symptoms, @NurseId)";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@AppointmentId", theVisit.AppointmentId);
                    insertCommand.Parameters.AddWithValue("@Weight", theVisit.Weight);
                    insertCommand.Parameters.AddWithValue("@SystolicBloodPressure", theVisit.SystolicBloodPressure);
                    insertCommand.Parameters.AddWithValue("@DiastolicBloodPressure", theVisit.DiastolicBloodPressure);
                    insertCommand.Parameters.AddWithValue("@BodyTemperature", theVisit.BodyTemperature);
                    insertCommand.Parameters.AddWithValue("@Pulse", theVisit.Pulse);
                    insertCommand.Parameters.AddWithValue("@Symptoms", theVisit.Symptoms);
                    insertCommand.Parameters.AddWithValue("@NurseId", theVisit.NurseId);
                    insertCommand.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Method that finds all of the visits for the specified patient.
        /// </summary>
        /// <param name="patientId">The ID of the patient.</param>
        /// <returns>A list of Visit objects associated with the specified patient.</returns>
        public List<Visit> FindVisits(int patientId)
        {
            if (patientId < 0)
            {
                throw new ArgumentException("The patient ID cannot be negative.", "patientId");
            }

            List<Visit> visitList = new List<Visit>();

            string selectStatement =
                "SELECT v.appointmentId, v.nurseId, v.weight, v.pulse, v.systolicBloodPressure, v.diastolicBloodPressure, v.bodyTemperature, v.symptoms, " +
                    "a.startDateTime, " +
                    "patInfo.firstName AS patientFirstName, patInfo.lastName AS patientLastName, patInfo.dateOfBirth AS patientDateOfBirth, " +
                    "docInfo.firstName AS doctorFirstName, docInfo.lastName AS doctorLastName, " +
                    "nurseInfo.firstName AS nurseFirstName, nurseInfo.lastName AS nurseLastName " +
                "FROM Visit v " +
                    "JOIN Appointment a ON v.appointmentId = a.appointmentId " +
                    "JOIN Patient pat ON a.patientId = pat.patientId " +
                    "JOIN Doctor doc ON a.doctorId = doc.doctorId " +
                    "JOIN Nurse nurse ON v.nurseId = nurse.nurseId " +
                    "JOIN Person patInfo ON pat.personId = patInfo.personId " +
                    "JOIN Person docInfo ON doc.personId = docInfo.personId " +
                    "JOIN Person nurseInfo ON nurse.nurseId = nurseInfo.personId " +
                "WHERE a.patientId = @PatientId " +
                "ORDER BY a.startDateTime ASC";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@PatientId", patientId);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        int appointmentIdOrdinal = reader.GetOrdinal("appointmentId");
                        int nurseIdOrdinal = reader.GetOrdinal("nurseId");
                        int weightOrdinal = reader.GetOrdinal("weight");
                        int pulseOrdinal = reader.GetOrdinal("pulse");
                        int systolicBloodPressureOrdinal = reader.GetOrdinal("systolicBloodPressure");
                        int diastolicBloodPressureOrdinal = reader.GetOrdinal("diastolicBloodPressure");
                        int bodyTemperatureOrdinal = reader.GetOrdinal("bodyTemperature");
                        int symptomsOrdinal = reader.GetOrdinal("symptoms");
                        int dateOrdinal = reader.GetOrdinal("startDateTime");
                        int patientFirstNameOrdinal = reader.GetOrdinal("patientFirstName");
                        int patientLastNameOrdinal = reader.GetOrdinal("patientLastName");
                        int patientDateOfBirthOrdinal = reader.GetOrdinal("patientDateOfBirth");
                        int doctorFirstNameOrdinal = reader.GetOrdinal("doctorFirstName");
                        int doctorLastNameOrdinal = reader.GetOrdinal("doctorLastName");
                        int nurseFirstNameOrdinal = reader.GetOrdinal("nurseFirstName");
                        int nurseLastNameOrdinal = reader.GetOrdinal("nurseLastName");
                        
                        while (reader.Read())
                        {
                            Visit theVisit = new Visit();
                            if (!reader.IsDBNull(appointmentIdOrdinal)) { theVisit.AppointmentId = reader.GetInt32(appointmentIdOrdinal); }
                            if (!reader.IsDBNull(nurseIdOrdinal)) { theVisit.NurseId = reader.GetInt32(nurseIdOrdinal); }
                            if (!reader.IsDBNull(weightOrdinal)) { theVisit.Weight = (double)reader.GetDecimal(weightOrdinal); }
                            if (!reader.IsDBNull(pulseOrdinal)) { theVisit.Pulse = reader.GetInt32(pulseOrdinal); }
                            if (!reader.IsDBNull(systolicBloodPressureOrdinal)) { theVisit.SystolicBloodPressure = reader.GetInt32(systolicBloodPressureOrdinal); }
                            if (!reader.IsDBNull(diastolicBloodPressureOrdinal)) { theVisit.DiastolicBloodPressure = reader.GetInt32(diastolicBloodPressureOrdinal); }
                            if (!reader.IsDBNull(bodyTemperatureOrdinal)) { theVisit.BodyTemperature = (double)reader.GetDecimal(bodyTemperatureOrdinal); }
                            if (!reader.IsDBNull(symptomsOrdinal)) { theVisit.Symptoms = reader.GetString(symptomsOrdinal); }
                            if (!reader.IsDBNull(dateOrdinal)) { theVisit.VisitDate = reader.GetDateTime(dateOrdinal); }
                            if (!reader.IsDBNull(patientFirstNameOrdinal)) { theVisit.PatientFirstName = reader.GetString(patientFirstNameOrdinal); }
                            if (!reader.IsDBNull(patientLastNameOrdinal)) { theVisit.PatientLastName = reader.GetString(patientLastNameOrdinal); }
                            if (!reader.IsDBNull(patientDateOfBirthOrdinal)) { theVisit.PatientDateOfBirth = reader.GetDateTime(patientDateOfBirthOrdinal); }
                            if (!reader.IsDBNull(doctorFirstNameOrdinal)) { theVisit.DoctorFirstName = reader.GetString(doctorFirstNameOrdinal); }
                            if (!reader.IsDBNull(doctorLastNameOrdinal)) { theVisit.DoctorLastName = reader.GetString(doctorLastNameOrdinal); }
                            if (!reader.IsDBNull(nurseFirstNameOrdinal)) { theVisit.NurseFirstName = reader.GetString(nurseFirstNameOrdinal); }
                            if (!reader.IsDBNull(nurseLastNameOrdinal)) { theVisit.NurseLastName = reader.GetString(nurseLastNameOrdinal); }
                            visitList.Add(theVisit);
                        }
                    }
                }
            }
            return visitList;
        }

        /// <summary>
        /// Method that finds all of the visits for patients with the specified last name.
        /// </summary>
        /// <param name="lastName">The last name of the patient(s).</param>
        /// <returns>A list of Visit objects associated with the specified patient(s).</returns>
        public List<Visit> FindVisits(string lastName)
        {
            if (string.IsNullOrEmpty(lastName))
            {
                throw new ArgumentNullException("lastName", "The last name cannot be null or empty.");
            }

            List<Visit> visitList = new List<Visit>();

            string selectStatement =
                "SELECT v.appointmentId, v.nurseId, v.weight, v.pulse, v.systolicBloodPressure, v.diastolicBloodPressure, v.bodyTemperature, v.symptoms, " +
                    "a.startDateTime, " +
                    "patInfo.firstName AS patientFirstName, patInfo.lastName AS patientLastName, patInfo.dateOfBirth AS patientDateOfBirth, " +
                    "docInfo.firstName AS doctorFirstName, docInfo.lastName AS doctorLastName, " +
                    "nurseInfo.firstName AS nurseFirstName, nurseInfo.lastName AS nurseLastName " +
                "FROM Visit v " +
                    "JOIN Appointment a ON v.appointmentId = a.appointmentId " +
                    "JOIN Patient pat ON a.patientId = pat.patientId " +
                    "JOIN Doctor doc ON a.doctorId = doc.doctorId " +
                    "JOIN Nurse nurse ON v.nurseId = nurse.nurseId " +
                    "JOIN Person patInfo ON pat.personId = patInfo.personId " +
                    "JOIN Person docInfo ON doc.personId = docInfo.personId " +
                    "JOIN Person nurseInfo ON nurse.nurseId = nurseInfo.personId " +
                "WHERE patInfo.lastName = @LastName " +
                "ORDER BY a.startDateTime ASC";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@LastName", lastName);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        int appointmentIdOrdinal = reader.GetOrdinal("appointmentId");
                        int nurseIdOrdinal = reader.GetOrdinal("nurseId");
                        int weightOrdinal = reader.GetOrdinal("weight");
                        int pulseOrdinal = reader.GetOrdinal("pulse");
                        int systolicBloodPressureOrdinal = reader.GetOrdinal("systolicBloodPressure");
                        int diastolicBloodPressureOrdinal = reader.GetOrdinal("diastolicBloodPressure");
                        int bodyTemperatureOrdinal = reader.GetOrdinal("bodyTemperature");
                        int symptomsOrdinal = reader.GetOrdinal("symptoms");
                        int dateOrdinal = reader.GetOrdinal("startDateTime");
                        int patientFirstNameOrdinal = reader.GetOrdinal("patientFirstName");
                        int patientLastNameOrdinal = reader.GetOrdinal("patientLastName");
                        int patientDateOfBirthOrdinal = reader.GetOrdinal("patientDateOfBirth");
                        int doctorFirstNameOrdinal = reader.GetOrdinal("doctorFirstName");
                        int doctorLastNameOrdinal = reader.GetOrdinal("doctorLastName");
                        int nurseFirstNameOrdinal = reader.GetOrdinal("nurseFirstName");
                        int nurseLastNameOrdinal = reader.GetOrdinal("nurseLastName");

                        while (reader.Read())
                        {
                            Visit theVisit = new Visit();
                            if (!reader.IsDBNull(appointmentIdOrdinal)) { theVisit.AppointmentId = reader.GetInt32(appointmentIdOrdinal); }
                            if (!reader.IsDBNull(nurseIdOrdinal)) { theVisit.NurseId = reader.GetInt32(nurseIdOrdinal); }
                            if (!reader.IsDBNull(weightOrdinal)) { theVisit.Weight = (double)reader.GetDecimal(weightOrdinal); }
                            if (!reader.IsDBNull(pulseOrdinal)) { theVisit.Pulse = reader.GetInt32(pulseOrdinal); }
                            if (!reader.IsDBNull(systolicBloodPressureOrdinal)) { theVisit.SystolicBloodPressure = reader.GetInt32(systolicBloodPressureOrdinal); }
                            if (!reader.IsDBNull(diastolicBloodPressureOrdinal)) { theVisit.DiastolicBloodPressure = reader.GetInt32(diastolicBloodPressureOrdinal); }
                            if (!reader.IsDBNull(bodyTemperatureOrdinal)) { theVisit.BodyTemperature = (double)reader.GetDecimal(bodyTemperatureOrdinal); }
                            if (!reader.IsDBNull(symptomsOrdinal)) { theVisit.Symptoms = reader.GetString(symptomsOrdinal); }
                            if (!reader.IsDBNull(dateOrdinal)) { theVisit.VisitDate = reader.GetDateTime(dateOrdinal); }
                            if (!reader.IsDBNull(patientFirstNameOrdinal)) { theVisit.PatientFirstName = reader.GetString(patientFirstNameOrdinal); }
                            if (!reader.IsDBNull(patientLastNameOrdinal)) { theVisit.PatientLastName = reader.GetString(patientLastNameOrdinal); }
                            if (!reader.IsDBNull(patientDateOfBirthOrdinal)) { theVisit.PatientDateOfBirth = reader.GetDateTime(patientDateOfBirthOrdinal); }
                            if (!reader.IsDBNull(doctorFirstNameOrdinal)) { theVisit.DoctorFirstName = reader.GetString(doctorFirstNameOrdinal); }
                            if (!reader.IsDBNull(doctorLastNameOrdinal)) { theVisit.DoctorLastName = reader.GetString(doctorLastNameOrdinal); }
                            if (!reader.IsDBNull(nurseFirstNameOrdinal)) { theVisit.NurseFirstName = reader.GetString(nurseFirstNameOrdinal); }
                            if (!reader.IsDBNull(nurseLastNameOrdinal)) { theVisit.NurseLastName = reader.GetString(nurseLastNameOrdinal); }
                            visitList.Add(theVisit);
                        }
                    }
                }
            }
            return visitList;
        }

        /// <summary>
        /// Method that finds all of the visits on the specified date.
        /// </summary>
        /// <param name="visitDate">The visit date to search for.</param>
        /// <returns>A list of Visit objects associated with the specified patient(s).</returns>
        public List<Visit> FindVisits(DateTime visitDate)
        {
            if (visitDate == null)
            {
                throw new ArgumentNullException("visitDate", "The visit date cannot be null or empty.");
            }

            List<Visit> visitList = new List<Visit>();

            string selectStatement =
                "SELECT v.appointmentId, v.nurseId, v.weight, v.pulse, v.systolicBloodPressure, v.diastolicBloodPressure, v.bodyTemperature, v.symptoms, " +
                    "a.startDateTime, " +
                    "patInfo.firstName AS patientFirstName, patInfo.lastName AS patientLastName, patInfo.dateOfBirth AS patientDateOfBirth, " +
                    "docInfo.firstName AS doctorFirstName, docInfo.lastName AS doctorLastName, " +
                    "nurseInfo.firstName AS nurseFirstName, nurseInfo.lastName AS nurseLastName " +
                "FROM Visit v " +
                    "JOIN Appointment a ON v.appointmentId = a.appointmentId " +
                    "JOIN Patient pat ON a.patientId = pat.patientId " +
                    "JOIN Doctor doc ON a.doctorId = doc.doctorId " +
                    "JOIN Nurse nurse ON v.nurseId = nurse.nurseId " +
                    "JOIN Person patInfo ON pat.personId = patInfo.personId " +
                    "JOIN Person docInfo ON doc.personId = docInfo.personId " +
                    "JOIN Person nurseInfo ON nurse.nurseId = nurseInfo.personId " +
                "WHERE a.startDateTime = @VisitDate " +
                "ORDER BY a.startDateTime ASC";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@VisitDate", visitDate);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        int appointmentIdOrdinal = reader.GetOrdinal("appointmentId");
                        int nurseIdOrdinal = reader.GetOrdinal("nurseId");
                        int weightOrdinal = reader.GetOrdinal("weight");
                        int pulseOrdinal = reader.GetOrdinal("pulse");
                        int systolicBloodPressureOrdinal = reader.GetOrdinal("systolicBloodPressure");
                        int diastolicBloodPressureOrdinal = reader.GetOrdinal("diastolicBloodPressure");
                        int bodyTemperatureOrdinal = reader.GetOrdinal("bodyTemperature");
                        int symptomsOrdinal = reader.GetOrdinal("symptoms");
                        int dateOrdinal = reader.GetOrdinal("startDateTime");
                        int patientFirstNameOrdinal = reader.GetOrdinal("patientFirstName");
                        int patientLastNameOrdinal = reader.GetOrdinal("patientLastName");
                        int patientDateOfBirthOrdinal = reader.GetOrdinal("patientDateOfBirth");
                        int doctorFirstNameOrdinal = reader.GetOrdinal("doctorFirstName");
                        int doctorLastNameOrdinal = reader.GetOrdinal("doctorLastName");
                        int nurseFirstNameOrdinal = reader.GetOrdinal("nurseFirstName");
                        int nurseLastNameOrdinal = reader.GetOrdinal("nurseLastName");

                        while (reader.Read())
                        {
                            Visit theVisit = new Visit();
                            if (!reader.IsDBNull(appointmentIdOrdinal)) { theVisit.AppointmentId = reader.GetInt32(appointmentIdOrdinal); }
                            if (!reader.IsDBNull(nurseIdOrdinal)) { theVisit.NurseId = reader.GetInt32(nurseIdOrdinal); }
                            if (!reader.IsDBNull(weightOrdinal)) { theVisit.Weight = (double)reader.GetDecimal(weightOrdinal); }
                            if (!reader.IsDBNull(pulseOrdinal)) { theVisit.Pulse = reader.GetInt32(pulseOrdinal); }
                            if (!reader.IsDBNull(systolicBloodPressureOrdinal)) { theVisit.SystolicBloodPressure = reader.GetInt32(systolicBloodPressureOrdinal); }
                            if (!reader.IsDBNull(diastolicBloodPressureOrdinal)) { theVisit.DiastolicBloodPressure = reader.GetInt32(diastolicBloodPressureOrdinal); }
                            if (!reader.IsDBNull(bodyTemperatureOrdinal)) { theVisit.BodyTemperature = (double)reader.GetDecimal(bodyTemperatureOrdinal); }
                            if (!reader.IsDBNull(symptomsOrdinal)) { theVisit.Symptoms = reader.GetString(symptomsOrdinal); }
                            if (!reader.IsDBNull(dateOrdinal)) { theVisit.VisitDate = reader.GetDateTime(dateOrdinal); }
                            if (!reader.IsDBNull(patientFirstNameOrdinal)) { theVisit.PatientFirstName = reader.GetString(patientFirstNameOrdinal); }
                            if (!reader.IsDBNull(patientLastNameOrdinal)) { theVisit.PatientLastName = reader.GetString(patientLastNameOrdinal); }
                            if (!reader.IsDBNull(patientDateOfBirthOrdinal)) { theVisit.PatientDateOfBirth = reader.GetDateTime(patientDateOfBirthOrdinal); }
                            if (!reader.IsDBNull(doctorFirstNameOrdinal)) { theVisit.DoctorFirstName = reader.GetString(doctorFirstNameOrdinal); }
                            if (!reader.IsDBNull(doctorLastNameOrdinal)) { theVisit.DoctorLastName = reader.GetString(doctorLastNameOrdinal); }
                            if (!reader.IsDBNull(nurseFirstNameOrdinal)) { theVisit.NurseFirstName = reader.GetString(nurseFirstNameOrdinal); }
                            if (!reader.IsDBNull(nurseLastNameOrdinal)) { theVisit.NurseLastName = reader.GetString(nurseLastNameOrdinal); }
                            visitList.Add(theVisit);
                        }
                    }
                }
            }
            return visitList;
        }

        /// <summary>
        /// Method that determines if a visit has been entered in to the DB.
        /// </summary>
        /// <param name="appointmentId">The ID of the appointment.</param>
        /// <returns>true if there is a visit in the DB matching the appointment ID</returns>
        public bool IsVisitPresent(int appointmentId)
        {
            if (appointmentId < 0)
            {
                throw new ArgumentException("The appointment ID cannot be negative.");
            }

            string selectStatement =
                "SELECT @NumberOfVisits = COUNT(appointmentId) " +
                "FROM Visit " +
                "WHERE appointmentId = @AppointmentId ";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    SqlParameter countParameter = new SqlParameter("@NumberOfVisits", SqlDbType.Int, 1)
                    {
                        Direction = ParameterDirection.Output
                    };
                    selectCommand.Parameters.Add(countParameter);
                    selectCommand.Parameters.AddWithValue("@AppointmentId", appointmentId);
                    selectCommand.ExecuteNonQuery();

                    return (Convert.ToInt32(countParameter.Value) > 0);
                }
            }
        }
    }
}
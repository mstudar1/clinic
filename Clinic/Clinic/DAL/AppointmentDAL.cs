using Clinic.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Clinic.DAL
{
    /// <summary>
    /// Class for accessing appointment information in the Clinic database.
    /// </summary>
    public class AppointmentDAL
    {
        private readonly VisitDAL visitSource;

        /// <summary>
        /// Constructor for the AppointmentDAL class.
        /// </summary>
        public AppointmentDAL()
        {
            this.visitSource = new VisitDAL();
        }

        /// <summary>
        /// Method that adds the specified Appointment object to the database.
        /// </summary>
        /// <param name="theAppointment">The Appointment object being added to the database.</param>
        public void AddAppointment(Appointment theAppointment)
        {
            if (theAppointment == null)
            {
                throw new ArgumentNullException("theAppointment", "The appointment cannot be null.");
            }

            string insertStatement =
                "INSERT Appointment (patientId, startDateTime, doctorId, reasonForVisit) " +
                "VALUES (@PatientId, @StartDateTime, @DoctorId, @ReasonForVisit)";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@PatientId", theAppointment.PatientId);
                    insertCommand.Parameters.AddWithValue("@StartDateTime", theAppointment.StartDateTime);
                    insertCommand.Parameters.AddWithValue("@DoctorId", theAppointment.DoctorId);
                    insertCommand.Parameters.AddWithValue("@ReasonForVisit", theAppointment.ReasonForVisit);
                    insertCommand.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Method that returns true if the specified doctor is unavailable at the specified start time
        /// assuming appointments are structured such that only start time is needed to confirm no overlap.
        /// </summary>
        /// <param name="doctorId">The ID of the doctor in question.</param>
        /// <param name="startDateTime">The date and time of the appointment in question.</param>
        /// <returns>True if the specified doctor is booked at the specified time, false otherwise.</returns>
        public bool DoctorIsBooked(int doctorId, DateTime startDateTime)
        {
            if (doctorId < 0)
            {
                throw new ArgumentException("The doctor's ID cannot be negative.", "doctorId");
            }
            if (startDateTime == null)
            {
                throw new ArgumentNullException("startDateTime", "The start date and time of the appointment cannot be null.");
            }

            string selectStatement =
                "SELECT @NumberOfAppointments = COUNT(appointmentId) " +
                "FROM Appointment " +
                "WHERE doctorId = @DoctorId " +
                    "AND startDateTime = @StartDateTime";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    SqlParameter countParameter = new SqlParameter("@NumberOfAppointments", SqlDbType.Int, 1)
                    {
                        Direction = ParameterDirection.Output
                    };
                    selectCommand.Parameters.Add(countParameter);
                    selectCommand.Parameters.AddWithValue("@DoctorId", doctorId);
                    selectCommand.Parameters.AddWithValue("@StartDateTime", startDateTime);
                    selectCommand.ExecuteNonQuery();
                    return (Convert.ToInt32(countParameter.Value) > 0);
                }
            }
        }

        /// <summary>
        /// Method that returns true if the specified doctor is unavailable at the specified time.  This method
        /// includes a check to prevent a false positive for an appointment overlapping itself when being edited.
        /// This also assumes that appointment time structure is such that start time is sufficient to check for appointment
        /// overlaps (i.e. all appointments are 30 minutes long and start on hour or half hour).
        /// </summary>
        /// <param name="originalAppointment">original appointment object</param>
        /// <param name="revisedAppointment">revised appointment object</param>
        /// <returns>True if doctor is booked for a different patient during the revised time slot</returns>
        public bool DoctorIsBookedForAppointmentEdit(Appointment originalAppointment, Appointment revisedAppointment)
        {
            if (originalAppointment == null)
            {
                throw new ArgumentNullException("originalAppointment", "The original appointment cannot be null.");
            }
            if (revisedAppointment == null)
            {
                throw new ArgumentNullException("revisedAppointment", "The revised appointment cannot be null.");
            }
            if (revisedAppointment.StartDateTime == null)
            {
                throw new ArgumentNullException("revisedAppointment", "The start date and time of the revised appointment cannot be null.");
            }
            if (originalAppointment.StartDateTime == null)
            {
                throw new ArgumentNullException("originalAppointment", "The start date and time of the original appointment cannot be null.");
            }

            string selectStatement =
                "SELECT @NumberOfAppointments = COUNT(appointmentId) " +
                "FROM Appointment " +
                "WHERE doctorId = @DoctorId " +
                    "AND startDateTime = @StartDateTime " +
                    "AND patientId != @PatientId";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    SqlParameter countParameter = new SqlParameter("@NumberOfAppointments", SqlDbType.Int, 1)
                    {
                        Direction = ParameterDirection.Output
                    };
                    selectCommand.Parameters.Add(countParameter);
                    selectCommand.Parameters.AddWithValue("@DoctorId", revisedAppointment.DoctorId);
                    selectCommand.Parameters.AddWithValue("@PatientId", revisedAppointment.PatientId);
                    selectCommand.Parameters.AddWithValue("@StartDateTime", revisedAppointment.StartDateTime);
                    selectCommand.ExecuteNonQuery();
                    return (Convert.ToInt32(countParameter.Value) > 0);
                }
            }
        }

        /// <summary>
        /// Method that revises a record for an appointment in the database.
        /// Requires that the record has not been changed since it was retrieved.
        /// </summary>
        /// <param name="originalAppointment">The Appointment object that was originally retrieved.</param>
        /// <param name="revisedAppointment">The Appointment object with the revised values.</param>
        /// <returns>True if the operation is successful, false otherwise.</returns>
        public bool EditAppointment(Appointment originalAppointment, Appointment revisedAppointment)
        {
            if (originalAppointment == null)
            {
                throw new ArgumentNullException("originalAppointment", "The original appointment cannot be null.");
            }

            if (revisedAppointment == null)
            {
                throw new ArgumentNullException("revisedAppointment", "The revised appointment cannot be null.");
            }

            string updateStatement =
                "UPDATE Appointment SET " +
                    "patientId = @RevisedPatientId, " +
                    "startDateTime = @RevisedStartDateTime, " +
                    "doctorId = @RevisedDoctorId, " +
                    "reasonForVisit = @RevisedReasonForVisit " +
                "WHERE patientId = @OriginalPatientId " +
                    "AND startDateTime = @OriginalStartDatetime " +
                    "AND doctorId = @OriginalDoctorId " +
                    "AND reasonForVisit = @OriginalReasonForVisit";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                {
                    updateCommand.Parameters.AddWithValue("@OriginalPatientId", originalAppointment.PatientId);
                    updateCommand.Parameters.AddWithValue("@OriginalStartDateTime", originalAppointment.StartDateTime);
                    updateCommand.Parameters.AddWithValue("@OriginalDoctorId", originalAppointment.DoctorId);
                    updateCommand.Parameters.AddWithValue("@OriginalReasonForVisit", originalAppointment.ReasonForVisit);
                    updateCommand.Parameters.AddWithValue("@RevisedPatientId", revisedAppointment.PatientId);
                    updateCommand.Parameters.AddWithValue("@RevisedStartDatetime", revisedAppointment.StartDateTime);
                    updateCommand.Parameters.AddWithValue("@RevisedDoctorId", revisedAppointment.DoctorId);
                    updateCommand.Parameters.AddWithValue("@RevisedReasonForVisit", revisedAppointment.ReasonForVisit);
                    int count = updateCommand.ExecuteNonQuery();
                    return (count > 0); 
                }
            }
        }

        /// <summary>
        /// Method that returns a list of all appointments for the specified patient.
        /// </summary>
        /// <param name="patientId">The ID of the patient being searched for.</param>
        /// <returns>A list of all appointments for the specified patient.</returns>
        public List<Appointment> FindAppointments(int patientId)
        {
            if (patientId < 0)
            {
                throw new ArgumentException("The patient ID cannot be negative.", "patientId");
            }

            List<Appointment> appointmentList = new List<Appointment>();

            string selectStatement =
                "SELECT " +
                    "appointmentId, " +
                    "startDateTime, " +
                    "endDateTime, " +
                    "a.doctorId AS doctorId, " +
                    "reasonForVisit, " +
                    "a.patientId AS patientId, " +
                    "docInfo.firstName AS doctorFirstName, " +
                    "docInfo.lastName AS doctorLastName, " +
                    "patInfo.firstName AS patientFirstName, " +
                    "patInfo.lastName AS patientLastName " +
                "FROM Appointment a " +
                "LEFT JOIN Doctor doc ON a.doctorId = doc.doctorId " +
                "LEFT JOIN Patient pat ON a.patientId = pat.patientId " +
                "LEFT JOIN Person docInfo ON doc.personId = docInfo.personId " +
                "LEFT JOIN Person patInfo ON pat.personId = patInfo.personId " +
                "WHERE a.patientId = @PatientId " +
                "ORDER BY startDateTime ASC"; 
            

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@PatientId", patientId);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        int appointmentIdOrdinal = reader.GetOrdinal("appointmentId");
                        int startDateTimeOrdinal = reader.GetOrdinal("startDateTime");
                        int endDateTimeOrdinal = reader.GetOrdinal("endDateTime");
                        int doctorIdOrdinal = reader.GetOrdinal("doctorId");
                        int doctorfirstNameOrdinal = reader.GetOrdinal("doctorFirstName");
                        int doctorlastNameOrdinal = reader.GetOrdinal("doctorLastName");
                        int reasonForVisitOrdinal = reader.GetOrdinal("reasonForVisit");
                        int patientIdOrdinal = reader.GetOrdinal("patientId");
                        int patientfirstNameOrdinal = reader.GetOrdinal("patientFirstName");
                        int patientlastNameOrdinal = reader.GetOrdinal("patientLastName");
                        while (reader.Read())
                        {
                            Appointment theAppointment = new Appointment();
                            if (!reader.IsDBNull(appointmentIdOrdinal)) { theAppointment.AppointmentId = reader.GetInt32(appointmentIdOrdinal); }
                            if (!reader.IsDBNull(startDateTimeOrdinal)) { theAppointment.StartDateTime = reader.GetDateTime(startDateTimeOrdinal); }
                            if (!reader.IsDBNull(endDateTimeOrdinal)) { theAppointment.EndDateTime = reader.GetDateTime(endDateTimeOrdinal); }
                            if (!reader.IsDBNull(doctorIdOrdinal)) { theAppointment.DoctorId = reader.GetInt32(doctorIdOrdinal); }
                            if (!reader.IsDBNull(doctorfirstNameOrdinal)) { theAppointment.DoctorFirstName = reader.GetString(doctorfirstNameOrdinal); }
                            if (!reader.IsDBNull(doctorlastNameOrdinal)) { theAppointment.DoctorLastName = reader.GetString(doctorlastNameOrdinal); }
                            if (!reader.IsDBNull(reasonForVisitOrdinal)) { theAppointment.ReasonForVisit = reader.GetString(reasonForVisitOrdinal); }
                            if (!reader.IsDBNull(patientIdOrdinal)) { theAppointment.PatientId = reader.GetInt32(patientIdOrdinal); }
                            if (!reader.IsDBNull(patientfirstNameOrdinal)) { theAppointment.PatientFirstName = reader.GetString(patientfirstNameOrdinal); }
                            if (!reader.IsDBNull(patientlastNameOrdinal)) { theAppointment.PatientLastName = reader.GetString(patientlastNameOrdinal); }
                            appointmentList.Add(theAppointment);

                        }
                    }
                }
            }
            return appointmentList;
        }

        /// <summary>
        /// Gets a list of appointments that have been made for the specified date
        /// </summary>
        /// <param name="date">the date for the appointments</param>
        /// <returns>List of Appointment objects</returns>
        public List<Appointment> GetAppointmentsOnDate(DateTime date)
        {
            if (date == null)
            {
                throw new ArgumentNullException("date", "The date cannot be null.");
            }
            List<Appointment> appointmentList = new List<Appointment>();

            string selectStatement =
                "SELECT " +
                    "appointmentId, " +
                    "startDateTime, " +
                    "a.doctorId AS doctorId, " +
                    "reasonForVisit, " +
                    "a.patientId AS patientId, " +
                    "docInfo.firstName AS doctorFirstName, " +
                    "docInfo.lastName AS doctorLastName, " +
                    "patInfo.firstName AS patientFirstName, " +
                    "patInfo.lastName AS patientLastName, " +
                    "patInfo.dateOfBirth AS patientDateOfBirth " +
                "FROM Appointment a " +
                "LEFT JOIN Doctor doc ON a.doctorId = doc.doctorId " +
                "LEFT JOIN Patient pat ON a.patientId = pat.patientId " +
                "LEFT JOIN Person docInfo ON doc.personId = docInfo.personId " +
                "LEFT JOIN Person patInfo ON pat.personId = patInfo.personId " +
                "WHERE datediff(day, startDateTime, @searchDate) = 0  " +
                "ORDER BY startDateTime ASC";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@searchDate", date);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        int appointmentIdOrdinal = reader.GetOrdinal("appointmentId");
                        int startDateTimeOrdinal = reader.GetOrdinal("startDateTime");
                        int doctorIdOrdinal = reader.GetOrdinal("doctorId");
                        int doctorfirstNameOrdinal = reader.GetOrdinal("doctorFirstName");
                        int doctorlastNameOrdinal = reader.GetOrdinal("doctorLastName");
                        int reasonForVisitOrdinal = reader.GetOrdinal("reasonForVisit");
                        int patientIdOrdinal = reader.GetOrdinal("patientId");
                        int patientfirstNameOrdinal = reader.GetOrdinal("patientFirstName");
                        int patientlastNameOrdinal = reader.GetOrdinal("patientLastName");
                        int patientDateOfBirthOrdinal = reader.GetOrdinal("patientDateOfBirth");
                        while (reader.Read())
                        {
                            Appointment theAppointment = new Appointment();
                            if (!reader.IsDBNull(appointmentIdOrdinal)) { theAppointment.AppointmentId = reader.GetInt32(appointmentIdOrdinal); }
                            if (!reader.IsDBNull(startDateTimeOrdinal)) { theAppointment.StartDateTime = reader.GetDateTime(startDateTimeOrdinal); }
                            if (!reader.IsDBNull(doctorIdOrdinal)) { theAppointment.DoctorId = reader.GetInt32(doctorIdOrdinal); }
                            if (!reader.IsDBNull(doctorfirstNameOrdinal)) { theAppointment.DoctorFirstName = reader.GetString(doctorfirstNameOrdinal); }
                            if (!reader.IsDBNull(doctorlastNameOrdinal)) { theAppointment.DoctorLastName = reader.GetString(doctorlastNameOrdinal); }
                            if (!reader.IsDBNull(reasonForVisitOrdinal)) { theAppointment.ReasonForVisit = reader.GetString(reasonForVisitOrdinal); }
                            if (!reader.IsDBNull(patientIdOrdinal)) { theAppointment.PatientId = reader.GetInt32(patientIdOrdinal); }
                            if (!reader.IsDBNull(patientfirstNameOrdinal)) { theAppointment.PatientFirstName = reader.GetString(patientfirstNameOrdinal); }
                            if (!reader.IsDBNull(patientlastNameOrdinal)) { theAppointment.PatientLastName = reader.GetString(patientlastNameOrdinal); }
                            if (!reader.IsDBNull(patientDateOfBirthOrdinal)) { theAppointment.PatientDateOfBirth = reader.GetDateTime(patientDateOfBirthOrdinal); }
                            appointmentList.Add(theAppointment);
                        }
                    }
                }
            }
            return appointmentList;
        }

        /// <summary>
        /// Get a list of Appointment objects with last name and date of birth 
        /// matching the seach name and DOB
        /// </summary>
        /// <param name="lastName">the last name to search for</param>
        /// <param name="dob">the date of birth to search for</param>
        /// <returns>List of Appointment objects</returns>
        public List<Appointment> GetAppointmentsForPatientLastNameAndDOB(String lastName, DateTime dob)
        {
            if (lastName == null || lastName == "")
            {
                throw new ArgumentException("lastName", "Last name for search cannot be empty");
            }
            if (dob == null)
            {
                throw new ArgumentNullException("date", "The date cannot be null.");
            }
            List<Appointment> appointmentList = new List<Appointment>();

            string selectStatement =
                "SELECT " +
                    "appointmentId, " +
                    "startDateTime, " +
                    "a.doctorId AS doctorId, " +
                    "reasonForVisit, " +
                    "a.patientId AS patientId, " +
                    "docInfo.firstName AS doctorFirstName, " +
                    "docInfo.lastName AS doctorLastName, " +
                    "patInfo.firstName AS patientFirstName, " +
                    "patInfo.lastName AS patientLastName, " +
                    "patInfo.dateOfBirth AS patientDateOfBirth " +
                "FROM Appointment a " +
                "LEFT JOIN Doctor doc ON a.doctorId = doc.doctorId " +
                "LEFT JOIN Patient pat ON a.patientId = pat.patientId " +
                "LEFT JOIN Person docInfo ON doc.personId = docInfo.personId " +
                "LEFT JOIN Person patInfo ON pat.personId = patInfo.personId " +
                "WHERE patInfo.lastName = @searchName  " +
                    "AND datediff(day, patInfo.dateOfBirth, @searchDOB) = 0 " +
                "ORDER BY startDateTime ASC";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {                   
                    selectCommand.Parameters.AddWithValue("@searchName", lastName);
                    selectCommand.Parameters.AddWithValue("@searchDOB", dob);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        int appointmentIdOrdinal = reader.GetOrdinal("appointmentId");
                        int startDateTimeOrdinal = reader.GetOrdinal("startDateTime");
                        int doctorIdOrdinal = reader.GetOrdinal("doctorId");
                        int doctorfirstNameOrdinal = reader.GetOrdinal("doctorFirstName");
                        int doctorlastNameOrdinal = reader.GetOrdinal("doctorLastName");
                        int reasonForVisitOrdinal = reader.GetOrdinal("reasonForVisit");
                        int patientIdOrdinal = reader.GetOrdinal("patientId");
                        int patientfirstNameOrdinal = reader.GetOrdinal("patientFirstName");
                        int patientlastNameOrdinal = reader.GetOrdinal("patientLastName");
                        int patientDateOfBirthOrdinal = reader.GetOrdinal("patientDateOfBirth");
                        while (reader.Read())
                        {
                            Appointment theAppointment = new Appointment();
                            if (!reader.IsDBNull(appointmentIdOrdinal)) { theAppointment.AppointmentId = reader.GetInt32(appointmentIdOrdinal); }
                            if (!reader.IsDBNull(startDateTimeOrdinal)) { theAppointment.StartDateTime = reader.GetDateTime(startDateTimeOrdinal); }
                            if (!reader.IsDBNull(doctorIdOrdinal)) { theAppointment.DoctorId = reader.GetInt32(doctorIdOrdinal); }
                            if (!reader.IsDBNull(doctorfirstNameOrdinal)) { theAppointment.DoctorFirstName = reader.GetString(doctorfirstNameOrdinal); }
                            if (!reader.IsDBNull(doctorlastNameOrdinal)) { theAppointment.DoctorLastName = reader.GetString(doctorlastNameOrdinal); }
                            if (!reader.IsDBNull(reasonForVisitOrdinal)) { theAppointment.ReasonForVisit = reader.GetString(reasonForVisitOrdinal); }
                            if (!reader.IsDBNull(patientIdOrdinal)) { theAppointment.PatientId = reader.GetInt32(patientIdOrdinal); }
                            if (!reader.IsDBNull(patientfirstNameOrdinal)) { theAppointment.PatientFirstName = reader.GetString(patientfirstNameOrdinal); }
                            if (!reader.IsDBNull(patientlastNameOrdinal)) { theAppointment.PatientLastName = reader.GetString(patientlastNameOrdinal); }
                            if (!reader.IsDBNull(patientDateOfBirthOrdinal)) { theAppointment.PatientDateOfBirth = reader.GetDateTime(patientDateOfBirthOrdinal); }
                            appointmentList.Add(theAppointment);
                        }
                    }
                }
            }
            return appointmentList;
        }


        /// <summary>
        /// Gets a list of appointments that have been made for the specified date for a specified doctor
        /// </summary>
        /// <param name="date">the date for the appointments</param>
        /// <param name="doctorId">the doctorId for the appointments</param>
        /// <returns>List of Appointment objects</returns>
        public List<Appointment> GetAppointmentsForDoctorOnDate(int doctorId, DateTime date)
        {
            if (date == null)
            {
                throw new ArgumentNullException("date", "The date cannot be null.");
            }
            List<Appointment> appointmentList = new List<Appointment>();

            string selectStatement =
                "SELECT startDateTime, endDateTime, doctorId, reasonForVisit " +
                "FROM Appointment " +
                "WHERE datediff(day, startDateTime, @searchDate) = 0  " +
                "AND doctorId = @doctorId " +
                "ORDER BY startDateTime ASC";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@searchDate", date);
                    selectCommand.Parameters.AddWithValue("@doctorId", doctorId);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        int startDateTimeOrdinal = reader.GetOrdinal("startDateTime");
                        int endDateTimeOrdinal = reader.GetOrdinal("endDateTime");
                        int doctorIdOrdinal = reader.GetOrdinal("doctorId");
                        int reasonForVisitOrdinal = reader.GetOrdinal("reasonForVisit");
                        while (reader.Read())
                        {
                            Appointment theAppointment = new Appointment();
                            if (!reader.IsDBNull(startDateTimeOrdinal)) { theAppointment.StartDateTime = reader.GetDateTime(startDateTimeOrdinal); }
                            if (!reader.IsDBNull(endDateTimeOrdinal)) { theAppointment.EndDateTime = reader.GetDateTime(endDateTimeOrdinal); }
                            if (!reader.IsDBNull(doctorIdOrdinal)) { theAppointment.DoctorId = reader.GetInt32(doctorIdOrdinal); }
                            if (!reader.IsDBNull(reasonForVisitOrdinal)) { theAppointment.ReasonForVisit = reader.GetString(reasonForVisitOrdinal); }
                            appointmentList.Add(theAppointment);
                        }
                    }
                }
            }
            return appointmentList;
        }

        /// <summary>
        /// Retrieves an Appointment object matching the appoitnmentId
        /// </summary>
        /// <param name="appointmentId">The Id of the appointment</param>
        /// <returns>Appointment object matching the id</returns>
        public Appointment GetAppointment(int appointmentId)
        {
            if (appointmentId < 0)
            {
                throw new ArgumentException("The appointment ID cannot be negative.", "appointmentId");
            }

            Appointment theAppointment = new Appointment();

            string selectStatement =
                "SELECT " +
                    "appointmentId, " +
                    "startDateTime, " +
                    "endDateTime, " +
                    "a.doctorId AS doctorId, " +
                    "reasonForVisit, " +
                    "a.patientId AS patientId, " +
                    "docInfo.firstName AS doctorFirstName, " +
                    "docInfo.lastName AS doctorLastName, " +
                    "patInfo.firstName AS patientFirstName, " +
                    "patInfo.lastName AS patientLastName " +
                "FROM Appointment a " +
                "LEFT JOIN Doctor doc ON a.doctorId = doc.doctorId " +
                "LEFT JOIN Patient pat ON a.patientId = pat.patientId " +
                "LEFT JOIN Person docInfo ON doc.personId = docInfo.personId " +
                "LEFT JOIN Person patInfo ON pat.personId = patInfo.personId " +
                "WHERE a.appointmentId = @AppointmentId";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@AppointmentId", appointmentId);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        int appointmentIdOrdinal = reader.GetOrdinal("appointmentId");
                        int startDateTimeOrdinal = reader.GetOrdinal("startDateTime");
                        int endDateTimeOrdinal = reader.GetOrdinal("endDateTime");
                        int doctorIdOrdinal = reader.GetOrdinal("doctorId");
                        int doctorfirstNameOrdinal = reader.GetOrdinal("doctorFirstName");
                        int doctorlastNameOrdinal = reader.GetOrdinal("doctorLastName");
                        int reasonForVisitOrdinal = reader.GetOrdinal("reasonForVisit");
                        int patientIdOrdinal = reader.GetOrdinal("patientId");
                        int patientfirstNameOrdinal = reader.GetOrdinal("patientFirstName");
                        int patientlastNameOrdinal = reader.GetOrdinal("patientLastName");
                        while (reader.Read())
                        {
                            
                            if (!reader.IsDBNull(appointmentIdOrdinal)) { theAppointment.AppointmentId = reader.GetInt32(appointmentIdOrdinal); }
                            if (!reader.IsDBNull(startDateTimeOrdinal)) { theAppointment.StartDateTime = reader.GetDateTime(startDateTimeOrdinal); }
                            if (!reader.IsDBNull(endDateTimeOrdinal)) { theAppointment.EndDateTime = reader.GetDateTime(endDateTimeOrdinal); }
                            if (!reader.IsDBNull(doctorIdOrdinal)) { theAppointment.DoctorId = reader.GetInt32(doctorIdOrdinal); }
                            if (!reader.IsDBNull(doctorfirstNameOrdinal)) { theAppointment.DoctorFirstName = reader.GetString(doctorfirstNameOrdinal); }
                            if (!reader.IsDBNull(doctorlastNameOrdinal)) { theAppointment.DoctorLastName = reader.GetString(doctorlastNameOrdinal); }
                            if (!reader.IsDBNull(reasonForVisitOrdinal)) { theAppointment.ReasonForVisit = reader.GetString(reasonForVisitOrdinal); }
                            if (!reader.IsDBNull(patientIdOrdinal)) { theAppointment.PatientId = reader.GetInt32(patientIdOrdinal); }
                            if (!reader.IsDBNull(patientfirstNameOrdinal)) { theAppointment.PatientFirstName = reader.GetString(patientfirstNameOrdinal); }
                            if (!reader.IsDBNull(patientlastNameOrdinal)) { theAppointment.PatientLastName = reader.GetString(patientlastNameOrdinal); }
                        }
                    }
                }
            }
            return theAppointment;
        }

        /// <summary>
        /// Method that deletes the specified appointment from the database.
        /// </summary>
        /// <param name="appointmentId">The ID of the appointment being deleted from the database.</param>
        public void DeleteAppointment(int appointmentId)
        {
            if (appointmentId < 0)
            {
                throw new ArgumentException("The appointment ID cannot be negative.", "appointmentId");
            }

            if (this.visitSource.IsVisitPresent(appointmentId))
            {
                throw new ArgumentException("The specified appointment already has a visit associated with it; therefore, it cannot be deleted.", "appointmentId");
            }

            string deleteStatement =
                "DELETE FROM Appointment " +
                "WHERE appointmentId = @AppointmentId";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@AppointmentId", appointmentId);
                    deleteCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
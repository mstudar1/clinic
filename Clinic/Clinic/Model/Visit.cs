using System;

namespace Clinic.Model
{
    /// <summary>
    /// Class representing a visit.
    /// </summary>
    public class Visit
    {
        public int AppointmentId { get; set; }

        public double Weight { get; set; }

        public int SystolicBloodPressure { get; set; }
        
        public int DiastolicBloodPressure { get; set; }

        public double BodyTemperature { get; set; }

        public int Pulse { get; set; }

        public string Symptoms { get; set; }

        public int NurseId { get; set; }

        public string PatientFirstName { get; set; }

        public string PatientLastName { get; set; }

        public string DoctorFirstName { get; set; }

        public string DoctorLastName { get; set; }

        public string NurseFirstName { get; set; }

        public string NurseLastName { get; set; }

        public DateTime PatientDateOfBirth { get; set; }

        public DateTime VisitDate { get; set; }

        public string PatientFullName
        {
            get
            {
                return PatientFirstName + " " + PatientLastName;
            }
        }

        public string DoctorFullName
        {
            get
            {
                return DoctorFirstName + " " + DoctorLastName;
            }
        }

        public string NurseFullName
        {
            get
            {
                return NurseFirstName + " " + NurseLastName;
            }
        }
    }
}
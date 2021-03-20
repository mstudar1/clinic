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
    }
}
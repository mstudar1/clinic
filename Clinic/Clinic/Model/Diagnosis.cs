namespace Clinic.Model
{
    /// <summary>
    /// Class representing a diagnosis.
    /// </summary>
    public class Diagnosis
    {
        public int AppointmentId { get; set; }

        public string DiagnosisName { get; set; }

        public bool IsFinal { get; set; }
    }
}
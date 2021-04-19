using System;

namespace Clinic.Model
{
    /// <summary>
    /// Class representing a conducted lab test.
    /// </summary>
    public class ConductedLabTest
    {
        public int AppointmentId { get; set; }

        public LabTest LabTest { get; set; }

        public DateTime DatePerformed { get; set; }

        public string Results { get; set; }

        public bool IsNormal { get; set; }
    }
}
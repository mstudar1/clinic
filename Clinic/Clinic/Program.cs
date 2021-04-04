using Clinic.Model;
using Clinic.View;
using System;
using System.Windows.Forms;

namespace Clinic
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LoginForm());

            // the temporary block of code shown below is for launching the add visit form directly
            Appointment testAppointment = new Appointment
            {
                AppointmentId = 1,
                PatientFirstName = "Tom",
                PatientLastName = "Cat",
                DoctorFirstName = "Bugs",
                DoctorLastName = "Bunny",
                StartDateTime = new DateTime(2021, 4, 15, 8, 30, 0)
            };
            Application.Run(new AddVisitForm(testAppointment));
        }
    }
}

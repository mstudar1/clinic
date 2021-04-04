using Clinic.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic.View
{
    /// <summary>
    /// This class will create the edit appointment form
    /// </summary>
    public partial class EditAppointmentForm : Form
    {
        private Appointment theAppointment;

        /// <summary>
        /// Constructor for the edit appointment form
        /// </summary>
        /// <param name="theAppointment">The appointment to be edited</param>
        public EditAppointmentForm(Appointment theAppointment)
        {
            InitializeComponent();
            if (theAppointment == null)
            {
                throw new ArgumentNullException("theAppointment", "Appointment cannot be null for this form");
            }
            this.theAppointment = theAppointment;
        }

        private void EditAppointmentForm_Load(object sender, EventArgs e)
        {
            this.searchPatientFirstNameTextBox.Text = this.theAppointment.PatientFirstName;
            this.searchPatientLastNameTextBox.Text = this.theAppointment.PatientLastName;
            this.datePicker.Value = this.theAppointment.StartDateTime;
            this.reasonTextBox.Text = this.theAppointment.ReasonForVisit;
        }
    }
}

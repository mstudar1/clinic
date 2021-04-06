using Clinic.Controller;
using Clinic.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Clinic.View
{
    public partial class AddVisitForm : Form
    {
        private readonly Appointment theAppointment;
        private readonly VisitController theVisitController;
        private readonly NurseController theNurseController;

        public AddVisitForm(Appointment theAppointment)
        {
            InitializeComponent();
            this.theAppointment = theAppointment ?? throw new ArgumentNullException("theAppointment", "The appointment object cannot be null.");
            this.theVisitController = new VisitController();
            this.theNurseController = new NurseController();
        }

        private void AddVisitForm_Load(object sender, EventArgs e)
        {
            List<Nurse> nurseList = this.theNurseController.GetAllNurses();
            this.nurseComboBox.DataSource = nurseList;
            this.appointmentBindingSource.Add(theAppointment);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                Visit theVisit = new Visit
                {
                    AppointmentId = this.theAppointment.AppointmentId,
                    NurseId = int.Parse(this.nurseComboBox.SelectedValue.ToString()),
                    Weight = double.Parse(this.weightTextBox.Text),
                    Pulse = int.Parse(this.weightTextBox.Text),
                    SystolicBloodPressure = int.Parse(this.systolicBloodPressureTextBox.Text),
                    DiastolicBloodPressure = int.Parse(this.diastolicBloodPressureTextBox.Text),
                    BodyTemperature = double.Parse(this.bodyTemperatureTextBox.Text),
                    Symptoms = this.symptomsTextBox.Text
                };
                this.theVisitController.AddVisit(theVisit);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error.  " + ex.Message, "Error");
            }
        }

        /// <summary>
        /// Handle cancel button clicks by opening a yes/no dialog box and acting accordingly.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            string message = "Any information entered int his form will be lost.  " +
                "Are you sure you want to cancel entering the visit information?";
            string title = "Cancel Entering Visit Details";
            var selectedOption = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (selectedOption == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

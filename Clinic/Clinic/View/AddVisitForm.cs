using Clinic.Controller;
using Clinic.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Clinic.View
{
    /// <summary>
    /// This class sets up and manages the add new visit form
    /// </summary>
    public partial class AddVisitForm : Form
    {
        private readonly Appointment theAppointment;
        private readonly VisitController theVisitController;
        private readonly NurseController theNurseController;

        /// <summary>
        /// Constructor for the form
        /// </summary>
        /// <param name="theAppointment">the Appointment object for the visit</param>
        public AddVisitForm(Appointment theAppointment)
        {
            InitializeComponent();
            this.theAppointment = theAppointment ?? throw new ArgumentNullException("theAppointment", "The appointment object cannot be null.");
            this.theVisitController = new VisitController();
            this.theNurseController = new NurseController();
        }

        /// <summary>
        /// Setting up the form fields and combo boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddVisitForm_Load(object sender, EventArgs e)
        {
            Console.WriteLine("TESTING COUNT = " + this.theVisitController.FindVisits(this.theAppointment.PatientId).Count); //TODO: Remove
            Console.WriteLine("TESTING PATIENT ID = " + this.theAppointment.PatientId); //TODO: Remove
            Console.WriteLine("TESTING APPOINTMENT ID = " + this.theAppointment.AppointmentId); //TOSO: Remove
            this.CheckIfDupe();
            this.PopulateNurseComboBox();
        }

        /// <summary>
        /// Populate the nurse combo box with nurse names from the DB
        /// </summary>
        private void PopulateNurseComboBox()
        {
            List<Nurse> nurseList = this.theNurseController.GetAllNurses();
            this.nurseComboBox.DataSource = nurseList;
            this.appointmentBindingSource.Add(theAppointment);
        }

        /// <summary>
        /// Checks to see if there is already Visit in the DB for this Appointment.
        /// If so then a message is presented and the form is closed.  
        /// No editing is available at this time.
        /// </summary>
        private void CheckIfDupe()
        {
            if (this.theVisitController.IsVisitPresent(this.theAppointment.AppointmentId))
            {
                string title = "Visit Already Created";
                string message = "The selected appointment already has a visit associated with it.  " +
                    "Visit information cannot be edited.";
                var selectedOption = MessageBox.Show(message, title, MessageBoxButtons.OK);
                if (selectedOption == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        /// <summary>
        /// Button click handler which creates new visit in DB with information 
        /// from the form and handles exceptions as needed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                Visit theVisit = new Visit
                {
                    AppointmentId = this.theAppointment.AppointmentId,
                    NurseId = int.Parse(this.nurseComboBox.SelectedValue.ToString()),
                    Weight = double.Parse(this.weightTextBox.Text),
                    Pulse = int.Parse(this.pulseTextBox.Text),
                    SystolicBloodPressure = int.Parse(this.systolicBloodPressureTextBox.Text),
                    DiastolicBloodPressure = int.Parse(this.diastolicBloodPressureTextBox.Text),
                    BodyTemperature = double.Parse(this.bodyTemperatureTextBox.Text),
                    Symptoms = this.symptomsTextBox.Text
                };
                this.theVisitController.AddVisit(theVisit);
                string title = "Success";
                string message = "Visit details successfully recorded.";
                var selectedOption = MessageBox.Show(message, title, MessageBoxButtons.OK);
                if (selectedOption == DialogResult.OK)
                {
                    this.Close();
                }
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
            string message = "Any information entered in this form will be lost.  " +
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

using Clinic.Controller;
using Clinic.Model;
using System;
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
        private readonly Nurse currentUser;
        private double weight;
        private int pulse;
        private int systolicBloodPressure;
        private int diastolicBloodPressure;
        private double bodyTemperature;
        private string symptoms;

        /// <summary>
        /// Constructor for the form
        /// </summary>
        /// <param name="theAppointment">the Appointment object for the visit</param>
        public AddVisitForm(Appointment theAppointment, Nurse currentUser)
        {
            InitializeComponent();
            this.theAppointment = theAppointment ?? throw new ArgumentNullException("theAppointment", "The appointment object cannot be null.");
            this.currentUser = currentUser ?? throw new ArgumentNullException("currentUser", "The user object cannot be null.");
            this.theVisitController = new VisitController();
        }

        /// <summary>
        /// Setting up the form fields and combo boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddVisitForm_Load(object sender, EventArgs e)
        {
            this.CheckIfDupe();
            this.appointmentBindingSource.Add(this.theAppointment);
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

        private bool AllInputsAreValid()
        {
            bool allInputsAreValid = true;

            bool weightIsValid = double.TryParse(this.weightTextBox.Text, out this.weight);
            if (!weightIsValid)
            {
                this.weightValidationLabel.Text = "The weight must be a valid number.";
                allInputsAreValid = false;
            }

            bool pulseIsValid = int.TryParse(this.pulseTextBox.Text, out this.pulse);
            if (!pulseIsValid)
            {
                this.pulseValidationLabel.Text = "The pulse must be a valid integer.";
                allInputsAreValid = false;
            }

            bool systolicBloodPressureIsValid = int.TryParse(this.systolicBloodPressureTextBox.Text, out this.systolicBloodPressure);
            if (!systolicBloodPressureIsValid)
            {
                this.systolicBloodPressureValidationLabel.Text = "The systolic blood pressure must be a valid integer.";
                allInputsAreValid = false;
            }

            bool diastolicBloodPressureIsValid = int.TryParse(this.diastolicBloodPressureTextBox.Text, out this.diastolicBloodPressure);
            if (!diastolicBloodPressureIsValid)
            {
                this.diastolicBloodPressureValidationLabel.Text = "The diastolic blood pressure must be a valid integer.";
                allInputsAreValid = false;
            }

            bool bodyTemperatureIsValid = double.TryParse(this.bodyTemperatureTextBox.Text, out this.bodyTemperature);
            if (!bodyTemperatureIsValid)
            {
                this.bodyTemperatureValidationLabel.Text = "The body temperature must be a valid number.";
                allInputsAreValid = false;
            }

            bool symptomsAreValid = !string.IsNullOrWhiteSpace(this.symptomsTextBox.Text);
            if (!symptomsAreValid)
            {
                this.symptomsValidationLabel.Text = "The symptoms field cannot be empty.";
                allInputsAreValid = false;
            }

            return allInputsAreValid;
        }

        private void ResetValidationLabels()
        {
            this.weightValidationLabel.Text = "";
            this.pulseValidationLabel.Text = "";
            this.systolicBloodPressureValidationLabel.Text = "";
            this.diastolicBloodPressureValidationLabel.Text = "";
            this.bodyTemperatureValidationLabel.Text = "";
            this.symptomsValidationLabel.Text = "";
        }

        /// <summary>
        /// Button click handler which creates new visit in DB with information 
        /// from the form and handles exceptions as needed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!AllInputsAreValid())
            {
                return;
            }

            try
            {
                Visit theVisit = new Visit
                {
                    AppointmentId = this.theAppointment.AppointmentId,
                    NurseId = currentUser.NurseId,
                    Weight = weight,
                    Pulse = pulse,
                    SystolicBloodPressure = systolicBloodPressure,
                    DiastolicBloodPressure = diastolicBloodPressure,
                    BodyTemperature = bodyTemperature,
                    Symptoms = symptoms
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

        private void WeightTextBox_TextChanged(object sender, EventArgs e)
        {
            ResetValidationLabels();
        }

        private void PulseTextBox_TextChanged(object sender, EventArgs e)
        {
            ResetValidationLabels();
        }

        private void SystolicBloodPressureTextBox_TextChanged(object sender, EventArgs e)
        {
            ResetValidationLabels();
        }

        private void DiastolicBloodPressureTextBox_TextChanged(object sender, EventArgs e)
        {
            ResetValidationLabels();
        }

        private void BodyTemperatureTextBox_TextChanged(object sender, EventArgs e)
        {
            ResetValidationLabels();
        }

        private void SymptomsTextBox_TextChanged(object sender, EventArgs e)
        {
            ResetValidationLabels();
        }
    }
}

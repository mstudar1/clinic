using Clinic.Controller;
using Clinic.Model;
using System;
using System.Windows.Forms;

namespace Clinic.View
{
    /// <summary>
    /// This form will be used to edit information for an existing visit
    /// </summary>
    public partial class EditVisitForm : Form
    {
        private readonly ViewVisitForm viewVisitForm;       
        private readonly VisitController theVisitController;
        private readonly AppointmentController theAppointmentController;
        private readonly Appointment theAppointment;
        private readonly int nurseId;
        private double weight;
        private int pulse;
        private int systolicBloodPressure;
        private int diastolicBloodPressure;
        private double bodyTemperature;
        private string symptoms;

        /// <summary>
        /// Constructor for the edit visit information form
        /// </summary>
        /// <param name="viewVisitForm">the referring form</param>
        public EditVisitForm(ViewVisitForm viewVisitForm, int appointmentId, int nurseId)
        {
            InitializeComponent();
            this.viewVisitForm = viewVisitForm;
            this.theVisitController = new VisitController();
            this.theAppointmentController = new AppointmentController();
            this.theAppointment = this.theAppointmentController.GetAppointment(appointmentId);
            this.nurseId = nurseId;
            this.InitializeFormData();
        }

        /// <summary>
        /// Get the Visit info from the referring form anf populate form fields
        /// </summary>
        private void InitializeFormData()
        {
            this.weightTextBox.Text = this.viewVisitForm.GetVisit().Weight.ToString();
            this.pulseTextBox.Text = this.viewVisitForm.GetVisit().Pulse.ToString();
            this.systolicBloodPressureTextBox.Text = this.viewVisitForm.GetVisit().SystolicBloodPressure.ToString();
            this.diastolicBloodPressureTextBox.Text = this.viewVisitForm.GetVisit().DiastolicBloodPressure.ToString();
            this.bodyTemperatureTextBox.Text = this.viewVisitForm.GetVisit().BodyTemperature.ToString();
            this.symptomsTextBox.Text = this.viewVisitForm.GetVisit().Symptoms.ToString();
        }

        /// <summary>
        /// Handler for when the form loads.  Should diable referring from and set binding object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditVisitForm_Load(object sender, EventArgs e)
        {
            this.viewVisitForm.Enabled = false;
            this.appointmentBindingSource.Add(this.theAppointment);
        }

        /// <summary>
        /// Executes actions to close form and re-enable referring form
        /// </summary>
        private void CloseForm()
        {
            this.viewVisitForm.Enabled = true;         
            this.Close();
        }

        /// <summary>
        /// Handles submit button click events.  Creates a new Visit object and uses it to 
        /// attempt to update the DB.  Supplies success or failire message.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (AllInputsAreValid())
            {
                try
                {
                    Visit revisedVisit = new Visit
                    {
                        AppointmentId = this.theAppointment.AppointmentId,
                        NurseId = this.nurseId,
                        Weight = this.weight,
                        Pulse = this.pulse,
                        SystolicBloodPressure = this.systolicBloodPressure,
                        DiastolicBloodPressure = this.diastolicBloodPressure,
                        BodyTemperature = this.bodyTemperature,
                        Symptoms = this.symptoms
                    };
                    if (this.theVisitController.EditVisit(this.viewVisitForm.GetVisit(), revisedVisit))
                    {
                        string title = "Success";
                        string message = "Visit details successfully recorded.";
                        var selectedOption = MessageBox.Show(message, title, MessageBoxButtons.OK);
                        if (selectedOption == DialogResult.OK)
                        {
                            this.CloseForm();
                            this.viewVisitForm.UpdateFormVisitInfo(revisedVisit);
                        }
                    }  
                    else
                    {
                        string title = "Update Failed";
                        string message = "Visit details were not recorded. Please try again.";
                        var selectedOption = MessageBox.Show(message, title, MessageBoxButtons.OK);
                        if (selectedOption == DialogResult.OK)
                        {
                            this.CloseForm();
                        }
                    }                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error.  " + ex.Message, "Error");
                }
            }
        }

        /// <summary>
        /// Handles cancel button clicks events.  Presents confirmation dialog before closing the form.
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
                this.CloseForm();
            }
        }

        /// <summary>
        /// Handles events that are fired that require resetting the error messages
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetValidationLabelsListener(object sender, EventArgs e)
        {
            this.weightValidationLabel.Text = "";
            this.pulseValidationLabel.Text = "";
            this.systolicBloodPressureValidationLabel.Text = "";
            this.diastolicBloodPressureValidationLabel.Text = "";
            this.bodyTemperatureValidationLabel.Text = "";
            this.symptomsValidationLabel.Text = "";
        }

        /// <summary>
        /// Verifies that all input is valid and supplies meessages accordingly.
        /// </summary>
        /// <returns>true if no validation errors</returns>
        private bool AllInputsAreValid()
        {
            bool allInputsAreValid = true;
            if (!double.TryParse(this.weightTextBox.Text, out this.weight))
            {
                this.weightValidationLabel.Text = "The weight must be a valid number.";
                allInputsAreValid = false;
            }
            if (!int.TryParse(this.pulseTextBox.Text, out this.pulse))
            {
                this.pulseValidationLabel.Text = "The pulse must be a valid integer.";
                allInputsAreValid = false;
            }
            if (!int.TryParse(this.systolicBloodPressureTextBox.Text, out this.systolicBloodPressure))
            {
                this.systolicBloodPressureValidationLabel.Text = "The systolic blood pressure must be a valid integer.";
                allInputsAreValid = false;
            }
            if (!int.TryParse(this.diastolicBloodPressureTextBox.Text, out this.diastolicBloodPressure))
            {
                this.diastolicBloodPressureValidationLabel.Text = "The diastolic blood pressure must be a valid integer.";
                allInputsAreValid = false;
            }
            if (!double.TryParse(this.bodyTemperatureTextBox.Text, out this.bodyTemperature))
            {
                this.bodyTemperatureValidationLabel.Text = "The body temperature must be a valid number.";
                allInputsAreValid = false;
            }
            if (string.IsNullOrWhiteSpace(this.symptomsTextBox.Text))
            {
                this.symptomsValidationLabel.Text = "The symptoms field cannot be empty.";
                allInputsAreValid = false;
            }
            else
            {
                this.symptoms = this.symptomsTextBox.Text;
            }
            return allInputsAreValid;
        }
    }
}

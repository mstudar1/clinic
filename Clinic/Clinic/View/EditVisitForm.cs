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

        private void InitializeFormData()
        {
            this.weightTextBox.Text = this.viewVisitForm.GetVisit().Weight.ToString();
            this.pulseTextBox.Text = this.viewVisitForm.GetVisit().Pulse.ToString();
            this.systolicBloodPressureTextBox.Text = this.viewVisitForm.GetVisit().SystolicBloodPressure.ToString();
            this.diastolicBloodPressureTextBox.Text = this.viewVisitForm.GetVisit().DiastolicBloodPressure.ToString();
            this.bodyTemperatureTextBox.Text = this.viewVisitForm.GetVisit().BodyTemperature.ToString();
            this.symptomsTextBox.Text = this.viewVisitForm.GetVisit().Symptoms.ToString();
        }

        private void EditVisitForm_Load(object sender, EventArgs e)
        {
            this.viewVisitForm.Enabled = false;
            this.appointmentBindingSource.Add(this.theAppointment);
        }

        private void CloseForm()
        {
            this.viewVisitForm.Enabled = true;
        }

       

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
                    this.theVisitController.EditVisit(this.viewVisitForm.GetVisit(), revisedVisit);
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
        }

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

        private void ResetValidationLabelsListener(object sender, EventArgs e)
        {
            this.weightValidationLabel.Text = "";
            this.pulseValidationLabel.Text = "";
            this.systolicBloodPressureValidationLabel.Text = "";
            this.diastolicBloodPressureValidationLabel.Text = "";
            this.bodyTemperatureValidationLabel.Text = "";
            this.symptomsValidationLabel.Text = "";
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
            else
            {
                this.symptoms = this.symptomsTextBox.Text;
            }

            return allInputsAreValid;
        }
    }
}

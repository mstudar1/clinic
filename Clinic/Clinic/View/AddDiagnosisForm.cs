using Clinic.Controller;
using System;
using System.Windows.Forms;

namespace Clinic.View
{
    /// <summary>
    /// Manage form for adding diagnosis information to DB.  
    /// User may input multiple diagnosis until they choose to enter a "final" diagnosis.
    /// </summary>
    public partial class AddDiagnosisForm : Form
    {
        private readonly int appointmentId;
        private readonly DiagnosisController theDiagnosisController;
        private readonly ViewVisitForm referringForm;

        /// <summary>
        /// Constructor for the form
        /// </summary>
        /// <param name="referringForm">the form from which this form was opened</param>
        public AddDiagnosisForm(ViewVisitForm referringForm)
        {
            InitializeComponent();        
            this.theDiagnosisController = new DiagnosisController();
            this.referringForm = referringForm;
            this.appointmentId = this.referringForm.GetAppointmentId();
            this.referringForm.Enabled = false;
        }

        /// <summary>
        /// Button to execute the adding of the diagnosis to the DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OkayButton_Click(object sender, EventArgs e)
        {
            this.alertMessage.Text = "";
            string diagnosisName = this.diagnosisTextBox.Text;
            if (diagnosisName == "")
            {
                this.alertMessage.Text = "Please enter a diagnosis in the provided textbox.";
            }
            bool isFinal = this.finalYesRadioButton.Checked;
            if (isFinal)
            {
                string boxMessage = "Are you sure you want to enter a final diagnosis.  " +
                    "You will not longer be able to add or edit this visit.";
                string boxTitle = "Confirm Final diagnosis";
                DialogResult dialogResult = MessageBox.Show(boxMessage, boxTitle, MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.AddDiagnosisToDB(diagnosisName, isFinal);
                }
                else
                {
                    this.alertMessage.Text = "Diagnosis was not recorded.";
                }              
            }
            else
            {
                this.AddDiagnosisToDB(diagnosisName, isFinal);               
            }
        }

        /// <summary>
        /// Helper method to handle the submitting of the record to the controller to be recorded
        /// </summary>
        /// <param name="diagnosisName">Text entry describing the diagnosis</param>
        /// <param name="isFinal">if final then true</param>
        private void AddDiagnosisToDB(string diagnosisName, bool isFinal)
        {
            {
                try
                {
                    this.theDiagnosisController.AddDiagnosis(this.appointmentId, diagnosisName, isFinal);
                    string boxMessage = "The diagnosis was successfully added to the visit record.";
                    string boxTitle = "Diagnosis Submitted";
                    DialogResult dialogResult = MessageBox.Show(boxMessage, boxTitle);
                    this.Close();
                }
                catch (Exception ex)
                {
                    string boxMessage = "The diagnosis was not successfully saved for the following reason: \n" +
                        ex.Message;
                    string boxTitle = "Diagnosis Update Failure";
                    MessageBox.Show(boxMessage, boxTitle);
                    this.CloseForm();
                }
            }
        }

        /// <summary>
        /// Helper method to handle actions of closing the form
        /// </summary>
        private void CloseForm()
        {
            this.referringForm.Enabled = true;
            this.referringForm.LoadTests();
            this.Close();
        }

        /// <summary>
        /// Handle for cancel button clicks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.CloseForm();
        }

        /// <summary>
        /// Handler for other ways the form is closed (i.e. clicking the X button)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDiagnosisForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.referringForm.Enabled = true;
        }

        /// <summary>
        /// Reset alert message when event is detected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DiagnosisTextBox_TextChanged(object sender, EventArgs e)
        {
            this.alertMessage.Text = "";
        }

    }
}

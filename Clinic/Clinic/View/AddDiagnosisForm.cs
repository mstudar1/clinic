using Clinic.Controller;
using System;
using System.Windows.Forms;

namespace Clinic.View
{
    public partial class AddDiagnosisForm : Form
    {
        int appointmentId;
        private readonly DiagnosisController theDiagnosisController;
        private readonly ViewVisitForm referringForm;

        public AddDiagnosisForm(int appointmentId, ViewVisitForm referringForm)
        {
            InitializeComponent();
            this.appointmentId = appointmentId;          
            this.theDiagnosisController = new DiagnosisController();
            this.referringForm = referringForm;
            this.referringForm.Enabled = false;
        }

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

        private void AddDiagnosisToDB(string diagnosisName, bool isFinal)
        {
            {
                try
                {
                    this.theDiagnosisController.AddDiagnosis(this.appointmentId, diagnosisName, isFinal);
                    string boxMessage = "The diagnosis was successfully added to the visit record.";
                    string boxTitle = "Diagnosis Submitted";
                    DialogResult dialogResult = MessageBox.Show(boxMessage, boxTitle);
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

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.CloseForm();
        }


        private void CloseForm()
        {
            this.referringForm.Enabled = true;
            this.Close();
        }

        private void AddDiagnosisForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.referringForm.Enabled = true;
        }

        // TODO:
        // Verify that text diagnosis is not equal to one already used in that diagnosis (it is a key)
        // Test form when I can merge back to master and wire to the ViewVisitForm
    }
}

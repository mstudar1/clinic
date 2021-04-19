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
            string diagnosisName = this.diagnosisTextBox.Text;
            if (diagnosisName == "")
            {
                this.alertMessage.Text = "Please enter a diagnosis in the provided textbox.";
            }
            bool isFinal = this.finalYesRadioButton.Checked;
            if (isFinal)
            {
                DialogResult dialogResult = MessageBox.Show(
                    "Are you sure you want to enter a final diagnosis.  " +
                    "You will not longer be able to add or edit this visit.", 
                    "Confirm Final diagnosis", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        this.theDiagnosisController.AddDiagnosis(this.appointmentId, diagnosisName, isFinal);
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
            else
            {
                try
                {
                    this.theDiagnosisController.AddDiagnosis(this.appointmentId, diagnosisName, isFinal);
                }
                catch (Exception ex)
                {

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
        // Disable referring form and re-enable when complete
        // Add confirmation box when submitting final=yes
        // Add OK box when submit successfully final=no
        // Verify that text diagnosis is not equal to one already used in that diagnosis (it is a key)
        //
    }
}

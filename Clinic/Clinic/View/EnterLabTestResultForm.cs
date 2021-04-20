using Clinic.Controller;
using Clinic.Model;
using System;
using System.Windows.Forms;

namespace Clinic.View
{
    /// <summary>
    /// Form to handle the entering of test result information
    /// </summary>
    public partial class EnterLabTestResultForm : Form
    {
        private readonly int appointmentId;
        private readonly int testCode;
        private readonly ConductedLabTestController theConductedLabTestController;
        private readonly ViewVisitForm referringForm;
        private readonly ConductedLabTest currentConductedLabTest;

        /// <summary>
        /// Constructor for the form
        /// </summary>
        /// <param name="appointmentId">the appointment ID associated with the lab test (part of the key)</param>
        /// <param name="testCode">the test code associated with the conducted test (part of the key)</param>
        /// <param name="referringForm">the referring ViewVisitForm</param>
        public EnterLabTestResultForm(int appointmentId, int testCode, ViewVisitForm referringForm)
        {
            InitializeComponent();
            this.appointmentId = appointmentId;
            this.testCode = testCode;
            this.theConductedLabTestController = new ConductedLabTestController();
            this.referringForm = referringForm;          
            this.referringForm.Enabled = false;
            this.currentConductedLabTest = this.GetCurrentConductedLabTest();
            this.SetPrefilledValues();
        }

        /// <summary>
        /// Set the prefilled values of the form
        /// </summary>
        private void SetPrefilledValues()
        {
            this.prefillPatientNameLabel.Text = this.currentConductedLabTest.FullName; 
            this.prefillTestNameLabel.Text = this.currentConductedLabTest.LabTest.Name;
            this.resultDateTimePicker.Value = DateTime.Now;
        }

        /// <summary>
        /// Get the conducted current test object based on the unique key information (appointment ID and testcode)
        /// </summary>
        /// <returns></returns>
        private ConductedLabTest GetCurrentConductedLabTest()
        {
            foreach (ConductedLabTest test in this.theConductedLabTestController.GetConductedLabTests(this.appointmentId))
            {
                if (test.LabTest.TestCode == this.testCode)
                {
                    return test;
                }
            }
            throw new Exception("No conducted test found");
        }

        /// <summary>
        /// Handles events that need to happen when submit button is clicked:
        /// Validate form entries, attempt to update DV and report out.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            this.alertTextLabel.Text = "";
            if (this.normalRadioButton.Checked == false && this.abnormalRadioButton.Checked == false)
            {
                this.alertTextLabel.Text += "Please select a conclusion.";
            }
            if (this.resultTextBox.Text == "")
            {
                this.alertTextLabel.Text += "Please enter a result in the space provided.";
            }

            if (this.alertTextLabel.Text == "")
            {
                LabTest labTest = this.currentConductedLabTest.LabTest; 
                DateTime datePerformed = this.resultDateTimePicker.Value;
                string results = this.resultTextBox.Text;
                bool isNormal = this.normalRadioButton.Checked;
                try
                {
                    this.theConductedLabTestController.AddLabTestResults(this.appointmentId, labTest, datePerformed, results, isNormal);
                }
                catch (Exception ex)
                {
                    string boxMessage = "The lab result was not successfully recorded for the following reason: \n" +
                        ex.Message;
                    string boxTitle = "Lab Test Result Update Failure";
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
            this.Close();
        }

        /// <summary>
        /// Handles cancel button clicks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.CloseForm();
        }

        /// <summary>
        /// Handles re-enabling the referring form when the form is closed using some means other than 
        /// the cancel button or successful submission
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnterLabTestResultForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.referringForm.Enabled = true;
        }
      
    }
}

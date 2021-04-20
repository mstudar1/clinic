using Clinic.Controller;
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
    public partial class EnterLabTestResultForm : Form
    {
        private readonly int appointmentId;
        private readonly int testCode;
        private readonly ConductedLabTestController theConductedLabTestController;
        private readonly ViewVisitForm referringForm;
        private readonly ConductedLabTest currentConductedLabTest;

        public EnterLabTestResultForm(int appointmentId, int testCode, ViewVisitForm referringForm)
        {
            InitializeComponent();
            this.appointmentId = appointmentId;
            this.testCode = testCode;
            this.theConductedLabTestController = new ConductedLabTestController();
            this.referringForm = referringForm;
            this.currentConductedLabTest = this.getCurrentConductedLabTest();
            this.referringForm.Enabled = false;
            this.resultDateTimePicker.Value = DateTime.Now;         
        }

        private void SetPrefilledValues()
        {
            this.prefillPatientNameLabel.Text = "Still Need to Implement :) ";
            this.prefillTestNameLabel.Text = this.currentConductedLabTest.LabTest.Name;
        }

        private ConductedLabTest getCurrentConductedLabTest()
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

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.CloseForm();
        }

        private void EnterLabTestResultForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.referringForm.Enabled = true;
        }

       
    }
}

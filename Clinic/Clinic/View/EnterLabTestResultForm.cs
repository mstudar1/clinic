using Clinic.Controller;
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
        private readonly ConductedLabTestController theConductedLabTestController;
        private readonly ViewVisitForm referringForm;

        public EnterLabTestResultForm(int appointmentId, ViewVisitForm referringForm)
        {
            InitializeComponent();
            this.appointmentId = appointmentId;
            this.theConductedLabTestController = new ConductedLabTestController();
            this.referringForm = referringForm;
            this.referringForm.Enabled = false;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            this.alertTextLabel.Text = "";
            if (this.normalRadioButton.Checked == false && this.abnormalRadioButton.Checked == false)
            {
                this.alertTextLabel.Text = "Please select a conclusion.";
            }

            if (this.alertTextLabel.Text == "")
            {
                LabTestController labTest = new LabTestController();
               // DateTime datePerformed = this.resultDateTimePicker;
                string results = this.resultTextBox.Text;
                bool isNormal = this.normalRadioButton.Checked;
                //this.theConductedLabTestController.AddLabTestResults(this.appointmentId, labTest, datePerformed, results, isNormal);
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

using Clinic.Controller;
using Clinic.Model;
using Clinic.UserControls;
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
    public partial class EditPatientForm : Form
    {
        private Patient thePatient;
        private PatientUserControl thePatientUserControl;
        private PatientController thePatientController;
        public EditPatientForm(PatientUserControl theInputPatientUserControl, Patient theInputedPatient)
        {
            InitializeComponent();
            this.thePatientUserControl = theInputPatientUserControl;
            this.thePatient = theInputedPatient;
            this.ShowPatientInformation();
            this.thePatientController = new PatientController();
        }

        private void ShowPatientInformation()
        {
            this.firstNameTextBox.Text = this.thePatient.FirstName;
            this.lastNameTextBox.Text = this.thePatient.LastName;
            this.dateOfBirthDateTimePicker.Value = this.thePatient.DateOfBirth;
            this.ssnTextBox.Text = this.thePatient.SocialSecurityNumber;
            this.genderComboBox.Text = this.thePatient.Gender;
            this.phoneNumberTextBox.Text = this.thePatient.PhoneNumber;
            this.address1TextBox.Text = this.thePatient.AddressLine1;
            this.address2TextBox.Text = this.thePatient.AddressLine2;
            this.stateComboBox.Text = this.thePatient.State;
            this.cityTextBox.Text = this.thePatient.City;
            this.zipTextBox.Text = this.thePatient.ZipCode;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.thePatientUserControl.Enabled = true;
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save the changes?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Patient updatedPatient = new Patient
                {
                    LastName = this.lastNameTextBox.Text,
                    FirstName = this.firstNameTextBox.Text,
                    DateOfBirth = this.dateOfBirthDateTimePicker.Value,
                    SocialSecurityNumber = this.ssnTextBox.Text,
                    Gender = this.genderComboBox.Text,
                    PhoneNumber = this.phoneNumberTextBox.Text,
                    AddressLine1 = this.address1TextBox.Text,
                    AddressLine2 = this.address2TextBox.Text,
                    City = this.cityTextBox.Text,
                    State = this.stateComboBox.Text,
                    ZipCode = this.zipTextBox.Text,
                    PersonId = this.thePatient.PersonId,
                    PatientId = this.thePatient.PatientId
                };

                this.thePatientController.EditPatient(this.thePatient, updatedPatient);
                this.thePatientUserControl.Enabled = true;
                this.thePatientUserControl.RefreshPatientsListData();
                this.Close();
            }
    
        }
    }
}

using Clinic.Controller;
using Clinic.Model;
using Clinic.UserControls;
using System;
using System.Windows.Forms;

namespace Clinic.View
{

    /// <summary>
    /// This is the popup form for registering patients to the system
    /// </summary>
    public partial class RegisterPatientForm : Form
    {

        private PatientUserControl thePatientUserControl;
        private PatientController thePatientController;

        /// <summary>
        /// Constructor used to initialize the thePatientUserControl and 
        /// </summary>
        /// <param name="theInputPatientUserControl"></param>
        public RegisterPatientForm(PatientUserControl theInputPatientUserControl)
        {
            InitializeComponent();
            this.thePatientUserControl = theInputPatientUserControl;
            this.thePatientController = new PatientController();
            this.thePatientUserControl.Enabled = false;
        }


        private void RegisterButton_Click(object sender, System.EventArgs e)
        {
            String alertText = "";

            if (String.IsNullOrEmpty(this.lastNameTextBox.Text))
            {
                alertText += "Patient last name cannot be blank. ";
            }
            if (String.IsNullOrEmpty(this.firstNameTextBox.Text))
            {
                alertText += "Patient first name cannot be blank. ";
            }
            if (DateTime.Compare(this.dateOfBirthDateTimePicker.Value, DateTime.Now) > 0)
            {
                alertText += "The date of birth cannot be in the future. ";
            }
            if (this.ssnMaskedTextBox.Text.Length != 11)
            {
                alertText += "Nine digit social security number is required. ";
            }
            if (String.IsNullOrEmpty(this.genderComboBox.Text))
            {
                alertText += "Gender must be selected. ";
            }
            if (this.phoneNumberMaskedTextBox.Text.Length != 14)
            {
                alertText += "Ten digit phone number is required. ";
            }
            if (String.IsNullOrEmpty(this.address1TextBox.Text))
            {
                alertText += "Address cannot be blank. ";
            }
            if (String.IsNullOrEmpty(this.stateComboBox.Text))
            {
                alertText += "State must be selected. ";
            }
            if (String.IsNullOrEmpty(this.cityTextBox.Text))
            {
                alertText += "City is required. ";
            }
            else if (char.IsLower(cityTextBox.Text[0]))
            {
                alertText += "City name should start with a capital letter. ";
            }
            if (this.zipMaskedTextBox.Text.Length != 5)
            {
                alertText += "Five digit zip number is required. ";
            }

            if (alertText == "")
            {
                Patient newPatient = new Patient
                {
                    LastName = this.lastNameTextBox.Text,
                    FirstName = this.firstNameTextBox.Text,
                    DateOfBirth = this.dateOfBirthDateTimePicker.Value,
                    SocialSecurityNumber = this.ssnMaskedTextBox.Text,
                    Gender = this.genderComboBox.Text,
                    PhoneNumber = this.phoneNumberMaskedTextBox.Text,
                    AddressLine1 = this.address1TextBox.Text,
                    City = this.cityTextBox.Text,
                    State = this.stateComboBox.Text,
                    ZipCode = this.zipMaskedTextBox.Text
                };

                this.thePatientController.AddPatient(newPatient);
                if (MessageBox.Show("The new patient " + this.firstNameTextBox.Text + " " + this.lastNameTextBox.Text + " is registered", "Confirmation", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    this.thePatientUserControl.Enabled = true;
                    this.thePatientUserControl.RefreshPatientsListData();
                    this.Close();
                }
            }
            this.alertNoticeLabel.Text = alertText;
        }

        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            this.thePatientUserControl.Enabled = true;
            this.Close(); 
        }

        private void RegisterPatientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.thePatientUserControl.Enabled = true;
        }
    }
}
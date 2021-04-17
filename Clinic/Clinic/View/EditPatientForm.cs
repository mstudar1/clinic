using Clinic.Controller;
using Clinic.Model;
using Clinic.UserControls;
using System;
using System.Windows.Forms;

namespace Clinic.View
{
    /// <summary>
    /// Constructs and manages the edit patient information form
    /// </summary>
    public partial class EditPatientForm : Form
    {
        private readonly Patient thePatient;
        private readonly PatientUserControl thePatientUserControl;
        private readonly PatientController thePatientController;

        /// <summary>
        /// Constructor for the edit patient information form
        /// </summary>
        /// <param name="theInputPatientUserControl">the referring patientUsercontroller</param>
        /// <param name="theInputedPatient">the Patient to be edited</param>
        public EditPatientForm(PatientUserControl theInputPatientUserControl, Patient theInputedPatient)
        {
            InitializeComponent();
            this.thePatientUserControl = theInputPatientUserControl;
            this.thePatient = theInputedPatient;
            this.ShowPatientInformation();
            this.thePatientController = new PatientController();
        }

        /// <summary>
        /// Fill in the form with current patient information
        /// </summary>
        private void ShowPatientInformation()
        {
            this.firstNameTextBox.Text = this.thePatient.FirstName;
            this.lastNameTextBox.Text = this.thePatient.LastName;
            this.dateOfBirthDateTimePicker.Value = this.thePatient.DateOfBirth;
            this.ssnMaskedTextBox.Text = this.thePatient.SocialSecurityNumber;
            this.genderComboBox.Text = this.thePatient.Gender;
            this.phoneNumberMaskedTextBox.Text = this.thePatient.PhoneNumber;
            this.address1TextBox.Text = this.thePatient.AddressLine1;
            this.address2TextBox.Text = this.thePatient.AddressLine2;
            this.stateComboBox.Text = this.thePatient.State;
            this.cityTextBox.Text = this.thePatient.City;
            this.zipMaskedTextBox.Text = this.thePatient.ZipCode;
        }

        /// <summary>
        /// Cancel button click handler to close form and re-enable the user control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.thePatientUserControl.Enabled = true;
            this.Close();
        }

        /// <summary>
        /// Save button click handler to verify and update the patient information according to form input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
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

            this.alertNoticeLabel.Text = alertText;
            
            if (alertText == "")
            {
                if (MessageBox.Show("Are you sure you want to save the changes?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        Patient updatedPatient = new Patient
                        {
                            LastName = this.lastNameTextBox.Text,
                            FirstName = this.firstNameTextBox.Text,
                            DateOfBirth = this.dateOfBirthDateTimePicker.Value,
                            SocialSecurityNumber = this.ssnMaskedTextBox.Text,
                            Gender = this.genderComboBox.Text,
                            PhoneNumber = this.phoneNumberMaskedTextBox.Text,
                            AddressLine1 = this.address1TextBox.Text,
                            AddressLine2 = this.address2TextBox.Text,
                            City = this.cityTextBox.Text,
                            State = this.stateComboBox.Text,
                            ZipCode = this.zipMaskedTextBox.Text,
                            PersonId = this.thePatient.PersonId,
                            PatientId = this.thePatient.PatientId
                        };

                        this.thePatientController.EditPatient(this.thePatient, updatedPatient);
                        this.thePatientUserControl.Enabled = true;
                        this.thePatientUserControl.RefreshPatientsListData();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        this.alertNoticeLabel.Text = "Form data not submitted.\n" + ex.Message + " Please fix and try again. ";
                    }

                }
            }
        }

        /// <summary>
        /// Re-enable user control upon form closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditPatient_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.thePatientUserControl.Enabled = true;
        }
    }
}

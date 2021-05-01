using Clinic.Controller;
using Clinic.Model;
using Clinic.UserControls;
using System;
using System.Windows.Forms;

namespace Clinic.View
{
    /// <summary>
    /// Clas to construct and manage edit nurse information form
    /// </summary>
    public partial class EditNurseForm : Form
    {
        private readonly Nurse theNurse;
        private readonly NurseUserControl theNurseUserControl;
        private readonly NurseController theNurseController;

        /// <summary>
        /// Constructor for edit nurse form
        /// </summary>
        /// <param name="theInputNurseUserControl"></param>
        /// <param name="theInputNurse"></param>
        public EditNurseForm(NurseUserControl theInputNurseUserControl, Nurse theInputNurse)
        {
            InitializeComponent();
            this.theNurseUserControl = theInputNurseUserControl;
            this.theNurse = theInputNurse;           
            this.theNurseController = new NurseController();
            this.ShowNurseInformation();
        }

        /// <summary>
        /// Fill in selected nurse information into the form
        /// </summary>
        private void ShowNurseInformation()
        {
            this.firstNameTextBox.Text = this.theNurse.FirstName;
            this.lastNameTextBox.Text = this.theNurse.LastName;
            this.dateOfBirthDateTimePicker.Value = this.theNurse.DateOfBirth;
            this.ssnMaskedTextBox.Text = this.theNurse.SocialSecurityNumber;
            this.genderComboBox.Text = this.theNurse.Gender;
            this.phoneNumberMaskedTextBox.Text = this.theNurse.PhoneNumber;
            this.address1TextBox.Text = this.theNurse.AddressLine1;
            this.address2TextBox.Text = this.theNurse.AddressLine2;
            this.stateComboBox.Text = this.theNurse.State;
            this.cityTextBox.Text = this.theNurse.City;
            this.zipMaskedTextBox.Text = this.theNurse.ZipCode;
        }

        /// <summary>
        /// Cancel button click handler to close form and re-enable userControl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.theNurseUserControl.Enabled = true;
            this.Close();
        }

        /// <summary>
        /// Re-enable userControl if form closes for any other reason
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditPatient_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.theNurseUserControl.Enabled = true;
        }

        /// <summary>
        /// Disable userControl when form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditNurseForm_Load(object sender, EventArgs e)
        {
            this.theNurseUserControl.Enabled = false;
        }
        
        /// <summary>
        /// Execute checks and update when button click 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateNurseButton_Click(object sender, EventArgs e)
        {
            String alertText = "";

            if (String.IsNullOrEmpty(this.lastNameTextBox.Text))
            {
                alertText += "Patient first name cannot be blank. ";
            }
            if (String.IsNullOrEmpty(this.firstNameTextBox.Text))
            {
                alertText += "Patient last name cannot be blank. ";
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
                if (MessageBox.Show("Are you sure you want to save the changes?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Nurse updatedNurse = new Nurse
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
                        PersonId = this.theNurse.PersonId,
                        NurseId = this.theNurse.NurseId
                    };

                    this.theNurseController.EditNurse(this.theNurse, updatedNurse);
                    this.theNurseUserControl.Enabled = true;
                    this.theNurseUserControl.ClearList();
                    this.theNurseUserControl.PopulateList();
                    this.Close();
                }
            }
            this.alertNoticeLabel.Text = alertText;
        }
    }
}

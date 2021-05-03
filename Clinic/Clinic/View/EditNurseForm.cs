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
        private readonly CredentialController theCredentialController;
        private string username;


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
            this.theCredentialController = new CredentialController();
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
            this.username = this.theCredentialController.GetUsername(this.theNurse.PersonId);
            this.usernameTextBox.Text = this.username;
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
        /// Executes actions to properly close the form and re-enable the Nurse User Control
        /// </summary>
        private void CloseForm()
        {
            this.theNurseUserControl.Enabled = true;
            this.Close();
        }

        /// <summary>
        /// Execute checks and update when button click 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateNurseButton_Click(object sender, EventArgs e)
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
            if (String.IsNullOrEmpty(this.usernameTextBox.Text))
            {
                alertText += "The user name is required. ";
            }
            try
            {
                if (this.username != this.usernameTextBox.Text)
                if (this.theCredentialController.GetUser(this.usernameTextBox.Text).GetType() == typeof(Nurse) || this.theCredentialController.GetUser(this.usernameTextBox.Text).GetType() == typeof(Administrator))
                {
                    alertText += "The username is already used. ";
                }
            }
            catch (Exception)
            {
            }
            this.alertNoticeLabel.Text = alertText;

            if (alertText == "")
            {
                string firstName = this.firstNameTextBox.Text;
                string lastName = this.lastNameTextBox.Text;
                DateTime dob = this.dateOfBirthDateTimePicker.Value;
                string ssn = this.ssnMaskedTextBox.Text;
                string gender = this.genderComboBox.Text;
                string phone = this.phoneNumberMaskedTextBox.Text;
                string address1 = this.address1TextBox.Text;
                string address2 = this.address2TextBox.Text;
                string city = this.cityTextBox.Text;
                string state = this.stateComboBox.Text;
                string zip = this.zipMaskedTextBox.Text;
                string username = this.usernameTextBox.Text;
                string password = this.passwordTextBox.Text;
                try
                {
                    Nurse newNurse = new Nurse
                    {
                        LastName = lastName,
                        FirstName = firstName,
                        DateOfBirth = dob,
                        SocialSecurityNumber = ssn,
                        Gender = gender,
                        PhoneNumber = phone,
                        AddressLine1 = address1,
                        AddressLine2 = address2,
                        City = city,
                        State = state,
                        ZipCode = zip,
                        PersonId = this.theNurse.PersonId,
                        NurseId = this.theNurse.NurseId
                    };
                    this.theNurseController.EditNurse(this.theNurse, newNurse);
                    if (password == "")
                    {
                        this.theCredentialController.EditCredentials(this.username, username);
                    }
                    else
                    {
                        this.theCredentialController.EditCredentials(this.username, username, password);
                    }
                    String successText = "Nurse  (" + firstName + " " + lastName + ") successfully edited.";
                    var dialogeResult = MessageBox.Show(successText, "Nurse Edited Success");
                    if (dialogeResult == DialogResult.OK)
                    {
                        this.CloseForm();
                        this.theNurseUserControl.RefreshNursesListData();
                    }
                }
                catch (Exception ex)
                {
                    this.alertNoticeLabel.Text = "Form data not submitted.\n" + ex.Message + " Please fix and try again. ";
                }
            }
        }
    }
}

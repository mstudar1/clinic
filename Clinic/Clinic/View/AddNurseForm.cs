using System;
using System.Windows.Forms;
using Clinic.Controller;
using Clinic.Model;
using Clinic.UserControls;

namespace Clinic.View
{
    /// <summary>
    /// This is the popup form for entering nurse information when adding a new nurse to the system
    /// </summary>
    public partial class AddNurseForm : Form
    {
        private readonly NurseController theNursecontroller;
        private readonly NurseUserControl nurseUserControl;
        private readonly CredentialController theCredentialController;

        /// <summary>
        /// Constructor for the add nurse form
        /// </summary>
        /// <param name="theInputNurseUserControl">the refering usercontrol</param>
        public AddNurseForm(NurseUserControl theInputNurseUserControl)
        {
            InitializeComponent();
            this.theNursecontroller = new NurseController();
            this.theCredentialController = new CredentialController();
            this.nurseUserControl = theInputNurseUserControl;
        }

        /// <summary>
        /// When add button is clicked a Person and Nurse entry is created in the DB with the form information.  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNurseButton_Click(object sender, System.EventArgs e)
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
            if (String.IsNullOrEmpty(this.passwordTextBox.Text))
            {
                alertText += "The password is required. ";
            }
            try
            {
                if (this.theCredentialController.GetUser(this.usernameTextBox.Text).GetType() == typeof(Nurse) || this.theCredentialController.GetUser(this.usernameTextBox.Text).GetType() == typeof(Administrator))
                {
                    alertText += "The username is already used. ";
                }
            }
            catch (Exception ex)
            {
            }
            this.noticeLabel.Text = alertText;

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
                        ZipCode = zip
                    };
                    



                    this.theNursecontroller.AddNurse(newNurse);
                    this.theCredentialController.AddUser(username,newNurse.PersonId,"Nurse",password);
                    String successText = "Nurse  (" + firstName + " " + lastName + ") successfully added.";
                    var dialogeResult = MessageBox.Show(successText, "Nurse Added Success");
                    if (dialogeResult == DialogResult.OK)
                    {
                        this.CloseForm();
                    }
                }
                catch (Exception ex)
                {
                   this.noticeLabel.Text = "Form data not submitted.\n" + ex.Message + " Please fix and try again. "; 
                }
            }
        }

        /// <summary>
        /// Cancel button click actions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.CloseForm();
        }

        /// <summary>
        /// Executes actions to properly close the form and re-enable the Nurse User Control
        /// </summary>
        private void CloseForm()
        {
            this.nurseUserControl.Enabled = true;
            this.Close();
        }

        /// <summary>
        /// Actions to perform when form loads.  Disable the nurse user control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNurseForm_Load(object sender, EventArgs e)
        {
            this.nurseUserControl.Enabled = false;
        }

        /// <summary>
        /// Re-enable user control when form closes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNurseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.nurseUserControl.Enabled = true;
        }
    }
}

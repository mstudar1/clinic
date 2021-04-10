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

        /// <summary>
        /// Constructor for the add nurse form
        /// </summary>
        /// <param name="theInputNurseUserControl">the refering usercontrol</param>
        public AddNurseForm(NurseUserControl theInputNurseUserControl)
        {
            InitializeComponent();
            this.theNursecontroller = new NurseController();
        }

        /// <summary>
        /// When add button is clicked a Person and Nurse entry is created in the DB with the form information.  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNurseButton_Click(object sender, System.EventArgs e)
        {
            if (DateTime.Compare(this.dateOfBirthDateTimePicker.Value, DateTime.Now) > 0)
            {
                MessageBox.Show("The date of birth cannot be in the future.  Please revise the date and resubmit.", "Invalid Date of Birth");
                return;
            }

            string firstName = this.firstNameTextBox.Text;
            string lastName = this.lastNameTextBox.Text;
            DateTime dob = this.dateOfBirthDateTimePicker.Value;
            string ssn = this.ssnTextBox.Text;
            string gender = this.genderComboBox.Text;
            string phone = this.phoneNumberTextBox.Text;
            string address1 = this.address1TextBox.Text;
            string address2 = this.address2TextBox.Text;
            string city = this.cityTextBox.Text;
            string state = this.stateComboBox.Text;
            string zip = this.zipTextBox.Text;
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
                this.noticeLabel.Text = "Success";  
            }
            catch(Exception ex)
            {
                this.noticeLabel.Text = "Error. Form data not submitted (" + ex.Message + "). Please fix and try again. ";
            }
        }
    }
    

}

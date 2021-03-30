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
        private readonly NurseUserControl theNurseUserControl;
        private readonly NurseController theNursecontroller;

        /// <summary>
        /// Constructor for the add nurse form
        /// </summary>
        /// <param name="theInputNurseUserControl">the refering usercontrol</param>
        public AddNurseForm(NurseUserControl theInputNurseUserControl)
        {
            InitializeComponent();
            this.theNurseUserControl = theInputNurseUserControl;
            this.theNursecontroller = new NurseController();
        }

        /// <summary>
        /// When add button is clicked a Person and Nurse entry is created in the DB with the form information.  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNurseButton_Click(object sender, System.EventArgs e)
        {
            string firstName = this.firstNameTextBox.Text;
            string lastName = this.lastNameTextBox.Text;
            int year = int.Parse(this.yearTextBox.Text);
            int month = int.Parse(this.monthComboBox.Text);
            int day = int.Parse(this.dayComboBox.Text);
            DateTime dob = new DateTime(year, month, day);
            string ssn = this.ssnTextBox.Text;
            string gender = this.genderComboBox.Text;
            string phone = this.phoneNumberTextBox.Text;
            string address1 = this.address1TextBox.Text;
            string address2 = this.address2TextBox.Text;
            string city = this.cityTextBox.Text;
            string state = this.stateTextBox.Text;
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
                this.noticeLabel.Text = "Success";  //TODO:  Replace with pop up success message followed by close form 
            }
            catch(Exception ex)
            {
                this.noticeLabel.Text = "Error. Form data not submitted (" + ex.Message + "). Please fix and try again. ";
            }
        }
    }
    

}

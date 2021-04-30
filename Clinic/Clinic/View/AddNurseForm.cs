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

        /// <summary>
        /// Constructor for the add nurse form
        /// </summary>
        /// <param name="theInputNurseUserControl">the refering usercontrol</param>
        public AddNurseForm(NurseUserControl theInputNurseUserControl)
        {
            InitializeComponent();
            this.theNursecontroller = new NurseController();
            this.nurseUserControl = theInputNurseUserControl;
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
            string ssn = this.ssnMaskedTextBox.Text;
            string gender = this.genderComboBox.Text;
            string phone = this.phoneNumberMaskedTextBox.Text;
            string address1 = this.address1TextBox.Text;
            string address2 = this.address2TextBox.Text;
            string city = this.cityTextBox.Text;
            string state = this.stateComboBox.Text;
            string zip = this.zipMaskedTextBox.Text;
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
                String successText = "Nurse  (" + firstName + " " + lastName + ") successfully added.";
                var dialogeResult = MessageBox.Show(successText, "Nurse Added Success");
                if (dialogeResult == DialogResult.OK)
                {
                    this.CloseForm();
                }
            }
            catch(Exception ex)
            {
                this.noticeLabel.Text = "Form data not submitted.\n" + ex.Message + " Please fix and try again. ";
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

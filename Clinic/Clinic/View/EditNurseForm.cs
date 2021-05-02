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
        private void UpdateNurseButton_Click(object sender, EventArgs e)
        {

        }
    }
}

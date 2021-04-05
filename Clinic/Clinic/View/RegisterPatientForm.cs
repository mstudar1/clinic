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
            if (DateTime.Compare(this.dateOfBirthDateTimePicker.Value, DateTime.Now) > 0)
            {
                MessageBox.Show("The date of birth cannot be in the future.  Please revise the date and resubmit.", "Invalid Date of Birth");
                return;
            }
            Patient newPatient = new Patient
            {
                LastName = this.lastNameTextBox.Text,
                FirstName = this.firstNameTextBox.Text,
                DateOfBirth = this.dateOfBirthDateTimePicker.Value,
                SocialSecurityNumber = this.ssnTextBox.Text,
                Gender = this.genderComboBox.Text,
                PhoneNumber = this.phoneNumberTextBox.Text,
                AddressLine1 = this.address1TextBox.Text,
                City = this.cityTextBox.Text,
                State = this.stateComboBox.Text,
                ZipCode = this.zipTextBox.Text
            };

            this.thePatientController.AddPatient(newPatient);
            if (MessageBox.Show("The new patient " + this.firstNameTextBox.Text + " " + this.lastNameTextBox.Text + " is registered", "Confirmation",  MessageBoxButtons.OK) == DialogResult.OK)
            {
                this.thePatientUserControl.Enabled = true;
                this.thePatientUserControl.RefreshPatientsListData();
                this.Close();
            }

        }

        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            this.thePatientUserControl.Enabled = true;
            this.Close(); 
        }
    }
}
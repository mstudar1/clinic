using Clinic.Model;
using Clinic.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic.View
{
    public partial class ViewPatientForm : Form
    {
        private Patient thePatient;
        private PatientUserControl thePatientUserControl;
        public ViewPatientForm(PatientUserControl theInputPatientUserControl, Patient theInputedPatient)
        {
            InitializeComponent();
            this.thePatientUserControl = theInputPatientUserControl;
            this.thePatient = theInputedPatient;
            this.ShowPatientInformation();
        }

        private void ShowPatientInformation()
        {
            this.firstNameTextBox.Text = this.thePatient.FirstName;
            this.lastNameTextBox.Text = this.thePatient.LastName;
            this.dateOfBirthDateTimePicker.Value = this.thePatient.DateOfBirth;
            this.ssnTextBox.Text = this.thePatient.SocialSecurityNumber;
            this.genderComboBox.Text = this.thePatient.Gender;
            this.phoneNumberTextBox.Text = this.thePatient.PhoneNumber;
            this.address1TextBox.Text = this.thePatient.AddressLine1;
            this.address2TextBox.Text = this.thePatient.AddressLine2;
            this.stateComboBox.Text = this.thePatient.State;
            this.cityTextBox.Text = this.thePatient.City;
            this.zipTextBox.Text = this.thePatient.ZipCode;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.thePatientUserControl.Enabled = true;
            this.Close();
        }
    }
}

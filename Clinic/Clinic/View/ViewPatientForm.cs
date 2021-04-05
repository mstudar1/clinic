using Clinic.Model;
using Clinic.UserControls;
using System;
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
            this.patientFirstNameLabel.Text = this.thePatient.FirstName;
            this.patientListNameLabel.Text = this.thePatient.LastName;
            this.patientDobLabel.Text = this.thePatient.DateOfBirth.ToString();
            this.patientSsnLabel.Text = this.thePatient.SocialSecurityNumber;
            this.patientGenderLabel.Text = this.thePatient.Gender;
            this.patientPhoneNumberLabel.Text = this.thePatient.PhoneNumber;
            this.patientAddress1Label.Text = this.thePatient.AddressLine1;
            this.patientAddress2Label.Text = this.thePatient.AddressLine2;
            this.patientStateLabel.Text = this.thePatient.State;
            this.patientCityLabel.Text = this.thePatient.City;
            this.patientZipLabel.Text = this.thePatient.ZipCode;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.thePatientUserControl.Enabled = true;
            this.Close();
        }
    }
}

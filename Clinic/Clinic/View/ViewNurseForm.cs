using Clinic.Controller;
using Clinic.Model;
using Clinic.UserControls;
using System;
using System.Windows.Forms;

namespace Clinic.View
{
    /// <summary>
    /// This class will create and manage actions within the view nurse deails form
    /// </summary>
    public partial class ViewNurseForm : Form
    {
        private readonly Nurse theNurse;
        private readonly NurseUserControl theNurseUserControl;
        private readonly CredentialController theCredentialController;

        /// <summary>
        /// Constructor for view nurse form
        /// </summary>
        /// <param name="theInputNurseUserControl">referring Nurse user control</param>
        /// <param name="theInputedNurse">the Nurse object whose infor will be displayed</param>
        public ViewNurseForm(NurseUserControl theInputNurseUserControl, Nurse theInputedNurse)
        {
            InitializeComponent();
            this.theCredentialController = new CredentialController();
            this.theNurseUserControl = theInputNurseUserControl;
            this.theNurse = theInputedNurse;
            this.theNurseUserControl.Enabled = false;
            this.ShowPatientInformation();
        }

        /// <summary>
        /// Fill in the form fields with the nurse details
        /// </summary>
        private void ShowPatientInformation()
        {
            this.nurseFirstNameLabel.Text = this.theNurse.FirstName;
            this.nurseListNameLabel.Text = this.theNurse.LastName;
            this.nurseDobLabel.Text = this.theNurse.DateOfBirth.ToShortDateString();
            this.nurseSsnLabel.Text = this.theNurse.SocialSecurityNumber;
            this.nurseGenderLabel.Text = this.theNurse.Gender;
            this.nursePhoneNumberLabel.Text = this.theNurse.PhoneNumber;
            this.nurseAddress1Label.Text = this.theNurse.AddressLine1;
            this.nurseAddress2Label.Text = this.theNurse.AddressLine2;
            this.nurseStateLabel.Text = this.theNurse.State;
            this.nurseCityLabel.Text = this.theNurse.City;
            this.nurseZipLabel.Text = this.theNurse.ZipCode;
            this.nurseUsernameLabel.Text = this.theCredentialController.GetUsername(this.theNurse.PersonId);
            if (this.theNurse.IsActive)
            {
                this.nurseIsActiveLabel.Text = "Yes";
            }
            else
            {
                this.nurseIsActiveLabel.Text = "No";
            }
            

        }

        /// <summary> 
        /// Handle cancel button clicks by enableing the referring user control and closing this form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.theNurseUserControl.Enabled = true;
            this.Close();
        }

        /// <summary>
        /// Handle form closing events by re-enabling the referring user control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewPatient_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.theNurseUserControl.Enabled = true;
        }
    }
}

using Clinic.View;
using System;
using System.Windows.Forms;

namespace Clinic.UserControls
{

    /// <summary>
    /// The PatientUserControl class creates user control to be added in the NurseAdminForm form's "Patient" tab.
    /// Patient controler let's admin and nurse to see the list of patient, add a new patient to the list, edit and delete existing patient list.
    /// </summary>
    public partial class PatientUserControl : UserControl
    {

        private RegisterPatientForm theRegisterPatientForm;

        /// <summary>
        /// The constructor initializes the components
        /// </summary>
        public PatientUserControl()
        {
            InitializeComponent();
            this.theRegisterPatientForm = null;
        }

        /// <summary>
        ///  The method sets the RegisterPatientForm to show it.
        /// </summary>
        /// <param name="theInputRegisterPatientForm"> Inputted form </param>
        public void SetNurseAdminForm(RegisterPatientForm theInputRegisterPatientForm)
        {
            this.theRegisterPatientForm = theInputRegisterPatientForm;
        }

        private void RegisterPatientButton_Click(object sender, System.EventArgs e)
        {
            this.theRegisterPatientForm = new RegisterPatientForm(this);
            theRegisterPatientForm.Show();
        }

        private void Search()
        {
            if (DateTime.Compare(this.dateOfBirthDateTimePicker.Value, DateTime.Now) > 0)
            {
                MessageBox.Show("The date of birth cannot be in the future.  Please revise the date and resubmit.", "Invalid Date of Birth");
                return;
            }

            // TODO: add the code to search here
        }

        private void SearchButton_Click(object sender, System.EventArgs e)
        {
            this.Search();
        }

        private void DateOfBirthDateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Search();
            }
        }

        private void ResetButton_Click(object sender, System.EventArgs e)
        {

        }
    }
}
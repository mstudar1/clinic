using Clinic.UserControls;
using System;
using System.Windows.Forms;

namespace Clinic.View
{
    /// <summary>
    /// Class defining a form that can be used to register patients.
    /// </summary>
    public partial class RegisterPatientForm : Form
    {
        private readonly PatientUserControl thePatientUserControl;

        /// <summary>
        /// Constructor for the RegisterPatientForm class.
        /// </summary>
        /// <param name="theInputPatientUserControl"></param>
        public RegisterPatientForm(PatientUserControl theInputPatientUserControl)
        {
            InitializeComponent();
            this.thePatientUserControl = theInputPatientUserControl;
        }

        private void RegisterButton_Click(object sender, System.EventArgs e)
        {
            if (DateTime.Compare(this.dateOfBirthDateTimePicker.Value, DateTime.Now) > 0)
            {
                MessageBox.Show("The date of birth cannot be in the future.  Please revise the date and resubmit.", "Invalid Date of Birth");
                return;
            }
        }
    }
}
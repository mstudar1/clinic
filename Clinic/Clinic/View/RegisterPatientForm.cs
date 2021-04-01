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

        /// <summary>
        /// Constructor used to initialize the thePatientUserControl and 
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
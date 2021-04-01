using Clinic.Controller;
using Clinic.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Clinic.View
{

    /// <summary>
    /// The NurseAdminForm class creates form with tabs, using user controls.
    /// Available tabs: Appointments    -   for nurse/admin
    ///                 Patients        -   for nurse/admin
    ///                 Visits          -   for nurse/admin
    ///                 Nurses          -   for admin
    /// </summary>
    public partial class NurseAdminForm : Form
    {
        private LoginForm theLoginForm;
        private CredentialController theCredentialController;

        /// <summary>
        /// The constructor initializes the components
        /// </summary>
        /// <param name="theInputLoginForm"></param>
        public NurseAdminForm(LoginForm theInputLoginForm)
        {
            InitializeComponent();
            this.theLoginForm = theInputLoginForm;
            theCredentialController = new CredentialController();
        }

        /// <summary>
        /// The method sets username(nurse or admin) to display on upper right corner of the form
        /// </summary>
        /// <param name="inputUuserName"> The inputted user name </param>
        public void SetActiveUsername(String inputUserName)
        {
            this.activeUsernameLabel.Text = inputUserName;
        }

        /// <summary>
        /// The method sets the Login form
        /// </summary>
        /// <param name="theInputLoginForm"> Inputted loginform </param>
        public void SetTheLoginForm(LoginForm theInputLoginForm)
        {
            this.theLoginForm = theInputLoginForm;
        }

        // Exits the program when the NurseAdminForm 'X' is clicked
        private void ApplicationFormsClosing(object sender, FormClosingEventArgs e)
        {
            var loginFormToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is LoginForm);
            loginFormToShow.Close();

        }

        private void LogoutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // calling an old LoginForm and Shows it
            this.theLoginForm.SetNurseAdminForm(this);
            this.theLoginForm.Show();
            this.Hide();
        }

        private void RefreshNurseList(object sender, EventArgs e)
        {
           // this.displayOpenIncidentsUserControl1.RefreshData();
        }

        /// <summary>
        /// Method displays the Nurse tab only if the logged in user is admin and hides the Nurse tab for the nurses.
        /// </summary>
        public void ShowNurseTabOnlyForAdmin()
        {

            Person user = this.theCredentialController.GetUser(this.activeUsernameLabel.Text);
      
            if (this.nurseAdminTabControl.TabPages.Contains(nurseTabPage))
            {
                if (user is Nurse)
                {
                    this.nurseAdminTabControl.TabPages.Remove(nurseTabPage);
                }
            } 
            else
            {
                if (user is Administrator)
                {
                    this.nurseAdminTabControl.TabPages.Add(nurseTabPage);
                }
            }
        }

    }
}

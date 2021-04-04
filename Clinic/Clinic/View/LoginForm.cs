using Clinic.Controller;
using Clinic.View;
using System;
using System.Windows.Forms;

namespace Clinic
{

    /// <summary>
    /// The LoginForm class let's user to input username and password to Login to form for the nurses and admins (after credentials check)
    /// </summary>
    public partial class LoginForm : Form
    {
        private NurseAdminForm theNurseAdminForm;
        private readonly CredentialController theCredentialController;

        /// <summary>
        /// The constructor initializes the components
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
            this.theNurseAdminForm = null;
            this.theCredentialController = new CredentialController();

        }

        /// <summary>
        ///  The method sets the NurseAdminForm to show it.
        /// </summary>
        /// <param name="theInputNurseAdminForm"> Inputted form</param>
        public void SetNurseAdminForm(NurseAdminForm theInputNurseAdminForm)
        {
            this.theNurseAdminForm = theInputNurseAdminForm;
        }

        /// <summary>
        /// Executes the actions to check credentials and attempt to log in to the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckCredentials(object sender, EventArgs e)
        {
            string username = this.usernameTextBox.Text;
            string password = this.passwordTextBox.Text;
            try
            {
                if (this.theCredentialController.CredentialsAreValid(username, password))
                {
                    if (this.theNurseAdminForm == null)
                    {
                        this.theNurseAdminForm = new NurseAdminForm(this);
                    }
                    else
                    {
                        this.theNurseAdminForm.SetTheLoginForm(this);
                    }
                    this.theNurseAdminForm.SetActiveUsername(username);
                    this.theNurseAdminForm.ShowNurseTabOnlyForAdmin();
                    this.theNurseAdminForm.Show();
                    this.theNurseAdminForm.SetActiveUsername(usernameTextBox.Text);
                    this.passwordTextBox.Text = "";
                    this.Hide();
                }
                else
                {
                    this.errorMessageLabel.Text = "Invalid username/password";
                }
            } catch (ArgumentNullException ex)
            {
                if (ex.ParamName == "username")
                    this.errorMessageLabel.Text = "Please enter a username";
                else if (ex.ParamName == "password")
                    this.errorMessageLabel.Text = "Please enter a password";
            } 
        }

        /// <summary>
        /// Clear error messages when new text entered in textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EntryInTextbox(object sender, EventArgs e)
        {
            this.errorMessageLabel.Text = "";
        }

    }
}

using Clinic.Controller;
using Clinic.View;
using System;
using System.Drawing;
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


        private void CheckCredentials(object sender, EventArgs e)
        {
            string username = this.usernameTextBox.Text;
            string password = this.passwordTextBox.Text;
            bool result = this.theCredentialController.CredentialsAreValid(username, password);
            if (result)
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

                theNurseAdminForm.Show();
                theNurseAdminForm.SetActiveUsername(usernameTextBox.Text);

                this.Hide();
            }
            else
            {
                errorMessageLabel.ForeColor = Color.Red;
                errorMessageLabel.Text = "Invalid username/password";
            }
        }

        private void EntryInTextbox(object sender, EventArgs e)
        {
            errorMessageLabel.Text = "";
        }
    }
}

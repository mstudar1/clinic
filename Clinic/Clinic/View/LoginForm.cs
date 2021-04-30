using Clinic.Controller;
using Clinic.View;
using System;
using System.Security.Cryptography;
using System.Text;
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
        /// Executes the actions to check credentials and attempt to log in to the application.
        /// Passwords are hashed using SHA256 before being checked against the DB to prevent 
        /// passwords from being stored anywhere in the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = this.usernameTextBox.Text;

            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(this.passwordTextBox.Text));
                string passwordHash = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();

                try
                {
                    if (this.theCredentialController.CredentialsAreValid(username, passwordHash))
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
                        this.theNurseAdminForm.ShowReportTabOnlyForAdmin();
                        this.theNurseAdminForm.ShowAppointmentsTabOnlyForNurse();
                        this.theNurseAdminForm.ShowVisitsTabOnlyForNurse();
                        this.theNurseAdminForm.ShowPatientsTabOnlyForNurse();
                        this.theNurseAdminForm.Show();
                        this.theNurseAdminForm.SetActiveUsername(usernameTextBox.Text);
                        this.theNurseAdminForm.SetCurrentUserOnAppointmentUserControl();
                        this.passwordTextBox.Text = "";
                        this.Hide();
                    }
                    else
                    {
                        this.errorMessageLabel.Text = "Invalid username/password";
                    }
                }
                catch (ArgumentNullException ex)
                {
                    if (ex.ParamName == "username")
                        this.errorMessageLabel.Text = "Please enter a username";
                    else if (ex.ParamName == "password")
                        this.errorMessageLabel.Text = "Please enter a password";
                }
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
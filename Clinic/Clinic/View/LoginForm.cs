using Clinic.View;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Clinic
{
    public partial class LoginForm : Form
    {
        NurseAdminForm theNurseAdminForm;

        public LoginForm()
        {
            InitializeComponent();
            this.theNurseAdminForm = null;
        }

        public void SetNurseAdminForm(NurseAdminForm theInputNurseAdminForm)
        {
            this.theNurseAdminForm = theInputNurseAdminForm;
        }

        private void CheckCredentials(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "admin" && passwordTextBox.Text == "admin")
            {
                if (this.theNurseAdminForm == null)
                {
                    this.theNurseAdminForm = new NurseAdminForm(this);
                }
                else
                {
                    this.theNurseAdminForm.SetTheLoginForm(this);
                }
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

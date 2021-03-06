﻿using Clinic.View;
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
        NurseAdminForm theNurseAdminForm;

        /// <summary>
        /// The constructor initializes the components
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
            this.theNurseAdminForm = null;
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

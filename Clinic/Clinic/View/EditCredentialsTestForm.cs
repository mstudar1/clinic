using Clinic.Controller;
using System;
using System.Windows.Forms;

namespace Clinic.View
{
    public partial class EditCredentialsTestForm : Form
    {
        private CredentialController credentialController;

        public EditCredentialsTestForm()
        {
            InitializeComponent();
            this.credentialController = new CredentialController();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            string originalUsername = "admin";
            string newUsername = "admin";
            string newUnhashedPassword = "test10";
            bool result = this.credentialController.EditCredentials(originalUsername, newUsername, newUnhashedPassword);
            MessageBox.Show(result.ToString());
        }
    }
}
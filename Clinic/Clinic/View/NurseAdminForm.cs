using System;
using System.Windows.Forms;

namespace Clinic.View
{
    public partial class NurseAdminForm : Form
    {

        private LoginForm theLoginForm;

        public NurseAdminForm(LoginForm theInputLoginForm)
        {
            InitializeComponent();
            this.theLoginForm = theInputLoginForm;
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
        /// The method sets the login form
        /// </summary>
        /// <param name="theInputLoginForm"> Inputted loginform </param>
        public void SetTheLoginForm(LoginForm theInputLoginForm)
        {
            this.theLoginForm = theInputLoginForm;
        }
    }
}

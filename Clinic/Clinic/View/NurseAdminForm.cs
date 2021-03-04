using System;
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

        /// <summary>
        /// The constructor initializes the components
        /// </summary>
        /// <param name="theInputLoginForm"></param>
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
        /// The method sets the Login form
        /// </summary>
        /// <param name="theInputLoginForm"> Inputted loginform </param>
        public void SetTheLoginForm(LoginForm theInputLoginForm)
        {
            this.theLoginForm = theInputLoginForm;
        }
    }
}

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
        private readonly CredentialController theCredentialController;
        private string username;

        /// <summary>
        /// The constructor initializes the components
        /// </summary>
        /// <param name="theInputLoginForm"></param>
        public NurseAdminForm(LoginForm theInputLoginForm)
        {
            InitializeComponent();
            this.theLoginForm = theInputLoginForm;
            theCredentialController = new CredentialController();
            this.username = "";
            this.patientUserControl1.SetNurseAdminForm(this);
        }

        /// <summary>
        /// The method sets username(nurse or admin) for the form and displays it along 
        /// with the full name of the user in upper right corner of the form
        /// </summary>
        /// <param name="inputUuserName"> The inputted user name </param>
        public void SetActiveUsername(String inputUserName)
        {
            this.username = inputUserName;
            String realName = this.theCredentialController.GetUser(this.username).FullName;          
            this.activeUsernameLabel.Text = realName + " (" + this.username + ")";
        }

        /// <summary>
        /// The method sets the Login form
        /// </summary>
        /// <param name="theInputLoginForm"> Inputted loginform </param>
        public void SetTheLoginForm(LoginForm theInputLoginForm)
        {
            this.theLoginForm = theInputLoginForm;
        }

        /// <summary>
        /// Method that can be called to set the value of the instance variable for the current user on the appointment user control.
        /// </summary>
        public void SetCurrentUserOnAppointmentUserControl()
        {
            Person user = this.theCredentialController.GetUser(this.username);
            this.appointmentUserControl1.SetCurrentUser(user);
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
            this.ShowTabPagesForAdmin(nurseTabPage);
        }

        /// <summary>
        /// Method displays the Report tab only if the logged in user is admin and hides the Report tab for the nurses.
        /// </summary>
        public void ShowReportTabOnlyForAdmin()
        {
            this.ShowTabPagesForAdmin(reportTabPage);
        }

        /// <summary>
        /// Method displays the Appointments tab only if the logged in user is nurse and hides 
        /// the Appointments tab for the admins.
        /// </summary>
        public void ShowAppointmentsTabOnlyForNurse()
        {
            this.ShowTabPagesForNurse(appointmentTabPage);
        }

        /// <summary>
        /// Method displays the Visits tab only if the logged in user is nurse and hides 
        /// the Visits tab for the admins.
        /// </summary>
        public void ShowVisitsTabOnlyForNurse()
        {
            this.ShowTabPagesForNurse(visitTabPage);
        }

        /// <summary>
        /// Method displays the Patients tab only if the logged in user is nurse and hides 
        /// the Patients tab for the admins.
        /// </summary>
        public void ShowPatientsTabOnlyForNurse()
        {
            this.ShowTabPagesForNurse(patientTabPage);
        }

        private void ShowTabPagesForNurse(System.Windows.Forms.TabPage tabPage)
        {
            Person user = this.theCredentialController.GetUser(this.username);

            if (this.nurseAdminTabControl.TabPages.Contains(tabPage))
            {
                if (user is Administrator)
                {
                    this.nurseAdminTabControl.TabPages.Remove(tabPage);
                }
            }
            else
            {
                if (user is Nurse)
                {
                    this.nurseAdminTabControl.TabPages.Add(tabPage);
                }
            }
        }

        private void ShowTabPagesForAdmin(System.Windows.Forms.TabPage tabPage)
        {
            Person user = this.theCredentialController.GetUser(this.username);

            if (this.nurseAdminTabControl.TabPages.Contains(tabPage))
            {
                if (user is Nurse)
                {
                    this.nurseAdminTabControl.TabPages.Remove(tabPage);
                }
            }
            else
            {
                if (user is Administrator)
                {
                    this.nurseAdminTabControl.TabPages.Add(tabPage);
                }
            }
        }

        private void PatientUserControl_Load(object sender, EventArgs e)
        {
            this.patientUserControl1.RefreshPatientsListData();
        }
    }
}
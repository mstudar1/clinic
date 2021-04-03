using Clinic.View;
using System.Windows.Forms;

namespace Clinic.UserControls
{

    /// <summary>
    /// The NurseUserControl class creates user control to be added in the NurseAdminForm form's "Nurse" tab.
    /// Nurse controler let's admin to see the list of nurses, add a new nurse to the list, edit and delete existing nurse list.
    /// </summary>
    public partial class NurseUserControl : UserControl
    {
        private AddNurseForm theAddNurseForm;

        /// <summary>
        /// Initialize the form
        /// </summary>
        public NurseUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When button clicked the add nurse form should be called
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterNurseButton_Click(object sender, System.EventArgs e)
        {
            this.theAddNurseForm = new AddNurseForm(this);
            theAddNurseForm.Show();
        }

        private void SearchByName()
        {
            // add the code to search by name here
        }

        private void SearchButton_Click(object sender, System.EventArgs e)
        {
            this.SearchByName();
        }

        private void NurseNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SearchByName();
            }
        }
    }
}
using System.Windows.Forms;
using Clinic.Controller;
using Clinic.UserControls;

namespace Clinic.View
{
    /// <summary>
    /// This is the popup form for entering nurse information when adding a new nurse to the system
    /// </summary>
    public partial class AddNurseForm : Form
    {
        private NurseUserControl theNurseUserControl;
        private NurseController controller;

        /// <summary>
        /// Constructor for the add nurse form
        /// </summary>
        /// <param name="theInputNurseUserControl">the refering usercontrol</param>
        public AddNurseForm(NurseUserControl theInputNurseUserControl)
        {
            InitializeComponent();
            this.theNurseUserControl = theInputNurseUserControl;
        }

        private void AddNurseButton_Click(object sender, System.EventArgs e)
        {
            string firstName = this.firstNameTextBox.Text;
            string lastName = this.lastNameTextBox.Text;
            try
            {
                this.controller.AddNurse();
            }
        }
    }
    

}

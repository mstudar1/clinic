using System;
using System.Windows.Forms;

namespace Clinic.UserControls
{
    /// <summary>
    /// Class that defines a user control for visits.
    /// </summary>
    public partial class VisitUserControl : UserControl
    {
        /// <summary>
        /// Constructor for the VisitUserControl class.
        /// </summary>
        public VisitUserControl()
        {
            InitializeComponent();
        }

        private void Search()
        {
            if (DateTime.Compare(this.visitDateTimePicker.Value, DateTime.Now) > 0)
            {
                MessageBox.Show("The visit date cannot be in the future.  Please revise the date and resubmit.", "Invalid Visit Date");
                return;
            }

            // TODO: add code to search here
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            this.Search();
        }

        private void PatientIdTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Search();
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {

        }
    }
}
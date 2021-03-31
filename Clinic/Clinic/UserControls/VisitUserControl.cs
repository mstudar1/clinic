using System;
using System.Windows.Forms;

namespace Clinic.UserControls
{
    public partial class VisitUserControl : UserControl
    {
        public VisitUserControl()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (DateTime.Compare(this.visitDateTimePicker.Value, DateTime.Now) > 0)
            {
                MessageBox.Show("The visit date cannot be in the future.  Please revise the date and resubmit.", "Invalid Visit Date");
                return;
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {

        }
    }
}
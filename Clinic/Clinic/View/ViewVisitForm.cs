using Clinic.Model;
using System;
using System.Windows.Forms;

namespace Clinic.View
{
    public partial class ViewVisitForm : Form
    {
        private Visit theVisit;

        public ViewVisitForm(Visit theVisit)
        {
            if (theVisit == null)
            {
                throw new ArgumentNullException("theVisit", "The visit object cannot be null.");
            }

            InitializeComponent();
            this.theVisit = theVisit;
        }

        private void ViewVisitForm_Load(object sender, EventArgs e)
        {
            this.visitBindingSource.Add(this.theVisit);
        }

        private void OkayButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}

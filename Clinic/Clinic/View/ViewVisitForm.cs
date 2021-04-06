using Clinic.Model;
using System;
using System.Windows.Forms;

namespace Clinic.View
{
    public partial class ViewVisitForm : Form
    {
        private readonly Visit theVisit;

        public ViewVisitForm(Visit theVisit)
        {
            InitializeComponent();
            this.theVisit = theVisit ?? throw new ArgumentNullException("theVisit", "The visit object cannot be null.");
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

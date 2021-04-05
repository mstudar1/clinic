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
    }
}

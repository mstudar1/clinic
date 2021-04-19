using Clinic.Model;
using System;
using System.Windows.Forms;

namespace Clinic.View
{
    /// <summary>
    /// Class to display and manage form for displaying visit information
    /// and allowing for visit managemrnt (lab tests, diagnosis, etc.)
    /// </summary>
    public partial class ViewVisitForm : Form
    {
        private readonly Visit theVisit;

        /// <summary>
        /// Constructor for the form
        /// </summary>
        /// <param name="theVisit">The Visit object being managed in the form</param>
        public ViewVisitForm(Visit theVisit)
        {
            InitializeComponent();
            this.theVisit = theVisit ?? throw new ArgumentNullException("theVisit", "The visit object cannot be null.");
        }

        /// <summary>
        /// Handler for load events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewVisitForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'conductedLabTests.ConductedLabTest' table. You can move, or remove it, as needed.
            this.conductedLabTestTableAdapter.Fill(this.conductedLabTests.ConductedLabTest);
            this.visitBindingSource.Add(this.theVisit);
        }

        /// <summary>
        /// Hndler for button click events of the Okay (Close) button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OkayButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}

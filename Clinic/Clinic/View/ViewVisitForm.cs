using Clinic.Controller;
using Clinic.Model;
using System;
using System.Collections.Generic;
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
        private List<ConductedLabTest> theTests;
        private DiagnosisController theDiagnosisController;
        private ConductedLabTestController theConductedLabTestController;
        private bool finalDiagnosis;

        /// <summary>
        /// Constructor for the form
        /// </summary>
        /// <param name="theVisit">The Visit object being managed in the form</param>
        public ViewVisitForm(Visit theVisit)
        {
            InitializeComponent();
            this.theDiagnosisController = new DiagnosisController();
            this.theConductedLabTestController = new ConductedLabTestController();
            this.theVisit = theVisit ?? throw new ArgumentNullException("theVisit", "The visit object cannot be null.");
            this.LoadDiagnosis();
            this.EnableDisableButtons();
            this.LoadTests();
        }

        /// <summary>
        /// Handler for load events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewVisitForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'conductedLabTests.ConductedLabTest' table. You can move, or remove it, as needed.
            this.visitBindingSource.Add(this.theVisit);
            this.finalDiagnosis = false;
            this.LoadDiagnosis();
            this.EnableDisableButtons();
            this.LoadTests();
        }

        /// <summary>
        /// Method that can be called to refresh the list of diagnoses.
        /// </summary>
        public void LoadDiagnosis()
        {
            String theAllDiagnosis = "";
            int indexOfDiagnosis = 1;
            List<Diagnosis> theDiagnosis = this.theDiagnosisController.GetDiagnoses(this.GetAppointmentId());
            foreach (Diagnosis theDiagnos in theDiagnosis)
            {
                theAllDiagnosis = theAllDiagnosis + indexOfDiagnosis.ToString() + ". " + theDiagnos.DiagnosisName + "\n";
                indexOfDiagnosis += 1;
                if (theDiagnos.IsFinal)
                {
                    this.finalDiagnosis = true;
                }
            }
            this.diagnosisOutputLabel.Text = theAllDiagnosis;
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

        /// <summary>
        /// Method that can be called to refresh the list of tests.
        /// </summary>
        public void LoadTests()
        {
            this.ClearList();
            this.theTests = this.theConductedLabTestController.GetConductedLabTests(this.GetAppointmentId());
            ConductedLabTest theConductedLabTest;

            for (int i = 0; i < this.theTests.Count; i++)
            {
                theConductedLabTest = this.theTests[i];
                this.testsListView.Items.Add(theConductedLabTest.LabTest.Name);

                string datePerformed;
                if (theConductedLabTest.DatePerformed == default)
                {
                    datePerformed = "Not performed yet";
                } 
                else
                {
                    datePerformed = theConductedLabTest.DatePerformed.ToString();
                }
                this.testsListView.Items[i].SubItems.Add(datePerformed);

                if (theConductedLabTest.Results == null)
                {
                    this.testsListView.Items[i].SubItems.Add("N/A");
                }
                else
                {
                    this.testsListView.Items[i].SubItems.Add(theConductedLabTest.Results);
                }    
                
                if (theConductedLabTest.IsNormal && datePerformed != "Not performed yet")
                {
                    this.testsListView.Items[i].SubItems.Add("Yes");
                }
                else if (datePerformed != "Not performed yet")
                {
                    this.testsListView.Items[i].SubItems.Add("No");
                }
                else
                {
                    this.testsListView.Items[i].SubItems.Add("N/A");
                }
            }
        }

        private void ClearList()
        {
            foreach (ListViewItem item in this.testsListView.Items)
            {
                this.testsListView.Items.Remove(item);
            }
        }

        private void OrderTestButton_Click(object sender, EventArgs e)
        {
            OrderNewLabTestForm theOrderNewLabtestForm = new OrderNewLabTestForm(this);
            theOrderNewLabtestForm.Show();
        }

        /// <summary>
        /// Gets the appointment ID associated with the form.
        /// </summary>
        /// <returns></returns>
        public int GetAppointmentId()
        {
            return this.theVisit.AppointmentId;
        }

        /// <summary>
        /// Enables/Disables buttons depending on options that shoujld be available
        /// to user
        /// </summary>
        private void EnableDisableButtons()
        {
            if (this.finalDiagnosis)
            {
                this.orderTestButton.Enabled = false;
                this.addDiagnosisButton.Enabled = false;
                this.enterResultButton.Enabled = false;
            }
            else
            {
                this.addDiagnosisButton.Enabled = true;
                this.orderTestButton.Enabled = true;
                this.enterResultButton.Enabled = true;
            }
        }

        private void EnterResult_Click(object sender, EventArgs e)
        {
            if (this.testsListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a Test, then click the button again.", "Select a Test to Enter Results");
                return;
            }
            int selectedIndex = this.testsListView.SelectedIndices[0];
            ConductedLabTest selectedTest = this.theTests[selectedIndex];
            try
            {
                EnterLabTestResultForm enterLabTestResultForm = new EnterLabTestResultForm(selectedTest.LabTest.TestCode, this);
                enterLabTestResultForm.Show();
            }
            catch (Exception)
            {
                this.Enabled = true;
            }
                     
        }

        /// <summary>
        /// On button click open up new AddDiagnosis form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDiagnosisButton_Click(object sender, EventArgs e)
        {
            AddDiagnosisForm addDiagnosisForm = new AddDiagnosisForm(this);
            addDiagnosisForm.Show();
        }

        private void ViewVisitForm_EnabledChanged(object sender, EventArgs e)
        {
            this.LoadDiagnosis();
            this.EnableDisableButtons();
            this.LoadTests();
        }
    }
}

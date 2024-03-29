﻿using Clinic.Controller;
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
        private readonly DiagnosisController theDiagnosisController;
        private readonly ConductedLabTestController theConductedLabTestController;
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
                this.editVisitButton.Enabled = false;
            }
            else
            {
                this.addDiagnosisButton.Enabled = true;
                this.orderTestButton.Enabled = true;
                this.enterResultButton.Enabled = true;
                this.editVisitButton.Enabled = true;
            }
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

        /// <summary>
        /// Hndler for button click events of the Close button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Handles order test button click events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderTestButton_Click(object sender, EventArgs e)
        {
            OrderNewLabTestForm theOrderNewLabtestForm = new OrderNewLabTestForm(this);
            theOrderNewLabtestForm.Show();
        } 

        /// <summary>
        /// HAndles the enter results button click events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Refresh needed elements when form is re-enabled
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewVisitForm_EnabledChanged(object sender, EventArgs e)
        {
            this.LoadDiagnosis();
            this.EnableDisableButtons();
            this.LoadTests();
        }

        /// <summary>
        /// Updates the fields in the Visit instance 
        /// </summary>
        /// <param name="newVisit">the new Visit object holding the revised info</param>
        public void UpdateFormVisitInfo(Visit newVisit)
        {
            this.theVisit.Weight = newVisit.Weight;
            this.theVisit.Pulse = newVisit.Pulse;
            this.theVisit.SystolicBloodPressure = newVisit.SystolicBloodPressure;
            this.theVisit.DiastolicBloodPressure = newVisit.DiastolicBloodPressure;
            this.theVisit.BodyTemperature = newVisit.BodyTemperature;
            this.theVisit.Symptoms = newVisit.Symptoms;
            this.visitBindingSource.ResetBindings(false);
        }

        /// <summary>
        /// Handles edit button clicks.  Opens the EditVisit form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditVisitButton_Click(object sender, EventArgs e)
        {
            EditVisitForm theEditVisitForm = new EditVisitForm(this, this.theVisit.AppointmentId, this.theVisit.NurseId);
            theEditVisitForm.Show();
        }

        /// <summary>
        /// Clears the list view
        /// </summary>
        private void ClearList()
        {
            foreach (ListViewItem item in this.testsListView.Items)
            {
                this.testsListView.Items.Remove(item);
            }
        }

        /// <summary>
        /// Gets the appointment ID associated with the form.
        /// </summary>
        /// <returns>the appointment ID</returns>
        public int GetAppointmentId()
        {
            return this.theVisit.AppointmentId;
        }

        /// <summary>
        /// Gets the visit being used by this object
        /// </summary>
        /// <returns>the Visit object being used on this form</returns>
        public Visit GetVisit()
        {
            return this.theVisit;
        }
    }
}

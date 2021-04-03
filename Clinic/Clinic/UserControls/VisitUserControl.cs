using Clinic.Controller;
using Clinic.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Clinic.UserControls
{
    /// <summary>
    /// Class that defines a user control for visits.
    /// </summary>
    public partial class VisitUserControl : UserControl
    {
        private readonly VisitController theVisitController;

        /// <summary>
        /// Constructor for the VisitUserControl class.
        /// </summary>
        public VisitUserControl()
        {
            InitializeComponent();
            this.theVisitController = new VisitController();
        }

        private void Search()
        {
            this.ClearList();
            this.PopulateList();
        }

        private void ClearList()
        {
            foreach (ListViewItem item in this.visitListView.Items)
            {
                this.visitListView.Items.Remove(item);
            }
        }

        private void PopulateList()
        {
            List<Visit> visitList;
            try
            {
                int patientId = int.Parse(this.patientIdTextBox.Text);
                visitList = this.theVisitController.FindVisits(patientId);

                if (visitList.Count > 0)
                {
                    Visit theVisit;
                    for (int i = 0; i < visitList.Count; i++)
                    {
                        theVisit = visitList[i];
                        this.visitListView.Items.Add(theVisit.PatientFullName);
                        this.visitListView.Items[i].SubItems.Add(theVisit.PatientDateOfBirth.ToShortDateString());
                        this.visitListView.Items[i].SubItems.Add(theVisit.DoctorFullName);
                        this.visitListView.Items[i].SubItems.Add(theVisit.NurseFullName);
                        this.visitListView.Items[i].SubItems.Add(theVisit.VisitDate.ToShortDateString());
                    }
                }
                else
                {
                    MessageBox.Show("There are no visits for the specified patient.", "No Matching Visits");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
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
            this.ClearList();
        }
    }
}
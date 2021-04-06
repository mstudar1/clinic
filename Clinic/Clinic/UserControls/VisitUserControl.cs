using Clinic.Controller;
using Clinic.Model;
using Clinic.View;
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
        private List<Visit> visitList;

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
            try
            {
                string lastName = this.lastNameTextBox.Text;
                this.visitList = this.theVisitController.FindVisits(lastName);

                if (this.visitList.Count > 0)
                {
                    Visit theVisit;
                    for (int i = 0; i < visitList.Count; i++)
                    {
                        theVisit = this.visitList[i];
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

        private void ViewVisitDetailsButton_Click(object sender, EventArgs e)
        {
            if (this.visitListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a visit, then click the button again.", "Select a Visit to View");
                return;
            }

            int selectedIndex = this.visitListView.SelectedIndices[0];
            Visit selectedVisit = this.visitList[selectedIndex];
            ViewVisitForm theViewVisitForm = new ViewVisitForm(selectedVisit);
            theViewVisitForm.ShowDialog();
        }
    }
}
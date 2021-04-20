using Clinic.Controller;
using Clinic.Model;
using Clinic.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Clinic.UserControls
{

    /// <summary>
    /// The NurseUserControl class creates user control to be added in the NurseAdminForm form's "Nurse" tab.
    /// Nurse controler let's admin to see the list of nurses, add a new nurse to the list, edit and delete existing nurse list.
    /// </summary>
    public partial class NurseUserControl : UserControl
    {
        private AddNurseForm theAddNurseForm;
        private EditNurseForm theEditNurseForm;
        private ViewNurseForm theViewNurseForm;
        private readonly NurseController theNurseController;
        public List<Nurse> nurseList;

        /// <summary>
        /// Initialize the form
        /// </summary>
        public NurseUserControl()
        {
            InitializeComponent();
            this.theNurseController = new NurseController();
        }

        /// <summary>
        /// When button clicked the add nurse form should be called
        /// </summary>
        private void RegisterNurseButton_Click(object sender, System.EventArgs e)
        {
            this.theAddNurseForm = new AddNurseForm(this);
            theAddNurseForm.Show();
        }

        private void SearchByName()
        {
            this.ClearList();
            this.PopulateList();
        }

        /// <summary>
        /// The Method clears list and removes items from the list
        /// </summary>
        public void ClearList()
        {
            foreach (ListViewItem item in this.nurseListView.Items)
            {
                this.nurseListView.Items.Remove(item);
            }
        }

        public void PopulateList()
        {
            try
            {
                string lastName = this.lastNameTextBox.Text;
                this.nurseList = this.theNurseController.FindNurses(lastName);

                if (this.nurseList.Count > 0)
                {
                    Nurse theNurse;
                    for (int i = 0; i < this.nurseList.Count; i++)
                    {
                        theNurse = this.nurseList[i];
                        this.nurseListView.Items.Add(theNurse.FirstName);
                        this.nurseListView.Items[i].SubItems.Add(theNurse.LastName);
                        this.nurseListView.Items[i].SubItems.Add(theNurse.DateOfBirth.ToShortDateString());
                    }
                }
                else
                {
                    MessageBox.Show("There are no nurses with the specified last name.", "No Matching Nurses");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void SearchButton_Click(object sender, System.EventArgs e)
        {
            this.SearchByName();
        }

        private void NurseNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SearchByName();
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            this.ClearList();
        }

        /// <summary>
        /// Handles edit nurse button clicks to open the edit nurse form with selected nurse info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditNurseButton_Click(object sender, EventArgs e)
        {
            this.ResetFormMessages();
            if (this.nurseListView.SelectedItems.Count == 0)
            {
                this.alertTextLabel.Text = "Please select a nurse to edit.";
            }
            else
            {
                int selectedIndex = this.nurseListView.SelectedIndices[0];
                Nurse selectedNurse = this.nurseList[selectedIndex];
                this.theEditNurseForm = new EditNurseForm(this, selectedNurse);
                this.theEditNurseForm.Show();
            }
        }

        /// <summary>
        /// Handles view nurse button click events to open view nurse details form for selected nurse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewNurseButton_Click(object sender, EventArgs e)
        {
            this.ResetFormMessages();
            if (this.nurseListView.SelectedItems.Count == 0)
            {
                this.alertTextLabel.Text = "Please select a nurse to view.";
            }
            else
            {
                int selectedIndex = this.nurseListView.SelectedIndices[0];
                Nurse selectedNurse = this.nurseList[selectedIndex];
                this.theViewNurseForm = new ViewNurseForm(this, selectedNurse);
                this.theViewNurseForm.Show();
            }
        }

        /// <summary>
        /// Reset alert messages on the form
        /// </summary>
        public void ResetFormMessages()
        {
            this.alertTextLabel.Text = "";
        }
    }
}
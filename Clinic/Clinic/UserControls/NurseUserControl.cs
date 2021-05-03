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
            this.RefreshNursesListData();
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

        /// <summary>
        /// The Method populates the list of nurses
        /// </summary>
        public void PopulateList()
        {
            try
            {
                string lastName = this.lastNameTextBox.Text;
                this.nurseList = this.theNurseController.FindNurses(lastName);

                if (this.nurseList.Count > 0)
                {
                    this.UpdateListView(this.nurseList);
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

        /// <summary>
        /// Method that can be called to refresh the list of nurses.
        /// </summary>
        public void RefreshNursesListData()
        {
            this.nurseList = this.theNurseController.GetAllNurses();
            this.UpdateListView(this.nurseList);
            this.lastNameTextBox.Text = "";
            this.alertTextLabel.Text = "";
        }

        private void UpdateListView(List<Nurse> nursesList)
        {
            this.ClearList();
            foreach (Nurse theNurse in nursesList)
            {
                ListViewItem item = new ListViewItem(theNurse.FirstName.ToString());
                item.SubItems.Add(theNurse.LastName.ToString());
                item.SubItems.Add(theNurse.DateOfBirth.ToShortDateString());
                this.nurseListView.Items.Add(item);
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
            this.RefreshNursesListData();
        }

        /// <summary>
        /// Handles edit nurse button clicks to open the edit nurse form with selected nurse info
        /// </summary>
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
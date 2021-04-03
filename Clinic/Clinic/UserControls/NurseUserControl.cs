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
        private NurseController theNurseController;

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
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void ClearList()
        {
            foreach (ListViewItem item in this.nurseListView.Items)
            {
                this.nurseListView.Items.Remove(item);
            }
        }

        private void PopulateList()
        {
            List<Nurse> nurseList;
            try
            {
                string lastName = this.lastNameTextBox.Text;
                nurseList = this.theNurseController.FindNurses(lastName);

                if (nurseList.Count > 0)
                {
                    Nurse theNurse;
                    for (int i = 0; i < nurseList.Count; i++)
                    {
                        theNurse = nurseList[i];
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
    }
}
using Clinic.Controller;
using Clinic.Model;
using Clinic.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Clinic.UserControls
{

    /// <summary>
    /// The PatientUserControl class creates user control to be added in the NurseAdminForm form's "Patient" tab.
    /// Patient controler let's admin and nurse to see the list of patient, add a new patient to the list, edit and delete existing patient list.
    /// </summary>
    public partial class PatientUserControl : UserControl
    {

        private RegisterPatientForm theRegisterPatientForm;
        private readonly PatientController thePatientController;

        /// <summary>
        /// The constructor initializes the components
        /// </summary>
        public PatientUserControl()
        {
            InitializeComponent();
            this.theRegisterPatientForm = null;
            this.thePatientController = new PatientController();
        }

        /// <summary>
        ///  The method sets the RegisterPatientForm to show it.
        /// </summary>
        /// <param name="theInputRegisterPatientForm"> Inputted form </param>
        public void SetNurseAdminForm(RegisterPatientForm theInputRegisterPatientForm)
        {
            this.theRegisterPatientForm = theInputRegisterPatientForm;
        }

        private void Search()
        {
            if (DateTime.Compare(this.dateOfBirthDateTimePicker.Value, DateTime.Now) > 0)
            {
                MessageBox.Show("The date of birth cannot be in the future.  Please revise the date and resubmit.", "Invalid Date of Birth");
                return;
            }

            this.ClearList();
            this.PopulateList();
        }

        private void ClearList()
        {
            foreach (ListViewItem item in this.patientListView.Items)
            {
                this.patientListView.Items.Remove(item);
            }
        }

        private void PopulateList()
        {
            List<Patient> patientList;
            try
            {
                DateTime dateOfBirth = this.dateOfBirthDateTimePicker.Value.Date;
                string lastName = this.lastNameTextBox.Text;
                patientList = this.thePatientController.FindPatients(dateOfBirth, lastName);

                if (patientList.Count > 0)
                {
                    Patient thePatient;
                    for (int i = 0; i < patientList.Count; i++)
                    {
                        thePatient = patientList[i];
                        this.patientListView.Items.Add(thePatient.FirstName);
                        this.patientListView.Items[i].SubItems.Add(thePatient.LastName);
                        this.patientListView.Items[i].SubItems.Add(thePatient.DateOfBirth.ToShortDateString());
                        this.patientListView.Items[i].SubItems.Add(thePatient.AddressLine1);
                    }
                }
                else
                {
                    MessageBox.Show("There are no patients with the specified last name and date of birth.", "No Matching Patients");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void RegisterPatientButton_Click(object sender, System.EventArgs e)
        {
            this.theRegisterPatientForm = new RegisterPatientForm(this);
            theRegisterPatientForm.Show();
        }

        private void SearchButton_Click(object sender, System.EventArgs e)
        {
            this.Search();
        }

        private void DateOfBirthDateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Search();
            }
        }

        private void ResetButton_Click(object sender, System.EventArgs e)
        {

        }
    }
}
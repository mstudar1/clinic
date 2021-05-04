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
    /// Patient controler let's admin and nurse to see the list of patient, add a new patient to the list, edit and 
    /// delete existing patient list.
    /// </summary>
    public partial class PatientUserControl : UserControl
    {
        private NurseAdminForm theNurseAdminForm;
        private readonly PatientController thePatientController;
        private List<Patient> thePatientList;

        /// <summary>
        /// The constructor initializes the components
        /// </summary>
        public PatientUserControl()
        {
            InitializeComponent();
            this.thePatientController = new PatientController();
            this.dateOfBirthDateTimePicker.Value = DateTimePicker.MinimumDateTime;
            this.RefreshPatientsListData();
        }

        /// <summary>
        ///  The method sets the NurseAdminForm .
        /// </summary>
        /// <param name="theInputedNurseAdminForm"> Inputted form </param>
        public void SetNurseAdminForm(NurseAdminForm theInputedNurseAdminForm)
        {
            this.theNurseAdminForm = theInputedNurseAdminForm;
        }

        /// <summary>
        /// Handler for resgister button clicks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterPatientButton_Click(object sender, System.EventArgs e)
        {
            RegisterPatientForm theRegisterPatientForm = new RegisterPatientForm(this);
            theRegisterPatientForm.Show();
        }

        /// <summary>
        /// Handler for search button clicks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchButton_Click(object sender, System.EventArgs e)
        {
            String alertText = "";

            if (DateTime.Compare(this.dateOfBirthDateTimePicker.Value, DateTime.Now) > 0)
            {
                alertText += "The date of birth cannot be in the future. ";
            }
            List<Patient> patientsList = this.thePatientController.GetPatientsList();
            if (this.dateOfBirthDateTimePicker.Value > DateTimePicker.MinimumDateTime && this.lastNameTextBox.Text.Length > 0 && this.dateOfBirthDateTimePicker.Format != DateTimePickerFormat.Custom)
            {
                patientsList = this.thePatientController.FindPatients(DateTime.Parse(this.dateOfBirthDateTimePicker.Text), this.lastNameTextBox.Text);
            }
            else if (this.dateOfBirthDateTimePicker.Value > DateTimePicker.MinimumDateTime && this.dateOfBirthDateTimePicker.Format != DateTimePickerFormat.Custom)
            {
                patientsList = this.thePatientController.FindPatients(DateTime.Parse(this.dateOfBirthDateTimePicker.Text));
            }
            else if (this.firstNameTextBox.Text.Length > 0 && this.lastNameTextBox.Text.Length > 0)
            {
                patientsList = this.thePatientController.FindPatients(this.lastNameTextBox.Text, this.firstNameTextBox.Text);
            }
            else
            {
                alertText = "Search patient by DOB, or last name and first name, or DOB and last name. ";

            }
            this.UpdateListView(patientsList);
            this.alertNoticeLabel.Text = alertText;
        }

        /// <summary>
        /// Handler for reset button clicks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, System.EventArgs e)
        {
            this.ResetFieldsAndRefresh();
        }

        /// <summary>
        /// Method every time clears the search fiels, alert message and refreshes the grid view 
        /// </summary>
        public void ResetFieldsAndRefresh()
        {
            this.RefreshPatientsListData();
            this.dateOfBirthDateTimePicker.Value = DateTimePicker.MinimumDateTime;
            this.firstNameTextBox.Text = "";
            this.lastNameTextBox.Text = "";
            this.alertNoticeLabel.Text = "";
        }

        /// <summary>
        /// Method every time clears the patients list from the DataGridView and then goes through the data 
        /// and adds patients to the list
        /// </summary>
        public void RefreshPatientsListData()
        {
            this.thePatientList = this.thePatientController.GetPatientsList();
            this.UpdateListView(this.thePatientList);
        }

        /// <summary>
        /// Method updates ListView for the givet PatientsList.
        /// The list can be all patients list or after search (by DOB, BOD and lastName, firstName and lastName)
        /// </summary>
        /// <param name="patientsList">the patient List</param>
        private void UpdateListView(List<Patient> patientsList)
        {
            this.ClearList();
            foreach (Patient thePatient in patientsList)
            {
                ListViewItem item = new ListViewItem(thePatient.FirstName.ToString());
                item.SubItems.Add(thePatient.LastName.ToString());
                item.SubItems.Add(thePatient.DateOfBirth.ToShortDateString());
                this.patientsListView.Items.Add(item);
            }
        }

        /// <summary>
        /// Clears the list
        /// </summary>
        private void ClearList()
        {
            foreach (ListViewItem item in this.patientsListView.Items)
            {
                this.patientsListView.Items.Remove(item);
            }
        }

        /// <summary>
        /// Method removes default value for DOB
        /// </summary>
        private void DateOfBirthDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (this.dateOfBirthDateTimePicker.Value == DateTimePicker.MinimumDateTime)
            {
                this.dateOfBirthDateTimePicker.Value = DateTime.Now;
                this.dateOfBirthDateTimePicker.Format = DateTimePickerFormat.Custom;
                this.dateOfBirthDateTimePicker.CustomFormat = " ";
            }
            else
            {
                this.dateOfBirthDateTimePicker.Format = DateTimePickerFormat.Short;
            }
        }

        /// <summary>
        /// Handles view patient details button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewPatientDetailsButton_Click(object sender, EventArgs e)
        {
            if (this.patientsListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a Patient, then click the button again.", "Select a Patient to View Details");
                return;
            }
            int selectedIndex = this.patientsListView.SelectedIndices[0];
            Patient theSelectedPatient = this.thePatientList[selectedIndex];
            ViewPatientForm theViewPatientForm = new ViewPatientForm(this, theSelectedPatient);
            theViewPatientForm.Show();
            this.Enabled = false;
        }

        /// <summary>
        /// Handles edit patient details button clicks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditPatientDetailsButton_Click(object sender, EventArgs e)
        {
            if (this.patientsListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a Patient, then click the button again.", "Select a Patient to Edit Details");
                return;
            }
            int selectedIndex = this.patientsListView.SelectedIndices[0];
            Patient theSelectedPatient = this.thePatientList[selectedIndex];
            EditPatientForm theEditPatientForm = new EditPatientForm(this, theSelectedPatient);
            theEditPatientForm.Show();
            this.Enabled = false;
        }

        /// <summary>
        /// Handles view patient appointments button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewPatientAppointmentsButton_Click(object sender, EventArgs e)
        {
            if (this.patientsListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a Patient, then click the button again.", "Select a Patient to View his/her Appointments");
                return;
            }
            int selectedIndex = this.patientsListView.SelectedIndices[0];
            Patient theSelectedPatient = this.thePatientList[selectedIndex];
            this.theNurseAdminForm.nurseAdminTabControl.SelectedTab = theNurseAdminForm.appointmentTabPage;
            this.theNurseAdminForm.appointmentUserControl1.ResetFormMessages();

            this.theNurseAdminForm.appointmentUserControl1.appointmentsSearchResultsListView.Items.Clear();
            this.theNurseAdminForm.appointmentUserControl1.ResetSearchFields();

            List<Appointment> theAppointments = this.theNurseAdminForm.appointmentUserControl1.appointmentController.FindAppointments(theSelectedPatient.PatientId);
            this.theNurseAdminForm.appointmentUserControl1.DisplayAppointmentList(theAppointments);
        }

        /// <summary>
        /// Handles delete patient button clicks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeletePatientButton_Click(object sender, EventArgs e)
        {
            if (this.patientsListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a Patient, then click the button again.", "Select a Patient to Delete");
                return;
            }
            int selectedIndex = this.patientsListView.SelectedIndices[0];
            Patient theSelectedPatient = this.thePatientList[selectedIndex];

            if (MessageBox.Show("Are you sure you want to delete the selected patient: " + theSelectedPatient.FirstName + " " + theSelectedPatient.LastName + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    this.thePatientController.DeletePatient(theSelectedPatient);
                    this.RefreshPatientsListData();
                }
                catch
                {
                    MessageBox.Show("Records for the patient already exist; therefore, he/she cannot be deleted.", "Could Not Delete Patient");
                }
            }
        }
    }
}
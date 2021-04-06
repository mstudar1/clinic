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

        
        private void RegisterPatientButton_Click(object sender, System.EventArgs e)
        {
            RegisterPatientForm theRegisterPatientForm = new RegisterPatientForm(this);
            theRegisterPatientForm.Show();
        }

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
            List<Patient> patientsList = this.thePatientController.GetPatientsList();
            this.UpdateListView(patientsList);
        }

        /// <summary>
        /// Method updates ListView for the givet PatientsList.
        /// The list can be all patients list or after search (by DOB, BOD and lastName, firstName and lastName)
        /// </summary>
        /// <param name="patientsList">the patient List</param>
        private void UpdateListView(List<Patient> patientsList)
        {
            try
            {
                this.patientBindingSource.Clear();


                if (patientsList.Count > 0)
                {
                    for (int i = 0; i < patientsList.Count; i++)
                    {
                        this.patientBindingSource.Add(patientsList[i]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        /// <summary>
        /// Method removes default value for DOB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void PatientDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.patientDataGridView.Columns[e.ColumnIndex].Name == "Edit")
            {
                Patient theSelectedPatient = (Patient)this.patientBindingSource.Current;
                EditPatientForm theEditPatientForm = new EditPatientForm(this, theSelectedPatient);
                theEditPatientForm.Show();
                this.Enabled = false;
            } else if (this.patientDataGridView.Columns[e.ColumnIndex].Name == "View")
            {
                Patient theSelectedPatient = (Patient)this.patientBindingSource.Current;
                ViewPatientForm theViewPatientForm = new ViewPatientForm(this,theSelectedPatient);
                theViewPatientForm.Show();
                this.Enabled = false;

            } else if (this.patientDataGridView.Columns[e.ColumnIndex].Name == "Appointments")
            {
                Patient theSelectedPatient = (Patient)this.patientBindingSource.Current;
                this.theNurseAdminForm.nurseAdminTabControl.SelectedTab = theNurseAdminForm.appointmentTabPage;
                this.theNurseAdminForm.appointmentUserControl1.ResetFormMessages();

                this.theNurseAdminForm.appointmentUserControl1.appointmentsSearchResultsListView.Items.Clear();

                List < Appointment > theAppointments = this.theNurseAdminForm.appointmentUserControl1.appointmentController.FindAppointments(theSelectedPatient.PatientId);

                foreach (Appointment current in theAppointments)
                {
                    ListViewItem item = new ListViewItem(current.PatientLastName.ToString());
                    item.SubItems.Add(current.PatientFirstName.ToString());
                    item.SubItems.Add(current.StartDateTime.ToString("dddd, dd MMMM yyyy"));
                    item.SubItems.Add(current.StartDateTime.ToString("hh:mm tt"));
                    item.SubItems.Add(current.EndDateTime.ToString("hh:mm tt"));
                    item.SubItems.Add(current.DoctorLastName.ToString());
                    this.theNurseAdminForm.appointmentUserControl1.appointmentsSearchResultsListView.Items.Add(item);
                }

            }
        }
    }
}
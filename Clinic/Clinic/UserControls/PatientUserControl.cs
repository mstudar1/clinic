﻿using Clinic.Controller;
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

        private PatientController thePatientController;
        private RegisterPatientForm theRegisterPatientForm;

        /// <summary>
        /// The constructor initializes the components
        /// </summary>
        public PatientUserControl()
        {
            InitializeComponent();
            this.thePatientController = new PatientController();
            this.dateOfBirthDateTimePicker.Value = DateTimePicker.MinimumDateTime;
            this.theRegisterPatientForm = null;
            this.RefreshPatientsListData();
        }

        /// <summary>
        ///  The method sets the RegisterPatientForm to show it.
        /// </summary>
        /// <param name="theInputRegisterPatientForm"> Inputted form </param>
        public void SetNurseAdminForm(RegisterPatientForm theInputRegisterPatientForm)
        {
            this.theRegisterPatientForm = theInputRegisterPatientForm;
        }

        private void RegisterPatientButton_Click(object sender, System.EventArgs e)
        {
            theRegisterPatientForm = new RegisterPatientForm(this);
            theRegisterPatientForm.Show();
        }

        private void SearchButton_Click(object sender, System.EventArgs e)
        {
            List<Patient> patientsList = this.thePatientController.GetPatientsList();
            if (this.dateOfBirthDateTimePicker.Value > DateTimePicker.MinimumDateTime && this.lastNameTextBox.Text.Length > 0 && this.dateOfBirthDateTimePicker.Format != DateTimePickerFormat.Custom) 
            {
                patientsList = this.thePatientController.FindPatients(DateTime.Parse(this.dateOfBirthDateTimePicker.Text), this.lastNameTextBox.Text);
                //MessageBox.Show("Person ID: " + currentPatient.PersonId + "\n" + "Name: " + currentPatient.FirstName + " " + currentPatient.LastName);
            }
            else if (this.dateOfBirthDateTimePicker.Value > DateTimePicker.MinimumDateTime && this.dateOfBirthDateTimePicker.Format != DateTimePickerFormat.Custom)
            {
                patientsList = this.thePatientController.FindPatients(DateTime.Parse(this.dateOfBirthDateTimePicker.Text));
            }
            else if (this.firstNameTextBox.Text.Length > 0 && this.lastNameTextBox.Text.Length > 0)
            {
                patientsList = this.thePatientController.FindPatients(this.lastNameTextBox.Text, this.firstNameTextBox.Text);
            }
            this.UpdateListView(patientsList);
        }

        private void ResetButton_Click(object sender, System.EventArgs e)
        {
            this.RefreshPatientsListData();
            this.dateOfBirthDateTimePicker.Value = DateTimePicker.MinimumDateTime;
            this.firstNameTextBox.Text = "";
            this.lastNameTextBox.Text = "";
        }

        /// <summary>
        /// Method every time clears the patients list from the ViewList and then goes through the data 
        /// and adds patients to the list
        /// </summary>
        public void RefreshPatientsListData()
        {
            List<Patient> patientsList = this.thePatientController.GetPatientsList();
            this.UpdateListView(patientsList);
        }

        private void UpdateListView(List<Patient> patientsList)
        {
            try
            {
                this.patientListView.Items.Clear();

                if (patientsList.Count > 0)
                {
                    Patient thePatient;
                    for (int i = 0; i < patientsList.Count; i++)
                    {
                        thePatient = patientsList[i];
                        this.patientListView.Items.Add(thePatient.FirstName);
                        this.patientListView.Items[i].SubItems.Add(thePatient.LastName);
                        this.patientListView.Items[i].SubItems.Add(thePatient.DateOfBirth.ToShortDateString());
                        this.patientListView.Items[i].SubItems.Add(thePatient.AddressLine1);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                //this.Close();
            }
        }

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
    }
}
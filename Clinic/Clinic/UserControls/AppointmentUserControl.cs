﻿using Clinic.Controller;
using Clinic.Model;
using Clinic.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Clinic.UserControls
{
    /// <summary>
    /// User control for appointment making, searching, and editing
    /// </summary>
    public partial class AppointmentUserControl : UserControl
    {
        private MakeAppointmentForm makeAppointmentForm;
        private EditAppointmentForm editAppointmentForm;
        private AddVisitForm addVisitForm;
        public  AppointmentController appointmentController;
        public List<Appointment> appointmentList;

        /// <summary>
        /// Constructor for AppointmentUserControl
        /// </summary>
        public AppointmentUserControl()
        {
            InitializeComponent();
            this.appointmentController = new AppointmentController();
        }

        /// <summary>
        /// Handler for clicks of the set appointment button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetAppointmentButton_Click(object sender, System.EventArgs e)
        {
            this.ResetFormMessages();
            this.makeAppointmentForm = new MakeAppointmentForm(this);
            this.makeAppointmentForm.Show();
        }

        /// <summary>
        /// Event handler for search by date button.  Searches for appointments with
        /// matching date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchDateButton_Click(object sender, System.EventArgs e)
        {
            this.ResetFormMessages();
            this.appointmentsSearchResultsListView.Items.Clear();
            this.nameTextBox.Text = "";
            DateTime searchDateTime = this.searchDateTimePicker.Value;
            this.appointmentList = this.appointmentController.GetAppointmentsOnDate(searchDateTime);
            foreach (Appointment current in this.appointmentList)
            {
                ListViewItem item = new ListViewItem(current.PatientLastName.ToString());
                item.SubItems.Add(current.PatientFirstName.ToString());
                item.SubItems.Add(current.PatientDateOfBirth.ToString("MM/dd/yyyy"));
                item.SubItems.Add(current.PatientId.ToString());
                item.SubItems.Add(current.StartDateTime.ToString("dddd, dd MMMM yyyy"));
                item.SubItems.Add(current.StartDateTime.ToString("hh:mm tt"));               
                item.SubItems.Add(current.DoctorLastName.ToString());
                this.appointmentsSearchResultsListView.Items.Add(item);
            }
        }

        /// <summary>
        /// Event handler for search by name button.  Searches for appointments with 
        /// matching last name to that provided
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchNameButton_Click(object sender, EventArgs e)
        {
            this.ResetFormMessages();
            if (this.nameTextBox.Text == "")
            {
                this.alertTextLabel.Text = "Search Name Empty:  Please provide a search name.";
            }
            else
            {
                this.appointmentsSearchResultsListView.Items.Clear();
                String searchName = this.nameTextBox.Text;
                DateTime searchDOB = new DateTime();  //TODO: Finish implementing
                this.appointmentList = this.appointmentController.GetAppointmentsForPatientLastNameAndDOB(searchName, searchDOB);
                foreach (Appointment current in this.appointmentList)
                {
                    ListViewItem item = new ListViewItem(current.PatientLastName.ToString());
                    item.SubItems.Add(current.PatientFirstName.ToString());
                    item.SubItems.Add(current.PatientDateOfBirth.ToString("MM/dd/yyyy"));
                    item.SubItems.Add(current.PatientId.ToString());
                    item.SubItems.Add(current.StartDateTime.ToString("dddd, dd MMMM yyyy"));
                    item.SubItems.Add(current.StartDateTime.ToString("hh:mm tt"));
                    item.SubItems.Add(current.DoctorLastName.ToString());
                    this.appointmentsSearchResultsListView.Items.Add(item);
                }
            }
        }

        /// <summary>
        /// Event handler for edit appointment button clicks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditAppointmentButton_Click(object sender, EventArgs e)
        {
            this.ResetFormMessages();
            if (this.appointmentsSearchResultsListView.SelectedItems.Count == 0)
            {
                this.alertTextLabel.Text = "Please select an appointment to edit.";
            }
            else
            {
                int selectedIndex = this.appointmentsSearchResultsListView.SelectedIndices[0];
                Appointment selectedAppointment = this.appointmentList[selectedIndex];
                this.editAppointmentForm = new EditAppointmentForm(this, selectedAppointment);
                this.editAppointmentForm.Show();
            }
        }

        /// <summary>
        /// Opens the visit information form to begin a new visit from an appointment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BeginVisitButton_Click(object sender, EventArgs e)
        {
            this.ResetFormMessages();
            if (this.appointmentsSearchResultsListView.SelectedItems.Count == 0)
            {
                this.alertTextLabel.Text = "Please select an appointment for this visit.";
            }
            else
            {
                int selectedIndex = this.appointmentsSearchResultsListView.SelectedIndices[0];
                Appointment selectedAppointment = this.appointmentList[selectedIndex];
                this.addVisitForm = new AddVisitForm(selectedAppointment);
                this.addVisitForm.Show();
            }
        }

        /// <summary>
        /// Event handler for reset button clicks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            this.ResetAppointmentListResults();
            this.ResetFormMessages();
        }

        /// <summary>
        /// Reset the list of results.  This method is public so that it can be accessed by related forms as the 
        /// return control back to the user control.
        /// </summary>
        public void ResetAppointmentListResults()
        {
            this.appointmentsSearchResultsListView.Items.Clear();           
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

﻿using Clinic.Controller;
using Clinic.Model;
using Clinic.UserControls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Clinic.View
{
    /// <summary>
    /// This class will construct and manage the make appointment form
    /// </summary>
    public partial class MakeAppointmentForm : Form
    {
        private readonly AppointmentUserControl appointmentUserControl;
        private readonly AppointmentController appointmentController;
        private readonly PatientController patientController;
        private readonly DoctorController doctorController;
        private List<Patient> patientList;
        private List<Doctor> doctorList;
        private List<Appointment> appointmentList;

        /// <summary>
        /// Constructor for the make appointment form
        /// </summary>
        /// <param name="appointmentUserControl">the refering appointment user control</param>
        public MakeAppointmentForm(AppointmentUserControl appointmentUserControl)
        {
            InitializeComponent();
            this.appointmentUserControl = appointmentUserControl;
            this.appointmentController = new AppointmentController();
            this.patientController = new PatientController();
            this.doctorController = new DoctorController();
        }

        /// <summary>
        /// Actions to happen when form loads.  Populate doctor combobox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MakeAppointmentForm_Load(object sender, EventArgs e)
        {
            this.appointmentUserControl.Enabled = false;
            this.doctorList = this.doctorController.GetAllDoctors();
            doctorComboBox.DataSource = this.doctorList;
        }

        /// <summary>
        /// Search patient button click actions.  Search for patient by names 
        /// and display selectable list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchPatientButton_Click(object sender, EventArgs e)
        {
            this.patientSearchResultListView.Items.Clear();
            try
            {
                this.patientList = this.patientController.FindPatients(this.searchPatientLastNameTextBox.Text, this.searchPatientFirstNameTextBox.Text);
                foreach (Patient current in this.patientList)
                {
                    ListViewItem item = new ListViewItem(current.FirstName);
                    item.SubItems.Add(current.LastName);
                    item.SubItems.Add(current.DateOfBirth.ToString("d"));
                    item.SubItems.Add(current.PersonId.ToString());
                    this.patientSearchResultListView.Items.Add(item);
                }
            }
            catch (Exception)
            {
                this.alertNoticeLabel.Text = "Please enter both first and last name for search.";
            }         
        }

        /// <summary>
        /// Format the doctor combo box to include first and last names of doctor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DoctorComboBox_Format(object sender, ListControlConvertEventArgs e)
        {
            string lastname = ((Doctor)e.ListItem).FirstName;
            string firstname = ((Doctor)e.ListItem).LastName;
            e.Value = lastname + " " + firstname;
        }

        /// <summary>
        /// Search for taken appointment times button.  Triggers a search and display 
        /// of list of appointments on the date set by the date picker.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchTimesButton_Click(object sender, EventArgs e)
        {
            this.appointmentTimeListView.Items.Clear();
            DateTime chosenDate = this.datePicker.Value;
            int chosenDoctorId = int.Parse(this.doctorComboBox.SelectedValue.ToString());
            this.appointmentList = this.appointmentController.GetAppointmentsForDoctorOnDate(chosenDoctorId, chosenDate);
            foreach (Appointment current in this.appointmentList)
            {
                ListViewItem item = new ListViewItem(current.StartDateTime.ToString("t"));
                item.SubItems.Add(current.EndDateTime.ToString("t"));
                this.appointmentTimeListView.Items.Add(item);
            }
        }

        /// <summary>
        /// The final submit button click for the form.  Validates form fields 
        /// and if appropriate submits the appointment to be added to the DB.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReserveAppointmentButton_Click(object sender, EventArgs e)
        {
            String alertText = "";
            DateTime startDateTime = new DateTime();
            DateTime endDateTime = new DateTime();

            if (this.patientSearchResultListView.SelectedItems.Count == 0)
            {
                alertText += "Patient Name Not Selected:  A name from the patient list must be selected.\n";
            }

            if (this.TimeFieldsNotSelected())
            {
                alertText += "Appointment Time Not Set:  Hours and minutes must be chosen for start and end times.\n";
            }
            else
            {
                startDateTime = this.GetFormStartDateTime();
                endDateTime = this.GetFormEndDateTime();
                if (startDateTime >= endDateTime)
                {
                    alertText += "Invalid Appointment Time:  The end time for the appointment cannot be before the start time.\n";
                }
                else if (this.appointmentController.DoctorIsBooked(int.Parse(this.doctorComboBox.SelectedValue.ToString()), startDateTime, endDateTime))
                {
                    alertText += "Appointment Conflict:  Appointment overlaps existing appointment.\n";
                }
            }

            if (this.reasonTextBox.Text == "")
            {
                alertText += "No Reason Provided:  Reason for appointment cannot be blank.\n";
            }

            if (alertText == "")
            {
                Appointment theAppointment = new Appointment
                {
                    PatientId = int.Parse(this.patientSearchResultListView.SelectedItems[0].SubItems[3].Text),
                    StartDateTime = startDateTime,
                    EndDateTime = endDateTime,
                    DoctorId = int.Parse(this.doctorComboBox.SelectedValue.ToString()),
                    ReasonForVisit = this.reasonTextBox.Text
                };
                try
                {
                    this.appointmentController.AddAppointment(theAppointment);
                    String successText = "Appointment successfully registered for : \n" +
                    startDateTime.ToString("f") + " - " +
                    endDateTime.ToString("t");
                    var dialogeResult = MessageBox.Show(successText, "Appointment Registration Success");
                    if (dialogeResult == DialogResult.OK)
                    {
                        this.Close();
                    }
                } catch (Exception ex)
                {
                    alertText += "Error in updating appointment database:\n" + 
                        ex.Message + "\n";
                }
            }
            this.alertNoticeLabel.Text = alertText;
        }

        /// <summary>
        /// Gets start time and minute from form and returns DateTime object
        /// </summary>
        /// <returns>Start DateTime object</returns>
        private DateTime GetFormStartDateTime()
        {
            DateTime date = this.datePicker.Value;
            int startHour = int.Parse(this.startHourComboBox.SelectedItem.ToString());
            int startMinute = int.Parse(this.startMinuteComboBox.SelectedItem.ToString());
            return new DateTime(date.Year, date.Month, date.Day, startHour, startMinute, 0);
        }

        /// <summary>
        /// Gets end time and minute from form and returns DateTime object
        /// </summary>
        /// <returns></returns>
        private DateTime GetFormEndDateTime()
        {
            DateTime date = this.datePicker.Value;
            int endHour = int.Parse(this.endHourComboBox.SelectedItem.ToString());
            int endMinute = int.Parse(this.endMinuteComboBox.SelectedItem.ToString());
            return new DateTime(date.Year, date.Month, date.Day, endHour, endMinute, 0);
        }

        /// <summary>
        /// Checks to see if any time comboBox is not selected
        /// </summary>
        /// <returns>true if any box is NOT selected</returns>
        private bool TimeFieldsNotSelected()
        {
            return (this.startHourComboBox.SelectedIndex == -1 ||
                this.startMinuteComboBox.SelectedIndex == -1 ||
                this.endHourComboBox.SelectedIndex == -1 ||
                this.endMinuteComboBox.SelectedIndex == -1);
        }

        /// <summary>
        /// Clear patient ListView if text changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchPatientLastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.patientSearchResultListView.Items.Clear();
        }

        /// <summary>
        /// Clear patient ListView if text changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchPatientFirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.patientSearchResultListView.Items.Clear();
        }

        /// <summary>
        /// When date changed clear the ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {
            this.appointmentTimeListView.Items.Clear();
        }

        /// <summary>
        /// When docotr selected changes, clear the ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DoctorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.appointmentTimeListView.Items.Clear();
        }

        /// <summary>
        /// Upon closing form re-enable the Appointment UserControl in the main tabcontrol
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MakeAppointmentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.appointmentUserControl.Enabled = true;
        }

        /// <summary>
        /// Cancel button click actions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

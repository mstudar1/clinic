using Clinic.Controller;
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

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchPatientButton_Click(object sender, EventArgs e)
        {
            this.patientList = this.patientController.FindPatients(this.searchPatientLastNameTextBox.Text, this.searchPatientFirstNameTextBox.Text);
            foreach (Patient current in this.patientList)
            {
                ListViewItem item = new ListViewItem(current.FirstName);
                item.SubItems.Add(current.LastName);
                item.SubItems.Add(current.DateOfBirth.ToString());
                item.SubItems.Add(current.PersonId.ToString());
                this.patientSearchResultListView.Items.Add(item);
            }
        }

        private void MakeAppointmentForm_Load(object sender, EventArgs e)
        {
            this.doctorList = this.doctorController.GetAllDoctors();
            doctorComboBox.DataSource = this.doctorList;
        }

        private void DoctorComboBox_Format(object sender, ListControlConvertEventArgs e)
        {
            string lastname = ((Doctor)e.ListItem).FirstName;
            string firstname = ((Doctor)e.ListItem).LastName;
            e.Value = lastname + " " + firstname;
        }

        private void SearchTimesButton_Click(object sender, EventArgs e)
        {
            DateTime chosenDate = this.datePicker.Value;
            this.appointmentList = this.appointmentController.GetAppointmentsOnDate(chosenDate);
            foreach (Appointment current in this.appointmentList)
            {
                ListViewItem item = new ListViewItem(current.StartDateTime.ToString());
                item.SubItems.Add(current.EndDateTime.ToString());
                item.SubItems.Add(doctorComboBox.SelectedItem.ToString());
                this.appointmentTimeListView.Items.Add(item);
            }
        }

        private void ReserveAppointmentButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateFormFields())
            {

            }
        }

        private bool ValidateFormFields()
        {
            bool allInputsValid = true;
            String alertText = "";
            
            if (this.patientSearchResultListView.SelectedItems.Count == 0)
            {
                alertText += "Patient Name Not Selected:  A name from the patient list must be selected.\n";
            }           
            if (this.startHourComboBox.SelectedIndex == -1 ||
                this.startMinuteComboBox.SelectedIndex == -1 ||
                this.endHourComboBox.SelectedIndex == -1 ||
                this.endMinuteComboBox.SelectedIndex == -1)
            {
                alertText += "Appointment Time Not Set:  Hours and minutes must be chosen for start and end times.\n";
            } 
            else
            {
                DateTime date = this.datePicker.Value;
                alertText += "TEST--" + this.startHourComboBox.SelectedText + "\n";
                //int startHour = int.Parse(this.startHourComboBox.SelectedText);
                //int startMinute = int.Parse(this.startMinuteComboBox.SelectedText);
                //int endHour = int.Parse(this.endHourComboBox.SelectedText);
                //int endMinute = int.Parse(this.endMinuteComboBox.SelectedText);
                //DateTime startTime = new DateTime(date.Year, date.Month, date.Day, startHour, startMinute, 0);
                //DateTime endTime = new DateTime(date.Year, date.Month, date.Day, endHour, endMinute, 0);
                //if (startTime >= endTime)
                //{
                //    alertText += "Invalid Appointment Time:  The end time for the appointment cannot be before the start time.\n";
                //}
                //alertText += "START=" + startHour + ":" + startMinute + "\n";
                //alertText += "END=" + endHour + ":" + endMinute + "\n";
            }
            if (this.reasonTextBox.Text == "")
            {
                alertText += "No Reason Provided:  Reason for appointment cannot be blank.\n";
            }


            this.alertNoticeLabel.Text = alertText;
            return allInputsValid;
        }

    }
}

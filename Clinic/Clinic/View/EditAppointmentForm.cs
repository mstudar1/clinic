using Clinic.Controller;
using Clinic.Model;
using Clinic.UserControls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Clinic.View
{
    /// <summary>
    /// This class will create the edit appointment form
    /// </summary>
    public partial class EditAppointmentForm : Form
    {
        private readonly Appointment theAppointment;
        private readonly AppointmentUserControl appointmentUserControl;
        private readonly AppointmentController appointmentController;
        private readonly DoctorController doctorController;
        private List<Doctor> doctorList;
        private List<Appointment> appointmentList;

        /// <summary>
        /// Constructor for the edit appointment form
        /// </summary>
        /// <param name="theAppointment">The appointment to be edited</param>
        public EditAppointmentForm(AppointmentUserControl appointmentUserControl, Appointment theAppointment)
        {
            InitializeComponent();
            this.appointmentUserControl = appointmentUserControl;
            this.appointmentController = new AppointmentController();
            this.doctorController = new DoctorController();
            this.theAppointment = theAppointment ?? throw new ArgumentNullException("theAppointment", "Appointment cannot be null for this form");
        }

        /// <summary>
        /// Actions to perform on form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditAppointmentForm_Load(object sender, EventArgs e)
        {
            this.appointmentUserControl.Enabled = false;
            this.VerifyNotIn24HourWindow();
            this.PopulateTextFields();
            this.SetDoctorComboBox();
            this.SetDateTimeFields();
            this.appointmentUserControl.ResetFormMessages();
        }

        /// <summary>
        /// Checks to see if the appointment is at least 24 hours away.  If not,
        /// a dialogue box appears and user is then returned to the Appointment
        /// User Control
        /// </summary>
        private void VerifyNotIn24HourWindow()
        {
            DateTime now = DateTime.Now;
            if (now.AddHours(24) > this.theAppointment.StartDateTime)
            {
                String messageText = "Appointments cannot be edited within 24 hours of the start of the appointment.";
                var dialogeResult = MessageBox.Show(messageText, "Alert - Appointment Too Close For Editing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (dialogeResult == DialogResult.OK)
                {
                    this.CloseForm();
                }
            }
        }

        /// <summary>
        /// Set values for all date and time fields
        /// </summary>
        private void SetDateTimeFields()
        {
            try
            {
                this.datePicker.Value = this.theAppointment.StartDateTime;
                this.startHourComboBox.SelectedIndex = this.startHourComboBox.FindStringExact(this.theAppointment.StartDateTime.ToString("HH"));
                this.startMinuteComboBox.SelectedIndex = this.startMinuteComboBox.FindStringExact(this.theAppointment.StartDateTime.ToString("mm"));
            }
            catch (Exception) 
            {
                this.CloseForm();
            }
        }

        /// <summary>
        /// Set values for text fields based on current appointment
        /// </summary>
        private void PopulateTextFields()
        {
            this.searchPatientFirstNameTextBox.Text = this.theAppointment.PatientFirstName;
            this.searchPatientLastNameTextBox.Text = this.theAppointment.PatientLastName;
            this.reasonTextBox.Text = this.theAppointment.ReasonForVisit;
        }

        /// <summary>
        /// Populate and set doctor combobox
        /// </summary>
        private void SetDoctorComboBox()
        {
            this.doctorList = this.doctorController.GetAllDoctors();
            doctorComboBox.DataSource = this.doctorList;
            this.doctorComboBox.SelectedValue = this.theAppointment.DoctorId;
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
            this.ClearErrorMessages();
            this.appointmentTimeListView.Items.Clear();
            DateTime chosenDate = this.datePicker.Value;
            int chosenDoctorId = int.Parse(this.doctorComboBox.SelectedValue.ToString());
            this.appointmentList = this.appointmentController.GetAppointmentsForDoctorOnDate(chosenDoctorId, chosenDate);
            foreach (Appointment current in this.appointmentList)
            {
                ListViewItem item = new ListViewItem(current.StartDateTime.ToString("t"));
                item.SubItems.Add(current.StartDateTime.AddMinutes(30).ToString("t"));
                this.appointmentTimeListView.Items.Add(item);
            }
        }

        /// <summary>
        /// Submits the revised appointment information to be checked and then updated in DB if validated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditAppointmentButton_Click(object sender, EventArgs e)
        {
            this.ClearErrorMessages();
            String alertText = "";
            DateTime startDateTime = new DateTime();

            if (this.TimeFieldsNotSelected())
            {
                alertText += "Appointment Time Not Set:  Hours and minutes must be chosen for start and end times.\n";
            }
            else
            {
                startDateTime = this.GetFormStartDateTime();
            }

            if (this.reasonTextBox.Text == "")
            {
                alertText += "No Reason Provided:  Reason for appointment cannot be blank.\n";
            }

            if (alertText == "")
            {
                Appointment revisedAppointment = new Appointment
                {
                    PatientId = this.theAppointment.PatientId,
                    StartDateTime = startDateTime,
                    DoctorId = int.Parse(this.doctorComboBox.SelectedValue.ToString()),
                    ReasonForVisit = this.reasonTextBox.Text
                };
                if (this.appointmentController.DoctorIsBookedForAppointmentEdit(this.theAppointment, revisedAppointment))
                {
                    alertText += "Appointment Conflict:  Appointment overlaps existing appointment.\n";
                } 
                else
                {
                    try
                    {
                        this.appointmentController.EditAppointment(this.theAppointment, revisedAppointment);
                        String successText = "Appointment successfully updated for : \n" + startDateTime.ToString("f") + " - ";
                        var dialogeResult = MessageBox.Show(successText, "Appointment Edit Success");
                        if (dialogeResult == DialogResult.OK)
                        {
                            this.CloseForm();
                        }
                    }
                    catch (Exception ex)
                    {
                        alertText += "Error in updating appointment database:\n" +
                            ex.Message + "\n";
                    }
                }
                
            }
            this.alertNoticeLabel.Text = alertText;
        }


        /* Helper Methods For Final Form Submit */

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
        /// Checks to see if any time comboBox is not selected
        /// </summary>
        /// <returns>true if any box is NOT selected</returns>
        private bool TimeFieldsNotSelected()
        {
            return (this.startHourComboBox.SelectedIndex == -1 || this.startMinuteComboBox.SelectedIndex == -1);
        }

        /* Additional Event Handlers */

        /// <summary>
        /// When date changed clear the ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {
            this.appointmentTimeListView.Items.Clear();
            this.ClearErrorMessages();
        }

        /// <summary>
        /// When docotr selected changes, clear the ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DoctorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.appointmentTimeListView.Items.Clear();
            this.ClearErrorMessages();
        }

        /// <summary>
        /// Upon closing form re-enable the Appointment UserControl in the main tabcontrol
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditAppointmentForm_FormClosed(object sender, FormClosedEventArgs e)
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
            this.CloseForm();
        }

        /// <summary>
        /// Executes actions to properly close the form and re-enable the Appointment User Control
        /// </summary>
        private void CloseForm()
        {           
            this.appointmentUserControl.ResetAppointmentListResults();
            this.appointmentUserControl.Enabled = true;
            this.Close();
        }

        /// <summary>
        /// Clears messages when date is changed on form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ClearErrorMessages();
        }

        /// <summary>
        /// Clears messages when reason field is edited
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReasonTextBox_TextChanged(object sender, EventArgs e)
        {
            this.ClearErrorMessages();
        }

        /// <summary>
        /// Clear error messages on the form
        /// </summary>
        private void ClearErrorMessages()
        {
            this.alertNoticeLabel.Text = "";
        }
    }
}

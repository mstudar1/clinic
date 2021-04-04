using Clinic.Controller;
using Clinic.Model;
using Clinic.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic.View
{
    /// <summary>
    /// This class will create the edit appointment form
    /// </summary>
    public partial class EditAppointmentForm : Form
    {
        private Appointment theAppointment;
        private readonly AppointmentUserControl appointmentUserControl;
        private readonly AppointmentController appointmentController;
        private readonly PatientController patientController;
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
            this.patientController = new PatientController();
            this.doctorController = new DoctorController();
            if (theAppointment == null)
            {
                throw new ArgumentNullException("theAppointment", "Appointment cannot be null for this form");
            }
            this.theAppointment = theAppointment;
        }

        /// <summary>
        /// Actions to perform on form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditAppointmentForm_Load(object sender, EventArgs e)
        {
            this.PopulateTextFields();
            this.SetDoctorComboBox();
            this.SetDateTimeFields();
        }

        /// <summary>
        /// Set values for all date and time fields
        /// </summary>
        private void SetDateTimeFields()
        {
            this.datePicker.Value = this.theAppointment.StartDateTime;
            this.startHourComboBox.SelectedIndex = this.startHourComboBox.FindStringExact(this.theAppointment.StartDateTime.ToString("HH"));
            this.startMinuteComboBox.SelectedIndex = this.startMinuteComboBox.FindStringExact(this.theAppointment.StartDateTime.ToString("mm"));
            this.endHourComboBox.SelectedIndex = this.endHourComboBox.FindStringExact(this.theAppointment.EndDateTime.ToString("HH"));
            this.endMinuteComboBox.SelectedIndex = this.endMinuteComboBox.FindStringExact(this.theAppointment.EndDateTime.ToString("mm"));
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
            this.appointmentUserControl.Enabled = false;
            this.doctorList = this.doctorController.GetAllDoctors();
            doctorComboBox.DataSource = this.doctorList;
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
            this.Close();
        }

        private void ReserveAppointmentButton_Click(object sender, EventArgs e)
        {

        }
    }
}

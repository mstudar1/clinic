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
            this.appointmentList = this.appointmentController.getAppointmentsOnDate(chosenDate);
            foreach (Appointment current in this.appointmentList)
            {
                ListViewItem item = new ListViewItem(current.StartDateTime.ToString());
                item.SubItems.Add(current.EndDateTime.ToString());
                this.appointmentTimeListView.Items.Add(item);
            }
        }
    }
}

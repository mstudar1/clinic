using Clinic.Controller;
using Clinic.Model;
using Clinic.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Clinic.UserControls
{
    public partial class AppointmentUserControl : UserControl
    {
        private MakeAppointmentForm makeAppointmentForm;
        private EditAppointmentForm editAppointmentForm;
        private readonly AppointmentController appointmentController;
        private List<Appointment> appointmentList;

        public AppointmentUserControl()
        {
            InitializeComponent();
            this.appointmentController = new AppointmentController();
        }

        private void SetAppointmentButton_Click(object sender, System.EventArgs e)
        {
            this.makeAppointmentForm = new MakeAppointmentForm(this);
            this.makeAppointmentForm.Show();
        }

        private void SearchDateButton_Click(object sender, System.EventArgs e)
        {
            this.appointmentsSearchResultsListView.Items.Clear();
            this.nameTextBox.Text = "";
            DateTime searchDateTime = this.searchDateTimePicker.Value;
            this.appointmentList = this.appointmentController.GetAppointmentsOnDate(searchDateTime);
            foreach (Appointment current in this.appointmentList)
            {
                ListViewItem item = new ListViewItem(current.PatientLastName.ToString());
                item.SubItems.Add(current.PatientFirstName.ToString());
                item.SubItems.Add(current.StartDateTime.ToString("dddd, dd MMMM yyyy"));
                item.SubItems.Add(current.StartDateTime.ToString("hh:mm tt"));
                item.SubItems.Add(current.EndDateTime.ToString("hh:mm tt"));
                item.SubItems.Add(current.DoctorLastName.ToString());
                this.appointmentsSearchResultsListView.Items.Add(item);
            }
        }

        private void SearchNameButton_Click(object sender, EventArgs e)
        {
            this.appointmentsSearchResultsListView.Items.Clear();
            String searchName = this.nameTextBox.Text;
            this.appointmentList = this.appointmentController.GetAppointmentsForPatientLastName(searchName);
            foreach (Appointment current in this.appointmentList)
            {
                ListViewItem item = new ListViewItem(current.PatientLastName.ToString());
                item.SubItems.Add(current.PatientFirstName.ToString());
                item.SubItems.Add(current.StartDateTime.ToString("dddd, dd MMMM yyyy"));
                item.SubItems.Add(current.StartDateTime.ToString("hh:mm tt"));
                item.SubItems.Add(current.EndDateTime.ToString("hh:mm tt"));
                item.SubItems.Add(current.DoctorLastName.ToString());
                this.appointmentsSearchResultsListView.Items.Add(item);
            }

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            this.appointmentsSearchResultsListView.Items.Clear();
        }

        private void EditAppointmentButton_Click(object sender, EventArgs e)
        {
            if (this.appointmentsSearchResultsListView.SelectedItems.Count == 0)
            {
                this.alertTextLabel.Text = "Please select an appointment to edit.";
            } else
            {
                int selectedIndex = this.appointmentsSearchResultsListView.SelectedIndices[0];
                Appointment selectedAppointment = this.appointmentList[selectedIndex];
                this.editAppointmentForm = new EditAppointmentForm(selectedAppointment);
                this.editAppointmentForm.Show();
            }
            
        }
    }
}

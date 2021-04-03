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
        private AppointmentController appointmentController;
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

        private void searchDateButton_Click(object sender, System.EventArgs e)
        {
            if (this.nameTextBox.Text == "")
            {
                //this.appointmentsSearchResultsListView.Clear();
                DateTime searchDateTime = this.searchDateTimePicker.Value;
                this.appointmentList = this.appointmentController.GetAppointmentsOnDate(searchDateTime);
                foreach (Appointment current in this.appointmentList)
                {
                    ListViewItem item = new ListViewItem(current.PatientId.ToString());
                    item.SubItems.Add(current.PatientId.ToString());
                    item.SubItems.Add(current.StartDateTime.ToString("dddd, dd MMMM yyyy"));
                    item.SubItems.Add(current.StartDateTime.ToString("hh:mm tt"));
                    item.SubItems.Add(current.EndDateTime.ToString("hh:mm tt"));
                    item.SubItems.Add(current.DoctorLastName.ToString());
                    this.appointmentsSearchResultsListView.Items.Add(item);
                }
            }
        }
    }
}

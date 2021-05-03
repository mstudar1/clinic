using Clinic.Controller;
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
        private Person currentUser;
        private VisitController visitController;
        public AppointmentController appointmentController;
        public List<Appointment> appointmentList;

        /// <summary>
        /// Constructor for AppointmentUserControl
        /// </summary>
        public AppointmentUserControl()
        {
            InitializeComponent();
            this.appointmentController = new AppointmentController();
            this.visitController = new VisitController();
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

        /// <summary>
        /// Method that can be called to set the current user instance variable.
        /// </summary>
        /// <param name="currentUser">The current user.</param>
        public void SetCurrentUser(Person currentUser)
        {
            this.currentUser = currentUser;
            this.EnableOrDisableBeginVisitButton();
        }

        /// <summary>
        /// Method that clears the last name text box, and resets the date time picker values to today's date.
        /// </summary>
        public void ResetSearchFields()
        {
            this.nameTextBox.Clear();
            this.searchDateTimePicker.Value = DateTime.Now;
            this.dobDateTimePicker.Value = DateTime.Now;
        }

        /// <summary>
        /// Method that can be called to set the stored list of appointments and display it on the form.
        /// </summary>
        /// <param name="appointments"></param>
        public void DisplayAppointmentList(List<Appointment> appointments)
        {
            if (appointments == null)
            {
                throw new ArgumentException("The list of appointments cannot be null.", "appointments");
            }
            this.appointmentList = appointments;
            this.RefreshAppointmentList();
        }

        /// <summary>
        /// Enables or disables begin visit button based on user
        /// </summary>
        private void EnableOrDisableBeginVisitButton()
        {
            if (this.currentUser == default)
            {
                throw new ArgumentNullException("The current user must be set before this method can be called.");
            }

            if (this.currentUser is Nurse)
            {
                this.beginVisitButton.Enabled = true;
            }
            else
            {
                this.beginVisitButton.Enabled = false;
            }
        }

        /// <summary>
        /// Helper method to refresh the appointment list
        /// </summary>
        private void RefreshAppointmentList()
        {
            this.ResetFormMessages();
            this.ResetSearchFields();
            foreach (Appointment current in this.appointmentList)
            {
                ListViewItem item = new ListViewItem(current.PatientLastName.ToString());
                item.SubItems.Add(current.PatientFirstName.ToString());
                item.SubItems.Add(current.StartDateTime.ToShortDateString());
                item.SubItems.Add(current.StartDateTime.ToShortTimeString());
                item.SubItems.Add(current.EndDateTime.ToShortTimeString());
                item.SubItems.Add(current.DoctorLastName.ToString());
                this.appointmentsSearchResultsListView.Items.Add(item);
            }
        }

        /// <summary>
        /// Handler for clicks of the set appointment button
        /// </summary>
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
        private void SearchDateButton_Click(object sender, System.EventArgs e)
        {
            this.ResetFormMessages();
            this.appointmentsSearchResultsListView.Items.Clear();
            this.nameTextBox.Text = "";
            DateTime searchDateTime = this.searchDateTimePicker.Value;
            this.appointmentList = this.appointmentController.GetAppointmentsOnDate(searchDateTime);
            this.RefreshAppointmentList();
        }

        /// <summary>
        /// Event handler for search by name button.  Searches for appointments with 
        /// matching last name to that provided
        /// </summary>
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
                DateTime searchDOB = this.dobDateTimePicker.Value;         
                this.appointmentList = this.appointmentController.GetAppointmentsForPatientLastNameAndDOB(searchName, searchDOB);
                this.RefreshAppointmentList();
            }
        }

        /// <summary>
        /// Event handler for edit appointment button clicks
        /// </summary>
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
        private void BeginVisitButton_Click(object sender, EventArgs e)
        {
            this.ResetFormMessages();

            if (this.appointmentsSearchResultsListView.SelectedItems.Count == 0)
            {
                this.alertTextLabel.Text = "Please select an appointment for this visit.";
                return;
            }

            int selectedIndex = this.appointmentsSearchResultsListView.SelectedIndices[0];
            Appointment selectedAppointment = this.appointmentList[selectedIndex];

            if (this.visitController.IsVisitPresent(selectedAppointment.AppointmentId))
            {
                this.alertTextLabel.Text = "A visit has already been entered for this appointment.";
                return;
            }
            
            this.addVisitForm = new AddVisitForm(selectedAppointment, (Nurse) this.currentUser);
            this.addVisitForm.Show();
        }

        /// <summary>
        /// Event handler for reset button clicks
        /// </summary>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            this.ResetAppointmentListResults();
            this.ResetFormMessages();
        }

        /// <summary>
        /// Handles delete appointment button clicks.  Verifies the user's desire to delete 
        /// and then verifies that delete does not violate any rules.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteAppointmentButton_Click(object sender, EventArgs e)
        {
            this.ResetFormMessages();
            if (this.appointmentsSearchResultsListView.SelectedItems.Count == 0)
            {
                this.alertTextLabel.Text = "Please select an appointment for this visit.";
                return;
            }

            int selectedIndex = this.appointmentsSearchResultsListView.SelectedIndices[0];
            Appointment selectedAppointment = this.appointmentList[selectedIndex];

            if (this.visitController.IsVisitPresent(selectedAppointment.AppointmentId))
            {
                this.alertTextLabel.Text = "A visit has already been entered for this appointment. It cannot be deleted.";
                return;
            }

            string title = "Confirm Delete Appointment";
            string message = "Are you sure you want to delete this appointment?";
            var selectedOption = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (selectedOption == DialogResult.Yes)
            {
                try
                {
                    this.appointmentController.DeleteAppointment(selectedAppointment.AppointmentId);
                }
                catch (Exception ex)
                {
                    string errorTitle = "Delete Appointment Failure";
                    string errorMessage = "Unable to delete this appointment." + ex.Message;
                    var errorSelectedOption = MessageBox.Show(errorMessage, errorTitle, MessageBoxButtons.OK);
                }
            }

        }
    }
}
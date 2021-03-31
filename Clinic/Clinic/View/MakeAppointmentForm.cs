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
    /// This class will construct and manage the make appointment form
    /// </summary>
    public partial class MakeAppointmentForm : Form
    {
        private readonly AppointmentUserControl appointmentUserControl;
        private readonly AppointmentController appointmentController;
        private readonly PatientController patientController;
        private List<Patient> patientList;

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
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchPatientButton_Click(object sender, EventArgs e)
        {
            this.patientList = this.patientController.FindPatients(this.searchPatientLastNameTextBox.Text, this.searchPatientFirstNameTextBox.Text);
            //this.patientSearchResultListView.Items.Clear();

            //this.patientSearchResultListView.Columns.Clear();
            //this.patientSearchResultListView.Columns.Add("Last Name");
            //this.patientSearchResultListView.Columns.Add("First Name");
            //this.patientSearchResultListView.Columns.Add("D.O.B.");
            //this.patientSearchResultListView.Columns.Add("Person ID");

            foreach (Patient current in this.patientList)
            {
                ListViewItem item = new ListViewItem(current.FirstName);
                item.SubItems.Add(current.LastName);
                item.SubItems.Add(current.DateOfBirth.ToString());
                item.SubItems.Add(current.PersonId.ToString());

                this.patientSearchResultListView.Items.Add(item);
            }

        }
    }
}

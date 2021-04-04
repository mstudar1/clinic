using Clinic.Controller;
using Clinic.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Clinic.View
{
    public partial class AddVisitForm : Form
    {
        private readonly NurseController theNurseController;
        private readonly Appointment theAppointment;

        public AddVisitForm(Appointment theAppointment)
        {
            if (theAppointment == null)
            {
                throw new ArgumentNullException("theAppointment", "The appointment object cannot be null.");
            }

            InitializeComponent();
            this.theAppointment = theAppointment;
            this.theNurseController = new NurseController();
        }

        private void AddVisitForm_Load(object sender, EventArgs e)
        {
            List<Nurse> nurseList = this.theNurseController.GetAllNurses();
            this.nurseComboBox.DataSource = nurseList;
            this.appointmentBindingSource.Add(theAppointment);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // TODO: handle click on add button
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            // TODO: handle click on cancel button
        }
    }
}

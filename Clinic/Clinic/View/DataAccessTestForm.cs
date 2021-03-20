using Clinic.Controller;
using Clinic.Model;
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
    public partial class DataAccessTestForm : Form
    {
        private readonly CredentialController theCredentialController;
        private readonly PatientController thePatientController;
        private readonly AppointmentController theAppointmentController;

        public DataAccessTestForm()
        {
            InitializeComponent();
            this.theCredentialController = new CredentialController();
            this.thePatientController = new PatientController();
            this.theAppointmentController = new AppointmentController();
        }

        private void CredentialsAreValidButton_Click(object sender, EventArgs e)
        {
            string username = this.usernameTextBox.Text;
            string password = this.passwordTextBox.Text;
            bool result = this.theCredentialController.CredentialsAreValid(username, password);
            MessageBox.Show("Valid? " + result.ToString());
        }

        private void AddPatientButton_Click(object sender, EventArgs e)
        {
            Patient newPatient = new Patient
            {
                LastName = "Doe",
                FirstName = "John",
                DateOfBirth = new DateTime(1970, 6, 1),
                SocialSecurityNumber = "555-55-5555",
                Gender = "M",
                PhoneNumber = "(555) 555-5555",
                AddressLine1 = "123 Maple Street",
                City = "Rome",
                State = "GA",
                ZipCode = "12345"
            };

            this.thePatientController.AddPatient(newPatient);
        }

        private void EditPatientButton_Click(object sender, EventArgs e)
        {
            Patient originalPatient = new Patient
            {
                PersonId = 14,
                LastName = "Doe",
                FirstName = "John",
                DateOfBirth = new DateTime(1970, 6, 1),
                SocialSecurityNumber = "555-55-5555",
                Gender = "M",
                PhoneNumber = "(555) 555-5555",
                AddressLine1 = "123 Maple Street",
                City = "Rome",
                State = "GA",
                ZipCode = "12345",
                PatientId = 5
            };

            Patient revisedPatient = new Patient
            {
                PersonId = 14,
                LastName = "Doe",
                FirstName = "Jane",
                DateOfBirth = new DateTime(1970, 6, 1),
                SocialSecurityNumber = "555-55-5555",
                Gender = "F",
                PhoneNumber = "(555) 555-5555",
                AddressLine1 = "123 Maple Street",
                City = "Rome",
                State = "GA",
                ZipCode = "12345",
                PatientId = 5
            };

            bool result = this.thePatientController.EditPatient(originalPatient, revisedPatient);

            MessageBox.Show(result.ToString());
        }

        private void AddAppointmentButton_Click(object sender, EventArgs e)
        {
            Appointment newAppointment = new Appointment
            {
                PatientId = 5,
                DateAndTime = new DateTime(2021, 4, 15, 8, 0, 0),
                DoctorId = 1,
                ReasonForVisit = "Routine checkup"
            };

            this.theAppointmentController.AddAppointment(newAppointment);
        }

        private void DoctorIsBookedButton_Click(object sender, EventArgs e)
        {
            int doctorId = int.Parse(this.doctorIdTextBox.Text);
            DateTime dateAndTime = DateTime.Parse(this.dateAndTimeTextBox.Text);
            bool result = this.theAppointmentController.DoctorIsBooked(doctorId, dateAndTime);
            MessageBox.Show(result.ToString());
        }

        private void EditAppointmentButton_Click(object sender, EventArgs e)
        {
            Appointment originalAppointment = new Appointment
            {
                PatientId = 5,
                DateAndTime = new DateTime(2021, 4, 15, 8, 0, 0),
                DoctorId = 1,
                ReasonForVisit = "Routine checkup"
            };

            Appointment revisedAppointment = new Appointment
            {
                PatientId = 5,
                DateAndTime = new DateTime(2021, 4, 10, 9, 0, 0),
                DoctorId = 1,
                ReasonForVisit = "Routine checkup"
            };

            bool result = this.theAppointmentController.EditAppointment(originalAppointment, revisedAppointment);

            MessageBox.Show(result.ToString());
        }

        private void GetUserButton_Click(object sender, EventArgs e)
        {
            Person result = this.theCredentialController.GetUser(this.getUserUsernameTextBox.Text);
            MessageBox.Show("Person ID: " + result.PersonId + "\n" + 
                "Name: " + result.FirstName + " " + result.LastName);
        }

        private void FindPatientsButton_Click(object sender, EventArgs e)
        {
            List<Patient> patients = this.thePatientController.FindPatients(DateTime.Parse(this.dateOfBirthTextBox.Text));
            foreach (Patient currentPatient in patients)
            {
                MessageBox.Show("Person ID: " + currentPatient.PersonId + "\n" + "Name: " + currentPatient.FirstName + " " + currentPatient.LastName);
            }
        }

        private void FindPatientsButton2_Click(object sender, EventArgs e)
        {
            List<Patient> patients = this.thePatientController.FindPatients(this.lastNameTextBox.Text, this.firstNameTextBox.Text);
            foreach (Patient currentPatient in patients)
            {
                MessageBox.Show("Person ID: " + currentPatient.PersonId + "\n" + "Name: " + currentPatient.FirstName + " " + currentPatient.LastName);
            }
        }

        private void FindPatientsButton3_Click(object sender, EventArgs e)
        {
            List<Patient> patients = this.thePatientController.FindPatients(DateTime.Parse(this.dateOfBirthTextBox2.Text), this.lastNameTextBox2.Text);
            foreach (Patient currentPatient in patients)
            {
                MessageBox.Show("Person ID: " + currentPatient.PersonId + "\n" + "Name: " + currentPatient.FirstName + " " + currentPatient.LastName);
            }
        }
    }
}
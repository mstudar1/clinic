﻿using Clinic.UserControls;
using System.Windows.Forms;

namespace Clinic.View
{
    public partial class RegisterPatientForm : Form
    {

        private PatientUserControl thePatientUserControl;
        public RegisterPatientForm(PatientUserControl theInputPatientUserControl)
        {
            InitializeComponent();
            this.thePatientUserControl = theInputPatientUserControl;
        }

        private void RegisterButton_Click(object sender, System.EventArgs e)
        {

        }
    }
}
using Clinic.Controller;
using Clinic.Model;
using Clinic.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Clinic.UserControls
{

    /// <summary>
    /// The PatientUserControl class creates user control to be added in the NurseAdminForm form's "Patient" tab.
    /// Patient controler let's admin and nurse to see the list of patient, add a new patient to the list, edit and delete existing patient list.
    /// </summary>
    public partial class PatientUserControl : UserControl
    {

        private PatientController thePatientController;
        private RegisterPatientForm theRegisterPatientForm;

        /// <summary>
        /// The constructor initializes the components
        /// </summary>
        public PatientUserControl()
        {
            InitializeComponent();
            this.thePatientController = new PatientController();
            this.theRegisterPatientForm = null;
            this.RefreshPatientsListData();
        }

        /// <summary>
        ///  The method sets the RegisterPatientForm to show it.
        /// </summary>
        /// <param name="theInputRegisterPatientForm"> Inputted form </param>
        public void SetNurseAdminForm(RegisterPatientForm theInputRegisterPatientForm)
        {
            this.theRegisterPatientForm = theInputRegisterPatientForm;
        }

        private void RegisterPatientButton_Click(object sender, System.EventArgs e)
        {
            this.theRegisterPatientForm = new RegisterPatientForm(this);
            theRegisterPatientForm.Show();
        }

        private void SearchButton_Click(object sender, System.EventArgs e)
        {
            
            
        }

        private void ResetButton_Click(object sender, System.EventArgs e)
        {
            this.RefreshPatientsListData();
        }

        /// <summary>
        /// Method every time clears the patients list from the ViewList and then goes through the data 
        /// and adds patients to the list
        /// </summary>
        public void RefreshPatientsListData()
        { }
   
    }
}
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
    /// <summary>
    /// Manages the order new lab test form
    /// </summary>
    public partial class OrderNewLabTestForm : Form
    {
        private readonly ViewVisitForm theViewVsitForm;
        private readonly LabTestController theLabTestController;
        private readonly ConductedLabTestController theConductedLabTestController;
        private List<LabTest> labTestList;


        public OrderNewLabTestForm(ViewVisitForm theViewVsitForm)
        {            
            this.theViewVsitForm = theViewVsitForm;
            this.theViewVsitForm.Enabled = false;
            InitializeComponent();
            //this.SetLabTestComboBox();
        }

        /// <summary>
        /// Populate and set lab test combobox
        /// </summary>
        //private void SetLabTestComboBox()
        //{
        //    this.labTestList = this.theLabTestController.GetAllLabTests();
        //    this.labTestComboBox.DataSource = this.labTestList;
        //}
        
        

        private void OrderTestButton_Click(object sender, EventArgs e)
        {
            // TODO: Add GetAppointmentId() method to ViewVisitForm
            try
            {
                this.theConductedLabTestController.AddLabTestResults(this.theViewVsitForm.GetAppointmentId(), this.labTestComboBox.SelectedValue);
            }
            catch (Exception ex)
            {
                this.alertTextLable.Text = ex.Message;
            }
        }

        /// <summary>
        /// Executes actions to properly close the form and re-enable the previous form
        /// </summary>
        private void CloseForm()
        {
            this.theViewVsitForm.Enabled = true;
            this.Close();
        }

        /// <summary>
        /// Handler for cancel button clicks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.CloseForm();
        }

        /// <summary>
        /// Handler for closeing form events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderNewLabTestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.theViewVsitForm.Enabled = true;
        }
    }
}

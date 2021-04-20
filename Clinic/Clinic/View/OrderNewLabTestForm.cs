using Clinic.Controller;
using Clinic.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Clinic.View
{
    /// <summary>
    /// Manages the order new lab test form
    /// </summary>
    public partial class OrderNewLabTestForm : Form
    {
        private readonly ViewVisitForm theViewVisitForm;
        private readonly LabTestController theLabTestController;
        private readonly ConductedLabTestController theConductedLabTestController;
        private List<LabTest> labTestList;


        /// <summary>
        /// Constructor for form
        /// </summary>
        /// <param name="theViewVisitForm"></param>
        public OrderNewLabTestForm(ViewVisitForm theViewVisitForm)
        {
            this.theLabTestController = new LabTestController();
            this.theConductedLabTestController = new ConductedLabTestController();
            this.theViewVisitForm = theViewVisitForm;
            this.theViewVisitForm.Enabled = false;
            InitializeComponent();
            this.SetLabTestComboBox();
        }

        /// <summary>
        /// Populate and set lab test combobox
        /// </summary>
        private void SetLabTestComboBox()
        {
            this.labTestList = this.theLabTestController.GetAllLabTests();
            this.labTestComboBox.DataSource = this.labTestList;
        }

        /// <summary>
        /// Handler for order test button clicks.  Validates input and then attempts to add record to DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderTestButton_Click(object sender, EventArgs e)
        {
            if (this.labTestComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a lab test.", "Form Incomplete");
                return;
            } 
            else
            {
                LabTest selectedLabTest = new LabTest();
                selectedLabTest.TestCode = int.Parse(this.labTestComboBox.SelectedValue.ToString());
                selectedLabTest.Name = this.labTestComboBox.Text;
                try
                {
                    this.theConductedLabTestController.OrderLabTest(this.theViewVisitForm.GetAppointmentId(), selectedLabTest);
                    string boxMessage = "Lab test successfully ordered.";
                    string boxTitle = "Lab Test Order Confirmation";
                    DialogResult dialogResult = MessageBox.Show(boxMessage, boxTitle);
                    this.CloseForm();
                }
                catch (Exception ex)
                {
                    this.alertTextLable.Text = "Test has already been ordered for this patient on this visit.";
                }
            }
        }

        /// <summary>
        /// Executes actions to properly close the form and re-enable the previous form
        /// </summary>
        private void CloseForm()
        {
            this.theViewVisitForm.Enabled = true;
            // TODO: force reload of ViewVisit form
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
            this.theViewVisitForm.Enabled = true;
        }

        /// <summary>
        /// Reset alert message when combobox selected index changes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labTestComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.alertTextLable.Text = "";
        }
    }
}
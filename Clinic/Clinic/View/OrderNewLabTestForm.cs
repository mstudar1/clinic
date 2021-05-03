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
        private readonly ViewVisitForm referringForm;
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
            this.referringForm = theViewVisitForm;
            this.referringForm.Enabled = false;
            InitializeComponent();
            this.SetLabTestListBox();
        }

        /// <summary>
        /// Populate and set lab test listbox
        /// </summary>
        private void SetLabTestListBox()
        {
            this.labTestList = this.theLabTestController.GetAllLabTests();
            this.labTestListBox.DataSource = this.labTestList;
        }

        /// <summary>
        /// Handler for order test button clicks.  Validates input and then attempts to add record to DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderTestButton_Click(object sender, EventArgs e)
        {
            if (this.labTestListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select at least one lab test.", "Form Incomplete");
                return;
            } 
            else
            {
                this.DisplayOrderConfirmationDialog();              
            }
        }

        /// <summary>
        /// Displays the confirmation dialog listing the selected tests.  If user confirms then the 
        /// list is sent to be processed, if not then the user is returned to the order form where 
        /// the current selections are still shown and editable.
        /// </summary>
        private void DisplayOrderConfirmationDialog ()
        {
            string selectedTestNames = "";
            foreach (LabTest labTest in this.labTestListBox.SelectedItems)
            {
                selectedTestNames += "\n" + labTest.Name;
            }
                DialogResult res = MessageBox.Show(
                "Are you sure you want to order the following tests:" + selectedTestNames, 
                "Confirmation", 
                MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Information
                );
            if (res == DialogResult.OK)
            {
                this.OrderSelectedTests();
            }
            if (res == DialogResult.Cancel)
            {

            }
        }

        /// <summary>
        /// Submits each lab test as an order.  User is alerted if any test is already ordered (and thus 
        /// cannot be ordered).  A report of ordered tests is provided at the conclusion of the operation.
        /// </summary>
        private void OrderSelectedTests()
        {
            string successfulTestNameList = "";
            foreach (LabTest labTest in this.labTestListBox.SelectedItems)
            {
                try
                {
                    this.theConductedLabTestController.OrderLabTest(this.referringForm.GetAppointmentId(), labTest);
                    successfulTestNameList += "\n" + labTest.Name;
                }
                catch (Exception)
                {
                    this.alertTextLable.Text = "Test (" + labTest.Name + ") has already been ordered for this patient on this visit.";
                }
            }
            string boxMessage = "No tests were ordered.";
            if (successfulTestNameList != "")
            { 
                boxMessage = "The followinglab tests were successfully ordered:" + successfulTestNameList;
            }           
            string boxTitle = "Lab Test Order Confirmation";
            _ = MessageBox.Show(boxMessage, boxTitle);
            this.CloseForm();
        }

        /// <summary>
        /// Executes actions to properly close the form and re-enable the previous form
        /// </summary>
        private void CloseForm()
        {
            this.referringForm.Enabled = true;
            this.referringForm.LoadTests();
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
            this.referringForm.Enabled = true;
        }

        /// <summary>
        /// Reset alert message when combobox selected index changes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabTestComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.alertTextLable.Text = "";
        }
    }
}
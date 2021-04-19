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
    public partial class EnterLabTestResultForm : Form
    {
        private readonly int appointmentId;
        private readonly ViewVisitForm referringForm;

        public EnterLabTestResultForm(int appointmentId, ViewVisitForm referringForm)
        {
            InitializeComponent();
            this.appointmentId = appointmentId;
            this.referringForm = referringForm;
            this.referringForm.Enabled = false;
        }

        /// <summary>
        /// Helper method to handle actions of closing the form
        /// </summary>
        private void CloseForm()
        {
            this.referringForm.Enabled = true;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.CloseForm();
        }

        private void EnterLabTestResultForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.referringForm.Enabled = true;
        }
    }
}

using Clinic.Controller;
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

        /// <summary>
        /// Constructor for the make appointment form
        /// </summary>
        /// <param name="appointmentUserControl">the refering appointment user control</param>
        public MakeAppointmentForm(AppointmentUserControl appointmentUserControl)
        {
            InitializeComponent();
            this.appointmentUserControl = appointmentUserControl;
            this.appointmentController = new AppointmentController();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

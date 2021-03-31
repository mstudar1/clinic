using Clinic.View;
using System.Windows.Forms;

namespace Clinic.UserControls
{
    public partial class AppointmentUserControl : UserControl
    {
        private MakeAppointmentForm makeAppointmentForm;

        public AppointmentUserControl()
        {
            InitializeComponent();
        }

        private void SetAppointmentButton_Click(object sender, System.EventArgs e)
        {
            this.makeAppointmentForm = new MakeAppointmentForm(this);
            this.makeAppointmentForm.Show();
        }
    }
}

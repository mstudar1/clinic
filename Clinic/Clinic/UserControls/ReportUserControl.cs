using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic.UserControls
{
    public partial class ReportUserControl: UserControl
    {
        public ReportUserControl()
        {
            InitializeComponent();
        }

        private void generateReportButton_Click(object sender, EventArgs e)
        {
            DateTime startDate = this.startDateTimePicker.Value;
            DateTime endDate = this.endDateTimePicker.Value;
            this.getMostPerformedTestsDuringDatesTableAdapter.Fill(_labTestReportDataSet.getMostPerformedTestsDuringDates, startDate, endDate);
            this.reportViewer.RefreshReport();
            //_labTestReportDataSet.getMostPerformedTestsDuringDates.Fill(startDate, endDate);


        }
    }
}

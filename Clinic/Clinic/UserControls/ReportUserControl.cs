using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

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
            DateTime start = this.startDateTimePicker.Value;
            DateTime end = this.endDateTimePicker.Value;

            ReportParameter[] parameters = new ReportParameter[2];
            parameters[0] = new ReportParameter("startDate", start.ToString("D"));
            parameters[1] = new ReportParameter("endDate", end.ToString("D"));
            this.reportViewer.LocalReport.SetParameters(parameters);

            this.getMostPerformedTestsDuringDatesTableAdapter.Fill(_labTestReportDataSet.getMostPerformedTestsDuringDates, start, end);
            this.reportViewer.RefreshReport();
        }
    }
}

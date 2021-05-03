using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Clinic.UserControls
{
    /// <summary>
    /// Provides UI for generating a report of lab test stas over a given date range
    /// </summary>
    public partial class ReportUserControl: UserControl
    {
        /// <summary>
        /// Constructor for the control
        /// </summary>
        public ReportUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the generate button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateReportButton_Click(object sender, EventArgs e)
        {
            DateTime start = this.startDateTimePicker.Value;
            DateTime end = this.endDateTimePicker.Value;
            if (this.DatesAreValid(start, end)) {

                ReportParameter[] parameters = new ReportParameter[2];
                parameters[0] = new ReportParameter("startDate", start.ToString("D"));
                parameters[1] = new ReportParameter("endDate", end.ToString("D"));
                this.reportViewer1.LocalReport.SetParameters(parameters);
                this.getMostPerformedTestsDuringDatesTableAdapter1.Fill(labTestReportDataSet1.getMostPerformedTestsDuringDates, start, end);

                System.Drawing.Printing.PageSettings ps = reportViewer1.GetPageSettings();
                ps.Landscape = true;
                reportViewer1.SetPageSettings(ps);
                this.reportViewer1.RefreshReport();
            }
            else
            {
                string boxTitle = "Date Error";
                string boxMessage = "The end date must be later than the start date.";              
                MessageBox.Show(boxMessage, boxTitle);
            }
            
        }


        /// <summary>
        /// Verifies that the end date comes chronologically after the start date
        /// </summary>
        /// <param name="startDate">start date</param>
        /// <param name="endDate">end date</param>
        /// <returns>true if condition is met</returns>
        private bool DatesAreValid(DateTime startDate, DateTime endDate)
        {
            return (DateTime.Compare(startDate, endDate) < 0);
        }
    }
}

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



                // BEGIN TESTING STUFF ----------------------------------------------
                //DataSet ds = new DataSet();
                //this.getMostPerformedTestsDuringDatesTableAdapter1.Fill(ds);
                //DataTable dt = ds.Tables[0];

                //DataSet ds = labTestReportDataSet1;
                //DataTable dt = ds.Tables[0];
                //this.reportViewer.Reset();
                //this.reportViewer.ProcessingMode = ProcessingMode.Local;
                //ReportDataSource reportDataSource = new ReportDataSource();
                //// Must match the DataSet in the RDLC
                //reportDataSource.Name = "labTestReportDataSet";
                //reportDataSource.Value = ds.Tables[0];
                //this.reportViewer.LocalReport.DataSources.Add(reportDataSource);
                //this.reportViewer.RefreshReport();

                //ReportDataSource reportDataSource = new ReportDataSource();
                //// Must match the DataSource in the RDLC
                //reportDataSource.Name = "ReportData";
                //reportDataSource.Value = ds.Tables[0];

                //this.reportViewer.LocalReport.DataSources.Add(reportDataSource);
                //this.reportViewer.DataBind();
                //var myDataTable = new dsReports.tsPrimaryMondayDataTable();
                //var myDataTable = this.getMostPerformedTestsDuringDatesTableAdapter1.Fill(labTestReportDataSet1.getMostPerformedTestsDuringDates, start, end);
                //var myTableAdapter = this.getMostPerformedTestsDuringDatesTableAdapter1;
                //myTableAdapter.Fill(myDataTable, Convert.ToDateTime(dtp.Value));
                //ReportDataSource theDataSource = new ReportDataSource();
                //theDataSource.Name = "LabReportStatsSource";
                //theDataSource.Value = labTestReportDataSet1.Tables.

                //this.reportViewer.LocalReport.DataSources.Add(labTestReportDataSet.getMostPerformedTestsDuringDatesDataTable);

                //var dataSource = new ReportDataSource("DataSet1", this.labTestReportDataSet1);

                //this.reportViewer.LocalReport.DataSources.Clear();
                //this.reportViewer.LocalReport.DataSources.Add(dataSource);
                //this.reportViewer.RefreshReport();

                // END ---------------------------------------------------------------



                //System.Drawing.Printing.PageSettings ps = reportViewer.GetPageSettings();
                //ps.Landscape = true;
                //reportViewer.SetPageSettings(ps);
                //this.reportViewer.RefreshReport();
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


namespace Clinic.UserControls
{
    partial class ReportUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            //Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            //this.getMostPerformedTestsDuringDatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.labTestReportDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this._labTestReportDataSet = new Clinic._labTestReportDataSet();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.generateReportButton = new System.Windows.Forms.Button();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            //this.getMostPerformedTestsDuringDatesTableAdapter = new Clinic._labTestReportDataSetTableAdapters.getMostPerformedTestsDuringDatesTableAdapter();
            //((System.ComponentModel.ISupportInitialize)(this.getMostPerformedTestsDuringDatesBindingSource)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.labTestReportDataSetBindingSource)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this._labTestReportDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // getMostPerformedTestsDuringDatesBindingSource
            // 
            //this.getMostPerformedTestsDuringDatesBindingSource.DataMember = "getMostPerformedTestsDuringDates";
            //this.getMostPerformedTestsDuringDatesBindingSource.DataSource = this.labTestReportDataSetBindingSource;
            // 
            // labTestReportDataSetBindingSource
            // 
            //this.labTestReportDataSetBindingSource.DataSource = this._labTestReportDataSet;
            //this.labTestReportDataSetBindingSource.Position = 0;
            // 
            // _labTestReportDataSet
            // 
            //this._labTestReportDataSet.DataSetName = "_labTestReportDataSet";
            //this._labTestReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(118, 13);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.startDateTimePicker.TabIndex = 1;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Location = new System.Drawing.Point(118, 40);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.endDateTimePicker.TabIndex = 2;
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(41, 13);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(58, 13);
            this.startDateLabel.TabIndex = 3;
            this.startDateLabel.Text = "Start Date:";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(41, 40);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(55, 13);
            this.endDateLabel.TabIndex = 4;
            this.endDateLabel.Text = "End Date:";
            // 
            // generateReportButton
            // 
            this.generateReportButton.Location = new System.Drawing.Point(354, 13);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(111, 47);
            this.generateReportButton.TabIndex = 5;
            this.generateReportButton.Text = "Generate Report";
            this.generateReportButton.UseVisualStyleBackColor = true;
            this.generateReportButton.Click += new System.EventHandler(this.GenerateReportButton_Click);
            // 
            // reportViewer
            // 
            //reportDataSource1.Name = "LabTestReportDataSet";
            //reportDataSource1.Value = this.getMostPerformedTestsDuringDatesBindingSource;
            //this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            //this.reportViewer.LocalReport.ReportEmbeddedResource = "Clinic.View.LabTestFrequencyReport.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 76);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(561, 214);
            this.reportViewer.TabIndex = 6;
            this.reportViewer.ZoomPercent = 75;
            // 
            // getMostPerformedTestsDuringDatesTableAdapter
            // 
            //this.getMostPerformedTestsDuringDatesTableAdapter.ClearBeforeFill = true;
            // 
            // ReportUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.generateReportButton);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReportUserControl";
            this.Size = new System.Drawing.Size(561, 322);
            //((System.ComponentModel.ISupportInitialize)(this.getMostPerformedTestsDuringDatesBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.labTestReportDataSetBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this._labTestReportDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Button generateReportButton;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        //private System.Windows.Forms.BindingSource labTestReportDataSetBindingSource;
        //private _labTestReportDataSet _labTestReportDataSet;
        //private System.Windows.Forms.BindingSource getMostPerformedTestsDuringDatesBindingSource;
        //private _labTestReportDataSetTableAdapters.getMostPerformedTestsDuringDatesTableAdapter getMostPerformedTestsDuringDatesTableAdapter;
    }
}

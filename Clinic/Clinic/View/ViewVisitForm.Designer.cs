
namespace Clinic.View
{
    partial class ViewVisitForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label bodyTemperatureLabel;
            System.Windows.Forms.Label diastolicBloodPressureLabel;
            System.Windows.Forms.Label doctorFullNameLabel;
            System.Windows.Forms.Label nurseFullNameLabel;
            System.Windows.Forms.Label patientFullNameLabel;
            System.Windows.Forms.Label pulseLabel;
            System.Windows.Forms.Label symptomsLabel;
            System.Windows.Forms.Label systolicBloodPressureLabel;
            System.Windows.Forms.Label visitDateLabel;
            System.Windows.Forms.Label weightLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.viewVisitTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.symptomsOutputLabel = new System.Windows.Forms.Label();
            this.visitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bodyTemperatureOutputLabel = new System.Windows.Forms.Label();
            this.diastolicBloodPressureOutputLabel = new System.Windows.Forms.Label();
            this.weightOutputLabel = new System.Windows.Forms.Label();
            this.pulseOutputLabel = new System.Windows.Forms.Label();
            this.systolicBloodPressureOutputLabel = new System.Windows.Forms.Label();
            this.doctorFullNameOutputLabel = new System.Windows.Forms.Label();
            this.visitInformationLabel = new System.Windows.Forms.Label();
            this.nurseFullNameOutputLabel = new System.Windows.Forms.Label();
            this.patientFullNameOutputLabel = new System.Windows.Forms.Label();
            this.visitDateOutputLabel = new System.Windows.Forms.Label();
            this.buttonTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.closeButton = new System.Windows.Forms.Button();
            this.orderTestButton = new System.Windows.Forms.Button();
            this.labTestDataGridView = new System.Windows.Forms.DataGridView();
            this.finalDiagnosisRichTextBox = new System.Windows.Forms.RichTextBox();
            this.initialDiagnosisRichTextBox = new System.Windows.Forms.RichTextBox();
            this.saveButton = new System.Windows.Forms.Button();
            bodyTemperatureLabel = new System.Windows.Forms.Label();
            diastolicBloodPressureLabel = new System.Windows.Forms.Label();
            doctorFullNameLabel = new System.Windows.Forms.Label();
            nurseFullNameLabel = new System.Windows.Forms.Label();
            patientFullNameLabel = new System.Windows.Forms.Label();
            pulseLabel = new System.Windows.Forms.Label();
            symptomsLabel = new System.Windows.Forms.Label();
            systolicBloodPressureLabel = new System.Windows.Forms.Label();
            visitDateLabel = new System.Windows.Forms.Label();
            weightLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.viewVisitTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingSource)).BeginInit();
            this.buttonTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labTestDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bodyTemperatureLabel
            // 
            bodyTemperatureLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            bodyTemperatureLabel.AutoSize = true;
            bodyTemperatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bodyTemperatureLabel.Location = new System.Drawing.Point(86, 340);
            bodyTemperatureLabel.Name = "bodyTemperatureLabel";
            bodyTemperatureLabel.Size = new System.Drawing.Size(237, 29);
            bodyTemperatureLabel.TabIndex = 4;
            bodyTemperatureLabel.Text = "Body Temperature:";
            // 
            // diastolicBloodPressureLabel
            // 
            diastolicBloodPressureLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            diastolicBloodPressureLabel.AutoSize = true;
            diastolicBloodPressureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            diastolicBloodPressureLabel.Location = new System.Drawing.Point(14, 270);
            diastolicBloodPressureLabel.Name = "diastolicBloodPressureLabel";
            diastolicBloodPressureLabel.Size = new System.Drawing.Size(309, 29);
            diastolicBloodPressureLabel.TabIndex = 6;
            diastolicBloodPressureLabel.Text = "Diastolic Blood Pressure:";
            // 
            // doctorFullNameLabel
            // 
            doctorFullNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            doctorFullNameLabel.AutoSize = true;
            doctorFullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            doctorFullNameLabel.Location = new System.Drawing.Point(226, 165);
            doctorFullNameLabel.Name = "doctorFullNameLabel";
            doctorFullNameLabel.Size = new System.Drawing.Size(97, 29);
            doctorFullNameLabel.TabIndex = 10;
            doctorFullNameLabel.Text = "Doctor:";
            // 
            // nurseFullNameLabel
            // 
            nurseFullNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            nurseFullNameLabel.AutoSize = true;
            nurseFullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nurseFullNameLabel.Location = new System.Drawing.Point(233, 130);
            nurseFullNameLabel.Name = "nurseFullNameLabel";
            nurseFullNameLabel.Size = new System.Drawing.Size(90, 29);
            nurseFullNameLabel.TabIndex = 16;
            nurseFullNameLabel.Text = "Nurse:";
            // 
            // patientFullNameLabel
            // 
            patientFullNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            patientFullNameLabel.AutoSize = true;
            patientFullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            patientFullNameLabel.Location = new System.Drawing.Point(222, 95);
            patientFullNameLabel.Name = "patientFullNameLabel";
            patientFullNameLabel.Size = new System.Drawing.Size(101, 29);
            patientFullNameLabel.TabIndex = 26;
            patientFullNameLabel.Text = "Patient:";
            // 
            // pulseLabel
            // 
            pulseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            pulseLabel.AutoSize = true;
            pulseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pulseLabel.Location = new System.Drawing.Point(237, 200);
            pulseLabel.Name = "pulseLabel";
            pulseLabel.Size = new System.Drawing.Size(86, 29);
            pulseLabel.TabIndex = 30;
            pulseLabel.Text = "Pulse:";
            // 
            // symptomsLabel
            // 
            symptomsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            symptomsLabel.AutoSize = true;
            symptomsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            symptomsLabel.Location = new System.Drawing.Point(182, 375);
            symptomsLabel.Name = "symptomsLabel";
            symptomsLabel.Size = new System.Drawing.Size(141, 29);
            symptomsLabel.TabIndex = 32;
            symptomsLabel.Text = "Symptoms:";
            // 
            // systolicBloodPressureLabel
            // 
            systolicBloodPressureLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            systolicBloodPressureLabel.AutoSize = true;
            systolicBloodPressureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            systolicBloodPressureLabel.Location = new System.Drawing.Point(24, 235);
            systolicBloodPressureLabel.Name = "systolicBloodPressureLabel";
            systolicBloodPressureLabel.Size = new System.Drawing.Size(299, 29);
            systolicBloodPressureLabel.TabIndex = 34;
            systolicBloodPressureLabel.Text = "Systolic Blood Pressure:";
            // 
            // visitDateLabel
            // 
            visitDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            visitDateLabel.AutoSize = true;
            visitDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            visitDateLabel.Location = new System.Drawing.Point(192, 60);
            visitDateLabel.Name = "visitDateLabel";
            visitDateLabel.Size = new System.Drawing.Size(131, 29);
            visitDateLabel.TabIndex = 36;
            visitDateLabel.Text = "Visit Date:";
            // 
            // weightLabel
            // 
            weightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            weightLabel.AutoSize = true;
            weightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            weightLabel.Location = new System.Drawing.Point(222, 305);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new System.Drawing.Size(101, 29);
            weightLabel.TabIndex = 38;
            weightLabel.Text = "Weight:";
            // 
            // viewVisitTableLayoutPanel
            // 
            this.viewVisitTableLayoutPanel.ColumnCount = 2;
            this.viewVisitTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.59748F));
            this.viewVisitTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.40252F));
            this.viewVisitTableLayoutPanel.Controls.Add(this.symptomsOutputLabel, 1, 10);
            this.viewVisitTableLayoutPanel.Controls.Add(this.bodyTemperatureOutputLabel, 1, 9);
            this.viewVisitTableLayoutPanel.Controls.Add(bodyTemperatureLabel, 0, 9);
            this.viewVisitTableLayoutPanel.Controls.Add(this.diastolicBloodPressureOutputLabel, 1, 7);
            this.viewVisitTableLayoutPanel.Controls.Add(this.weightOutputLabel, 1, 8);
            this.viewVisitTableLayoutPanel.Controls.Add(diastolicBloodPressureLabel, 0, 7);
            this.viewVisitTableLayoutPanel.Controls.Add(this.pulseOutputLabel, 1, 5);
            this.viewVisitTableLayoutPanel.Controls.Add(this.systolicBloodPressureOutputLabel, 1, 6);
            this.viewVisitTableLayoutPanel.Controls.Add(this.doctorFullNameOutputLabel, 1, 4);
            this.viewVisitTableLayoutPanel.Controls.Add(this.visitInformationLabel, 1, 0);
            this.viewVisitTableLayoutPanel.Controls.Add(this.nurseFullNameOutputLabel, 1, 3);
            this.viewVisitTableLayoutPanel.Controls.Add(symptomsLabel, 0, 10);
            this.viewVisitTableLayoutPanel.Controls.Add(this.patientFullNameOutputLabel, 1, 2);
            this.viewVisitTableLayoutPanel.Controls.Add(doctorFullNameLabel, 0, 4);
            this.viewVisitTableLayoutPanel.Controls.Add(pulseLabel, 0, 5);
            this.viewVisitTableLayoutPanel.Controls.Add(nurseFullNameLabel, 0, 3);
            this.viewVisitTableLayoutPanel.Controls.Add(this.visitDateOutputLabel, 1, 1);
            this.viewVisitTableLayoutPanel.Controls.Add(weightLabel, 0, 8);
            this.viewVisitTableLayoutPanel.Controls.Add(systolicBloodPressureLabel, 0, 6);
            this.viewVisitTableLayoutPanel.Controls.Add(patientFullNameLabel, 0, 2);
            this.viewVisitTableLayoutPanel.Controls.Add(visitDateLabel, 0, 1);
            this.viewVisitTableLayoutPanel.Controls.Add(this.labTestDataGridView, 0, 13);
            this.viewVisitTableLayoutPanel.Controls.Add(label1, 0, 11);
            this.viewVisitTableLayoutPanel.Controls.Add(label2, 0, 12);
            this.viewVisitTableLayoutPanel.Controls.Add(this.finalDiagnosisRichTextBox, 1, 12);
            this.viewVisitTableLayoutPanel.Controls.Add(this.initialDiagnosisRichTextBox, 1, 11);
            this.viewVisitTableLayoutPanel.Controls.Add(this.buttonTableLayoutPanel, 0, 14);
            this.viewVisitTableLayoutPanel.Location = new System.Drawing.Point(14, 14);
            this.viewVisitTableLayoutPanel.Name = "viewVisitTableLayoutPanel";
            this.viewVisitTableLayoutPanel.RowCount = 15;
            this.viewVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.viewVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.viewVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.viewVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.viewVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.viewVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.viewVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.viewVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.viewVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.viewVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.viewVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.viewVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.viewVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.viewVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 215F));
            this.viewVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.viewVisitTableLayoutPanel.Size = new System.Drawing.Size(716, 906);
            this.viewVisitTableLayoutPanel.TabIndex = 2;
            // 
            // symptomsOutputLabel
            // 
            this.symptomsOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.symptomsOutputLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Symptoms", true));
            this.symptomsOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symptomsOutputLabel.Location = new System.Drawing.Point(329, 373);
            this.symptomsOutputLabel.Name = "symptomsOutputLabel";
            this.symptomsOutputLabel.Size = new System.Drawing.Size(318, 31);
            this.symptomsOutputLabel.TabIndex = 33;
            // 
            // visitBindingSource
            // 
            this.visitBindingSource.DataSource = typeof(Clinic.Model.Visit);
            // 
            // bodyTemperatureOutputLabel
            // 
            this.bodyTemperatureOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bodyTemperatureOutputLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "BodyTemperature", true));
            this.bodyTemperatureOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bodyTemperatureOutputLabel.Location = new System.Drawing.Point(329, 338);
            this.bodyTemperatureOutputLabel.Name = "bodyTemperatureOutputLabel";
            this.bodyTemperatureOutputLabel.Size = new System.Drawing.Size(318, 31);
            this.bodyTemperatureOutputLabel.TabIndex = 5;
            // 
            // diastolicBloodPressureOutputLabel
            // 
            this.diastolicBloodPressureOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.diastolicBloodPressureOutputLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "DiastolicBloodPressure", true));
            this.diastolicBloodPressureOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diastolicBloodPressureOutputLabel.Location = new System.Drawing.Point(329, 268);
            this.diastolicBloodPressureOutputLabel.Name = "diastolicBloodPressureOutputLabel";
            this.diastolicBloodPressureOutputLabel.Size = new System.Drawing.Size(318, 31);
            this.diastolicBloodPressureOutputLabel.TabIndex = 7;
            // 
            // weightOutputLabel
            // 
            this.weightOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.weightOutputLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Weight", true));
            this.weightOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightOutputLabel.Location = new System.Drawing.Point(329, 303);
            this.weightOutputLabel.Name = "weightOutputLabel";
            this.weightOutputLabel.Size = new System.Drawing.Size(318, 31);
            this.weightOutputLabel.TabIndex = 39;
            // 
            // pulseOutputLabel
            // 
            this.pulseOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pulseOutputLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Pulse", true));
            this.pulseOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pulseOutputLabel.Location = new System.Drawing.Point(329, 198);
            this.pulseOutputLabel.Name = "pulseOutputLabel";
            this.pulseOutputLabel.Size = new System.Drawing.Size(318, 31);
            this.pulseOutputLabel.TabIndex = 31;
            // 
            // systolicBloodPressureOutputLabel
            // 
            this.systolicBloodPressureOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.systolicBloodPressureOutputLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "SystolicBloodPressure", true));
            this.systolicBloodPressureOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systolicBloodPressureOutputLabel.Location = new System.Drawing.Point(329, 233);
            this.systolicBloodPressureOutputLabel.Name = "systolicBloodPressureOutputLabel";
            this.systolicBloodPressureOutputLabel.Size = new System.Drawing.Size(318, 31);
            this.systolicBloodPressureOutputLabel.TabIndex = 35;
            // 
            // doctorFullNameOutputLabel
            // 
            this.doctorFullNameOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.doctorFullNameOutputLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "DoctorFullName", true));
            this.doctorFullNameOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorFullNameOutputLabel.Location = new System.Drawing.Point(329, 163);
            this.doctorFullNameOutputLabel.Name = "doctorFullNameOutputLabel";
            this.doctorFullNameOutputLabel.Size = new System.Drawing.Size(318, 31);
            this.doctorFullNameOutputLabel.TabIndex = 11;
            // 
            // visitInformationLabel
            // 
            this.visitInformationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.visitInformationLabel.AutoSize = true;
            this.visitInformationLabel.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitInformationLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.visitInformationLabel.Location = new System.Drawing.Point(329, 0);
            this.visitInformationLabel.Name = "visitInformationLabel";
            this.visitInformationLabel.Size = new System.Drawing.Size(318, 54);
            this.visitInformationLabel.TabIndex = 16;
            this.visitInformationLabel.Text = "Visit Information";
            // 
            // nurseFullNameOutputLabel
            // 
            this.nurseFullNameOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nurseFullNameOutputLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "NurseFullName", true));
            this.nurseFullNameOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nurseFullNameOutputLabel.Location = new System.Drawing.Point(329, 128);
            this.nurseFullNameOutputLabel.Name = "nurseFullNameOutputLabel";
            this.nurseFullNameOutputLabel.Size = new System.Drawing.Size(318, 31);
            this.nurseFullNameOutputLabel.TabIndex = 17;
            // 
            // patientFullNameOutputLabel
            // 
            this.patientFullNameOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.patientFullNameOutputLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "PatientFullName", true));
            this.patientFullNameOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientFullNameOutputLabel.Location = new System.Drawing.Point(329, 93);
            this.patientFullNameOutputLabel.Name = "patientFullNameOutputLabel";
            this.patientFullNameOutputLabel.Size = new System.Drawing.Size(318, 31);
            this.patientFullNameOutputLabel.TabIndex = 27;
            // 
            // visitDateOutputLabel
            // 
            this.visitDateOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.visitDateOutputLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "VisitDate", true));
            this.visitDateOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitDateOutputLabel.Location = new System.Drawing.Point(329, 58);
            this.visitDateOutputLabel.Name = "visitDateOutputLabel";
            this.visitDateOutputLabel.Size = new System.Drawing.Size(318, 31);
            this.visitDateOutputLabel.TabIndex = 37;
            // 
            // buttonTableLayoutPanel
            // 
            this.buttonTableLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonTableLayoutPanel.ColumnCount = 3;
            this.viewVisitTableLayoutPanel.SetColumnSpan(this.buttonTableLayoutPanel, 2);
            this.buttonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.buttonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.buttonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.buttonTableLayoutPanel.Controls.Add(this.saveButton, 0, 0);
            this.buttonTableLayoutPanel.Controls.Add(this.closeButton, 2, 0);
            this.buttonTableLayoutPanel.Controls.Add(this.orderTestButton, 0, 0);
            this.buttonTableLayoutPanel.Location = new System.Drawing.Point(5, 833);
            this.buttonTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonTableLayoutPanel.Name = "buttonTableLayoutPanel";
            this.buttonTableLayoutPanel.RowCount = 1;
            this.buttonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonTableLayoutPanel.Size = new System.Drawing.Size(706, 68);
            this.buttonTableLayoutPanel.TabIndex = 40;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.closeButton.AutoSize = true;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(481, 26);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(201, 39);
            this.closeButton.TabIndex = 20;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.OkayButton_Click);
            // 
            // orderTestButton
            // 
            this.orderTestButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.orderTestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderTestButton.Location = new System.Drawing.Point(23, 6);
            this.orderTestButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.orderTestButton.Name = "orderTestButton";
            this.orderTestButton.Size = new System.Drawing.Size(201, 57);
            this.orderTestButton.TabIndex = 22;
            this.orderTestButton.Text = "Order New Test";
            this.orderTestButton.UseVisualStyleBackColor = true;
            // 
            // labTestDataGridView
            // 
            this.labTestDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewVisitTableLayoutPanel.SetColumnSpan(this.labTestDataGridView, 2);
            this.labTestDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labTestDataGridView.Location = new System.Drawing.Point(4, 609);
            this.labTestDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labTestDataGridView.Name = "labTestDataGridView";
            this.labTestDataGridView.RowHeadersWidth = 62;
            this.labTestDataGridView.Size = new System.Drawing.Size(708, 205);
            this.labTestDataGridView.TabIndex = 41;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(117, 439);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(206, 29);
            label1.TabIndex = 42;
            label1.Text = "Initial Diagnosis:";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(122, 539);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(201, 29);
            label2.TabIndex = 43;
            label2.Text = "Final Diagnosis:";
            // 
            // finalDiagnosisRichTextBox
            // 
            this.finalDiagnosisRichTextBox.Location = new System.Drawing.Point(329, 507);
            this.finalDiagnosisRichTextBox.Name = "finalDiagnosisRichTextBox";
            this.finalDiagnosisRichTextBox.Size = new System.Drawing.Size(384, 94);
            this.finalDiagnosisRichTextBox.TabIndex = 45;
            this.finalDiagnosisRichTextBox.Text = "";
            // 
            // initialDiagnosisRichTextBox
            // 
            this.initialDiagnosisRichTextBox.Location = new System.Drawing.Point(329, 407);
            this.initialDiagnosisRichTextBox.Name = "initialDiagnosisRichTextBox";
            this.initialDiagnosisRichTextBox.Size = new System.Drawing.Size(382, 94);
            this.initialDiagnosisRichTextBox.TabIndex = 46;
            this.initialDiagnosisRichTextBox.Text = "";
            // 
            // saveButton
            // 
            this.saveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.saveButton.AutoSize = true;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(252, 26);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(201, 39);
            this.saveButton.TabIndex = 23;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // ViewVisitForm
            // 
            this.AcceptButton = this.closeButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 937);
            this.Controls.Add(this.viewVisitTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewVisitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Visit Details";
            this.Load += new System.EventHandler(this.ViewVisitForm_Load);
            this.viewVisitTableLayoutPanel.ResumeLayout(false);
            this.viewVisitTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingSource)).EndInit();
            this.buttonTableLayoutPanel.ResumeLayout(false);
            this.buttonTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labTestDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel viewVisitTableLayoutPanel;
        private System.Windows.Forms.Label visitInformationLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.BindingSource visitBindingSource;
        private System.Windows.Forms.Label bodyTemperatureOutputLabel;
        private System.Windows.Forms.Label diastolicBloodPressureOutputLabel;
        private System.Windows.Forms.Label doctorFullNameOutputLabel;
        private System.Windows.Forms.Label nurseFullNameOutputLabel;
        private System.Windows.Forms.Label patientFullNameOutputLabel;
        private System.Windows.Forms.Label pulseOutputLabel;
        private System.Windows.Forms.Label symptomsOutputLabel;
        private System.Windows.Forms.Label systolicBloodPressureOutputLabel;
        private System.Windows.Forms.Label visitDateOutputLabel;
        private System.Windows.Forms.Label weightOutputLabel;
        private System.Windows.Forms.TableLayoutPanel buttonTableLayoutPanel;
        private System.Windows.Forms.Button orderTestButton;
        private System.Windows.Forms.DataGridView labTestDataGridView;
        private System.Windows.Forms.RichTextBox finalDiagnosisRichTextBox;
        private System.Windows.Forms.RichTextBox initialDiagnosisRichTextBox;
        private System.Windows.Forms.Button saveButton;
    }
}
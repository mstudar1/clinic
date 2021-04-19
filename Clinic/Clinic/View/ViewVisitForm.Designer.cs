
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
            this.viewVisitTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.closeButton = new System.Windows.Forms.Button();
            this.symptomsOutputLabel = new System.Windows.Forms.Label();
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
            this.visitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.enterDiagnosisButton = new System.Windows.Forms.Button();
            this.orderTestButton = new System.Windows.Forms.Button();
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
            this.viewVisitTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingSource)).BeginInit();
            this.buttonTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bodyTemperatureLabel
            // 
            bodyTemperatureLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            bodyTemperatureLabel.AutoSize = true;
            bodyTemperatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bodyTemperatureLabel.Location = new System.Drawing.Point(54, 330);
            bodyTemperatureLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            bodyTemperatureLabel.Name = "bodyTemperatureLabel";
            bodyTemperatureLabel.Size = new System.Drawing.Size(161, 20);
            bodyTemperatureLabel.TabIndex = 4;
            bodyTemperatureLabel.Text = "Body Temperature:";
            // 
            // diastolicBloodPressureLabel
            // 
            diastolicBloodPressureLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            diastolicBloodPressureLabel.AutoSize = true;
            diastolicBloodPressureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            diastolicBloodPressureLabel.Location = new System.Drawing.Point(5, 260);
            diastolicBloodPressureLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            diastolicBloodPressureLabel.Name = "diastolicBloodPressureLabel";
            diastolicBloodPressureLabel.Size = new System.Drawing.Size(210, 20);
            diastolicBloodPressureLabel.TabIndex = 6;
            diastolicBloodPressureLabel.Text = "Diastolic Blood Pressure:";
            // 
            // doctorFullNameLabel
            // 
            doctorFullNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            doctorFullNameLabel.AutoSize = true;
            doctorFullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            doctorFullNameLabel.Location = new System.Drawing.Point(147, 155);
            doctorFullNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            doctorFullNameLabel.Name = "doctorFullNameLabel";
            doctorFullNameLabel.Size = new System.Drawing.Size(68, 20);
            doctorFullNameLabel.TabIndex = 10;
            doctorFullNameLabel.Text = "Doctor:";
            // 
            // nurseFullNameLabel
            // 
            nurseFullNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            nurseFullNameLabel.AutoSize = true;
            nurseFullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nurseFullNameLabel.Location = new System.Drawing.Point(154, 120);
            nurseFullNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nurseFullNameLabel.Name = "nurseFullNameLabel";
            nurseFullNameLabel.Size = new System.Drawing.Size(61, 20);
            nurseFullNameLabel.TabIndex = 16;
            nurseFullNameLabel.Text = "Nurse:";
            // 
            // patientFullNameLabel
            // 
            patientFullNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            patientFullNameLabel.AutoSize = true;
            patientFullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            patientFullNameLabel.Location = new System.Drawing.Point(144, 85);
            patientFullNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            patientFullNameLabel.Name = "patientFullNameLabel";
            patientFullNameLabel.Size = new System.Drawing.Size(71, 20);
            patientFullNameLabel.TabIndex = 26;
            patientFullNameLabel.Text = "Patient:";
            // 
            // pulseLabel
            // 
            pulseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            pulseLabel.AutoSize = true;
            pulseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pulseLabel.Location = new System.Drawing.Point(157, 190);
            pulseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            pulseLabel.Name = "pulseLabel";
            pulseLabel.Size = new System.Drawing.Size(58, 20);
            pulseLabel.TabIndex = 30;
            pulseLabel.Text = "Pulse:";
            // 
            // symptomsLabel
            // 
            symptomsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            symptomsLabel.AutoSize = true;
            symptomsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            symptomsLabel.Location = new System.Drawing.Point(118, 365);
            symptomsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            symptomsLabel.Name = "symptomsLabel";
            symptomsLabel.Size = new System.Drawing.Size(97, 20);
            symptomsLabel.TabIndex = 32;
            symptomsLabel.Text = "Symptoms:";
            // 
            // systolicBloodPressureLabel
            // 
            systolicBloodPressureLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            systolicBloodPressureLabel.AutoSize = true;
            systolicBloodPressureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            systolicBloodPressureLabel.Location = new System.Drawing.Point(12, 225);
            systolicBloodPressureLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            systolicBloodPressureLabel.Name = "systolicBloodPressureLabel";
            systolicBloodPressureLabel.Size = new System.Drawing.Size(203, 20);
            systolicBloodPressureLabel.TabIndex = 34;
            systolicBloodPressureLabel.Text = "Systolic Blood Pressure:";
            // 
            // visitDateLabel
            // 
            visitDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            visitDateLabel.AutoSize = true;
            visitDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            visitDateLabel.Location = new System.Drawing.Point(122, 50);
            visitDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            visitDateLabel.Name = "visitDateLabel";
            visitDateLabel.Size = new System.Drawing.Size(93, 20);
            visitDateLabel.TabIndex = 36;
            visitDateLabel.Text = "Visit Date:";
            // 
            // weightLabel
            // 
            weightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            weightLabel.AutoSize = true;
            weightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            weightLabel.Location = new System.Drawing.Point(145, 295);
            weightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new System.Drawing.Size(70, 20);
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
            this.viewVisitTableLayoutPanel.Controls.Add(this.buttonTableLayoutPanel, 0, 12);
            this.viewVisitTableLayoutPanel.Location = new System.Drawing.Point(9, 9);
            this.viewVisitTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.viewVisitTableLayoutPanel.Name = "viewVisitTableLayoutPanel";
            this.viewVisitTableLayoutPanel.RowCount = 13;
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
            this.viewVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.viewVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.viewVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.viewVisitTableLayoutPanel.Size = new System.Drawing.Size(477, 509);
            this.viewVisitTableLayoutPanel.TabIndex = 2;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.closeButton.AutoSize = true;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(321, 43);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(134, 38);
            this.closeButton.TabIndex = 20;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.OkayButton_Click);
            // 
            // symptomsOutputLabel
            // 
            this.symptomsOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.symptomsOutputLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Symptoms", true));
            this.symptomsOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symptomsOutputLabel.Location = new System.Drawing.Point(219, 365);
            this.symptomsOutputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.symptomsOutputLabel.Name = "symptomsOutputLabel";
            this.symptomsOutputLabel.Size = new System.Drawing.Size(212, 20);
            this.symptomsOutputLabel.TabIndex = 33;
            // 
            // bodyTemperatureOutputLabel
            // 
            this.bodyTemperatureOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bodyTemperatureOutputLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "BodyTemperature", true));
            this.bodyTemperatureOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bodyTemperatureOutputLabel.Location = new System.Drawing.Point(219, 330);
            this.bodyTemperatureOutputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bodyTemperatureOutputLabel.Name = "bodyTemperatureOutputLabel";
            this.bodyTemperatureOutputLabel.Size = new System.Drawing.Size(212, 20);
            this.bodyTemperatureOutputLabel.TabIndex = 5;
            // 
            // diastolicBloodPressureOutputLabel
            // 
            this.diastolicBloodPressureOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.diastolicBloodPressureOutputLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "DiastolicBloodPressure", true));
            this.diastolicBloodPressureOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diastolicBloodPressureOutputLabel.Location = new System.Drawing.Point(219, 260);
            this.diastolicBloodPressureOutputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.diastolicBloodPressureOutputLabel.Name = "diastolicBloodPressureOutputLabel";
            this.diastolicBloodPressureOutputLabel.Size = new System.Drawing.Size(212, 20);
            this.diastolicBloodPressureOutputLabel.TabIndex = 7;
            // 
            // weightOutputLabel
            // 
            this.weightOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.weightOutputLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Weight", true));
            this.weightOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightOutputLabel.Location = new System.Drawing.Point(219, 295);
            this.weightOutputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.weightOutputLabel.Name = "weightOutputLabel";
            this.weightOutputLabel.Size = new System.Drawing.Size(212, 20);
            this.weightOutputLabel.TabIndex = 39;
            // 
            // pulseOutputLabel
            // 
            this.pulseOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pulseOutputLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Pulse", true));
            this.pulseOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pulseOutputLabel.Location = new System.Drawing.Point(219, 190);
            this.pulseOutputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pulseOutputLabel.Name = "pulseOutputLabel";
            this.pulseOutputLabel.Size = new System.Drawing.Size(212, 20);
            this.pulseOutputLabel.TabIndex = 31;
            // 
            // systolicBloodPressureOutputLabel
            // 
            this.systolicBloodPressureOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.systolicBloodPressureOutputLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "SystolicBloodPressure", true));
            this.systolicBloodPressureOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systolicBloodPressureOutputLabel.Location = new System.Drawing.Point(219, 225);
            this.systolicBloodPressureOutputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.systolicBloodPressureOutputLabel.Name = "systolicBloodPressureOutputLabel";
            this.systolicBloodPressureOutputLabel.Size = new System.Drawing.Size(212, 20);
            this.systolicBloodPressureOutputLabel.TabIndex = 35;
            // 
            // doctorFullNameOutputLabel
            // 
            this.doctorFullNameOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.doctorFullNameOutputLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "DoctorFullName", true));
            this.doctorFullNameOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorFullNameOutputLabel.Location = new System.Drawing.Point(219, 155);
            this.doctorFullNameOutputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.doctorFullNameOutputLabel.Name = "doctorFullNameOutputLabel";
            this.doctorFullNameOutputLabel.Size = new System.Drawing.Size(212, 20);
            this.doctorFullNameOutputLabel.TabIndex = 11;
            // 
            // visitInformationLabel
            // 
            this.visitInformationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.visitInformationLabel.AutoSize = true;
            this.visitInformationLabel.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitInformationLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.visitInformationLabel.Location = new System.Drawing.Point(219, 0);
            this.visitInformationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.visitInformationLabel.Name = "visitInformationLabel";
            this.visitInformationLabel.Size = new System.Drawing.Size(218, 35);
            this.visitInformationLabel.TabIndex = 16;
            this.visitInformationLabel.Text = "Visit Information";
            // 
            // nurseFullNameOutputLabel
            // 
            this.nurseFullNameOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nurseFullNameOutputLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "NurseFullName", true));
            this.nurseFullNameOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nurseFullNameOutputLabel.Location = new System.Drawing.Point(219, 120);
            this.nurseFullNameOutputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nurseFullNameOutputLabel.Name = "nurseFullNameOutputLabel";
            this.nurseFullNameOutputLabel.Size = new System.Drawing.Size(212, 20);
            this.nurseFullNameOutputLabel.TabIndex = 17;
            // 
            // patientFullNameOutputLabel
            // 
            this.patientFullNameOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.patientFullNameOutputLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "PatientFullName", true));
            this.patientFullNameOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientFullNameOutputLabel.Location = new System.Drawing.Point(219, 85);
            this.patientFullNameOutputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientFullNameOutputLabel.Name = "patientFullNameOutputLabel";
            this.patientFullNameOutputLabel.Size = new System.Drawing.Size(212, 20);
            this.patientFullNameOutputLabel.TabIndex = 27;
            // 
            // visitDateOutputLabel
            // 
            this.visitDateOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.visitDateOutputLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "VisitDate", true));
            this.visitDateOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitDateOutputLabel.Location = new System.Drawing.Point(219, 50);
            this.visitDateOutputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.visitDateOutputLabel.Name = "visitDateOutputLabel";
            this.visitDateOutputLabel.Size = new System.Drawing.Size(212, 20);
            this.visitDateOutputLabel.TabIndex = 37;
            // 
            // visitBindingSource
            // 
            this.visitBindingSource.DataSource = typeof(Clinic.Model.Visit);
            // 
            // buttonTableLayoutPanel
            // 
            this.buttonTableLayoutPanel.ColumnCount = 3;
            this.viewVisitTableLayoutPanel.SetColumnSpan(this.buttonTableLayoutPanel, 2);
            this.buttonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.buttonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.buttonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.buttonTableLayoutPanel.Controls.Add(this.closeButton, 2, 0);
            this.buttonTableLayoutPanel.Controls.Add(this.enterDiagnosisButton, 1, 0);
            this.buttonTableLayoutPanel.Controls.Add(this.orderTestButton, 0, 0);
            this.buttonTableLayoutPanel.Location = new System.Drawing.Point(3, 423);
            this.buttonTableLayoutPanel.Name = "buttonTableLayoutPanel";
            this.buttonTableLayoutPanel.RowCount = 1;
            this.buttonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonTableLayoutPanel.Size = new System.Drawing.Size(471, 83);
            this.buttonTableLayoutPanel.TabIndex = 40;
            // 
            // enterDiagnosisButton
            // 
            this.enterDiagnosisButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.enterDiagnosisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterDiagnosisButton.Location = new System.Drawing.Point(167, 43);
            this.enterDiagnosisButton.Name = "enterDiagnosisButton";
            this.enterDiagnosisButton.Size = new System.Drawing.Size(135, 37);
            this.enterDiagnosisButton.TabIndex = 21;
            this.enterDiagnosisButton.Text = "Enter Diagnosis";
            this.enterDiagnosisButton.UseVisualStyleBackColor = true;
            // 
            // orderTestButton
            // 
            this.orderTestButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.orderTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderTestButton.Location = new System.Drawing.Point(15, 43);
            this.orderTestButton.Name = "orderTestButton";
            this.orderTestButton.Size = new System.Drawing.Size(134, 37);
            this.orderTestButton.TabIndex = 22;
            this.orderTestButton.Text = "Order New Test";
            this.orderTestButton.UseVisualStyleBackColor = true;
            // 
            // ViewVisitForm
            // 
            this.AcceptButton = this.closeButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 529);
            this.Controls.Add(this.viewVisitTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button enterDiagnosisButton;
        private System.Windows.Forms.Button orderTestButton;
    }
}
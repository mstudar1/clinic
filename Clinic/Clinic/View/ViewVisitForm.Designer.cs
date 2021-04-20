
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
            System.Windows.Forms.Label diagnosisLabel;
            this.viewVisitTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.enterResultButton = new System.Windows.Forms.Button();
            this.symptomsOutputLabel = new System.Windows.Forms.Label();
            this.bodyTemperatureOutputLabel = new System.Windows.Forms.Label();
            this.diastolicBloodPressureOutputLabel = new System.Windows.Forms.Label();
            this.weightOutputLabel = new System.Windows.Forms.Label();
            this.pulseOutputLabel = new System.Windows.Forms.Label();
            this.systolicBloodPressureOutputLabel = new System.Windows.Forms.Label();
            this.doctorFullNameOutputLabel = new System.Windows.Forms.Label();
            this.nurseFullNameOutputLabel = new System.Windows.Forms.Label();
            this.patientFullNameOutputLabel = new System.Windows.Forms.Label();
            this.visitDateOutputLabel = new System.Windows.Forms.Label();
            this.buttonTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.addDiagnosisButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.orderTestButton = new System.Windows.Forms.Button();
            this.diagnosisOutputLabel = new System.Windows.Forms.Label();
            this.visitInformationLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.testsListView = new System.Windows.Forms.ListView();
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.resultColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.isValidColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.visitBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            diagnosisLabel = new System.Windows.Forms.Label();
            this.viewVisitTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.buttonTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bodyTemperatureLabel
            // 
            bodyTemperatureLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            bodyTemperatureLabel.AutoSize = true;
            bodyTemperatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bodyTemperatureLabel.Location = new System.Drawing.Point(80, 340);
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
            diastolicBloodPressureLabel.Location = new System.Drawing.Point(8, 270);
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
            doctorFullNameLabel.Location = new System.Drawing.Point(220, 165);
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
            nurseFullNameLabel.Location = new System.Drawing.Point(227, 130);
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
            patientFullNameLabel.Location = new System.Drawing.Point(216, 95);
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
            pulseLabel.Location = new System.Drawing.Point(231, 200);
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
            symptomsLabel.Location = new System.Drawing.Point(176, 375);
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
            systolicBloodPressureLabel.Location = new System.Drawing.Point(18, 235);
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
            visitDateLabel.Location = new System.Drawing.Point(186, 60);
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
            weightLabel.Location = new System.Drawing.Point(216, 305);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new System.Drawing.Size(101, 29);
            weightLabel.TabIndex = 38;
            weightLabel.Text = "Weight:";
            // 
            // diagnosisLabel
            // 
            diagnosisLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            diagnosisLabel.AutoSize = true;
            diagnosisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            diagnosisLabel.Location = new System.Drawing.Point(181, 411);
            diagnosisLabel.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            diagnosisLabel.Name = "diagnosisLabel";
            diagnosisLabel.Size = new System.Drawing.Size(136, 29);
            diagnosisLabel.TabIndex = 42;
            diagnosisLabel.Text = "Diagnosis:";
            // 
            // viewVisitTableLayoutPanel
            // 
            this.viewVisitTableLayoutPanel.ColumnCount = 2;
            this.viewVisitTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.76257F));
            this.viewVisitTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.23743F));
            this.viewVisitTableLayoutPanel.Controls.Add(this.tableLayoutPanel2, 0, 13);
            this.viewVisitTableLayoutPanel.Controls.Add(this.symptomsOutputLabel, 1, 10);
            this.viewVisitTableLayoutPanel.Controls.Add(this.bodyTemperatureOutputLabel, 1, 9);
            this.viewVisitTableLayoutPanel.Controls.Add(bodyTemperatureLabel, 0, 9);
            this.viewVisitTableLayoutPanel.Controls.Add(this.diastolicBloodPressureOutputLabel, 1, 7);
            this.viewVisitTableLayoutPanel.Controls.Add(this.weightOutputLabel, 1, 8);
            this.viewVisitTableLayoutPanel.Controls.Add(diastolicBloodPressureLabel, 0, 7);
            this.viewVisitTableLayoutPanel.Controls.Add(this.pulseOutputLabel, 1, 5);
            this.viewVisitTableLayoutPanel.Controls.Add(this.systolicBloodPressureOutputLabel, 1, 6);
            this.viewVisitTableLayoutPanel.Controls.Add(this.doctorFullNameOutputLabel, 1, 4);
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
            this.viewVisitTableLayoutPanel.Controls.Add(this.buttonTableLayoutPanel, 0, 14);
            this.viewVisitTableLayoutPanel.Controls.Add(diagnosisLabel, 0, 11);
            this.viewVisitTableLayoutPanel.Controls.Add(this.diagnosisOutputLabel, 1, 11);
            this.viewVisitTableLayoutPanel.Controls.Add(this.visitInformationLabel, 1, 0);
            this.viewVisitTableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 12);
            this.viewVisitTableLayoutPanel.Location = new System.Drawing.Point(12, 14);
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
            this.viewVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.viewVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.viewVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.viewVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.viewVisitTableLayoutPanel.Size = new System.Drawing.Size(1042, 920);
            this.viewVisitTableLayoutPanel.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.viewVisitTableLayoutPanel.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.Controls.Add(this.enterResultButton, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(168, 779);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(706, 62);
            this.tableLayoutPanel2.TabIndex = 45;
            // 
            // enterResultButton
            // 
            this.enterResultButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.enterResultButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterResultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterResultButton.Location = new System.Drawing.Point(29, 5);
            this.enterResultButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enterResultButton.Name = "enterResultButton";
            this.enterResultButton.Size = new System.Drawing.Size(648, 52);
            this.enterResultButton.TabIndex = 1;
            this.enterResultButton.Text = "Enter Result for the Selected Test";
            this.enterResultButton.UseVisualStyleBackColor = true;
            this.enterResultButton.Click += new System.EventHandler(this.EnterResult_Click);
            // 
            // symptomsOutputLabel
            // 
            this.symptomsOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.symptomsOutputLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Symptoms", true));
            this.symptomsOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symptomsOutputLabel.Location = new System.Drawing.Point(323, 373);
            this.symptomsOutputLabel.Name = "symptomsOutputLabel";
            this.symptomsOutputLabel.Size = new System.Drawing.Size(565, 31);
            this.symptomsOutputLabel.TabIndex = 33;
            // 
            // bodyTemperatureOutputLabel
            // 
            this.bodyTemperatureOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bodyTemperatureOutputLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "BodyTemperature", true));
            this.bodyTemperatureOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bodyTemperatureOutputLabel.Location = new System.Drawing.Point(323, 338);
            this.bodyTemperatureOutputLabel.Name = "bodyTemperatureOutputLabel";
            this.bodyTemperatureOutputLabel.Size = new System.Drawing.Size(565, 31);
            this.bodyTemperatureOutputLabel.TabIndex = 5;
            // 
            // diastolicBloodPressureOutputLabel
            // 
            this.diastolicBloodPressureOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.diastolicBloodPressureOutputLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "DiastolicBloodPressure", true));
            this.diastolicBloodPressureOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diastolicBloodPressureOutputLabel.Location = new System.Drawing.Point(323, 268);
            this.diastolicBloodPressureOutputLabel.Name = "diastolicBloodPressureOutputLabel";
            this.diastolicBloodPressureOutputLabel.Size = new System.Drawing.Size(565, 31);
            this.diastolicBloodPressureOutputLabel.TabIndex = 7;
            // 
            // weightOutputLabel
            // 
            this.weightOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.weightOutputLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Weight", true));
            this.weightOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightOutputLabel.Location = new System.Drawing.Point(323, 303);
            this.weightOutputLabel.Name = "weightOutputLabel";
            this.weightOutputLabel.Size = new System.Drawing.Size(565, 31);
            this.weightOutputLabel.TabIndex = 39;
            // 
            // pulseOutputLabel
            // 
            this.pulseOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pulseOutputLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Pulse", true));
            this.pulseOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pulseOutputLabel.Location = new System.Drawing.Point(323, 198);
            this.pulseOutputLabel.Name = "pulseOutputLabel";
            this.pulseOutputLabel.Size = new System.Drawing.Size(565, 31);
            this.pulseOutputLabel.TabIndex = 31;
            // 
            // systolicBloodPressureOutputLabel
            // 
            this.systolicBloodPressureOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.systolicBloodPressureOutputLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "SystolicBloodPressure", true));
            this.systolicBloodPressureOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systolicBloodPressureOutputLabel.Location = new System.Drawing.Point(323, 233);
            this.systolicBloodPressureOutputLabel.Name = "systolicBloodPressureOutputLabel";
            this.systolicBloodPressureOutputLabel.Size = new System.Drawing.Size(565, 31);
            this.systolicBloodPressureOutputLabel.TabIndex = 35;
            // 
            // doctorFullNameOutputLabel
            // 
            this.doctorFullNameOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.doctorFullNameOutputLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "DoctorFullName", true));
            this.doctorFullNameOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorFullNameOutputLabel.Location = new System.Drawing.Point(323, 163);
            this.doctorFullNameOutputLabel.Name = "doctorFullNameOutputLabel";
            this.doctorFullNameOutputLabel.Size = new System.Drawing.Size(565, 31);
            this.doctorFullNameOutputLabel.TabIndex = 11;
            // 
            // nurseFullNameOutputLabel
            // 
            this.nurseFullNameOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nurseFullNameOutputLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "NurseFullName", true));
            this.nurseFullNameOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nurseFullNameOutputLabel.Location = new System.Drawing.Point(323, 128);
            this.nurseFullNameOutputLabel.Name = "nurseFullNameOutputLabel";
            this.nurseFullNameOutputLabel.Size = new System.Drawing.Size(565, 31);
            this.nurseFullNameOutputLabel.TabIndex = 17;
            // 
            // patientFullNameOutputLabel
            // 
            this.patientFullNameOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.patientFullNameOutputLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "PatientFullName", true));
            this.patientFullNameOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientFullNameOutputLabel.Location = new System.Drawing.Point(323, 93);
            this.patientFullNameOutputLabel.Name = "patientFullNameOutputLabel";
            this.patientFullNameOutputLabel.Size = new System.Drawing.Size(565, 31);
            this.patientFullNameOutputLabel.TabIndex = 27;
            // 
            // visitDateOutputLabel
            // 
            this.visitDateOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.visitDateOutputLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "VisitDate", true));
            this.visitDateOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitDateOutputLabel.Location = new System.Drawing.Point(323, 58);
            this.visitDateOutputLabel.Name = "visitDateOutputLabel";
            this.visitDateOutputLabel.Size = new System.Drawing.Size(565, 31);
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
            this.buttonTableLayoutPanel.Controls.Add(this.addDiagnosisButton, 0, 0);
            this.buttonTableLayoutPanel.Controls.Add(this.closeButton, 2, 0);
            this.buttonTableLayoutPanel.Controls.Add(this.orderTestButton, 0, 0);
            this.buttonTableLayoutPanel.Location = new System.Drawing.Point(168, 851);
            this.buttonTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonTableLayoutPanel.Name = "buttonTableLayoutPanel";
            this.buttonTableLayoutPanel.RowCount = 1;
            this.buttonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.buttonTableLayoutPanel.Size = new System.Drawing.Size(706, 64);
            this.buttonTableLayoutPanel.TabIndex = 40;
            // 
            // addDiagnosisButton
            // 
            this.addDiagnosisButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addDiagnosisButton.AutoSize = true;
            this.addDiagnosisButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addDiagnosisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDiagnosisButton.Location = new System.Drawing.Point(252, 22);
            this.addDiagnosisButton.Name = "addDiagnosisButton";
            this.addDiagnosisButton.Size = new System.Drawing.Size(201, 39);
            this.addDiagnosisButton.TabIndex = 3;
            this.addDiagnosisButton.Text = "Add Diagnosis";
            this.addDiagnosisButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.closeButton.AutoSize = true;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(481, 22);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(201, 39);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.OkayButton_Click);
            // 
            // orderTestButton
            // 
            this.orderTestButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.orderTestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderTestButton.Location = new System.Drawing.Point(23, 19);
            this.orderTestButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.orderTestButton.Name = "orderTestButton";
            this.orderTestButton.Size = new System.Drawing.Size(201, 40);
            this.orderTestButton.TabIndex = 2;
            this.orderTestButton.Text = "Order New Test";
            this.orderTestButton.UseVisualStyleBackColor = true;
            this.orderTestButton.Click += new System.EventHandler(this.OrderTestButton_Click);
            // 
            // diagnosisOutputLabel
            // 
            this.diagnosisOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.diagnosisOutputLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Symptoms", true));
            this.diagnosisOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagnosisOutputLabel.Location = new System.Drawing.Point(323, 404);
            this.diagnosisOutputLabel.Name = "diagnosisOutputLabel";
            this.diagnosisOutputLabel.Size = new System.Drawing.Size(565, 150);
            this.diagnosisOutputLabel.TabIndex = 43;
            // 
            // visitInformationLabel
            // 
            this.visitInformationLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.visitInformationLabel.AutoSize = true;
            this.visitInformationLabel.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitInformationLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.visitInformationLabel.Location = new System.Drawing.Point(522, 0);
            this.visitInformationLabel.Name = "visitInformationLabel";
            this.visitInformationLabel.Size = new System.Drawing.Size(318, 54);
            this.visitInformationLabel.TabIndex = 16;
            this.visitInformationLabel.Text = "Visit Information";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.viewVisitTableLayoutPanel.SetColumnSpan(this.tableLayoutPanel1, 2);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Controls.Add(this.testsListView, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 559);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1032, 210);
            this.tableLayoutPanel1.TabIndex = 44;
            // 
            // testsListView
            // 
            this.testsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.testsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumnHeader,
            this.dateColumnHeader,
            this.resultColumnHeader,
            this.isValidColumnHeader});
            this.testsListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testsListView.FullRowSelect = true;
            this.testsListView.HideSelection = false;
            this.testsListView.Location = new System.Drawing.Point(3, 3);
            this.testsListView.Name = "testsListView";
            this.testsListView.Size = new System.Drawing.Size(1026, 204);
            this.testsListView.TabIndex = 41;
            this.testsListView.UseCompatibleStateImageBehavior = false;
            this.testsListView.View = System.Windows.Forms.View.Details;
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.Text = "Test Name";
            this.nameColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameColumnHeader.Width = 124;
            // 
            // dateColumnHeader
            // 
            this.dateColumnHeader.Text = "Date Performed";
            this.dateColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dateColumnHeader.Width = 182;
            // 
            // resultColumnHeader
            // 
            this.resultColumnHeader.Text = "Result";
            this.resultColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.resultColumnHeader.Width = 200;
            // 
            // isValidColumnHeader
            // 
            this.isValidColumnHeader.Text = "Is Valid?";
            this.isValidColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.isValidColumnHeader.Width = 106;
            // 
            // visitBindingSource
            // 
            this.visitBindingSource.DataSource = typeof(Clinic.Model.Visit);
            // 
            // ViewVisitForm
            // 
            this.AcceptButton = this.closeButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 937);
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
            this.tableLayoutPanel2.ResumeLayout(false);
            this.buttonTableLayoutPanel.ResumeLayout(false);
            this.buttonTableLayoutPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingSource)).EndInit();
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
        private System.Windows.Forms.Button addDiagnosisButton;
        private System.Windows.Forms.Label diagnosisOutputLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView testsListView;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader dateColumnHeader;
        private System.Windows.Forms.ColumnHeader resultColumnHeader;
        private System.Windows.Forms.ColumnHeader isValidColumnHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button enterResultButton;
    }
}
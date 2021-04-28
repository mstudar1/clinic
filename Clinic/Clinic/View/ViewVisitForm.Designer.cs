
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
            this.visitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bodyTemperatureOutputLabel = new System.Windows.Forms.Label();
            this.diastolicBloodPressureOutputLabel = new System.Windows.Forms.Label();
            this.weightOutputLabel = new System.Windows.Forms.Label();
            this.pulseOutputLabel = new System.Windows.Forms.Label();
            this.systolicBloodPressureOutputLabel = new System.Windows.Forms.Label();
            this.doctorFullNameOutputLabel = new System.Windows.Forms.Label();
            this.nurseFullNameOutputLabel = new System.Windows.Forms.Label();
            this.patientFullNameOutputLabel = new System.Windows.Forms.Label();
            this.buttonTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.addDiagnosisButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.orderTestButton = new System.Windows.Forms.Button();
            this.diagnosisOutputLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.testsListView = new System.Windows.Forms.ListView();
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.resultColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.isValidColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.visitInformationLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.visitDateOutputLabel = new System.Windows.Forms.Label();
            this.editVisitButton = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingSource)).BeginInit();
            this.buttonTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bodyTemperatureLabel
            // 
            bodyTemperatureLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            bodyTemperatureLabel.AutoSize = true;
            bodyTemperatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bodyTemperatureLabel.Location = new System.Drawing.Point(50, 234);
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
            diastolicBloodPressureLabel.Location = new System.Drawing.Point(77, 185);
            diastolicBloodPressureLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            diastolicBloodPressureLabel.Name = "diastolicBloodPressureLabel";
            diastolicBloodPressureLabel.Size = new System.Drawing.Size(134, 23);
            diastolicBloodPressureLabel.TabIndex = 6;
            diastolicBloodPressureLabel.Text = "Diastolic Blood Pressure:";
            // 
            // doctorFullNameLabel
            // 
            doctorFullNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            doctorFullNameLabel.AutoSize = true;
            doctorFullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            doctorFullNameLabel.Location = new System.Drawing.Point(143, 119);
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
            nurseFullNameLabel.Location = new System.Drawing.Point(150, 96);
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
            patientFullNameLabel.Location = new System.Drawing.Point(140, 73);
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
            pulseLabel.Location = new System.Drawing.Point(153, 142);
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
            symptomsLabel.Location = new System.Drawing.Point(114, 257);
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
            systolicBloodPressureLabel.Location = new System.Drawing.Point(8, 165);
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
            visitDateLabel.Location = new System.Drawing.Point(118, 50);
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
            weightLabel.Location = new System.Drawing.Point(141, 211);
            weightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new System.Drawing.Size(70, 20);
            weightLabel.TabIndex = 38;
            weightLabel.Text = "Weight:";
            // 
            // diagnosisLabel
            // 
            diagnosisLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            diagnosisLabel.AutoSize = true;
            diagnosisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            diagnosisLabel.Location = new System.Drawing.Point(118, 282);
            diagnosisLabel.Margin = new System.Windows.Forms.Padding(2, 5, 2, 0);
            diagnosisLabel.Name = "diagnosisLabel";
            diagnosisLabel.Size = new System.Drawing.Size(93, 20);
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
            this.viewVisitTableLayoutPanel.Controls.Add(weightLabel, 0, 8);
            this.viewVisitTableLayoutPanel.Controls.Add(systolicBloodPressureLabel, 0, 6);
            this.viewVisitTableLayoutPanel.Controls.Add(patientFullNameLabel, 0, 2);
            this.viewVisitTableLayoutPanel.Controls.Add(visitDateLabel, 0, 1);
            this.viewVisitTableLayoutPanel.Controls.Add(this.buttonTableLayoutPanel, 0, 14);
            this.viewVisitTableLayoutPanel.Controls.Add(diagnosisLabel, 0, 11);
            this.viewVisitTableLayoutPanel.Controls.Add(this.diagnosisOutputLabel, 1, 11);
            this.viewVisitTableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 12);
            this.viewVisitTableLayoutPanel.Controls.Add(this.visitInformationLabel, 0, 0);
            this.viewVisitTableLayoutPanel.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.viewVisitTableLayoutPanel.Location = new System.Drawing.Point(9, 9);
            this.viewVisitTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.viewVisitTableLayoutPanel.Name = "viewVisitTableLayoutPanel";
            this.viewVisitTableLayoutPanel.RowCount = 15;
            this.viewVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.viewVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.viewVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.viewVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.viewVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.viewVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.viewVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.viewVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.viewVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.viewVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.viewVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.viewVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.viewVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 143F));
            this.viewVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.viewVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.viewVisitTableLayoutPanel.Size = new System.Drawing.Size(693, 609);
            this.viewVisitTableLayoutPanel.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.viewVisitTableLayoutPanel.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.Controls.Add(this.enterResultButton, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(111, 521);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(471, 40);
            this.tableLayoutPanel2.TabIndex = 45;
            // 
            // enterResultButton
            // 
            this.enterResultButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.enterResultButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterResultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterResultButton.Location = new System.Drawing.Point(19, 4);
            this.enterResultButton.Name = "enterResultButton";
            this.enterResultButton.Size = new System.Drawing.Size(432, 33);
            this.enterResultButton.TabIndex = 1;
            this.enterResultButton.Text = "Enter Lab Test Result";
            this.enterResultButton.UseVisualStyleBackColor = true;
            this.enterResultButton.Click += new System.EventHandler(this.EnterResult_Click);
            // 
            // symptomsOutputLabel
            // 
            this.symptomsOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.symptomsOutputLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Symptoms", true));
            this.symptomsOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symptomsOutputLabel.Location = new System.Drawing.Point(215, 257);
            this.symptomsOutputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.symptomsOutputLabel.Name = "symptomsOutputLabel";
            this.symptomsOutputLabel.Size = new System.Drawing.Size(377, 20);
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
            this.bodyTemperatureOutputLabel.Location = new System.Drawing.Point(215, 234);
            this.bodyTemperatureOutputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bodyTemperatureOutputLabel.Name = "bodyTemperatureOutputLabel";
            this.bodyTemperatureOutputLabel.Size = new System.Drawing.Size(377, 20);
            this.bodyTemperatureOutputLabel.TabIndex = 5;
            // 
            // diastolicBloodPressureOutputLabel
            // 
            this.diastolicBloodPressureOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.diastolicBloodPressureOutputLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "DiastolicBloodPressure", true));
            this.diastolicBloodPressureOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diastolicBloodPressureOutputLabel.Location = new System.Drawing.Point(215, 188);
            this.diastolicBloodPressureOutputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.diastolicBloodPressureOutputLabel.Name = "diastolicBloodPressureOutputLabel";
            this.diastolicBloodPressureOutputLabel.Size = new System.Drawing.Size(377, 20);
            this.diastolicBloodPressureOutputLabel.TabIndex = 7;
            // 
            // weightOutputLabel
            // 
            this.weightOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.weightOutputLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Weight", true));
            this.weightOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightOutputLabel.Location = new System.Drawing.Point(215, 211);
            this.weightOutputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.weightOutputLabel.Name = "weightOutputLabel";
            this.weightOutputLabel.Size = new System.Drawing.Size(377, 20);
            this.weightOutputLabel.TabIndex = 39;
            // 
            // pulseOutputLabel
            // 
            this.pulseOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pulseOutputLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Pulse", true));
            this.pulseOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pulseOutputLabel.Location = new System.Drawing.Point(215, 142);
            this.pulseOutputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pulseOutputLabel.Name = "pulseOutputLabel";
            this.pulseOutputLabel.Size = new System.Drawing.Size(377, 20);
            this.pulseOutputLabel.TabIndex = 31;
            // 
            // systolicBloodPressureOutputLabel
            // 
            this.systolicBloodPressureOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.systolicBloodPressureOutputLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "SystolicBloodPressure", true));
            this.systolicBloodPressureOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systolicBloodPressureOutputLabel.Location = new System.Drawing.Point(215, 165);
            this.systolicBloodPressureOutputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.systolicBloodPressureOutputLabel.Name = "systolicBloodPressureOutputLabel";
            this.systolicBloodPressureOutputLabel.Size = new System.Drawing.Size(377, 20);
            this.systolicBloodPressureOutputLabel.TabIndex = 35;
            // 
            // doctorFullNameOutputLabel
            // 
            this.doctorFullNameOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.doctorFullNameOutputLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "DoctorFullName", true));
            this.doctorFullNameOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorFullNameOutputLabel.Location = new System.Drawing.Point(215, 119);
            this.doctorFullNameOutputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.doctorFullNameOutputLabel.Name = "doctorFullNameOutputLabel";
            this.doctorFullNameOutputLabel.Size = new System.Drawing.Size(377, 20);
            this.doctorFullNameOutputLabel.TabIndex = 11;
            // 
            // nurseFullNameOutputLabel
            // 
            this.nurseFullNameOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nurseFullNameOutputLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "NurseFullName", true));
            this.nurseFullNameOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nurseFullNameOutputLabel.Location = new System.Drawing.Point(215, 96);
            this.nurseFullNameOutputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nurseFullNameOutputLabel.Name = "nurseFullNameOutputLabel";
            this.nurseFullNameOutputLabel.Size = new System.Drawing.Size(377, 20);
            this.nurseFullNameOutputLabel.TabIndex = 17;
            // 
            // patientFullNameOutputLabel
            // 
            this.patientFullNameOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.patientFullNameOutputLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "PatientFullName", true));
            this.patientFullNameOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientFullNameOutputLabel.Location = new System.Drawing.Point(215, 73);
            this.patientFullNameOutputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientFullNameOutputLabel.Name = "patientFullNameOutputLabel";
            this.patientFullNameOutputLabel.Size = new System.Drawing.Size(377, 20);
            this.patientFullNameOutputLabel.TabIndex = 27;
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
            this.buttonTableLayoutPanel.Location = new System.Drawing.Point(111, 567);
            this.buttonTableLayoutPanel.Name = "buttonTableLayoutPanel";
            this.buttonTableLayoutPanel.RowCount = 1;
            this.buttonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.buttonTableLayoutPanel.Size = new System.Drawing.Size(471, 39);
            this.buttonTableLayoutPanel.TabIndex = 40;
            // 
            // addDiagnosisButton
            // 
            this.addDiagnosisButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addDiagnosisButton.AutoSize = true;
            this.addDiagnosisButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addDiagnosisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDiagnosisButton.Location = new System.Drawing.Point(166, 2);
            this.addDiagnosisButton.Margin = new System.Windows.Forms.Padding(2);
            this.addDiagnosisButton.Name = "addDiagnosisButton";
            this.addDiagnosisButton.Size = new System.Drawing.Size(136, 35);
            this.addDiagnosisButton.TabIndex = 3;
            this.addDiagnosisButton.Text = "Add Diagnosis";
            this.addDiagnosisButton.UseVisualStyleBackColor = true;
            this.addDiagnosisButton.Click += new System.EventHandler(this.AddDiagnosisButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.closeButton.AutoSize = true;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(321, 2);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(134, 35);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // orderTestButton
            // 
            this.orderTestButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.orderTestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderTestButton.Location = new System.Drawing.Point(15, 3);
            this.orderTestButton.Name = "orderTestButton";
            this.orderTestButton.Size = new System.Drawing.Size(134, 33);
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
            this.diagnosisOutputLabel.Location = new System.Drawing.Point(215, 282);
            this.diagnosisOutputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.diagnosisOutputLabel.Name = "diagnosisOutputLabel";
            this.diagnosisOutputLabel.Size = new System.Drawing.Size(475, 92);
            this.diagnosisOutputLabel.TabIndex = 43;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.viewVisitTableLayoutPanel.SetColumnSpan(this.tableLayoutPanel1, 2);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Controls.Add(this.testsListView, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 378);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(687, 136);
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
            this.testsListView.Location = new System.Drawing.Point(2, 2);
            this.testsListView.Margin = new System.Windows.Forms.Padding(2);
            this.testsListView.Name = "testsListView";
            this.testsListView.Size = new System.Drawing.Size(683, 132);
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
            this.isValidColumnHeader.Text = "Is Normal?";
            this.isValidColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.isValidColumnHeader.Width = 106;
            // 
            // visitInformationLabel
            // 
            this.visitInformationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.visitInformationLabel.AutoSize = true;
            this.viewVisitTableLayoutPanel.SetColumnSpan(this.visitInformationLabel, 2);
            this.visitInformationLabel.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitInformationLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.visitInformationLabel.Location = new System.Drawing.Point(2, 0);
            this.visitInformationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.visitInformationLabel.Name = "visitInformationLabel";
            this.visitInformationLabel.Size = new System.Drawing.Size(689, 35);
            this.visitInformationLabel.TabIndex = 16;
            this.visitInformationLabel.Text = "Visit Information";
            this.visitInformationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.13502F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.86498F));
            this.tableLayoutPanel3.Controls.Add(this.visitDateOutputLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.editVisitButton, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(216, 38);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(474, 29);
            this.tableLayoutPanel3.TabIndex = 46;
            // 
            // visitDateOutputLabel
            // 
            this.visitDateOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.visitDateOutputLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "VisitDate", true));
            this.visitDateOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitDateOutputLabel.Location = new System.Drawing.Point(2, 12);
            this.visitDateOutputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.visitDateOutputLabel.Name = "visitDateOutputLabel";
            this.visitDateOutputLabel.Size = new System.Drawing.Size(299, 17);
            this.visitDateOutputLabel.TabIndex = 38;
            // 
            // editVisitButton
            // 
            this.editVisitButton.Location = new System.Drawing.Point(306, 3);
            this.editVisitButton.Name = "editVisitButton";
            this.editVisitButton.Size = new System.Drawing.Size(165, 23);
            this.editVisitButton.TabIndex = 39;
            this.editVisitButton.Text = "Edit Visit Information";
            this.editVisitButton.UseVisualStyleBackColor = true;
            this.editVisitButton.Click += new System.EventHandler(this.EditVisitButton_Click);
            // 
            // ViewVisitForm
            // 
            this.AcceptButton = this.closeButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 629);
            this.Controls.Add(this.viewVisitTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewVisitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Visit Details";
            this.Load += new System.EventHandler(this.ViewVisitForm_Load);
            this.EnabledChanged += new System.EventHandler(this.ViewVisitForm_EnabledChanged);
            this.viewVisitTableLayoutPanel.ResumeLayout(false);
            this.viewVisitTableLayoutPanel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingSource)).EndInit();
            this.buttonTableLayoutPanel.ResumeLayout(false);
            this.buttonTableLayoutPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label visitDateOutputLabel;
        private System.Windows.Forms.Button editVisitButton;
    }
}
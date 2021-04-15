
namespace Clinic.View
{
    partial class AddVisitForm
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
            System.Windows.Forms.Label doctorFullNameLabel;
            System.Windows.Forms.Label patientFullNameLabel;
            System.Windows.Forms.Label startDateTimeLabel;
            this.addVisitTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.symptomsValidationLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.bodyTemperatureValidationLabel = new System.Windows.Forms.Label();
            this.bodyTemperatureTextBox = new System.Windows.Forms.TextBox();
            this.pulseLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.diastolicBloodPressureValidationLabel = new System.Windows.Forms.Label();
            this.diastolicBloodPressureTextBox = new System.Windows.Forms.TextBox();
            this.systolicBloodPressureLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.systolicBloodPressureValidationLabel = new System.Windows.Forms.Label();
            this.systolicBloodPressureTextBox = new System.Windows.Forms.TextBox();
            this.diastolicBloodPressureLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pulseValidationLabel = new System.Windows.Forms.Label();
            this.pulseTextBox = new System.Windows.Forms.TextBox();
            this.bodyTemperatureLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.weightValidationLabel = new System.Windows.Forms.Label();
            this.symptomsLabel = new System.Windows.Forms.Label();
            this.buttonTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.headerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.startDateTimeOutputLabel = new System.Windows.Forms.Label();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientFullNameOutputLabel = new System.Windows.Forms.Label();
            this.doctorFullNameOutputLabel = new System.Windows.Forms.Label();
            this.addNewVisitLabel = new System.Windows.Forms.Label();
            this.symptomsTextBox = new System.Windows.Forms.TextBox();
            doctorFullNameLabel = new System.Windows.Forms.Label();
            patientFullNameLabel = new System.Windows.Forms.Label();
            startDateTimeLabel = new System.Windows.Forms.Label();
            this.addVisitTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.buttonTableLayoutPanel.SuspendLayout();
            this.headerTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // doctorFullNameLabel
            // 
            doctorFullNameLabel.AutoSize = true;
            doctorFullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            doctorFullNameLabel.Location = new System.Drawing.Point(3, 50);
            doctorFullNameLabel.Name = "doctorFullNameLabel";
            doctorFullNameLabel.Size = new System.Drawing.Size(65, 20);
            doctorFullNameLabel.TabIndex = 5;
            doctorFullNameLabel.Text = "Doctor:";
            // 
            // patientFullNameLabel
            // 
            patientFullNameLabel.AutoSize = true;
            patientFullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            patientFullNameLabel.Location = new System.Drawing.Point(3, 75);
            patientFullNameLabel.Name = "patientFullNameLabel";
            patientFullNameLabel.Size = new System.Drawing.Size(66, 20);
            patientFullNameLabel.TabIndex = 15;
            patientFullNameLabel.Text = "Patient:";
            // 
            // startDateTimeLabel
            // 
            startDateTimeLabel.AutoSize = true;
            startDateTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            startDateTimeLabel.Location = new System.Drawing.Point(3, 96);
            startDateTimeLabel.Name = "startDateTimeLabel";
            startDateTimeLabel.Size = new System.Drawing.Size(124, 20);
            startDateTimeLabel.TabIndex = 23;
            startDateTimeLabel.Text = "Date and Time:";
            // 
            // addVisitTableLayoutPanel
            // 
            this.addVisitTableLayoutPanel.ColumnCount = 2;
            this.addVisitTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.9298F));
            this.addVisitTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.0702F));
            this.addVisitTableLayoutPanel.Controls.Add(this.tableLayoutPanel6, 1, 7);
            this.addVisitTableLayoutPanel.Controls.Add(this.weightLabel, 0, 2);
            this.addVisitTableLayoutPanel.Controls.Add(this.tableLayoutPanel5, 1, 6);
            this.addVisitTableLayoutPanel.Controls.Add(this.pulseLabel, 0, 3);
            this.addVisitTableLayoutPanel.Controls.Add(this.tableLayoutPanel4, 1, 5);
            this.addVisitTableLayoutPanel.Controls.Add(this.systolicBloodPressureLabel, 0, 4);
            this.addVisitTableLayoutPanel.Controls.Add(this.tableLayoutPanel3, 1, 4);
            this.addVisitTableLayoutPanel.Controls.Add(this.diastolicBloodPressureLabel, 0, 5);
            this.addVisitTableLayoutPanel.Controls.Add(this.tableLayoutPanel2, 1, 3);
            this.addVisitTableLayoutPanel.Controls.Add(this.bodyTemperatureLabel, 0, 6);
            this.addVisitTableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 1, 2);
            this.addVisitTableLayoutPanel.Controls.Add(this.symptomsLabel, 0, 7);
            this.addVisitTableLayoutPanel.Controls.Add(this.buttonTableLayoutPanel, 1, 8);
            this.addVisitTableLayoutPanel.Controls.Add(this.headerTableLayoutPanel, 0, 0);
            this.addVisitTableLayoutPanel.Location = new System.Drawing.Point(12, 11);
            this.addVisitTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addVisitTableLayoutPanel.Name = "addVisitTableLayoutPanel";
            this.addVisitTableLayoutPanel.RowCount = 9;
            this.addVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 151F));
            this.addVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.addVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.addVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.addVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.addVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.addVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.addVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.addVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            this.addVisitTableLayoutPanel.Size = new System.Drawing.Size(641, 729);
            this.addVisitTableLayoutPanel.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.symptomsTextBox, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.symptomsValidationLabel, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(291, 519);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(347, 62);
            this.tableLayoutPanel6.TabIndex = 7;
            // 
            // symptomsValidationLabel
            // 
            this.symptomsValidationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.symptomsValidationLabel.AutoSize = true;
            this.symptomsValidationLabel.ForeColor = System.Drawing.Color.Red;
            this.symptomsValidationLabel.Location = new System.Drawing.Point(3, 7);
            this.symptomsValidationLabel.Name = "symptomsValidationLabel";
            this.symptomsValidationLabel.Size = new System.Drawing.Size(0, 17);
            this.symptomsValidationLabel.TabIndex = 31;
            // 
            // weightLabel
            // 
            this.weightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.weightLabel.AutoSize = true;
            this.weightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightLabel.Location = new System.Drawing.Point(205, 219);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(80, 25);
            this.weightLabel.TabIndex = 4;
            this.weightLabel.Tag = "";
            this.weightLabel.Text = "Weight:";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.bodyTemperatureValidationLabel, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.bodyTemperatureTextBox, 0, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(291, 451);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(347, 62);
            this.tableLayoutPanel5.TabIndex = 6;
            // 
            // bodyTemperatureValidationLabel
            // 
            this.bodyTemperatureValidationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bodyTemperatureValidationLabel.AutoSize = true;
            this.bodyTemperatureValidationLabel.ForeColor = System.Drawing.Color.Red;
            this.bodyTemperatureValidationLabel.Location = new System.Drawing.Point(3, 7);
            this.bodyTemperatureValidationLabel.Name = "bodyTemperatureValidationLabel";
            this.bodyTemperatureValidationLabel.Size = new System.Drawing.Size(0, 17);
            this.bodyTemperatureValidationLabel.TabIndex = 31;
            // 
            // bodyTemperatureTextBox
            // 
            this.bodyTemperatureTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bodyTemperatureTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bodyTemperatureTextBox.Location = new System.Drawing.Point(3, 30);
            this.bodyTemperatureTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bodyTemperatureTextBox.Name = "bodyTemperatureTextBox";
            this.bodyTemperatureTextBox.Size = new System.Drawing.Size(341, 30);
            this.bodyTemperatureTextBox.TabIndex = 70;
            this.bodyTemperatureTextBox.TextChanged += new System.EventHandler(this.BodyTemperatureTextBox_TextChanged);
            // 
            // pulseLabel
            // 
            this.pulseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pulseLabel.AutoSize = true;
            this.pulseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pulseLabel.Location = new System.Drawing.Point(218, 287);
            this.pulseLabel.Name = "pulseLabel";
            this.pulseLabel.Size = new System.Drawing.Size(67, 25);
            this.pulseLabel.TabIndex = 14;
            this.pulseLabel.Tag = "";
            this.pulseLabel.Text = "Pulse:";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.diastolicBloodPressureValidationLabel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.diastolicBloodPressureTextBox, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(291, 383);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(347, 62);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // diastolicBloodPressureValidationLabel
            // 
            this.diastolicBloodPressureValidationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.diastolicBloodPressureValidationLabel.AutoSize = true;
            this.diastolicBloodPressureValidationLabel.ForeColor = System.Drawing.Color.Red;
            this.diastolicBloodPressureValidationLabel.Location = new System.Drawing.Point(3, 7);
            this.diastolicBloodPressureValidationLabel.Name = "diastolicBloodPressureValidationLabel";
            this.diastolicBloodPressureValidationLabel.Size = new System.Drawing.Size(0, 17);
            this.diastolicBloodPressureValidationLabel.TabIndex = 31;
            // 
            // diastolicBloodPressureTextBox
            // 
            this.diastolicBloodPressureTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.diastolicBloodPressureTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diastolicBloodPressureTextBox.Location = new System.Drawing.Point(3, 30);
            this.diastolicBloodPressureTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.diastolicBloodPressureTextBox.Name = "diastolicBloodPressureTextBox";
            this.diastolicBloodPressureTextBox.Size = new System.Drawing.Size(341, 30);
            this.diastolicBloodPressureTextBox.TabIndex = 60;
            this.diastolicBloodPressureTextBox.TextChanged += new System.EventHandler(this.DiastolicBloodPressureTextBox_TextChanged);
            // 
            // systolicBloodPressureLabel
            // 
            this.systolicBloodPressureLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.systolicBloodPressureLabel.AutoSize = true;
            this.systolicBloodPressureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systolicBloodPressureLabel.Location = new System.Drawing.Point(61, 355);
            this.systolicBloodPressureLabel.Name = "systolicBloodPressureLabel";
            this.systolicBloodPressureLabel.Size = new System.Drawing.Size(224, 25);
            this.systolicBloodPressureLabel.TabIndex = 12;
            this.systolicBloodPressureLabel.Tag = "";
            this.systolicBloodPressureLabel.Text = "Systolic Blood Pressure:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.systolicBloodPressureValidationLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.systolicBloodPressureTextBox, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(291, 315);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(347, 62);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // systolicBloodPressureValidationLabel
            // 
            this.systolicBloodPressureValidationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.systolicBloodPressureValidationLabel.AutoSize = true;
            this.systolicBloodPressureValidationLabel.ForeColor = System.Drawing.Color.Red;
            this.systolicBloodPressureValidationLabel.Location = new System.Drawing.Point(3, 7);
            this.systolicBloodPressureValidationLabel.Name = "systolicBloodPressureValidationLabel";
            this.systolicBloodPressureValidationLabel.Size = new System.Drawing.Size(0, 17);
            this.systolicBloodPressureValidationLabel.TabIndex = 31;
            // 
            // systolicBloodPressureTextBox
            // 
            this.systolicBloodPressureTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.systolicBloodPressureTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systolicBloodPressureTextBox.Location = new System.Drawing.Point(3, 30);
            this.systolicBloodPressureTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.systolicBloodPressureTextBox.Name = "systolicBloodPressureTextBox";
            this.systolicBloodPressureTextBox.Size = new System.Drawing.Size(341, 30);
            this.systolicBloodPressureTextBox.TabIndex = 50;
            this.systolicBloodPressureTextBox.TextChanged += new System.EventHandler(this.SystolicBloodPressureTextBox_TextChanged);
            // 
            // diastolicBloodPressureLabel
            // 
            this.diastolicBloodPressureLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.diastolicBloodPressureLabel.AutoSize = true;
            this.diastolicBloodPressureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diastolicBloodPressureLabel.Location = new System.Drawing.Point(56, 423);
            this.diastolicBloodPressureLabel.Name = "diastolicBloodPressureLabel";
            this.diastolicBloodPressureLabel.Size = new System.Drawing.Size(229, 25);
            this.diastolicBloodPressureLabel.TabIndex = 6;
            this.diastolicBloodPressureLabel.Tag = "";
            this.diastolicBloodPressureLabel.Text = "Diastolic Blood Pressure:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.pulseValidationLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pulseTextBox, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(291, 247);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(347, 62);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // pulseValidationLabel
            // 
            this.pulseValidationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pulseValidationLabel.AutoSize = true;
            this.pulseValidationLabel.ForeColor = System.Drawing.Color.Red;
            this.pulseValidationLabel.Location = new System.Drawing.Point(3, 7);
            this.pulseValidationLabel.Name = "pulseValidationLabel";
            this.pulseValidationLabel.Size = new System.Drawing.Size(0, 17);
            this.pulseValidationLabel.TabIndex = 31;
            // 
            // pulseTextBox
            // 
            this.pulseTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pulseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pulseTextBox.Location = new System.Drawing.Point(3, 30);
            this.pulseTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pulseTextBox.Name = "pulseTextBox";
            this.pulseTextBox.Size = new System.Drawing.Size(341, 30);
            this.pulseTextBox.TabIndex = 40;
            this.pulseTextBox.TextChanged += new System.EventHandler(this.PulseTextBox_TextChanged);
            // 
            // bodyTemperatureLabel
            // 
            this.bodyTemperatureLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bodyTemperatureLabel.AutoSize = true;
            this.bodyTemperatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bodyTemperatureLabel.Location = new System.Drawing.Point(105, 491);
            this.bodyTemperatureLabel.Name = "bodyTemperatureLabel";
            this.bodyTemperatureLabel.Size = new System.Drawing.Size(180, 25);
            this.bodyTemperatureLabel.TabIndex = 10;
            this.bodyTemperatureLabel.Tag = "";
            this.bodyTemperatureLabel.Text = "Body Temperature:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.weightTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.weightValidationLabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(291, 179);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(347, 62);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.weightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightTextBox.Location = new System.Drawing.Point(3, 30);
            this.weightTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(341, 30);
            this.weightTextBox.TabIndex = 30;
            this.weightTextBox.TextChanged += new System.EventHandler(this.WeightTextBox_TextChanged);
            // 
            // weightValidationLabel
            // 
            this.weightValidationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.weightValidationLabel.AutoSize = true;
            this.weightValidationLabel.ForeColor = System.Drawing.Color.Red;
            this.weightValidationLabel.Location = new System.Drawing.Point(3, 7);
            this.weightValidationLabel.Name = "weightValidationLabel";
            this.weightValidationLabel.Size = new System.Drawing.Size(0, 17);
            this.weightValidationLabel.TabIndex = 31;
            // 
            // symptomsLabel
            // 
            this.symptomsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.symptomsLabel.AutoSize = true;
            this.symptomsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symptomsLabel.Location = new System.Drawing.Point(174, 559);
            this.symptomsLabel.Name = "symptomsLabel";
            this.symptomsLabel.Size = new System.Drawing.Size(111, 25);
            this.symptomsLabel.TabIndex = 17;
            this.symptomsLabel.Tag = "";
            this.symptomsLabel.Text = "Symptoms:";
            // 
            // buttonTableLayoutPanel
            // 
            this.buttonTableLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTableLayoutPanel.ColumnCount = 2;
            this.buttonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.90164F));
            this.buttonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.09836F));
            this.buttonTableLayoutPanel.Controls.Add(this.addButton, 0, 0);
            this.buttonTableLayoutPanel.Controls.Add(this.cancelButton, 1, 0);
            this.buttonTableLayoutPanel.Location = new System.Drawing.Point(291, 659);
            this.buttonTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTableLayoutPanel.Name = "buttonTableLayoutPanel";
            this.buttonTableLayoutPanel.RowCount = 1;
            this.buttonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonTableLayoutPanel.Size = new System.Drawing.Size(347, 54);
            this.buttonTableLayoutPanel.TabIndex = 90;
            // 
            // addButton
            // 
            this.addButton.AutoSize = true;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(3, 2);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(104, 43);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.AutoSize = true;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(162, 2);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(112, 43);
            this.cancelButton.TabIndex = 20;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // headerTableLayoutPanel
            // 
            this.headerTableLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.headerTableLayoutPanel.ColumnCount = 2;
            this.addVisitTableLayoutPanel.SetColumnSpan(this.headerTableLayoutPanel, 2);
            this.headerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.28572F));
            this.headerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.71429F));
            this.headerTableLayoutPanel.Controls.Add(this.startDateTimeOutputLabel, 1, 3);
            this.headerTableLayoutPanel.Controls.Add(this.patientFullNameOutputLabel, 1, 2);
            this.headerTableLayoutPanel.Controls.Add(this.doctorFullNameOutputLabel, 1, 1);
            this.headerTableLayoutPanel.Controls.Add(doctorFullNameLabel, 0, 1);
            this.headerTableLayoutPanel.Controls.Add(patientFullNameLabel, 0, 2);
            this.headerTableLayoutPanel.Controls.Add(startDateTimeLabel, 0, 3);
            this.headerTableLayoutPanel.Controls.Add(this.addNewVisitLabel, 0, 0);
            this.headerTableLayoutPanel.Location = new System.Drawing.Point(3, 14);
            this.headerTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.headerTableLayoutPanel.Name = "headerTableLayoutPanel";
            this.headerTableLayoutPanel.RowCount = 4;
            this.headerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.headerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.headerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.headerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.headerTableLayoutPanel.Size = new System.Drawing.Size(629, 123);
            this.headerTableLayoutPanel.TabIndex = 91;
            // 
            // startDateTimeOutputLabel
            // 
            this.startDateTimeOutputLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "StartDateTime", true));
            this.startDateTimeOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateTimeOutputLabel.Location = new System.Drawing.Point(155, 96);
            this.startDateTimeOutputLabel.Name = "startDateTimeOutputLabel";
            this.startDateTimeOutputLabel.Size = new System.Drawing.Size(200, 23);
            this.startDateTimeOutputLabel.TabIndex = 24;
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataSource = typeof(Clinic.Model.Appointment);
            // 
            // patientFullNameOutputLabel
            // 
            this.patientFullNameOutputLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "PatientFullName", true));
            this.patientFullNameOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientFullNameOutputLabel.Location = new System.Drawing.Point(155, 75);
            this.patientFullNameOutputLabel.Name = "patientFullNameOutputLabel";
            this.patientFullNameOutputLabel.Size = new System.Drawing.Size(251, 18);
            this.patientFullNameOutputLabel.TabIndex = 16;
            // 
            // doctorFullNameOutputLabel
            // 
            this.doctorFullNameOutputLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "DoctorFullName", true));
            this.doctorFullNameOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorFullNameOutputLabel.Location = new System.Drawing.Point(155, 50);
            this.doctorFullNameOutputLabel.Name = "doctorFullNameOutputLabel";
            this.doctorFullNameOutputLabel.Size = new System.Drawing.Size(200, 23);
            this.doctorFullNameOutputLabel.TabIndex = 6;
            // 
            // addNewVisitLabel
            // 
            this.addNewVisitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addNewVisitLabel.AutoSize = true;
            this.headerTableLayoutPanel.SetColumnSpan(this.addNewVisitLabel, 2);
            this.addNewVisitLabel.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewVisitLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addNewVisitLabel.Location = new System.Drawing.Point(3, 0);
            this.addNewVisitLabel.Name = "addNewVisitLabel";
            this.addNewVisitLabel.Size = new System.Drawing.Size(236, 50);
            this.addNewVisitLabel.TabIndex = 16;
            this.addNewVisitLabel.Text = "Add New Visit";
            // 
            // symptomsTextBox
            // 
            this.symptomsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.symptomsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symptomsTextBox.Location = new System.Drawing.Point(3, 30);
            this.symptomsTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.symptomsTextBox.Name = "symptomsTextBox";
            this.symptomsTextBox.Size = new System.Drawing.Size(341, 30);
            this.symptomsTextBox.TabIndex = 71;
            this.symptomsTextBox.TextChanged += new System.EventHandler(this.SymptomsTextBox_TextChanged);
            // 
            // AddVisitForm
            // 
            this.AcceptButton = this.addButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 750);
            this.Controls.Add(this.addVisitTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddVisitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Visit";
            this.Load += new System.EventHandler(this.AddVisitForm_Load);
            this.addVisitTableLayoutPanel.ResumeLayout(false);
            this.addVisitTableLayoutPanel.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.buttonTableLayoutPanel.ResumeLayout(false);
            this.buttonTableLayoutPanel.PerformLayout();
            this.headerTableLayoutPanel.ResumeLayout(false);
            this.headerTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel addVisitTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel buttonTableLayoutPanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label diastolicBloodPressureLabel;
        private System.Windows.Forms.TextBox systolicBloodPressureTextBox;
        private System.Windows.Forms.TextBox diastolicBloodPressureTextBox;
        private System.Windows.Forms.Label bodyTemperatureLabel;
        private System.Windows.Forms.Label systolicBloodPressureLabel;
        private System.Windows.Forms.Label pulseLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label addNewVisitLabel;
        private System.Windows.Forms.Label symptomsLabel;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox pulseTextBox;
        private System.Windows.Forms.TextBox bodyTemperatureTextBox;
        private System.Windows.Forms.TableLayoutPanel headerTableLayoutPanel;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private System.Windows.Forms.Label doctorFullNameOutputLabel;
        private System.Windows.Forms.Label patientFullNameOutputLabel;
        private System.Windows.Forms.Label startDateTimeOutputLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label weightValidationLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label pulseValidationLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label systolicBloodPressureValidationLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label diastolicBloodPressureValidationLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label bodyTemperatureValidationLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label symptomsValidationLabel;
        private System.Windows.Forms.TextBox symptomsTextBox;
    }
}
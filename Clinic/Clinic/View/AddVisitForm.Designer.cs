
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
            this.appointmentIdLabel = new System.Windows.Forms.Label();
            this.appointmentIdTextBox = new System.Windows.Forms.TextBox();
            this.nurseLabel = new System.Windows.Forms.Label();
            this.nurseComboBox = new System.Windows.Forms.ComboBox();
            this.nurseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.weightLabel = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.pulseLabel = new System.Windows.Forms.Label();
            this.pulseTextBox = new System.Windows.Forms.TextBox();
            this.systolicBloodPressureLabel = new System.Windows.Forms.Label();
            this.systolicBloodPressureTextBox = new System.Windows.Forms.TextBox();
            this.diastolicBloodPressureLabel = new System.Windows.Forms.Label();
            this.diastolicBloodPressureTextBox = new System.Windows.Forms.TextBox();
            this.bodyTemperatureLabel = new System.Windows.Forms.Label();
            this.bodyTemperatureTextBox = new System.Windows.Forms.TextBox();
            this.symptomsLabel = new System.Windows.Forms.Label();
            this.symptomsTextBox = new System.Windows.Forms.TextBox();
            this.buttonTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.headerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.startDateTimeOutputLabel = new System.Windows.Forms.Label();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientFullNameOutputLabel = new System.Windows.Forms.Label();
            this.doctorFullNameOutputLabel = new System.Windows.Forms.Label();
            this.addNewVisitLabel = new System.Windows.Forms.Label();
            doctorFullNameLabel = new System.Windows.Forms.Label();
            patientFullNameLabel = new System.Windows.Forms.Label();
            startDateTimeLabel = new System.Windows.Forms.Label();
            this.addVisitTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nurseBindingSource)).BeginInit();
            this.buttonTableLayoutPanel.SuspendLayout();
            this.headerTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // doctorFullNameLabel
            // 
            doctorFullNameLabel.AutoSize = true;
            doctorFullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            doctorFullNameLabel.Location = new System.Drawing.Point(2, 41);
            doctorFullNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            doctorFullNameLabel.Name = "doctorFullNameLabel";
            doctorFullNameLabel.Size = new System.Drawing.Size(54, 17);
            doctorFullNameLabel.TabIndex = 5;
            doctorFullNameLabel.Text = "Doctor:";
            // 
            // patientFullNameLabel
            // 
            patientFullNameLabel.AutoSize = true;
            patientFullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            patientFullNameLabel.Location = new System.Drawing.Point(2, 61);
            patientFullNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            patientFullNameLabel.Name = "patientFullNameLabel";
            patientFullNameLabel.Size = new System.Drawing.Size(56, 17);
            patientFullNameLabel.TabIndex = 15;
            patientFullNameLabel.Text = "Patient:";
            // 
            // startDateTimeLabel
            // 
            startDateTimeLabel.AutoSize = true;
            startDateTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            startDateTimeLabel.Location = new System.Drawing.Point(2, 78);
            startDateTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            startDateTimeLabel.Name = "startDateTimeLabel";
            startDateTimeLabel.Size = new System.Drawing.Size(105, 17);
            startDateTimeLabel.TabIndex = 23;
            startDateTimeLabel.Text = "Date and Time:";
            // 
            // addVisitTableLayoutPanel
            // 
            this.addVisitTableLayoutPanel.ColumnCount = 2;
            this.addVisitTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.37754F));
            this.addVisitTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.62246F));
            this.addVisitTableLayoutPanel.Controls.Add(this.appointmentIdLabel, 0, 1);
            this.addVisitTableLayoutPanel.Controls.Add(this.appointmentIdTextBox, 1, 1);
            this.addVisitTableLayoutPanel.Controls.Add(this.nurseLabel, 0, 2);
            this.addVisitTableLayoutPanel.Controls.Add(this.nurseComboBox, 1, 2);
            this.addVisitTableLayoutPanel.Controls.Add(this.weightLabel, 0, 3);
            this.addVisitTableLayoutPanel.Controls.Add(this.weightTextBox, 1, 3);
            this.addVisitTableLayoutPanel.Controls.Add(this.pulseLabel, 0, 4);
            this.addVisitTableLayoutPanel.Controls.Add(this.pulseTextBox, 1, 4);
            this.addVisitTableLayoutPanel.Controls.Add(this.systolicBloodPressureLabel, 0, 5);
            this.addVisitTableLayoutPanel.Controls.Add(this.systolicBloodPressureTextBox, 1, 5);
            this.addVisitTableLayoutPanel.Controls.Add(this.diastolicBloodPressureLabel, 0, 6);
            this.addVisitTableLayoutPanel.Controls.Add(this.diastolicBloodPressureTextBox, 1, 6);
            this.addVisitTableLayoutPanel.Controls.Add(this.bodyTemperatureLabel, 0, 7);
            this.addVisitTableLayoutPanel.Controls.Add(this.bodyTemperatureTextBox, 1, 7);
            this.addVisitTableLayoutPanel.Controls.Add(this.symptomsLabel, 0, 8);
            this.addVisitTableLayoutPanel.Controls.Add(this.symptomsTextBox, 1, 8);
            this.addVisitTableLayoutPanel.Controls.Add(this.buttonTableLayoutPanel, 1, 9);
            this.addVisitTableLayoutPanel.Controls.Add(this.headerTableLayoutPanel, 0, 0);
            this.addVisitTableLayoutPanel.Location = new System.Drawing.Point(9, 9);
            this.addVisitTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addVisitTableLayoutPanel.Name = "addVisitTableLayoutPanel";
            this.addVisitTableLayoutPanel.RowCount = 10;
            this.addVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.addVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.addVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.addVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.addVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.addVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.addVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.addVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.addVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.addVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.addVisitTableLayoutPanel.Size = new System.Drawing.Size(481, 562);
            this.addVisitTableLayoutPanel.TabIndex = 1;
            // 
            // appointmentIdLabel
            // 
            this.appointmentIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.appointmentIdLabel.AutoSize = true;
            this.appointmentIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentIdLabel.Location = new System.Drawing.Point(57, 143);
            this.appointmentIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.appointmentIdLabel.Name = "appointmentIdLabel";
            this.appointmentIdLabel.Size = new System.Drawing.Size(125, 20);
            this.appointmentIdLabel.TabIndex = 0;
            this.appointmentIdLabel.Tag = "";
            this.appointmentIdLabel.Text = "Appointment ID:";
            // 
            // appointmentIdTextBox
            // 
            this.appointmentIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.appointmentIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentIdTextBox.Location = new System.Drawing.Point(186, 135);
            this.appointmentIdTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.appointmentIdTextBox.Name = "appointmentIdTextBox";
            this.appointmentIdTextBox.Size = new System.Drawing.Size(293, 26);
            this.appointmentIdTextBox.TabIndex = 10;
            // 
            // nurseLabel
            // 
            this.nurseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nurseLabel.AutoSize = true;
            this.nurseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nurseLabel.Location = new System.Drawing.Point(127, 189);
            this.nurseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nurseLabel.Name = "nurseLabel";
            this.nurseLabel.Size = new System.Drawing.Size(55, 20);
            this.nurseLabel.TabIndex = 2;
            this.nurseLabel.Tag = "";
            this.nurseLabel.Text = "Nurse:";
            // 
            // nurseComboBox
            // 
            this.nurseComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nurseComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nurseBindingSource, "FullName", true));
            this.nurseComboBox.DataSource = this.nurseBindingSource;
            this.nurseComboBox.DisplayMember = "FullName";
            this.nurseComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nurseComboBox.FormattingEnabled = true;
            this.nurseComboBox.Location = new System.Drawing.Point(186, 179);
            this.nurseComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nurseComboBox.Name = "nurseComboBox";
            this.nurseComboBox.Size = new System.Drawing.Size(293, 28);
            this.nurseComboBox.TabIndex = 20;
            this.nurseComboBox.ValueMember = "NurseId";
            // 
            // nurseBindingSource
            // 
            this.nurseBindingSource.DataSource = typeof(Clinic.Model.Nurse);
            // 
            // weightLabel
            // 
            this.weightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.weightLabel.AutoSize = true;
            this.weightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightLabel.Location = new System.Drawing.Point(119, 232);
            this.weightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(63, 20);
            this.weightLabel.TabIndex = 4;
            this.weightLabel.Tag = "";
            this.weightLabel.Text = "Weight:";
            // 
            // weightTextBox
            // 
            this.weightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.weightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightTextBox.Location = new System.Drawing.Point(186, 224);
            this.weightTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(293, 26);
            this.weightTextBox.TabIndex = 30;
            // 
            // pulseLabel
            // 
            this.pulseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pulseLabel.AutoSize = true;
            this.pulseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pulseLabel.Location = new System.Drawing.Point(130, 277);
            this.pulseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pulseLabel.Name = "pulseLabel";
            this.pulseLabel.Size = new System.Drawing.Size(52, 20);
            this.pulseLabel.TabIndex = 14;
            this.pulseLabel.Tag = "";
            this.pulseLabel.Text = "Pulse:";
            // 
            // pulseTextBox
            // 
            this.pulseTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pulseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pulseTextBox.Location = new System.Drawing.Point(186, 269);
            this.pulseTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pulseTextBox.Name = "pulseTextBox";
            this.pulseTextBox.Size = new System.Drawing.Size(293, 26);
            this.pulseTextBox.TabIndex = 40;
            // 
            // systolicBloodPressureLabel
            // 
            this.systolicBloodPressureLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.systolicBloodPressureLabel.AutoSize = true;
            this.systolicBloodPressureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systolicBloodPressureLabel.Location = new System.Drawing.Point(3, 318);
            this.systolicBloodPressureLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.systolicBloodPressureLabel.Name = "systolicBloodPressureLabel";
            this.systolicBloodPressureLabel.Size = new System.Drawing.Size(179, 20);
            this.systolicBloodPressureLabel.TabIndex = 12;
            this.systolicBloodPressureLabel.Tag = "";
            this.systolicBloodPressureLabel.Text = "Systolic Blood Pressure:";
            // 
            // systolicBloodPressureTextBox
            // 
            this.systolicBloodPressureTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.systolicBloodPressureTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systolicBloodPressureTextBox.Location = new System.Drawing.Point(186, 310);
            this.systolicBloodPressureTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.systolicBloodPressureTextBox.Name = "systolicBloodPressureTextBox";
            this.systolicBloodPressureTextBox.Size = new System.Drawing.Size(293, 26);
            this.systolicBloodPressureTextBox.TabIndex = 50;
            // 
            // diastolicBloodPressureLabel
            // 
            this.diastolicBloodPressureLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.diastolicBloodPressureLabel.AutoSize = true;
            this.diastolicBloodPressureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diastolicBloodPressureLabel.Location = new System.Drawing.Point(64, 342);
            this.diastolicBloodPressureLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.diastolicBloodPressureLabel.Name = "diastolicBloodPressureLabel";
            this.diastolicBloodPressureLabel.Size = new System.Drawing.Size(118, 40);
            this.diastolicBloodPressureLabel.TabIndex = 6;
            this.diastolicBloodPressureLabel.Tag = "";
            this.diastolicBloodPressureLabel.Text = "Diastolic Blood Pressure:";
            // 
            // diastolicBloodPressureTextBox
            // 
            this.diastolicBloodPressureTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.diastolicBloodPressureTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diastolicBloodPressureTextBox.Location = new System.Drawing.Point(186, 354);
            this.diastolicBloodPressureTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.diastolicBloodPressureTextBox.Name = "diastolicBloodPressureTextBox";
            this.diastolicBloodPressureTextBox.Size = new System.Drawing.Size(293, 26);
            this.diastolicBloodPressureTextBox.TabIndex = 60;
            // 
            // bodyTemperatureLabel
            // 
            this.bodyTemperatureLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bodyTemperatureLabel.AutoSize = true;
            this.bodyTemperatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bodyTemperatureLabel.Location = new System.Drawing.Point(38, 404);
            this.bodyTemperatureLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bodyTemperatureLabel.Name = "bodyTemperatureLabel";
            this.bodyTemperatureLabel.Size = new System.Drawing.Size(144, 20);
            this.bodyTemperatureLabel.TabIndex = 10;
            this.bodyTemperatureLabel.Tag = "";
            this.bodyTemperatureLabel.Text = "Body Temperature:";
            // 
            // bodyTemperatureTextBox
            // 
            this.bodyTemperatureTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bodyTemperatureTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bodyTemperatureTextBox.Location = new System.Drawing.Point(186, 396);
            this.bodyTemperatureTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bodyTemperatureTextBox.Name = "bodyTemperatureTextBox";
            this.bodyTemperatureTextBox.Size = new System.Drawing.Size(293, 26);
            this.bodyTemperatureTextBox.TabIndex = 70;
            // 
            // symptomsLabel
            // 
            this.symptomsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.symptomsLabel.AutoSize = true;
            this.symptomsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symptomsLabel.Location = new System.Drawing.Point(94, 444);
            this.symptomsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.symptomsLabel.Name = "symptomsLabel";
            this.symptomsLabel.Size = new System.Drawing.Size(88, 20);
            this.symptomsLabel.TabIndex = 17;
            this.symptomsLabel.Tag = "";
            this.symptomsLabel.Text = "Symptoms:";
            // 
            // symptomsTextBox
            // 
            this.symptomsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.symptomsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symptomsTextBox.Location = new System.Drawing.Point(186, 436);
            this.symptomsTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.symptomsTextBox.Name = "symptomsTextBox";
            this.symptomsTextBox.Size = new System.Drawing.Size(293, 26);
            this.symptomsTextBox.TabIndex = 80;
            // 
            // buttonTableLayoutPanel
            // 
            this.buttonTableLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTableLayoutPanel.ColumnCount = 2;
            this.buttonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.90164F));
            this.buttonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.09836F));
            this.buttonTableLayoutPanel.Controls.Add(this.addButton, 0, 0);
            this.buttonTableLayoutPanel.Controls.Add(this.cancelButton, 1, 0);
            this.buttonTableLayoutPanel.Location = new System.Drawing.Point(190, 525);
            this.buttonTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonTableLayoutPanel.Name = "buttonTableLayoutPanel";
            this.buttonTableLayoutPanel.RowCount = 1;
            this.buttonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonTableLayoutPanel.Size = new System.Drawing.Size(285, 44);
            this.buttonTableLayoutPanel.TabIndex = 90;
            // 
            // addButton
            // 
            this.addButton.AutoSize = true;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(2, 2);
            this.addButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(78, 35);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.AutoSize = true;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(132, 2);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(84, 35);
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
            this.headerTableLayoutPanel.Location = new System.Drawing.Point(2, 11);
            this.headerTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.headerTableLayoutPanel.Name = "headerTableLayoutPanel";
            this.headerTableLayoutPanel.RowCount = 4;
            this.headerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.headerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.headerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.headerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.headerTableLayoutPanel.Size = new System.Drawing.Size(472, 100);
            this.headerTableLayoutPanel.TabIndex = 91;
            // 
            // startDateTimeOutputLabel
            // 
            this.startDateTimeOutputLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "StartDateTime", true));
            this.startDateTimeOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateTimeOutputLabel.Location = new System.Drawing.Point(116, 78);
            this.startDateTimeOutputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.startDateTimeOutputLabel.Name = "startDateTimeOutputLabel";
            this.startDateTimeOutputLabel.Size = new System.Drawing.Size(150, 19);
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
            this.patientFullNameOutputLabel.Location = new System.Drawing.Point(116, 61);
            this.patientFullNameOutputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientFullNameOutputLabel.Name = "patientFullNameOutputLabel";
            this.patientFullNameOutputLabel.Size = new System.Drawing.Size(188, 15);
            this.patientFullNameOutputLabel.TabIndex = 16;
            // 
            // doctorFullNameOutputLabel
            // 
            this.doctorFullNameOutputLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "DoctorFullName", true));
            this.doctorFullNameOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorFullNameOutputLabel.Location = new System.Drawing.Point(116, 41);
            this.doctorFullNameOutputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.doctorFullNameOutputLabel.Name = "doctorFullNameOutputLabel";
            this.doctorFullNameOutputLabel.Size = new System.Drawing.Size(150, 19);
            this.doctorFullNameOutputLabel.TabIndex = 6;
            // 
            // addNewVisitLabel
            // 
            this.addNewVisitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addNewVisitLabel.AutoSize = true;
            this.headerTableLayoutPanel.SetColumnSpan(this.addNewVisitLabel, 2);
            this.addNewVisitLabel.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewVisitLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addNewVisitLabel.Location = new System.Drawing.Point(2, 0);
            this.addNewVisitLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addNewVisitLabel.Name = "addNewVisitLabel";
            this.addNewVisitLabel.Size = new System.Drawing.Size(189, 41);
            this.addNewVisitLabel.TabIndex = 16;
            this.addNewVisitLabel.Text = "Add New Visit";
            // 
            // AddVisitForm
            // 
            this.AcceptButton = this.addButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 587);
            this.Controls.Add(this.addVisitTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddVisitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Visit";
            this.Load += new System.EventHandler(this.AddVisitForm_Load);
            this.addVisitTableLayoutPanel.ResumeLayout(false);
            this.addVisitTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nurseBindingSource)).EndInit();
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
        private System.Windows.Forms.Label nurseLabel;
        private System.Windows.Forms.Label appointmentIdLabel;
        private System.Windows.Forms.TextBox appointmentIdTextBox;
        private System.Windows.Forms.Label addNewVisitLabel;
        private System.Windows.Forms.Label symptomsLabel;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox pulseTextBox;
        private System.Windows.Forms.TextBox bodyTemperatureTextBox;
        private System.Windows.Forms.TextBox symptomsTextBox;
        private System.Windows.Forms.ComboBox nurseComboBox;
        private System.Windows.Forms.BindingSource nurseBindingSource;
        private System.Windows.Forms.TableLayoutPanel headerTableLayoutPanel;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private System.Windows.Forms.Label doctorFullNameOutputLabel;
        private System.Windows.Forms.Label patientFullNameOutputLabel;
        private System.Windows.Forms.Label startDateTimeOutputLabel;
    }
}
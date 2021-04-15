
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
            this.addVisitTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.37754F));
            this.addVisitTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.62246F));
            this.addVisitTableLayoutPanel.Controls.Add(this.weightLabel, 0, 2);
            this.addVisitTableLayoutPanel.Controls.Add(this.weightTextBox, 1, 2);
            this.addVisitTableLayoutPanel.Controls.Add(this.pulseLabel, 0, 3);
            this.addVisitTableLayoutPanel.Controls.Add(this.pulseTextBox, 1, 3);
            this.addVisitTableLayoutPanel.Controls.Add(this.systolicBloodPressureLabel, 0, 4);
            this.addVisitTableLayoutPanel.Controls.Add(this.systolicBloodPressureTextBox, 1, 4);
            this.addVisitTableLayoutPanel.Controls.Add(this.diastolicBloodPressureLabel, 0, 5);
            this.addVisitTableLayoutPanel.Controls.Add(this.diastolicBloodPressureTextBox, 1, 5);
            this.addVisitTableLayoutPanel.Controls.Add(this.bodyTemperatureLabel, 0, 6);
            this.addVisitTableLayoutPanel.Controls.Add(this.bodyTemperatureTextBox, 1, 6);
            this.addVisitTableLayoutPanel.Controls.Add(this.symptomsLabel, 0, 7);
            this.addVisitTableLayoutPanel.Controls.Add(this.symptomsTextBox, 1, 7);
            this.addVisitTableLayoutPanel.Controls.Add(this.buttonTableLayoutPanel, 1, 8);
            this.addVisitTableLayoutPanel.Controls.Add(this.headerTableLayoutPanel, 0, 0);
            this.addVisitTableLayoutPanel.Location = new System.Drawing.Point(12, 11);
            this.addVisitTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addVisitTableLayoutPanel.Name = "addVisitTableLayoutPanel";
            this.addVisitTableLayoutPanel.RowCount = 9;
            this.addVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 151F));
            this.addVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.addVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.addVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.addVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.addVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.addVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.addVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.addVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            this.addVisitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.addVisitTableLayoutPanel.Size = new System.Drawing.Size(641, 692);
            this.addVisitTableLayoutPanel.TabIndex = 1;
            // 
            // weightLabel
            // 
            this.weightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.weightLabel.AutoSize = true;
            this.weightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightLabel.Location = new System.Drawing.Point(163, 204);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(80, 25);
            this.weightLabel.TabIndex = 4;
            this.weightLabel.Tag = "";
            this.weightLabel.Text = "Weight:";
            // 
            // weightTextBox
            // 
            this.weightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.weightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightTextBox.Location = new System.Drawing.Point(249, 197);
            this.weightTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(389, 30);
            this.weightTextBox.TabIndex = 30;
            // 
            // pulseLabel
            // 
            this.pulseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pulseLabel.AutoSize = true;
            this.pulseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pulseLabel.Location = new System.Drawing.Point(176, 259);
            this.pulseLabel.Name = "pulseLabel";
            this.pulseLabel.Size = new System.Drawing.Size(67, 25);
            this.pulseLabel.TabIndex = 14;
            this.pulseLabel.Tag = "";
            this.pulseLabel.Text = "Pulse:";
            // 
            // pulseTextBox
            // 
            this.pulseTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pulseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pulseTextBox.Location = new System.Drawing.Point(249, 252);
            this.pulseTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pulseTextBox.Name = "pulseTextBox";
            this.pulseTextBox.Size = new System.Drawing.Size(389, 30);
            this.pulseTextBox.TabIndex = 40;
            // 
            // systolicBloodPressureLabel
            // 
            this.systolicBloodPressureLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.systolicBloodPressureLabel.AutoSize = true;
            this.systolicBloodPressureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systolicBloodPressureLabel.Location = new System.Drawing.Point(19, 309);
            this.systolicBloodPressureLabel.Name = "systolicBloodPressureLabel";
            this.systolicBloodPressureLabel.Size = new System.Drawing.Size(224, 25);
            this.systolicBloodPressureLabel.TabIndex = 12;
            this.systolicBloodPressureLabel.Tag = "";
            this.systolicBloodPressureLabel.Text = "Systolic Blood Pressure:";
            // 
            // systolicBloodPressureTextBox
            // 
            this.systolicBloodPressureTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.systolicBloodPressureTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systolicBloodPressureTextBox.Location = new System.Drawing.Point(249, 302);
            this.systolicBloodPressureTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.systolicBloodPressureTextBox.Name = "systolicBloodPressureTextBox";
            this.systolicBloodPressureTextBox.Size = new System.Drawing.Size(389, 30);
            this.systolicBloodPressureTextBox.TabIndex = 50;
            // 
            // diastolicBloodPressureLabel
            // 
            this.diastolicBloodPressureLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.diastolicBloodPressureLabel.AutoSize = true;
            this.diastolicBloodPressureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diastolicBloodPressureLabel.Location = new System.Drawing.Point(14, 363);
            this.diastolicBloodPressureLabel.Name = "diastolicBloodPressureLabel";
            this.diastolicBloodPressureLabel.Size = new System.Drawing.Size(229, 25);
            this.diastolicBloodPressureLabel.TabIndex = 6;
            this.diastolicBloodPressureLabel.Tag = "";
            this.diastolicBloodPressureLabel.Text = "Diastolic Blood Pressure:";
            // 
            // diastolicBloodPressureTextBox
            // 
            this.diastolicBloodPressureTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.diastolicBloodPressureTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diastolicBloodPressureTextBox.Location = new System.Drawing.Point(249, 356);
            this.diastolicBloodPressureTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.diastolicBloodPressureTextBox.Name = "diastolicBloodPressureTextBox";
            this.diastolicBloodPressureTextBox.Size = new System.Drawing.Size(389, 30);
            this.diastolicBloodPressureTextBox.TabIndex = 60;
            // 
            // bodyTemperatureLabel
            // 
            this.bodyTemperatureLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bodyTemperatureLabel.AutoSize = true;
            this.bodyTemperatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bodyTemperatureLabel.Location = new System.Drawing.Point(63, 415);
            this.bodyTemperatureLabel.Name = "bodyTemperatureLabel";
            this.bodyTemperatureLabel.Size = new System.Drawing.Size(180, 25);
            this.bodyTemperatureLabel.TabIndex = 10;
            this.bodyTemperatureLabel.Tag = "";
            this.bodyTemperatureLabel.Text = "Body Temperature:";
            // 
            // bodyTemperatureTextBox
            // 
            this.bodyTemperatureTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bodyTemperatureTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bodyTemperatureTextBox.Location = new System.Drawing.Point(249, 408);
            this.bodyTemperatureTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bodyTemperatureTextBox.Name = "bodyTemperatureTextBox";
            this.bodyTemperatureTextBox.Size = new System.Drawing.Size(389, 30);
            this.bodyTemperatureTextBox.TabIndex = 70;
            // 
            // symptomsLabel
            // 
            this.symptomsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.symptomsLabel.AutoSize = true;
            this.symptomsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symptomsLabel.Location = new System.Drawing.Point(132, 464);
            this.symptomsLabel.Name = "symptomsLabel";
            this.symptomsLabel.Size = new System.Drawing.Size(111, 25);
            this.symptomsLabel.TabIndex = 17;
            this.symptomsLabel.Tag = "";
            this.symptomsLabel.Text = "Symptoms:";
            // 
            // symptomsTextBox
            // 
            this.symptomsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.symptomsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symptomsTextBox.Location = new System.Drawing.Point(249, 457);
            this.symptomsTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.symptomsTextBox.Name = "symptomsTextBox";
            this.symptomsTextBox.Size = new System.Drawing.Size(389, 30);
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
            this.buttonTableLayoutPanel.Location = new System.Drawing.Point(253, 564);
            this.buttonTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTableLayoutPanel.Name = "buttonTableLayoutPanel";
            this.buttonTableLayoutPanel.RowCount = 1;
            this.buttonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonTableLayoutPanel.Size = new System.Drawing.Size(380, 54);
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
            this.cancelButton.Location = new System.Drawing.Point(177, 2);
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
            // AddVisitForm
            // 
            this.AcceptButton = this.addButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 715);
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
        private System.Windows.Forms.TextBox symptomsTextBox;
        private System.Windows.Forms.TableLayoutPanel headerTableLayoutPanel;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private System.Windows.Forms.Label doctorFullNameOutputLabel;
        private System.Windows.Forms.Label patientFullNameOutputLabel;
        private System.Windows.Forms.Label startDateTimeOutputLabel;
    }
}

namespace Clinic.View
{
    partial class EditAppointmentForm
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
            this.reasonTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.startHourComboBox = new System.Windows.Forms.ComboBox();
            this.startMinuteComboBox = new System.Windows.Forms.ComboBox();
            this.reserveAppointmentButton = new System.Windows.Forms.Button();
            this.alertNoticeLabel = new System.Windows.Forms.Label();
            this.searchPatientFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.searchPatientLastNameTextBox = new System.Windows.Forms.TextBox();
            this.searchTimesButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.endHourComboBox = new System.Windows.Forms.ComboBox();
            this.endMinuteComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.doctorComboBox = new System.Windows.Forms.ComboBox();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.appointmentTimeListView = new System.Windows.Forms.ListView();
            this.startTimeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.endTimeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label13 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reasonTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.reasonTextBox, 3);
            this.reasonTextBox.Location = new System.Drawing.Point(158, 338);
            this.reasonTextBox.Name = "reasonTextBox";
            this.reasonTextBox.Size = new System.Drawing.Size(380, 20);
            this.reasonTextBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Edit reason for visit:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Edit start time:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Edit end time:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.99319F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.0068F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel2.Controls.Add(this.label11, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.startHourComboBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.startMinuteComboBox, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(158, 278);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(303, 24);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(134, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = ":";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startHourComboBox
            // 
            this.startHourComboBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.startHourComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startHourComboBox.FormattingEnabled = true;
            this.startHourComboBox.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.startHourComboBox.Location = new System.Drawing.Point(82, 3);
            this.startHourComboBox.Name = "startHourComboBox";
            this.startHourComboBox.Size = new System.Drawing.Size(42, 21);
            this.startHourComboBox.TabIndex = 1;
            // 
            // startMinuteComboBox
            // 
            this.startMinuteComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.startMinuteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startMinuteComboBox.FormattingEnabled = true;
            this.startMinuteComboBox.Items.AddRange(new object[] {
            "00",
            "05",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55"});
            this.startMinuteComboBox.Location = new System.Drawing.Point(156, 3);
            this.startMinuteComboBox.Name = "startMinuteComboBox";
            this.startMinuteComboBox.Size = new System.Drawing.Size(39, 21);
            this.startMinuteComboBox.TabIndex = 2;
            // 
            // reserveAppointmentButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.reserveAppointmentButton, 2);
            this.reserveAppointmentButton.Location = new System.Drawing.Point(158, 368);
            this.reserveAppointmentButton.Name = "reserveAppointmentButton";
            this.reserveAppointmentButton.Size = new System.Drawing.Size(303, 19);
            this.reserveAppointmentButton.TabIndex = 13;
            this.reserveAppointmentButton.Text = "Reserve Appointment";
            this.reserveAppointmentButton.UseVisualStyleBackColor = true;
            // 
            // alertNoticeLabel
            // 
            this.alertNoticeLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.alertNoticeLabel, 4);
            this.alertNoticeLabel.ForeColor = System.Drawing.Color.Red;
            this.alertNoticeLabel.Location = new System.Drawing.Point(158, 390);
            this.alertNoticeLabel.Name = "alertNoticeLabel";
            this.alertNoticeLabel.Size = new System.Drawing.Size(0, 13);
            this.alertNoticeLabel.TabIndex = 9;
            // 
            // searchPatientFirstNameTextBox
            // 
            this.searchPatientFirstNameTextBox.Location = new System.Drawing.Point(544, 3);
            this.searchPatientFirstNameTextBox.Name = "searchPatientFirstNameTextBox";
            this.searchPatientFirstNameTextBox.ReadOnly = true;
            this.searchPatientFirstNameTextBox.Size = new System.Drawing.Size(226, 20);
            this.searchPatientFirstNameTextBox.TabIndex = 2;
            // 
            // searchPatientLastNameTextBox
            // 
            this.searchPatientLastNameTextBox.Location = new System.Drawing.Point(235, 3);
            this.searchPatientLastNameTextBox.Name = "searchPatientLastNameTextBox";
            this.searchPatientLastNameTextBox.ReadOnly = true;
            this.searchPatientLastNameTextBox.Size = new System.Drawing.Size(226, 20);
            this.searchPatientLastNameTextBox.TabIndex = 1;
            // 
            // searchTimesButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.searchTimesButton, 2);
            this.searchTimesButton.Location = new System.Drawing.Point(158, 78);
            this.searchTimesButton.Name = "searchTimesButton";
            this.searchTimesButton.Size = new System.Drawing.Size(226, 19);
            this.searchTimesButton.TabIndex = 8;
            this.searchTimesButton.Text = "Show Unavailable Appointment Times";
            this.searchTimesButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(467, 368);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(71, 19);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(168, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Last Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 18);
            this.label10.TabIndex = 3;
            this.label10.Text = "Edit Appointment";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.doctorComboBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.datePicker, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.appointmentTimeListView, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.reserveAppointmentButton, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.reasonTextBox, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.alertNoticeLabel, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.searchPatientFirstNameTextBox, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.searchPatientLastNameTextBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.searchTimesButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cancelButton, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label13, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 44);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 576);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel3, 2);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.99319F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.0068F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel3.Controls.Add(this.label12, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.endHourComboBox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.endMinuteComboBox, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(158, 308);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(303, 24);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(133, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = ":";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endHourComboBox
            // 
            this.endHourComboBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.endHourComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.endHourComboBox.FormattingEnabled = true;
            this.endHourComboBox.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.endHourComboBox.Location = new System.Drawing.Point(81, 3);
            this.endHourComboBox.Name = "endHourComboBox";
            this.endHourComboBox.Size = new System.Drawing.Size(42, 21);
            this.endHourComboBox.TabIndex = 1;
            // 
            // endMinuteComboBox
            // 
            this.endMinuteComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.endMinuteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.endMinuteComboBox.FormattingEnabled = true;
            this.endMinuteComboBox.Items.AddRange(new object[] {
            "00",
            "05",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55"});
            this.endMinuteComboBox.Location = new System.Drawing.Point(155, 3);
            this.endMinuteComboBox.Name = "endMinuteComboBox";
            this.endMinuteComboBox.Size = new System.Drawing.Size(39, 21);
            this.endMinuteComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search for patient by name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Choose doctor:";
            // 
            // doctorComboBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.doctorComboBox, 2);
            this.doctorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.doctorBindingSource, "DoctorId", true));
            this.doctorComboBox.DataSource = this.doctorBindingSource;
            this.doctorComboBox.DisplayMember = "LastName, FirstName";
            this.doctorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doctorComboBox.FormattingEnabled = true;
            this.doctorComboBox.Location = new System.Drawing.Point(158, 28);
            this.doctorComboBox.Name = "doctorComboBox";
            this.doctorComboBox.Size = new System.Drawing.Size(226, 21);
            this.doctorComboBox.TabIndex = 5;
            this.doctorComboBox.ValueMember = "DoctorId";
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataSource = typeof(Clinic.Model.Doctor);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 65);
            this.label4.TabIndex = 0;
            this.label4.Text = "The following is a list of previously scheduled (unavailable) appointment times\r\n" +
    "for the chosen date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Edit appointment date:";
            // 
            // datePicker
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.datePicker, 2);
            this.datePicker.Location = new System.Drawing.Point(158, 53);
            this.datePicker.MinDate = new System.DateTime(2021, 3, 31, 23, 19, 45, 68);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(303, 20);
            this.datePicker.TabIndex = 7;
            this.datePicker.Value = new System.DateTime(2021, 3, 31, 23, 19, 45, 68);
            // 
            // appointmentTimeListView
            // 
            this.appointmentTimeListView.BackColor = System.Drawing.SystemColors.ControlLight;
            this.appointmentTimeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.startTimeColumnHeader,
            this.endTimeColumnHeader});
            this.tableLayoutPanel1.SetColumnSpan(this.appointmentTimeListView, 2);
            this.appointmentTimeListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appointmentTimeListView.Enabled = false;
            this.appointmentTimeListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.appointmentTimeListView.HideSelection = false;
            this.appointmentTimeListView.Location = new System.Drawing.Point(158, 103);
            this.appointmentTimeListView.MultiSelect = false;
            this.appointmentTimeListView.Name = "appointmentTimeListView";
            this.appointmentTimeListView.Size = new System.Drawing.Size(303, 169);
            this.appointmentTimeListView.TabIndex = 0;
            this.appointmentTimeListView.TabStop = false;
            this.appointmentTimeListView.UseCompatibleStateImageBehavior = false;
            this.appointmentTimeListView.View = System.Windows.Forms.View.Details;
            // 
            // startTimeColumnHeader
            // 
            this.startTimeColumnHeader.Text = "Start Time";
            this.startTimeColumnHeader.Width = 140;
            // 
            // endTimeColumnHeader
            // 
            this.endTimeColumnHeader.Text = "End Time";
            this.endTimeColumnHeader.Width = 152;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(475, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "First Name: ";
            // 
            // EditAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EditAppointmentForm";
            this.Text = "EditAppointmentForm";
            this.Load += new System.EventHandler(this.EditAppointmentForm_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox reasonTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox endHourComboBox;
        private System.Windows.Forms.ComboBox endMinuteComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox doctorComboBox;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.ListView appointmentTimeListView;
        private System.Windows.Forms.ColumnHeader startTimeColumnHeader;
        private System.Windows.Forms.ColumnHeader endTimeColumnHeader;
        private System.Windows.Forms.Button reserveAppointmentButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox startHourComboBox;
        private System.Windows.Forms.ComboBox startMinuteComboBox;
        private System.Windows.Forms.Label alertNoticeLabel;
        private System.Windows.Forms.TextBox searchPatientFirstNameTextBox;
        private System.Windows.Forms.TextBox searchPatientLastNameTextBox;
        private System.Windows.Forms.Button searchTimesButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
    }
}
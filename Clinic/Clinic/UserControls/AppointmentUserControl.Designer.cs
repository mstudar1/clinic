
namespace Clinic.UserControls
{
    partial class AppointmentUserControl
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
            this.appointmentTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.searchDateLabel = new System.Windows.Forms.Label();
            this.searchLastNameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.searchDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.searchDateButton = new System.Windows.Forms.Button();
            this.searchNameButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.appointmentsLabel = new System.Windows.Forms.Label();
            this.editSelectedAppointmentButton = new System.Windows.Forms.Button();
            this.setAppointmentButton = new System.Windows.Forms.Button();
            this.appointmentsSearchResultsListView = new System.Windows.Forms.ListView();
            this.lastNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.startTimeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.endTimeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.doctorCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.appointmentTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // appointmentTableLayoutPanel
            // 
            this.appointmentTableLayoutPanel.ColumnCount = 3;
            this.appointmentTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.appointmentTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 223F));
            this.appointmentTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 356F));
            this.appointmentTableLayoutPanel.Controls.Add(this.searchDateLabel, 0, 0);
            this.appointmentTableLayoutPanel.Controls.Add(this.searchLastNameLabel, 0, 1);
            this.appointmentTableLayoutPanel.Controls.Add(this.nameTextBox, 1, 1);
            this.appointmentTableLayoutPanel.Controls.Add(this.searchDateTimePicker, 1, 0);
            this.appointmentTableLayoutPanel.Controls.Add(this.searchDateButton, 2, 0);
            this.appointmentTableLayoutPanel.Controls.Add(this.searchNameButton, 2, 1);
            this.appointmentTableLayoutPanel.Controls.Add(this.resetButton, 2, 2);
            this.appointmentTableLayoutPanel.Controls.Add(this.appointmentsLabel, 0, 2);
            this.appointmentTableLayoutPanel.Controls.Add(this.editSelectedAppointmentButton, 0, 4);
            this.appointmentTableLayoutPanel.Controls.Add(this.setAppointmentButton, 2, 4);
            this.appointmentTableLayoutPanel.Controls.Add(this.appointmentsSearchResultsListView, 0, 3);
            this.appointmentTableLayoutPanel.Location = new System.Drawing.Point(8, 4);
            this.appointmentTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.appointmentTableLayoutPanel.Name = "appointmentTableLayoutPanel";
            this.appointmentTableLayoutPanel.RowCount = 5;
            this.appointmentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.appointmentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.appointmentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.appointmentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.appointmentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.appointmentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.appointmentTableLayoutPanel.Size = new System.Drawing.Size(719, 374);
            this.appointmentTableLayoutPanel.TabIndex = 1;
            // 
            // searchDateLabel
            // 
            this.searchDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.searchDateLabel.AutoSize = true;
            this.searchDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchDateLabel.Location = new System.Drawing.Point(28, 14);
            this.searchDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchDateLabel.Name = "searchDateLabel";
            this.searchDateLabel.Size = new System.Drawing.Size(108, 20);
            this.searchDateLabel.TabIndex = 4;
            this.searchDateLabel.Text = "Search Date:";
            this.searchDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // searchLastNameLabel
            // 
            this.searchLastNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.searchLastNameLabel.AutoSize = true;
            this.searchLastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLastNameLabel.Location = new System.Drawing.Point(36, 53);
            this.searchLastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLastNameLabel.Name = "searchLastNameLabel";
            this.searchLastNameLabel.Size = new System.Drawing.Size(100, 40);
            this.searchLastNameLabel.TabIndex = 3;
            this.searchLastNameLabel.Text = "Search Last Name:";
            this.searchLastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(143, 60);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(171, 26);
            this.nameTextBox.TabIndex = 40;
            this.nameTextBox.Tag = "";
            // 
            // searchDateTimePicker
            // 
            this.searchDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.searchDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.searchDateTimePicker.Location = new System.Drawing.Point(144, 11);
            this.searchDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchDateTimePicker.Name = "searchDateTimePicker";
            this.searchDateTimePicker.Size = new System.Drawing.Size(132, 26);
            this.searchDateTimePicker.TabIndex = 20;
            // 
            // searchDateButton
            // 
            this.searchDateButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.searchDateButton.AutoSize = true;
            this.searchDateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchDateButton.Location = new System.Drawing.Point(366, 6);
            this.searchDateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchDateButton.Name = "searchDateButton";
            this.searchDateButton.Size = new System.Drawing.Size(204, 37);
            this.searchDateButton.TabIndex = 30;
            this.searchDateButton.Text = "Search By Date";
            this.searchDateButton.UseVisualStyleBackColor = true;
            this.searchDateButton.Click += new System.EventHandler(this.SearchDateButton_Click);
            // 
            // searchNameButton
            // 
            this.searchNameButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.searchNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchNameButton.Location = new System.Drawing.Point(367, 57);
            this.searchNameButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchNameButton.Name = "searchNameButton";
            this.searchNameButton.Size = new System.Drawing.Size(204, 32);
            this.searchNameButton.TabIndex = 50;
            this.searchNameButton.Text = "Search By Last Name";
            this.searchNameButton.UseVisualStyleBackColor = true;
            this.searchNameButton.Click += new System.EventHandler(this.SearchNameButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.resetButton.AutoSize = true;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(366, 104);
            this.resetButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(239, 37);
            this.resetButton.TabIndex = 60;
            this.resetButton.Text = "Clear Search Results";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // appointmentsLabel
            // 
            this.appointmentsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.appointmentsLabel.AutoSize = true;
            this.appointmentTableLayoutPanel.SetColumnSpan(this.appointmentsLabel, 2);
            this.appointmentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentsLabel.Location = new System.Drawing.Point(3, 122);
            this.appointmentsLabel.Name = "appointmentsLabel";
            this.appointmentsLabel.Size = new System.Drawing.Size(150, 25);
            this.appointmentsLabel.TabIndex = 2;
            this.appointmentsLabel.Text = "Search Results:";
            // 
            // editSelectedAppointmentButton
            // 
            this.appointmentTableLayoutPanel.SetColumnSpan(this.editSelectedAppointmentButton, 2);
            this.editSelectedAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editSelectedAppointmentButton.Location = new System.Drawing.Point(4, 299);
            this.editSelectedAppointmentButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editSelectedAppointmentButton.Name = "editSelectedAppointmentButton";
            this.editSelectedAppointmentButton.Size = new System.Drawing.Size(351, 34);
            this.editSelectedAppointmentButton.TabIndex = 80;
            this.editSelectedAppointmentButton.Text = "Edit Selected Appointment";
            this.editSelectedAppointmentButton.UseVisualStyleBackColor = true;
            // 
            // setAppointmentButton
            // 
            this.setAppointmentButton.AutoSize = true;
            this.setAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setAppointmentButton.Location = new System.Drawing.Point(366, 297);
            this.setAppointmentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.setAppointmentButton.Name = "setAppointmentButton";
            this.setAppointmentButton.Size = new System.Drawing.Size(350, 37);
            this.setAppointmentButton.TabIndex = 90;
            this.setAppointmentButton.Text = "Schedule New Appointment";
            this.setAppointmentButton.UseVisualStyleBackColor = true;
            this.setAppointmentButton.Click += new System.EventHandler(this.SetAppointmentButton_Click);
            // 
            // appointmentsSearchResultsListView
            // 
            this.appointmentsSearchResultsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lastNameCol,
            this.firstNameCol,
            this.dateCol,
            this.startTimeCol,
            this.endTimeCol,
            this.doctorCol});
            this.appointmentTableLayoutPanel.SetColumnSpan(this.appointmentsSearchResultsListView, 3);
            this.appointmentsSearchResultsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appointmentsSearchResultsListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentsSearchResultsListView.FullRowSelect = true;
            this.appointmentsSearchResultsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.appointmentsSearchResultsListView.HideSelection = false;
            this.appointmentsSearchResultsListView.Location = new System.Drawing.Point(3, 149);
            this.appointmentsSearchResultsListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.appointmentsSearchResultsListView.MultiSelect = false;
            this.appointmentsSearchResultsListView.Name = "appointmentsSearchResultsListView";
            this.appointmentsSearchResultsListView.Size = new System.Drawing.Size(713, 144);
            this.appointmentsSearchResultsListView.TabIndex = 70;
            this.appointmentsSearchResultsListView.UseCompatibleStateImageBehavior = false;
            this.appointmentsSearchResultsListView.View = System.Windows.Forms.View.Details;
            // 
            // lastNameCol
            // 
            this.lastNameCol.Text = "Last Name";
            this.lastNameCol.Width = 85;
            // 
            // firstNameCol
            // 
            this.firstNameCol.Text = "First Name";
            this.firstNameCol.Width = 113;
            // 
            // dateCol
            // 
            this.dateCol.Text = "Date";
            this.dateCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dateCol.Width = 175;
            // 
            // startTimeCol
            // 
            this.startTimeCol.Text = "Start Time";
            this.startTimeCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.startTimeCol.Width = 91;
            // 
            // endTimeCol
            // 
            this.endTimeCol.Text = "End Time";
            this.endTimeCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.endTimeCol.Width = 80;
            // 
            // doctorCol
            // 
            this.doctorCol.Text = "Doctor";
            this.doctorCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.doctorCol.Width = 90;
            // 
            // AppointmentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.appointmentTableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AppointmentUserControl";
            this.Size = new System.Drawing.Size(732, 380);
            this.appointmentTableLayoutPanel.ResumeLayout(false);
            this.appointmentTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel appointmentTableLayoutPanel;
        private System.Windows.Forms.Button setAppointmentButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label appointmentsLabel;
        private System.Windows.Forms.Button searchDateButton;
        private System.Windows.Forms.ListView appointmentsSearchResultsListView;
        private System.Windows.Forms.ColumnHeader lastNameCol;
        private System.Windows.Forms.ColumnHeader dateCol;
        private System.Windows.Forms.ColumnHeader firstNameCol;
        private System.Windows.Forms.ColumnHeader endTimeCol;
        private System.Windows.Forms.ColumnHeader doctorCol;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ColumnHeader startTimeCol;
        private System.Windows.Forms.Label searchLastNameLabel;
        private System.Windows.Forms.Label searchDateLabel;
        private System.Windows.Forms.DateTimePicker searchDateTimePicker;
        private System.Windows.Forms.Button searchNameButton;
        private System.Windows.Forms.Button editSelectedAppointmentButton;
    }
}

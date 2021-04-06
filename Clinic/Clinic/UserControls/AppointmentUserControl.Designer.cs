
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.searchDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.searchDateButton = new System.Windows.Forms.Button();
            this.searchNameButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.appointmentsLabel = new System.Windows.Forms.Label();
            this.editAppointmentButton = new System.Windows.Forms.Button();
            this.setAppointmentButton = new System.Windows.Forms.Button();
            this.appointmentsSearchResultsListView = new System.Windows.Forms.ListView();
            this.lastNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.startTimeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.endTimeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.doctorCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.alertTextLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.beginVisitButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.nameTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.searchDateTimePicker, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.searchDateButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.searchNameButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.resetButton, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.appointmentsLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.appointmentsSearchResultsListView, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.alertTextLabel, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(539, 304);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search Date:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search Last Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(136, 48);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(129, 23);
            this.nameTextBox.TabIndex = 40;
            this.nameTextBox.Tag = "";
            this.nameTextBox.TextChanged += new System.EventHandler(this.ResetButton_Click);
            // 
            // searchDateTimePicker
            // 
            this.searchDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.searchDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.searchDateTimePicker.Location = new System.Drawing.Point(137, 8);
            this.searchDateTimePicker.Name = "searchDateTimePicker";
            this.searchDateTimePicker.Size = new System.Drawing.Size(100, 23);
            this.searchDateTimePicker.TabIndex = 20;
            this.searchDateTimePicker.ValueChanged += new System.EventHandler(this.ResetButton_Click);
            // 
            // searchDateButton
            // 
            this.searchDateButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.searchDateButton.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.searchDateButton, 2);
            this.searchDateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchDateButton.Location = new System.Drawing.Point(270, 6);
            this.searchDateButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchDateButton.Name = "searchDateButton";
            this.searchDateButton.Size = new System.Drawing.Size(153, 27);
            this.searchDateButton.TabIndex = 30;
            this.searchDateButton.Text = "Search By Date";
            this.searchDateButton.UseVisualStyleBackColor = true;
            this.searchDateButton.Click += new System.EventHandler(this.SearchDateButton_Click);
            // 
            // searchNameButton
            // 
            this.searchNameButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.searchNameButton, 2);
            this.searchNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchNameButton.Location = new System.Drawing.Point(271, 47);
            this.searchNameButton.Name = "searchNameButton";
            this.searchNameButton.Size = new System.Drawing.Size(153, 26);
            this.searchNameButton.TabIndex = 50;
            this.searchNameButton.Text = "Search By Last Name";
            this.searchNameButton.UseVisualStyleBackColor = true;
            this.searchNameButton.Click += new System.EventHandler(this.SearchNameButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.resetButton.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.resetButton, 2);
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(270, 86);
            this.resetButton.Margin = new System.Windows.Forms.Padding(2);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(153, 27);
            this.resetButton.TabIndex = 60;
            this.resetButton.Text = "Clear Search Results";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // appointmentsLabel
            // 
            this.appointmentsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.appointmentsLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.appointmentsLabel, 2);
            this.appointmentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentsLabel.Location = new System.Drawing.Point(2, 100);
            this.appointmentsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.appointmentsLabel.Name = "appointmentsLabel";
            this.appointmentsLabel.Size = new System.Drawing.Size(122, 20);
            this.appointmentsLabel.TabIndex = 2;
            this.appointmentsLabel.Text = "Search Results:";
            // 
            // editAppointmentButton
            // 
            this.editAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editAppointmentButton.Location = new System.Drawing.Point(3, 3);
            this.editAppointmentButton.Name = "editAppointmentButton";
            this.editAppointmentButton.Size = new System.Drawing.Size(171, 27);
            this.editAppointmentButton.TabIndex = 80;
            this.editAppointmentButton.Text = "Edit Selected Appointment";
            this.editAppointmentButton.UseVisualStyleBackColor = true;
            this.editAppointmentButton.Click += new System.EventHandler(this.EditAppointmentButton_Click);
            // 
            // setAppointmentButton
            // 
            this.setAppointmentButton.AutoSize = true;
            this.setAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setAppointmentButton.Location = new System.Drawing.Point(179, 2);
            this.setAppointmentButton.Margin = new System.Windows.Forms.Padding(2);
            this.setAppointmentButton.Name = "setAppointmentButton";
            this.setAppointmentButton.Size = new System.Drawing.Size(173, 27);
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
            this.tableLayoutPanel1.SetColumnSpan(this.appointmentsSearchResultsListView, 4);
            this.appointmentsSearchResultsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appointmentsSearchResultsListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentsSearchResultsListView.FullRowSelect = true;
            this.appointmentsSearchResultsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.appointmentsSearchResultsListView.HideSelection = false;
            this.appointmentsSearchResultsListView.Location = new System.Drawing.Point(2, 122);
            this.appointmentsSearchResultsListView.Margin = new System.Windows.Forms.Padding(2);
            this.appointmentsSearchResultsListView.MultiSelect = false;
            this.appointmentsSearchResultsListView.Name = "appointmentsSearchResultsListView";
            this.appointmentsSearchResultsListView.Size = new System.Drawing.Size(535, 110);
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
            // alertTextLabel
            // 
            this.alertTextLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.alertTextLabel, 2);
            this.alertTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertTextLabel.ForeColor = System.Drawing.Color.Red;
            this.alertTextLabel.Location = new System.Drawing.Point(137, 273);
            this.alertTextLabel.Name = "alertTextLabel";
            this.alertTextLabel.Size = new System.Drawing.Size(0, 17);
            this.alertTextLabel.TabIndex = 91;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 4);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.setAppointmentButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.editAppointmentButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.beginVisitButton, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 237);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(533, 33);
            this.tableLayoutPanel2.TabIndex = 92;
            // 
            // beginVisitButton
            // 
            this.beginVisitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginVisitButton.Location = new System.Drawing.Point(357, 3);
            this.beginVisitButton.Name = "beginVisitButton";
            this.beginVisitButton.Size = new System.Drawing.Size(173, 27);
            this.beginVisitButton.TabIndex = 91;
            this.beginVisitButton.Text = "Begin Visit";
            this.beginVisitButton.UseVisualStyleBackColor = true;
            // 
            // AppointmentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AppointmentUserControl";
            this.Size = new System.Drawing.Size(549, 309);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker searchDateTimePicker;
        private System.Windows.Forms.Button searchNameButton;
        private System.Windows.Forms.Button editAppointmentButton;
        private System.Windows.Forms.Label alertTextLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button beginVisitButton;
    }
}


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
            this.dobDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.searchDobLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.searchDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.searchDateButton = new System.Windows.Forms.Button();
            this.searchNameButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.appointmentsLabel = new System.Windows.Forms.Label();
            this.appointmentsSearchResultsListView = new System.Windows.Forms.ListView();
            this.lastNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.startTimeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.docCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.alertTextLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.setAppointmentButton = new System.Windows.Forms.Button();
            this.beginVisitButton = new System.Windows.Forms.Button();
            this.editAppointmentButton = new System.Windows.Forms.Button();
            this.deleteAppointmentButton = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.Controls.Add(this.dobDateTimePicker, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.searchDobLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.nameTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.searchDateTimePicker, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.searchDateButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.searchNameButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.resetButton, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.appointmentsLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.appointmentsSearchResultsListView, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.alertTextLabel, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(808, 468);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dobDateTimePicker
            // 
            this.dobDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dobDateTimePicker.Location = new System.Drawing.Point(206, 97);
            this.dobDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dobDateTimePicker.Name = "dobDateTimePicker";
            this.dobDateTimePicker.Size = new System.Drawing.Size(148, 30);
            this.dobDateTimePicker.TabIndex = 44;
            // 
            // searchDobLabel
            // 
            this.searchDobLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchDobLabel.AutoSize = true;
            this.searchDobLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchDobLabel.Location = new System.Drawing.Point(6, 92);
            this.searchDobLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchDobLabel.Name = "searchDobLabel";
            this.searchDobLabel.Size = new System.Drawing.Size(192, 25);
            this.searchDobLabel.TabIndex = 93;
            this.searchDobLabel.Text = "Search Date of Birth:";
            this.searchDobLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search Date:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search Last Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(205, 59);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(192, 30);
            this.nameTextBox.TabIndex = 40;
            this.nameTextBox.Tag = "";
            this.nameTextBox.TextChanged += new System.EventHandler(this.ResetButton_Click);
            // 
            // searchDateTimePicker
            // 
            this.searchDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.searchDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.searchDateTimePicker.Location = new System.Drawing.Point(206, 8);
            this.searchDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchDateTimePicker.Name = "searchDateTimePicker";
            this.searchDateTimePicker.Size = new System.Drawing.Size(148, 30);
            this.searchDateTimePicker.TabIndex = 20;
            this.searchDateTimePicker.ValueChanged += new System.EventHandler(this.ResetButton_Click);
            // 
            // searchDateButton
            // 
            this.searchDateButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.searchDateButton.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.searchDateButton, 2);
            this.searchDateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchDateButton.Location = new System.Drawing.Point(407, 3);
            this.searchDateButton.Name = "searchDateButton";
            this.searchDateButton.Size = new System.Drawing.Size(238, 40);
            this.searchDateButton.TabIndex = 30;
            this.searchDateButton.Text = "Search By Date";
            this.searchDateButton.UseVisualStyleBackColor = true;
            this.searchDateButton.Click += new System.EventHandler(this.SearchDateButton_Click);
            // 
            // searchNameButton
            // 
            this.searchNameButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.SetColumnSpan(this.searchNameButton, 2);
            this.searchNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchNameButton.Location = new System.Drawing.Point(408, 51);
            this.searchNameButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchNameButton.Name = "searchNameButton";
            this.tableLayoutPanel1.SetRowSpan(this.searchNameButton, 2);
            this.searchNameButton.Size = new System.Drawing.Size(230, 82);
            this.searchNameButton.TabIndex = 50;
            this.searchNameButton.Text = "Search By Last Name and Date of Birth";
            this.searchNameButton.UseVisualStyleBackColor = true;
            this.searchNameButton.Click += new System.EventHandler(this.SearchNameButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.resetButton.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.resetButton, 2);
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(407, 141);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(309, 40);
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
            this.appointmentsLabel.Location = new System.Drawing.Point(3, 201);
            this.appointmentsLabel.Name = "appointmentsLabel";
            this.appointmentsLabel.Size = new System.Drawing.Size(166, 29);
            this.appointmentsLabel.TabIndex = 2;
            this.appointmentsLabel.Text = "Appointments:";
            // 
            // appointmentsSearchResultsListView
            // 
            this.appointmentsSearchResultsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lastNameCol,
            this.firstNameCol,
            this.dateCol,
            this.startTimeCol,
            this.docCol});
            this.tableLayoutPanel1.SetColumnSpan(this.appointmentsSearchResultsListView, 4);
            this.appointmentsSearchResultsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appointmentsSearchResultsListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentsSearchResultsListView.FullRowSelect = true;
            this.appointmentsSearchResultsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.appointmentsSearchResultsListView.HideSelection = false;
            this.appointmentsSearchResultsListView.Location = new System.Drawing.Point(3, 233);
            this.appointmentsSearchResultsListView.MultiSelect = false;
            this.appointmentsSearchResultsListView.Name = "appointmentsSearchResultsListView";
            this.appointmentsSearchResultsListView.Size = new System.Drawing.Size(802, 148);
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
            this.startTimeCol.Width = 90;
            // 
            // docCol
            // 
            this.docCol.Text = "Doctor";
            // 
            // alertTextLabel
            // 
            this.alertTextLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.alertTextLabel, 4);
            this.alertTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertTextLabel.ForeColor = System.Drawing.Color.Red;
            this.alertTextLabel.Location = new System.Drawing.Point(4, 432);
            this.alertTextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.alertTextLabel.Name = "alertTextLabel";
            this.alertTextLabel.Size = new System.Drawing.Size(0, 25);
            this.alertTextLabel.TabIndex = 91;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 4);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.setAppointmentButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.beginVisitButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.editAppointmentButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.deleteAppointmentButton, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 389);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(800, 38);
            this.tableLayoutPanel2.TabIndex = 92;
            // 
            // setAppointmentButton
            // 
            this.setAppointmentButton.AutoSize = true;
            this.setAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setAppointmentButton.Location = new System.Drawing.Point(3, 3);
            this.setAppointmentButton.Name = "setAppointmentButton";
            this.setAppointmentButton.Size = new System.Drawing.Size(194, 32);
            this.setAppointmentButton.TabIndex = 90;
            this.setAppointmentButton.Text = "Schedule New Appointment";
            this.setAppointmentButton.UseVisualStyleBackColor = true;
            this.setAppointmentButton.Click += new System.EventHandler(this.SetAppointmentButton_Click);
            // 
            // beginVisitButton
            // 
            this.beginVisitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginVisitButton.Location = new System.Drawing.Point(204, 5);
            this.beginVisitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.beginVisitButton.Name = "beginVisitButton";
            this.beginVisitButton.Size = new System.Drawing.Size(190, 28);
            this.beginVisitButton.TabIndex = 91;
            this.beginVisitButton.Text = "Begin Visit";
            this.beginVisitButton.UseVisualStyleBackColor = true;
            this.beginVisitButton.Click += new System.EventHandler(this.BeginVisitButton_Click);
            // 
            // editAppointmentButton
            // 
            this.editAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editAppointmentButton.Location = new System.Drawing.Point(404, 5);
            this.editAppointmentButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editAppointmentButton.Name = "editAppointmentButton";
            this.editAppointmentButton.Size = new System.Drawing.Size(190, 28);
            this.editAppointmentButton.TabIndex = 80;
            this.editAppointmentButton.Text = "Edit Selected Appointment";
            this.editAppointmentButton.UseVisualStyleBackColor = true;
            this.editAppointmentButton.Click += new System.EventHandler(this.EditAppointmentButton_Click);
            // 
            // deleteAppointmentButton
            // 
            this.deleteAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAppointmentButton.Location = new System.Drawing.Point(604, 5);
            this.deleteAppointmentButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteAppointmentButton.Name = "deleteAppointmentButton";
            this.deleteAppointmentButton.Size = new System.Drawing.Size(190, 28);
            this.deleteAppointmentButton.TabIndex = 92;
            this.deleteAppointmentButton.Text = "Delete Selected";
            this.deleteAppointmentButton.UseVisualStyleBackColor = true;
            this.deleteAppointmentButton.Click += new System.EventHandler(this.DeleteAppointmentButton_Click);
            // 
            // AppointmentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AppointmentUserControl";
            this.Size = new System.Drawing.Size(824, 475);
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
        public System.Windows.Forms.ListView appointmentsSearchResultsListView;
        private System.Windows.Forms.ColumnHeader lastNameCol;
        private System.Windows.Forms.ColumnHeader firstNameCol;
        private System.Windows.Forms.ColumnHeader dateCol;
        private System.Windows.Forms.ColumnHeader startTimeCol;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker searchDateTimePicker;
        private System.Windows.Forms.Button searchNameButton;
        private System.Windows.Forms.Button editAppointmentButton;
        private System.Windows.Forms.Label alertTextLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button beginVisitButton;
        private System.Windows.Forms.ColumnHeader docCol;
        private System.Windows.Forms.DateTimePicker dobDateTimePicker;
        private System.Windows.Forms.Label searchDobLabel;
        private System.Windows.Forms.Button deleteAppointmentButton;
    }
}

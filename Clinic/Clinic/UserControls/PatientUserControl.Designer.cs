
namespace Clinic.UserControls
{
    partial class PatientUserControl
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
            this.patientTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.registerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.registerPatientButton = new System.Windows.Forms.Button();
            this.titleAndResetTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.resetButton = new System.Windows.Forms.Button();
            this.listOfPatientsLabel = new System.Windows.Forms.Label();
            this.searchTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.searchButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NurseListView = new System.Windows.Forms.ListView();
            this.firstNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dobColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addressColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.editColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deleteColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.patientTableLayoutPanel.SuspendLayout();
            this.registerTableLayoutPanel.SuspendLayout();
            this.titleAndResetTableLayoutPanel.SuspendLayout();
            this.searchTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // patientTableLayoutPanel
            // 
            this.patientTableLayoutPanel.ColumnCount = 1;
            this.patientTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.patientTableLayoutPanel.Controls.Add(this.registerTableLayoutPanel, 0, 1);
            this.patientTableLayoutPanel.Controls.Add(this.titleAndResetTableLayoutPanel, 0, 2);
            this.patientTableLayoutPanel.Controls.Add(this.searchTableLayoutPanel, 0, 0);
            this.patientTableLayoutPanel.Controls.Add(this.NurseListView, 0, 3);
            this.patientTableLayoutPanel.Location = new System.Drawing.Point(3, 7);
            this.patientTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.patientTableLayoutPanel.Name = "patientTableLayoutPanel";
            this.patientTableLayoutPanel.RowCount = 4;
            this.patientTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.35165F));
            this.patientTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.64835F));
            this.patientTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.patientTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 251F));
            this.patientTableLayoutPanel.Size = new System.Drawing.Size(719, 362);
            this.patientTableLayoutPanel.TabIndex = 2;
            // 
            // registerTableLayoutPanel
            // 
            this.registerTableLayoutPanel.ColumnCount = 2;
            this.registerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.847736F));
            this.registerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.15226F));
            this.registerTableLayoutPanel.Controls.Add(this.registerPatientButton, 1, 0);
            this.registerTableLayoutPanel.Location = new System.Drawing.Point(3, 37);
            this.registerTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registerTableLayoutPanel.Name = "registerTableLayoutPanel";
            this.registerTableLayoutPanel.RowCount = 1;
            this.registerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.registerTableLayoutPanel.Size = new System.Drawing.Size(713, 32);
            this.registerTableLayoutPanel.TabIndex = 20;
            // 
            // registerPatientButton
            // 
            this.registerPatientButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.registerPatientButton.AutoSize = true;
            this.registerPatientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerPatientButton.Location = new System.Drawing.Point(66, 2);
            this.registerPatientButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registerPatientButton.Name = "registerPatientButton";
            this.registerPatientButton.Size = new System.Drawing.Size(211, 28);
            this.registerPatientButton.TabIndex = 10;
            this.registerPatientButton.Text = "Register Patient";
            this.registerPatientButton.UseVisualStyleBackColor = true;
            this.registerPatientButton.Click += new System.EventHandler(this.RegisterPatientButton_Click);
            // 
            // titleAndResetTableLayoutPanel
            // 
            this.titleAndResetTableLayoutPanel.ColumnCount = 3;
            this.titleAndResetTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.12851F));
            this.titleAndResetTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.87148F));
            this.titleAndResetTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.titleAndResetTableLayoutPanel.Controls.Add(this.resetButton, 1, 0);
            this.titleAndResetTableLayoutPanel.Controls.Add(this.listOfPatientsLabel, 0, 0);
            this.titleAndResetTableLayoutPanel.Location = new System.Drawing.Point(3, 75);
            this.titleAndResetTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.titleAndResetTableLayoutPanel.Name = "titleAndResetTableLayoutPanel";
            this.titleAndResetTableLayoutPanel.RowCount = 1;
            this.titleAndResetTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.titleAndResetTableLayoutPanel.Size = new System.Drawing.Size(713, 32);
            this.titleAndResetTableLayoutPanel.TabIndex = 30;
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resetButton.AutoSize = true;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(556, 2);
            this.resetButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(96, 28);
            this.resetButton.TabIndex = 10;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // listOfPatientsLabel
            // 
            this.listOfPatientsLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.listOfPatientsLabel.AutoSize = true;
            this.listOfPatientsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOfPatientsLabel.Location = new System.Drawing.Point(15, 3);
            this.listOfPatientsLabel.Name = "listOfPatientsLabel";
            this.listOfPatientsLabel.Size = new System.Drawing.Size(180, 29);
            this.listOfPatientsLabel.TabIndex = 99;
            this.listOfPatientsLabel.Text = "List of Patients";
            // 
            // searchTableLayoutPanel
            // 
            this.searchTableLayoutPanel.ColumnCount = 4;
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.35203F));
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.64797F));
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.searchTableLayoutPanel.Controls.Add(this.searchButton, 3, 0);
            this.searchTableLayoutPanel.Controls.Add(this.nameTextBox, 1, 0);
            this.searchTableLayoutPanel.Controls.Add(this.dateOfBirthDateTimePicker, 2, 0);
            this.searchTableLayoutPanel.Location = new System.Drawing.Point(3, 2);
            this.searchTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchTableLayoutPanel.Name = "searchTableLayoutPanel";
            this.searchTableLayoutPanel.RowCount = 1;
            this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchTableLayoutPanel.Size = new System.Drawing.Size(713, 31);
            this.searchTableLayoutPanel.TabIndex = 10;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.searchButton.AutoSize = true;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(611, 2);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(95, 27);
            this.searchButton.TabIndex = 30;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(246, 2);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(198, 30);
            this.nameTextBox.TabIndex = 10;
            this.nameTextBox.Tag = "";
            // 
            // dateOfBirthDateTimePicker
            // 
            this.dateOfBirthDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(451, 4);
            this.dateOfBirthDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(152, 30);
            this.dateOfBirthDateTimePicker.TabIndex = 20;
            this.dateOfBirthDateTimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DateOfBirthDateTimePicker_KeyDown);
            // 
            // NurseListView
            // 
            this.NurseListView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.NurseListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.firstNameColumnHeader,
            this.lastNameColumnHeader,
            this.dobColumnHeader,
            this.addressColumnHeader,
            this.viewColumnHeader,
            this.editColumnHeader,
            this.deleteColumnHeader});
            this.NurseListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NurseListView.HideSelection = false;
            this.NurseListView.Location = new System.Drawing.Point(13, 112);
            this.NurseListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NurseListView.Name = "NurseListView";
            this.NurseListView.Size = new System.Drawing.Size(693, 248);
            this.NurseListView.TabIndex = 40;
            this.NurseListView.TabStop = false;
            this.NurseListView.UseCompatibleStateImageBehavior = false;
            this.NurseListView.View = System.Windows.Forms.View.Details;
            // 
            // firstNameColumnHeader
            // 
            this.firstNameColumnHeader.Text = "First Name";
            this.firstNameColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.firstNameColumnHeader.Width = 160;
            // 
            // lastNameColumnHeader
            // 
            this.lastNameColumnHeader.Text = "Last Name";
            this.lastNameColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lastNameColumnHeader.Width = 160;
            // 
            // dobColumnHeader
            // 
            this.dobColumnHeader.Text = "DOB";
            this.dobColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dobColumnHeader.Width = 100;
            // 
            // addressColumnHeader
            // 
            this.addressColumnHeader.Text = "Address";
            this.addressColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.addressColumnHeader.Width = 170;
            // 
            // viewColumnHeader
            // 
            this.viewColumnHeader.Text = "View";
            this.viewColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.viewColumnHeader.Width = 90;
            // 
            // editColumnHeader
            // 
            this.editColumnHeader.Text = "Edit";
            this.editColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.editColumnHeader.Width = 90;
            // 
            // deleteColumnHeader
            // 
            this.deleteColumnHeader.Text = "Delete";
            this.deleteColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deleteColumnHeader.Width = 90;
            // 
            // PatientUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.patientTableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PatientUserControl";
            this.Size = new System.Drawing.Size(731, 383);
            this.patientTableLayoutPanel.ResumeLayout(false);
            this.registerTableLayoutPanel.ResumeLayout(false);
            this.registerTableLayoutPanel.PerformLayout();
            this.titleAndResetTableLayoutPanel.ResumeLayout(false);
            this.titleAndResetTableLayoutPanel.PerformLayout();
            this.searchTableLayoutPanel.ResumeLayout(false);
            this.searchTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel patientTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel registerTableLayoutPanel;
        private System.Windows.Forms.Button registerPatientButton;
        private System.Windows.Forms.TableLayoutPanel titleAndResetTableLayoutPanel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label listOfPatientsLabel;
        private System.Windows.Forms.TableLayoutPanel searchTableLayoutPanel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ListView NurseListView;
        private System.Windows.Forms.ColumnHeader dobColumnHeader;
        private System.Windows.Forms.ColumnHeader firstNameColumnHeader;
        private System.Windows.Forms.ColumnHeader addressColumnHeader;
        private System.Windows.Forms.ColumnHeader viewColumnHeader;
        private System.Windows.Forms.ColumnHeader editColumnHeader;
        private System.Windows.Forms.ColumnHeader deleteColumnHeader;
        private System.Windows.Forms.ColumnHeader lastNameColumnHeader;
        private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker;
    }
}

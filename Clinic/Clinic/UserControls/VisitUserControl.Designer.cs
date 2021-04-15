
namespace Clinic.UserControls
{
    partial class VisitUserControl
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
            this.visitTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.visitListView = new System.Windows.Forms.ListView();
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dobColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.doctorColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nurseColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewVisitDetailsButton = new System.Windows.Forms.Button();
            this.searchByDateTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.searchByDateButton = new System.Windows.Forms.Button();
            this.visitDateLabel = new System.Windows.Forms.Label();
            this.visitDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.searchByLastNameAndDateOfBirthTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.searchByLastNameAndDateOfBirthButton = new System.Windows.Forms.Button();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.clearSearchResultsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.clearSearchResultsButton = new System.Windows.Forms.Button();
            this.searchResultsLabel = new System.Windows.Forms.Label();
            this.visitTableLayoutPanel.SuspendLayout();
            this.searchByDateTableLayoutPanel.SuspendLayout();
            this.searchByLastNameAndDateOfBirthTableLayoutPanel.SuspendLayout();
            this.clearSearchResultsTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // visitTableLayoutPanel
            // 
            this.visitTableLayoutPanel.ColumnCount = 1;
            this.visitTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.visitTableLayoutPanel.Controls.Add(this.visitListView, 0, 4);
            this.visitTableLayoutPanel.Controls.Add(this.viewVisitDetailsButton, 0, 5);
            this.visitTableLayoutPanel.Controls.Add(this.searchByDateTableLayoutPanel, 0, 0);
            this.visitTableLayoutPanel.Controls.Add(this.searchByLastNameAndDateOfBirthTableLayoutPanel, 0, 1);
            this.visitTableLayoutPanel.Controls.Add(this.clearSearchResultsTableLayoutPanel, 0, 2);
            this.visitTableLayoutPanel.Controls.Add(this.searchResultsLabel, 0, 3);
            this.visitTableLayoutPanel.Location = new System.Drawing.Point(2, 2);
            this.visitTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.visitTableLayoutPanel.Name = "visitTableLayoutPanel";
            this.visitTableLayoutPanel.RowCount = 6;
            this.visitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.visitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.visitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.visitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.visitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.visitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.visitTableLayoutPanel.Size = new System.Drawing.Size(539, 278);
            this.visitTableLayoutPanel.TabIndex = 2;
            // 
            // visitListView
            // 
            this.visitListView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.visitListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumnHeader,
            this.dobColumnHeader,
            this.doctorColumnHeader,
            this.nurseColumnHeader,
            this.dateColumnHeader});
            this.visitListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitListView.FullRowSelect = true;
            this.visitListView.HideSelection = false;
            this.visitListView.Location = new System.Drawing.Point(9, 142);
            this.visitListView.Margin = new System.Windows.Forms.Padding(2);
            this.visitListView.Name = "visitListView";
            this.visitListView.Size = new System.Drawing.Size(521, 96);
            this.visitListView.TabIndex = 4;
            this.visitListView.TabStop = false;
            this.visitListView.UseCompatibleStateImageBehavior = false;
            this.visitListView.View = System.Windows.Forms.View.Details;
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.Text = "Name";
            this.nameColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameColumnHeader.Width = 150;
            // 
            // dobColumnHeader
            // 
            this.dobColumnHeader.Text = "DOB";
            this.dobColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dobColumnHeader.Width = 80;
            // 
            // doctorColumnHeader
            // 
            this.doctorColumnHeader.Text = "Doctor";
            this.doctorColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.doctorColumnHeader.Width = 150;
            // 
            // nurseColumnHeader
            // 
            this.nurseColumnHeader.Text = "Nurse";
            this.nurseColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nurseColumnHeader.Width = 150;
            // 
            // dateColumnHeader
            // 
            this.dateColumnHeader.Text = "Date";
            this.dateColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dateColumnHeader.Width = 90;
            // 
            // viewVisitDetailsButton
            // 
            this.viewVisitDetailsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewVisitDetailsButton.Location = new System.Drawing.Point(2, 242);
            this.viewVisitDetailsButton.Margin = new System.Windows.Forms.Padding(2);
            this.viewVisitDetailsButton.Name = "viewVisitDetailsButton";
            this.viewVisitDetailsButton.Size = new System.Drawing.Size(535, 34);
            this.viewVisitDetailsButton.TabIndex = 5;
            this.viewVisitDetailsButton.Text = "View Visit Details";
            this.viewVisitDetailsButton.UseVisualStyleBackColor = true;
            this.viewVisitDetailsButton.Click += new System.EventHandler(this.ViewVisitDetailsButton_Click);
            // 
            // searchByDateTableLayoutPanel
            // 
            this.searchByDateTableLayoutPanel.ColumnCount = 3;
            this.searchByDateTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3F));
            this.searchByDateTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3F));
            this.searchByDateTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.4F));
            this.searchByDateTableLayoutPanel.Controls.Add(this.searchByDateButton, 2, 0);
            this.searchByDateTableLayoutPanel.Controls.Add(this.visitDateLabel, 0, 0);
            this.searchByDateTableLayoutPanel.Controls.Add(this.visitDateTimePicker, 1, 0);
            this.searchByDateTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchByDateTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.searchByDateTableLayoutPanel.Name = "searchByDateTableLayoutPanel";
            this.searchByDateTableLayoutPanel.RowCount = 1;
            this.searchByDateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.searchByDateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.searchByDateTableLayoutPanel.Size = new System.Drawing.Size(533, 24);
            this.searchByDateTableLayoutPanel.TabIndex = 6;
            // 
            // searchByDateButton
            // 
            this.searchByDateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchByDateButton.Location = new System.Drawing.Point(357, 3);
            this.searchByDateButton.Name = "searchByDateButton";
            this.searchByDateButton.Size = new System.Drawing.Size(173, 18);
            this.searchByDateButton.TabIndex = 0;
            this.searchByDateButton.Text = "Search By Date";
            this.searchByDateButton.UseVisualStyleBackColor = true;
            this.searchByDateButton.Click += new System.EventHandler(this.SearchByDateButton_Click);
            // 
            // visitDateLabel
            // 
            this.visitDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.visitDateLabel.AutoSize = true;
            this.visitDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitDateLabel.Location = new System.Drawing.Point(106, 3);
            this.visitDateLabel.Name = "visitDateLabel";
            this.visitDateLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.visitDateLabel.Size = new System.Drawing.Size(68, 21);
            this.visitDateLabel.TabIndex = 1;
            this.visitDateLabel.Text = "Visit Date:";
            // 
            // visitDateTimePicker
            // 
            this.visitDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.visitDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.visitDateTimePicker.Location = new System.Drawing.Point(180, 3);
            this.visitDateTimePicker.Name = "visitDateTimePicker";
            this.visitDateTimePicker.Size = new System.Drawing.Size(171, 20);
            this.visitDateTimePicker.TabIndex = 2;
            // 
            // searchByLastNameAndDateOfBirthTableLayoutPanel
            // 
            this.searchByLastNameAndDateOfBirthTableLayoutPanel.ColumnCount = 3;
            this.searchByLastNameAndDateOfBirthTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3F));
            this.searchByLastNameAndDateOfBirthTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3F));
            this.searchByLastNameAndDateOfBirthTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.4F));
            this.searchByLastNameAndDateOfBirthTableLayoutPanel.Controls.Add(this.searchByLastNameAndDateOfBirthButton, 2, 0);
            this.searchByLastNameAndDateOfBirthTableLayoutPanel.Controls.Add(this.lastNameLabel, 0, 0);
            this.searchByLastNameAndDateOfBirthTableLayoutPanel.Controls.Add(this.dateOfBirthLabel, 0, 1);
            this.searchByLastNameAndDateOfBirthTableLayoutPanel.Controls.Add(this.lastNameTextBox, 1, 0);
            this.searchByLastNameAndDateOfBirthTableLayoutPanel.Controls.Add(this.dateOfBirthDateTimePicker, 1, 1);
            this.searchByLastNameAndDateOfBirthTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchByLastNameAndDateOfBirthTableLayoutPanel.Location = new System.Drawing.Point(3, 33);
            this.searchByLastNameAndDateOfBirthTableLayoutPanel.Name = "searchByLastNameAndDateOfBirthTableLayoutPanel";
            this.searchByLastNameAndDateOfBirthTableLayoutPanel.RowCount = 2;
            this.searchByLastNameAndDateOfBirthTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchByLastNameAndDateOfBirthTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchByLastNameAndDateOfBirthTableLayoutPanel.Size = new System.Drawing.Size(533, 54);
            this.searchByLastNameAndDateOfBirthTableLayoutPanel.TabIndex = 7;
            // 
            // searchByLastNameAndDateOfBirthButton
            // 
            this.searchByLastNameAndDateOfBirthButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchByLastNameAndDateOfBirthButton.Location = new System.Drawing.Point(357, 3);
            this.searchByLastNameAndDateOfBirthButton.Name = "searchByLastNameAndDateOfBirthButton";
            this.searchByLastNameAndDateOfBirthTableLayoutPanel.SetRowSpan(this.searchByLastNameAndDateOfBirthButton, 2);
            this.searchByLastNameAndDateOfBirthButton.Size = new System.Drawing.Size(173, 48);
            this.searchByLastNameAndDateOfBirthButton.TabIndex = 0;
            this.searchByLastNameAndDateOfBirthButton.Text = "Search by Last Name and Date of Birth";
            this.searchByLastNameAndDateOfBirthButton.UseVisualStyleBackColor = true;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(98, 6);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lastNameLabel.Size = new System.Drawing.Size(76, 21);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthLabel.Location = new System.Drawing.Point(91, 33);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.dateOfBirthLabel.Size = new System.Drawing.Size(83, 21);
            this.dateOfBirthLabel.TabIndex = 2;
            this.dateOfBirthLabel.Text = "Date of Birth:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(180, 4);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(171, 20);
            this.lastNameTextBox.TabIndex = 4;
            // 
            // dateOfBirthDateTimePicker
            // 
            this.dateOfBirthDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateOfBirthDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(180, 31);
            this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(171, 20);
            this.dateOfBirthDateTimePicker.TabIndex = 3;
            // 
            // clearSearchResultsTableLayoutPanel
            // 
            this.clearSearchResultsTableLayoutPanel.ColumnCount = 3;
            this.clearSearchResultsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3F));
            this.clearSearchResultsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3F));
            this.clearSearchResultsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.4F));
            this.clearSearchResultsTableLayoutPanel.Controls.Add(this.clearSearchResultsButton, 2, 0);
            this.clearSearchResultsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearSearchResultsTableLayoutPanel.Location = new System.Drawing.Point(3, 93);
            this.clearSearchResultsTableLayoutPanel.Name = "clearSearchResultsTableLayoutPanel";
            this.clearSearchResultsTableLayoutPanel.RowCount = 1;
            this.clearSearchResultsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.clearSearchResultsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.clearSearchResultsTableLayoutPanel.Size = new System.Drawing.Size(533, 24);
            this.clearSearchResultsTableLayoutPanel.TabIndex = 8;
            // 
            // clearSearchResultsButton
            // 
            this.clearSearchResultsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearSearchResultsButton.Location = new System.Drawing.Point(357, 3);
            this.clearSearchResultsButton.Name = "clearSearchResultsButton";
            this.clearSearchResultsButton.Size = new System.Drawing.Size(173, 18);
            this.clearSearchResultsButton.TabIndex = 0;
            this.clearSearchResultsButton.Text = "Clear Search Results";
            this.clearSearchResultsButton.UseVisualStyleBackColor = true;
            // 
            // searchResultsLabel
            // 
            this.searchResultsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.searchResultsLabel.AutoSize = true;
            this.searchResultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchResultsLabel.Location = new System.Drawing.Point(3, 120);
            this.searchResultsLabel.Name = "searchResultsLabel";
            this.searchResultsLabel.Size = new System.Drawing.Size(141, 20);
            this.searchResultsLabel.TabIndex = 9;
            this.searchResultsLabel.Text = "Search Results:";
            // 
            // VisitUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.visitTableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VisitUserControl";
            this.Size = new System.Drawing.Size(547, 291);
            this.visitTableLayoutPanel.ResumeLayout(false);
            this.visitTableLayoutPanel.PerformLayout();
            this.searchByDateTableLayoutPanel.ResumeLayout(false);
            this.searchByDateTableLayoutPanel.PerformLayout();
            this.searchByLastNameAndDateOfBirthTableLayoutPanel.ResumeLayout(false);
            this.searchByLastNameAndDateOfBirthTableLayoutPanel.PerformLayout();
            this.clearSearchResultsTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel visitTableLayoutPanel;
        private System.Windows.Forms.ListView visitListView;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader dobColumnHeader;
        private System.Windows.Forms.ColumnHeader doctorColumnHeader;
        private System.Windows.Forms.ColumnHeader nurseColumnHeader;
        private System.Windows.Forms.ColumnHeader dateColumnHeader;
        private System.Windows.Forms.Button viewVisitDetailsButton;
        private System.Windows.Forms.TableLayoutPanel searchByDateTableLayoutPanel;
        private System.Windows.Forms.Button searchByDateButton;
        private System.Windows.Forms.TableLayoutPanel searchByLastNameAndDateOfBirthTableLayoutPanel;
        private System.Windows.Forms.Button searchByLastNameAndDateOfBirthButton;
        private System.Windows.Forms.TableLayoutPanel clearSearchResultsTableLayoutPanel;
        private System.Windows.Forms.Button clearSearchResultsButton;
        private System.Windows.Forms.Label visitDateLabel;
        private System.Windows.Forms.DateTimePicker visitDateTimePicker;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label searchResultsLabel;
    }
}

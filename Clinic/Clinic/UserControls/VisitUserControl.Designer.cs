
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
            this.spacerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.titleAndResetTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.resetButton = new System.Windows.Forms.Button();
            this.visitsLabel = new System.Windows.Forms.Label();
            this.searchTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.searchButton = new System.Windows.Forms.Button();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.visitListView = new System.Windows.Forms.ListView();
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dobColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.doctorColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nurseColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewVisitDetailsButton = new System.Windows.Forms.Button();
            this.visitTableLayoutPanel.SuspendLayout();
            this.titleAndResetTableLayoutPanel.SuspendLayout();
            this.searchTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // visitTableLayoutPanel
            // 
            this.visitTableLayoutPanel.ColumnCount = 1;
            this.visitTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.visitTableLayoutPanel.Controls.Add(this.spacerTableLayoutPanel, 0, 1);
            this.visitTableLayoutPanel.Controls.Add(this.titleAndResetTableLayoutPanel, 0, 2);
            this.visitTableLayoutPanel.Controls.Add(this.searchTableLayoutPanel, 0, 0);
            this.visitTableLayoutPanel.Controls.Add(this.visitListView, 0, 3);
            this.visitTableLayoutPanel.Controls.Add(this.viewVisitDetailsButton, 0, 4);
            this.visitTableLayoutPanel.Location = new System.Drawing.Point(2, 2);
            this.visitTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.visitTableLayoutPanel.Name = "visitTableLayoutPanel";
            this.visitTableLayoutPanel.RowCount = 5;
            this.visitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.94505F));
            this.visitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.05495F));
            this.visitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.visitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.visitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.visitTableLayoutPanel.Size = new System.Drawing.Size(539, 306);
            this.visitTableLayoutPanel.TabIndex = 2;
            // 
            // spacerTableLayoutPanel
            // 
            this.spacerTableLayoutPanel.ColumnCount = 2;
            this.spacerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.847736F));
            this.spacerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.15226F));
            this.spacerTableLayoutPanel.Location = new System.Drawing.Point(2, 26);
            this.spacerTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.spacerTableLayoutPanel.Name = "spacerTableLayoutPanel";
            this.spacerTableLayoutPanel.RowCount = 1;
            this.spacerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.spacerTableLayoutPanel.Size = new System.Drawing.Size(535, 15);
            this.spacerTableLayoutPanel.TabIndex = 20;
            // 
            // titleAndResetTableLayoutPanel
            // 
            this.titleAndResetTableLayoutPanel.ColumnCount = 3;
            this.titleAndResetTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.45783F));
            this.titleAndResetTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.54217F));
            this.titleAndResetTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.titleAndResetTableLayoutPanel.Controls.Add(this.resetButton, 1, 0);
            this.titleAndResetTableLayoutPanel.Controls.Add(this.visitsLabel, 0, 0);
            this.titleAndResetTableLayoutPanel.Location = new System.Drawing.Point(2, 45);
            this.titleAndResetTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.titleAndResetTableLayoutPanel.Name = "titleAndResetTableLayoutPanel";
            this.titleAndResetTableLayoutPanel.RowCount = 1;
            this.titleAndResetTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.titleAndResetTableLayoutPanel.Size = new System.Drawing.Size(535, 26);
            this.titleAndResetTableLayoutPanel.TabIndex = 30;
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resetButton.AutoSize = true;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(411, 2);
            this.resetButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(72, 22);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // visitsLabel
            // 
            this.visitsLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.visitsLabel.AutoSize = true;
            this.visitsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitsLabel.Location = new System.Drawing.Point(5, 1);
            this.visitsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.visitsLabel.Name = "visitsLabel";
            this.visitsLabel.Size = new System.Drawing.Size(59, 25);
            this.visitsLabel.TabIndex = 99;
            this.visitsLabel.Text = "Visits";
            // 
            // searchTableLayoutPanel
            // 
            this.searchTableLayoutPanel.ColumnCount = 4;
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.35203F));
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.64797F));
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.searchTableLayoutPanel.Controls.Add(this.searchButton, 3, 0);
            this.searchTableLayoutPanel.Controls.Add(this.lastNameTextBox, 2, 0);
            this.searchTableLayoutPanel.Controls.Add(this.lastNameLabel, 1, 0);
            this.searchTableLayoutPanel.Location = new System.Drawing.Point(2, 2);
            this.searchTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchTableLayoutPanel.Name = "searchTableLayoutPanel";
            this.searchTableLayoutPanel.RowCount = 1;
            this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchTableLayoutPanel.Size = new System.Drawing.Size(535, 20);
            this.searchTableLayoutPanel.TabIndex = 10;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.searchButton.AutoSize = true;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(453, 2);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(70, 16);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(376, 2);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(71, 26);
            this.lastNameTextBox.TabIndex = 1;
            this.lastNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PatientIdTextBox_KeyDown);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(311, 3);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.lastNameLabel.TabIndex = 32;
            this.lastNameLabel.Text = "Last Name:";
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
            this.visitListView.Location = new System.Drawing.Point(9, 75);
            this.visitListView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.visitListView.Name = "visitListView";
            this.visitListView.Size = new System.Drawing.Size(521, 196);
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
            this.viewVisitDetailsButton.Location = new System.Drawing.Point(2, 275);
            this.viewVisitDetailsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.viewVisitDetailsButton.Name = "viewVisitDetailsButton";
            this.viewVisitDetailsButton.Size = new System.Drawing.Size(535, 29);
            this.viewVisitDetailsButton.TabIndex = 5;
            this.viewVisitDetailsButton.Text = "View Visit Details";
            this.viewVisitDetailsButton.UseVisualStyleBackColor = true;
            this.viewVisitDetailsButton.Click += new System.EventHandler(this.ViewVisitDetailsButton_Click);
            // 
            // VisitUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.visitTableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "VisitUserControl";
            this.Size = new System.Drawing.Size(547, 315);
            this.visitTableLayoutPanel.ResumeLayout(false);
            this.titleAndResetTableLayoutPanel.ResumeLayout(false);
            this.titleAndResetTableLayoutPanel.PerformLayout();
            this.searchTableLayoutPanel.ResumeLayout(false);
            this.searchTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel visitTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel spacerTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel titleAndResetTableLayoutPanel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label visitsLabel;
        private System.Windows.Forms.TableLayoutPanel searchTableLayoutPanel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListView visitListView;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader dobColumnHeader;
        private System.Windows.Forms.ColumnHeader doctorColumnHeader;
        private System.Windows.Forms.ColumnHeader nurseColumnHeader;
        private System.Windows.Forms.ColumnHeader dateColumnHeader;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Button viewVisitDetailsButton;
        private System.Windows.Forms.Label lastNameLabel;
    }
}

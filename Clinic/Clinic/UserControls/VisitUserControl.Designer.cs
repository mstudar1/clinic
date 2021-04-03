
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.visitDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.visitListView = new System.Windows.Forms.ListView();
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dobColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.doctorColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nurseColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.editColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deleteColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.visitTableLayoutPanel.SuspendLayout();
            this.titleAndResetTableLayoutPanel.SuspendLayout();
            this.searchTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // visitTableLayoutPanel
            // 
            this.visitTableLayoutPanel.ColumnCount = 1;
            this.visitTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.visitTableLayoutPanel.Controls.Add(this.spacerTableLayoutPanel, 0, 1);
            this.visitTableLayoutPanel.Controls.Add(this.titleAndResetTableLayoutPanel, 0, 2);
            this.visitTableLayoutPanel.Controls.Add(this.searchTableLayoutPanel, 0, 0);
            this.visitTableLayoutPanel.Controls.Add(this.visitListView, 0, 3);
            this.visitTableLayoutPanel.Location = new System.Drawing.Point(3, 2);
            this.visitTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.visitTableLayoutPanel.Name = "visitTableLayoutPanel";
            this.visitTableLayoutPanel.RowCount = 4;
            this.visitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.94505F));
            this.visitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.05495F));
            this.visitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.visitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 246F));
            this.visitTableLayoutPanel.Size = new System.Drawing.Size(719, 362);
            this.visitTableLayoutPanel.TabIndex = 2;
            // 
            // spacerTableLayoutPanel
            // 
            this.spacerTableLayoutPanel.ColumnCount = 2;
            this.spacerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.847736F));
            this.spacerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.15226F));
            this.spacerTableLayoutPanel.Location = new System.Drawing.Point(3, 45);
            this.spacerTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.spacerTableLayoutPanel.Name = "spacerTableLayoutPanel";
            this.spacerTableLayoutPanel.RowCount = 1;
            this.spacerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.spacerTableLayoutPanel.Size = new System.Drawing.Size(713, 30);
            this.spacerTableLayoutPanel.TabIndex = 20;
            // 
            // titleAndResetTableLayoutPanel
            // 
            this.titleAndResetTableLayoutPanel.ColumnCount = 3;
            this.titleAndResetTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.45783F));
            this.titleAndResetTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.54217F));
            this.titleAndResetTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.titleAndResetTableLayoutPanel.Controls.Add(this.resetButton, 1, 0);
            this.titleAndResetTableLayoutPanel.Controls.Add(this.visitsLabel, 0, 0);
            this.titleAndResetTableLayoutPanel.Location = new System.Drawing.Point(3, 80);
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
            this.resetButton.Location = new System.Drawing.Point(557, 2);
            this.resetButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(96, 28);
            this.resetButton.TabIndex = 10;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // visitsLabel
            // 
            this.visitsLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.visitsLabel.AutoSize = true;
            this.visitsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitsLabel.Location = new System.Drawing.Point(9, 3);
            this.visitsLabel.Name = "visitsLabel";
            this.visitsLabel.Size = new System.Drawing.Size(75, 29);
            this.visitsLabel.TabIndex = 99;
            this.visitsLabel.Text = "Visits";
            // 
            // searchTableLayoutPanel
            // 
            this.searchTableLayoutPanel.ColumnCount = 4;
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.35203F));
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.64797F));
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.searchTableLayoutPanel.Controls.Add(this.searchButton, 3, 0);
            this.searchTableLayoutPanel.Controls.Add(this.nameTextBox, 1, 0);
            this.searchTableLayoutPanel.Controls.Add(this.visitDateTimePicker, 2, 0);
            this.searchTableLayoutPanel.Location = new System.Drawing.Point(3, 2);
            this.searchTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchTableLayoutPanel.Name = "searchTableLayoutPanel";
            this.searchTableLayoutPanel.RowCount = 1;
            this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchTableLayoutPanel.Size = new System.Drawing.Size(713, 38);
            this.searchTableLayoutPanel.TabIndex = 10;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.searchButton.AutoSize = true;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(613, 2);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(93, 34);
            this.searchButton.TabIndex = 30;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(247, 4);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(199, 30);
            this.nameTextBox.TabIndex = 10;
            this.nameTextBox.Tag = "";
            // 
            // visitDateTimePicker
            // 
            this.visitDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.visitDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.visitDateTimePicker.Location = new System.Drawing.Point(453, 4);
            this.visitDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.visitDateTimePicker.Name = "visitDateTimePicker";
            this.visitDateTimePicker.Size = new System.Drawing.Size(152, 30);
            this.visitDateTimePicker.TabIndex = 20;
            this.visitDateTimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VisitDateTimePicker_KeyDown);
            // 
            // visitListView
            // 
            this.visitListView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.visitListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumnHeader,
            this.dobColumnHeader,
            this.doctorColumnHeader,
            this.nurseColumnHeader,
            this.dateColumnHeader,
            this.viewColumnHeader,
            this.editColumnHeader,
            this.deleteColumnHeader});
            this.visitListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitListView.HideSelection = false;
            this.visitListView.Location = new System.Drawing.Point(13, 117);
            this.visitListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.visitListView.Name = "visitListView";
            this.visitListView.Size = new System.Drawing.Size(693, 243);
            this.visitListView.TabIndex = 40;
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
            // viewColumnHeader
            // 
            this.viewColumnHeader.Text = "View";
            this.viewColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.viewColumnHeader.Width = 80;
            // 
            // editColumnHeader
            // 
            this.editColumnHeader.Text = "Edit";
            this.editColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.editColumnHeader.Width = 80;
            // 
            // deleteColumnHeader
            // 
            this.deleteColumnHeader.Text = "Delete";
            this.deleteColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deleteColumnHeader.Width = 80;
            // 
            // VisitUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.visitTableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VisitUserControl";
            this.Size = new System.Drawing.Size(732, 378);
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
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ListView visitListView;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader dobColumnHeader;
        private System.Windows.Forms.ColumnHeader doctorColumnHeader;
        private System.Windows.Forms.ColumnHeader nurseColumnHeader;
        private System.Windows.Forms.ColumnHeader dateColumnHeader;
        private System.Windows.Forms.ColumnHeader viewColumnHeader;
        private System.Windows.Forms.ColumnHeader editColumnHeader;
        private System.Windows.Forms.ColumnHeader deleteColumnHeader;
        private System.Windows.Forms.DateTimePicker visitDateTimePicker;
    }
}

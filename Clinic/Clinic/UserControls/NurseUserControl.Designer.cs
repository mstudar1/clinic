
namespace Clinic.UserControls
{
    partial class NurseUserControl
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
            this.nurseTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.addNurseTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.addNurseButton = new System.Windows.Forms.Button();
            this.titleAndResetTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.resetButton = new System.Windows.Forms.Button();
            this.listOfNursesLabel = new System.Windows.Forms.Label();
            this.searchTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.searchButton = new System.Windows.Forms.Button();
            this.nurseNameTextBox = new System.Windows.Forms.TextBox();
            this.NursListView = new System.Windows.Forms.ListView();
            this.firstNameClumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastNameClumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dobColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.editColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deleteColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nurseTableLayoutPanel.SuspendLayout();
            this.addNurseTableLayoutPanel.SuspendLayout();
            this.titleAndResetTableLayoutPanel.SuspendLayout();
            this.searchTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // nurseTableLayoutPanel
            // 
            this.nurseTableLayoutPanel.ColumnCount = 1;
            this.nurseTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.nurseTableLayoutPanel.Controls.Add(this.addNurseTableLayoutPanel, 0, 1);
            this.nurseTableLayoutPanel.Controls.Add(this.titleAndResetTableLayoutPanel, 0, 2);
            this.nurseTableLayoutPanel.Controls.Add(this.searchTableLayoutPanel, 0, 0);
            this.nurseTableLayoutPanel.Controls.Add(this.NursListView, 0, 3);
            this.nurseTableLayoutPanel.Location = new System.Drawing.Point(3, 2);
            this.nurseTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nurseTableLayoutPanel.Name = "nurseTableLayoutPanel";
            this.nurseTableLayoutPanel.RowCount = 4;
            this.nurseTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.74725F));
            this.nurseTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.25275F));
            this.nurseTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.nurseTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 246F));
            this.nurseTableLayoutPanel.Size = new System.Drawing.Size(719, 362);
            this.nurseTableLayoutPanel.TabIndex = 0;
            // 
            // addNurseTableLayoutPanel
            // 
            this.addNurseTableLayoutPanel.ColumnCount = 2;
            this.addNurseTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.847736F));
            this.addNurseTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.15226F));
            this.addNurseTableLayoutPanel.Controls.Add(this.addNurseButton, 1, 0);
            this.addNurseTableLayoutPanel.Location = new System.Drawing.Point(3, 43);
            this.addNurseTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addNurseTableLayoutPanel.Name = "addNurseTableLayoutPanel";
            this.addNurseTableLayoutPanel.RowCount = 1;
            this.addNurseTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.addNurseTableLayoutPanel.Size = new System.Drawing.Size(713, 32);
            this.addNurseTableLayoutPanel.TabIndex = 20;
            // 
            // addNurseButton
            // 
            this.addNurseButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addNurseButton.AutoSize = true;
            this.addNurseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNurseButton.Location = new System.Drawing.Point(66, 2);
            this.addNurseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addNurseButton.Name = "addNurseButton";
            this.addNurseButton.Size = new System.Drawing.Size(153, 28);
            this.addNurseButton.TabIndex = 10;
            this.addNurseButton.Text = "Add Nurse";
            this.addNurseButton.UseVisualStyleBackColor = true;
            this.addNurseButton.Click += new System.EventHandler(this.RegisterNurseButton_Click);
            // 
            // titleAndResetTableLayoutPanel
            // 
            this.titleAndResetTableLayoutPanel.ColumnCount = 3;
            this.titleAndResetTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.87248F));
            this.titleAndResetTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.12752F));
            this.titleAndResetTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.titleAndResetTableLayoutPanel.Controls.Add(this.resetButton, 1, 0);
            this.titleAndResetTableLayoutPanel.Controls.Add(this.listOfNursesLabel, 0, 0);
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
            // 
            // listOfNursesLabel
            // 
            this.listOfNursesLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.listOfNursesLabel.AutoSize = true;
            this.listOfNursesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOfNursesLabel.Location = new System.Drawing.Point(17, 3);
            this.listOfNursesLabel.Name = "listOfNursesLabel";
            this.listOfNursesLabel.Size = new System.Drawing.Size(168, 29);
            this.listOfNursesLabel.TabIndex = 99;
            this.listOfNursesLabel.Text = "List of Nurses";
            // 
            // searchTableLayoutPanel
            // 
            this.searchTableLayoutPanel.ColumnCount = 4;
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 239F));
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.searchTableLayoutPanel.Controls.Add(this.searchButton, 3, 0);
            this.searchTableLayoutPanel.Controls.Add(this.nurseNameTextBox, 2, 0);
            this.searchTableLayoutPanel.Location = new System.Drawing.Point(3, 2);
            this.searchTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchTableLayoutPanel.Name = "searchTableLayoutPanel";
            this.searchTableLayoutPanel.RowCount = 1;
            this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchTableLayoutPanel.Size = new System.Drawing.Size(713, 36);
            this.searchTableLayoutPanel.TabIndex = 10;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.searchButton.AutoSize = true;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(608, 2);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(101, 32);
            this.searchButton.TabIndex = 20;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // nurseNameTextBox
            // 
            this.nurseNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nurseNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nurseNameTextBox.Location = new System.Drawing.Point(369, 3);
            this.nurseNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nurseNameTextBox.Name = "nurseNameTextBox";
            this.nurseNameTextBox.Size = new System.Drawing.Size(221, 30);
            this.nurseNameTextBox.TabIndex = 10;
            this.nurseNameTextBox.Tag = "";
            this.nurseNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NurseNameTextBox_KeyDown);
            // 
            // NursListView
            // 
            this.NursListView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.NursListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.firstNameClumnHeader,
            this.lastNameClumnHeader,
            this.dobColumnHeader,
            this.viewColumnHeader,
            this.editColumnHeader,
            this.deleteColumnHeader});
            this.NursListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NursListView.HideSelection = false;
            this.NursListView.Location = new System.Drawing.Point(13, 117);
            this.NursListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NursListView.Name = "NursListView";
            this.NursListView.Size = new System.Drawing.Size(693, 243);
            this.NursListView.TabIndex = 40;
            this.NursListView.TabStop = false;
            this.NursListView.UseCompatibleStateImageBehavior = false;
            this.NursListView.View = System.Windows.Forms.View.Details;
            // 
            // firstNameClumnHeader
            // 
            this.firstNameClumnHeader.Text = "First Name";
            this.firstNameClumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.firstNameClumnHeader.Width = 200;
            // 
            // lastNameClumnHeader
            // 
            this.lastNameClumnHeader.Text = "Last Name";
            this.lastNameClumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lastNameClumnHeader.Width = 200;
            // 
            // dobColumnHeader
            // 
            this.dobColumnHeader.Text = "DOB";
            this.dobColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dobColumnHeader.Width = 160;
            // 
            // viewColumnHeader
            // 
            this.viewColumnHeader.Text = "View";
            this.viewColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.viewColumnHeader.Width = 100;
            // 
            // editColumnHeader
            // 
            this.editColumnHeader.Text = "Edit";
            this.editColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.editColumnHeader.Width = 100;
            // 
            // deleteColumnHeader
            // 
            this.deleteColumnHeader.Text = "Delete";
            this.deleteColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deleteColumnHeader.Width = 100;
            // 
            // NurseUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nurseTableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NurseUserControl";
            this.Size = new System.Drawing.Size(736, 388);
            this.nurseTableLayoutPanel.ResumeLayout(false);
            this.addNurseTableLayoutPanel.ResumeLayout(false);
            this.addNurseTableLayoutPanel.PerformLayout();
            this.titleAndResetTableLayoutPanel.ResumeLayout(false);
            this.titleAndResetTableLayoutPanel.PerformLayout();
            this.searchTableLayoutPanel.ResumeLayout(false);
            this.searchTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel nurseTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel addNurseTableLayoutPanel;
        private System.Windows.Forms.Button addNurseButton;
        private System.Windows.Forms.TableLayoutPanel titleAndResetTableLayoutPanel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label listOfNursesLabel;
        private System.Windows.Forms.ListView NursListView;
        private System.Windows.Forms.ColumnHeader firstNameClumnHeader;
        private System.Windows.Forms.ColumnHeader lastNameClumnHeader;
        private System.Windows.Forms.ColumnHeader dobColumnHeader;
        private System.Windows.Forms.ColumnHeader viewColumnHeader;
        private System.Windows.Forms.ColumnHeader editColumnHeader;
        private System.Windows.Forms.ColumnHeader deleteColumnHeader;
        private System.Windows.Forms.TableLayoutPanel searchTableLayoutPanel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox nurseNameTextBox;
    }
}

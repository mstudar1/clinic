﻿
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
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.searchNameLabel = new System.Windows.Forms.Label();
            this.nurseListView = new System.Windows.Forms.ListView();
            this.firstNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dobColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ststusColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.editViewTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.viewNurseButton = new System.Windows.Forms.Button();
            this.editNurseButton = new System.Windows.Forms.Button();
            this.alertTextLabel = new System.Windows.Forms.Label();
            this.nurseTableLayoutPanel.SuspendLayout();
            this.addNurseTableLayoutPanel.SuspendLayout();
            this.titleAndResetTableLayoutPanel.SuspendLayout();
            this.searchTableLayoutPanel.SuspendLayout();
            this.editViewTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // nurseTableLayoutPanel
            // 
            this.nurseTableLayoutPanel.ColumnCount = 1;
            this.nurseTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.nurseTableLayoutPanel.Controls.Add(this.addNurseTableLayoutPanel, 0, 1);
            this.nurseTableLayoutPanel.Controls.Add(this.titleAndResetTableLayoutPanel, 0, 2);
            this.nurseTableLayoutPanel.Controls.Add(this.searchTableLayoutPanel, 0, 0);
            this.nurseTableLayoutPanel.Controls.Add(this.nurseListView, 0, 3);
            this.nurseTableLayoutPanel.Controls.Add(this.editViewTableLayoutPanel, 0, 4);
            this.nurseTableLayoutPanel.Controls.Add(this.alertTextLabel, 0, 5);
            this.nurseTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.nurseTableLayoutPanel.Name = "nurseTableLayoutPanel";
            this.nurseTableLayoutPanel.RowCount = 6;
            this.nurseTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.nurseTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.nurseTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.nurseTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 194F));
            this.nurseTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.nurseTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.nurseTableLayoutPanel.Size = new System.Drawing.Size(808, 452);
            this.nurseTableLayoutPanel.TabIndex = 0;
            // 
            // addNurseTableLayoutPanel
            // 
            this.addNurseTableLayoutPanel.ColumnCount = 2;
            this.addNurseTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.738318F));
            this.addNurseTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.26168F));
            this.addNurseTableLayoutPanel.Controls.Add(this.addNurseButton, 1, 0);
            this.addNurseTableLayoutPanel.Location = new System.Drawing.Point(3, 57);
            this.addNurseTableLayoutPanel.Name = "addNurseTableLayoutPanel";
            this.addNurseTableLayoutPanel.RowCount = 1;
            this.addNurseTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.addNurseTableLayoutPanel.Size = new System.Drawing.Size(802, 48);
            this.addNurseTableLayoutPanel.TabIndex = 20;
            // 
            // addNurseButton
            // 
            this.addNurseButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addNurseButton.AutoSize = true;
            this.addNurseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNurseButton.Location = new System.Drawing.Point(32, 4);
            this.addNurseButton.Name = "addNurseButton";
            this.addNurseButton.Size = new System.Drawing.Size(322, 39);
            this.addNurseButton.TabIndex = 10;
            this.addNurseButton.Text = "Add New Nurse";
            this.addNurseButton.UseVisualStyleBackColor = true;
            this.addNurseButton.Click += new System.EventHandler(this.RegisterNurseButton_Click);
            // 
            // titleAndResetTableLayoutPanel
            // 
            this.titleAndResetTableLayoutPanel.ColumnCount = 3;
            this.titleAndResetTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.87248F));
            this.titleAndResetTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.12752F));
            this.titleAndResetTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.titleAndResetTableLayoutPanel.Controls.Add(this.resetButton, 1, 0);
            this.titleAndResetTableLayoutPanel.Controls.Add(this.listOfNursesLabel, 0, 0);
            this.titleAndResetTableLayoutPanel.Location = new System.Drawing.Point(3, 111);
            this.titleAndResetTableLayoutPanel.Name = "titleAndResetTableLayoutPanel";
            this.titleAndResetTableLayoutPanel.RowCount = 1;
            this.titleAndResetTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.titleAndResetTableLayoutPanel.Size = new System.Drawing.Size(797, 62);
            this.titleAndResetTableLayoutPanel.TabIndex = 30;
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resetButton.AutoSize = true;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(589, 20);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(129, 39);
            this.resetButton.TabIndex = 10;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // listOfNursesLabel
            // 
            this.listOfNursesLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.listOfNursesLabel.AutoSize = true;
            this.listOfNursesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOfNursesLabel.Location = new System.Drawing.Point(12, 26);
            this.listOfNursesLabel.Name = "listOfNursesLabel";
            this.listOfNursesLabel.Size = new System.Drawing.Size(198, 36);
            this.listOfNursesLabel.TabIndex = 99;
            this.listOfNursesLabel.Text = "List of Nurses";
            // 
            // searchTableLayoutPanel
            // 
            this.searchTableLayoutPanel.ColumnCount = 4;
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.87591F));
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.12409F));
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 268F));
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.searchTableLayoutPanel.Controls.Add(this.searchButton, 3, 0);
            this.searchTableLayoutPanel.Controls.Add(this.lastNameTextBox, 2, 0);
            this.searchTableLayoutPanel.Controls.Add(this.searchNameLabel, 1, 0);
            this.searchTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.searchTableLayoutPanel.Name = "searchTableLayoutPanel";
            this.searchTableLayoutPanel.RowCount = 1;
            this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.searchTableLayoutPanel.Size = new System.Drawing.Size(802, 45);
            this.searchTableLayoutPanel.TabIndex = 10;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.searchButton.AutoSize = true;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(675, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(122, 39);
            this.searchButton.TabIndex = 20;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(407, 5);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(248, 35);
            this.lastNameTextBox.TabIndex = 10;
            this.lastNameTextBox.Tag = "";
            this.lastNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NurseNameTextBox_KeyDown);
            // 
            // searchNameLabel
            // 
            this.searchNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.searchNameLabel.AutoSize = true;
            this.searchNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchNameLabel.Location = new System.Drawing.Point(201, 9);
            this.searchNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchNameLabel.Name = "searchNameLabel";
            this.searchNameLabel.Size = new System.Drawing.Size(199, 26);
            this.searchNameLabel.TabIndex = 21;
            this.searchNameLabel.Text = "Search Last Name:";
            // 
            // nurseListView
            // 
            this.nurseListView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nurseListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.firstNameColumnHeader,
            this.lastNameColumnHeader,
            this.dobColumnHeader,
            this.ststusColumnHeader});
            this.nurseListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nurseListView.FullRowSelect = true;
            this.nurseListView.HideSelection = false;
            this.nurseListView.Location = new System.Drawing.Point(9, 179);
            this.nurseListView.MultiSelect = false;
            this.nurseListView.Name = "nurseListView";
            this.nurseListView.Size = new System.Drawing.Size(790, 188);
            this.nurseListView.TabIndex = 40;
            this.nurseListView.TabStop = false;
            this.nurseListView.UseCompatibleStateImageBehavior = false;
            this.nurseListView.View = System.Windows.Forms.View.Details;
            // 
            // firstNameColumnHeader
            // 
            this.firstNameColumnHeader.Text = "First Name";
            this.firstNameColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.firstNameColumnHeader.Width = 200;
            // 
            // lastNameColumnHeader
            // 
            this.lastNameColumnHeader.Text = "Last Name";
            this.lastNameColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lastNameColumnHeader.Width = 200;
            // 
            // dobColumnHeader
            // 
            this.dobColumnHeader.Text = "DOB";
            this.dobColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dobColumnHeader.Width = 160;
            // 
            // ststusColumnHeader
            // 
            this.ststusColumnHeader.Text = "Status";
            this.ststusColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ststusColumnHeader.Width = 150;
            // 
            // editViewTableLayoutPanel
            // 
            this.editViewTableLayoutPanel.ColumnCount = 2;
            this.editViewTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.editViewTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.editViewTableLayoutPanel.Controls.Add(this.viewNurseButton, 0, 0);
            this.editViewTableLayoutPanel.Controls.Add(this.editNurseButton, 1, 0);
            this.editViewTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editViewTableLayoutPanel.Location = new System.Drawing.Point(4, 375);
            this.editViewTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editViewTableLayoutPanel.Name = "editViewTableLayoutPanel";
            this.editViewTableLayoutPanel.RowCount = 1;
            this.editViewTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.editViewTableLayoutPanel.Size = new System.Drawing.Size(800, 48);
            this.editViewTableLayoutPanel.TabIndex = 41;
            // 
            // viewNurseButton
            // 
            this.viewNurseButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.viewNurseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewNurseButton.Location = new System.Drawing.Point(34, 5);
            this.viewNurseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewNurseButton.Name = "viewNurseButton";
            this.viewNurseButton.Size = new System.Drawing.Size(332, 38);
            this.viewNurseButton.TabIndex = 0;
            this.viewNurseButton.Text = "View Nurse Details";
            this.viewNurseButton.UseVisualStyleBackColor = true;
            this.viewNurseButton.Click += new System.EventHandler(this.ViewNurseButton_Click);
            // 
            // editNurseButton
            // 
            this.editNurseButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.editNurseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editNurseButton.Location = new System.Drawing.Point(429, 5);
            this.editNurseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editNurseButton.Name = "editNurseButton";
            this.editNurseButton.Size = new System.Drawing.Size(341, 38);
            this.editNurseButton.TabIndex = 1;
            this.editNurseButton.Text = "Edit Nurse Information";
            this.editNurseButton.UseVisualStyleBackColor = true;
            this.editNurseButton.Click += new System.EventHandler(this.EditNurseButton_Click);
            // 
            // alertTextLabel
            // 
            this.alertTextLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.alertTextLabel.AutoSize = true;
            this.alertTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertTextLabel.ForeColor = System.Drawing.Color.Red;
            this.alertTextLabel.Location = new System.Drawing.Point(404, 428);
            this.alertTextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.alertTextLabel.Name = "alertTextLabel";
            this.alertTextLabel.Size = new System.Drawing.Size(0, 24);
            this.alertTextLabel.TabIndex = 42;
            // 
            // NurseUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nurseTableLayoutPanel);
            this.Name = "NurseUserControl";
            this.Size = new System.Drawing.Size(828, 485);
            this.nurseTableLayoutPanel.ResumeLayout(false);
            this.nurseTableLayoutPanel.PerformLayout();
            this.addNurseTableLayoutPanel.ResumeLayout(false);
            this.addNurseTableLayoutPanel.PerformLayout();
            this.titleAndResetTableLayoutPanel.ResumeLayout(false);
            this.titleAndResetTableLayoutPanel.PerformLayout();
            this.searchTableLayoutPanel.ResumeLayout(false);
            this.searchTableLayoutPanel.PerformLayout();
            this.editViewTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel nurseTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel addNurseTableLayoutPanel;
        private System.Windows.Forms.Button addNurseButton;
        private System.Windows.Forms.TableLayoutPanel titleAndResetTableLayoutPanel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label listOfNursesLabel;
        private System.Windows.Forms.ListView nurseListView;
        private System.Windows.Forms.ColumnHeader firstNameColumnHeader;
        private System.Windows.Forms.ColumnHeader lastNameColumnHeader;
        private System.Windows.Forms.ColumnHeader dobColumnHeader;
        private System.Windows.Forms.TableLayoutPanel searchTableLayoutPanel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TableLayoutPanel editViewTableLayoutPanel;
        private System.Windows.Forms.Button viewNurseButton;
        private System.Windows.Forms.Button editNurseButton;
        private System.Windows.Forms.Label searchNameLabel;
        private System.Windows.Forms.Label alertTextLabel;
        private System.Windows.Forms.ColumnHeader ststusColumnHeader;
    }
}

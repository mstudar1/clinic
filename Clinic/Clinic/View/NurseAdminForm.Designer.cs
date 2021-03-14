
namespace Clinic.View
{
    partial class NurseAdminForm
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
            this.activeUsernameLabel = new System.Windows.Forms.Label();
            this.nurseAdminTabControl = new System.Windows.Forms.TabControl();
            this.nurseTabPage = new System.Windows.Forms.TabPage();
            this.logoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.nurse1 = new Clinic.UserControls.Nurse();
            this.nurseAdminTabControl.SuspendLayout();
            this.nurseTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // activeUsernameLabel
            // 
            this.activeUsernameLabel.AutoSize = true;
            this.activeUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeUsernameLabel.Location = new System.Drawing.Point(1168, 29);
            this.activeUsernameLabel.Name = "activeUsernameLabel";
            this.activeUsernameLabel.Size = new System.Drawing.Size(21, 30);
            this.activeUsernameLabel.TabIndex = 0;
            this.activeUsernameLabel.Text = ".";
            // 
            // nurseAdminTabControl
            // 
            this.nurseAdminTabControl.Controls.Add(this.nurseTabPage);
            this.nurseAdminTabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nurseAdminTabControl.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nurseAdminTabControl.Location = new System.Drawing.Point(0, 94);
            this.nurseAdminTabControl.Name = "nurseAdminTabControl";
            this.nurseAdminTabControl.SelectedIndex = 0;
            this.nurseAdminTabControl.Size = new System.Drawing.Size(1478, 850);
            this.nurseAdminTabControl.TabIndex = 2;
            this.nurseAdminTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.RefreshNurseList);
            // 
            // nurseTabPage
            // 
            this.nurseTabPage.Controls.Add(this.nurse1);
            this.nurseTabPage.Location = new System.Drawing.Point(4, 42);
            this.nurseTabPage.Name = "nurseTabPage";
            this.nurseTabPage.Size = new System.Drawing.Size(1470, 804);
            this.nurseTabPage.TabIndex = 0;
            this.nurseTabPage.Text = "Nurse";
            this.nurseTabPage.UseVisualStyleBackColor = true;
            // 
            // logoutLinkLabel
            // 
            this.logoutLinkLabel.AutoSize = true;
            this.logoutLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLinkLabel.Location = new System.Drawing.Point(1316, 29);
            this.logoutLinkLabel.Name = "logoutLinkLabel";
            this.logoutLinkLabel.Size = new System.Drawing.Size(96, 30);
            this.logoutLinkLabel.TabIndex = 3;
            this.logoutLinkLabel.TabStop = true;
            this.logoutLinkLabel.Text = "Logout";
            this.logoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLink_LinkClicked);
            // 
            // nurse1
            // 
            this.nurse1.Location = new System.Drawing.Point(10, 8);
            this.nurse1.Margin = new System.Windows.Forms.Padding(5);
            this.nurse1.Name = "nurse1";
            this.nurse1.Size = new System.Drawing.Size(1450, 786);
            this.nurse1.TabIndex = 0;
            // 
            // NurseAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 944);
            this.Controls.Add(this.logoutLinkLabel);
            this.Controls.Add(this.nurseAdminTabControl);
            this.Controls.Add(this.activeUsernameLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NurseAdminForm";
            this.Text = "Nurse/Admin Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ApplicationFormsClosing);
            this.nurseAdminTabControl.ResumeLayout(false);
            this.nurseTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label activeUsernameLabel;
        private System.Windows.Forms.TabControl nurseAdminTabControl;
        private System.Windows.Forms.TabPage nurseTabPage;
        private UserControls.Nurse nurse1;
        private System.Windows.Forms.LinkLabel logoutLinkLabel;
    }
}
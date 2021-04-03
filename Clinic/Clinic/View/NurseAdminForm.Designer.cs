
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
            this.nurseAdminTabControl = new System.Windows.Forms.TabControl();
            this.appointmentTabPage = new System.Windows.Forms.TabPage();
            this.appointmentUserControl1 = new Clinic.UserControls.AppointmentUserControl();
            this.visitTabPage = new System.Windows.Forms.TabPage();
            this.visitUserControl1 = new Clinic.UserControls.VisitUserControl();
            this.patientTabPage = new System.Windows.Forms.TabPage();
            this.patientUserControl1 = new Clinic.UserControls.PatientUserControl();
            this.nurseTabPage = new System.Windows.Forms.TabPage();
            this.nurse1 = new Clinic.UserControls.NurseUserControl();
            this.logoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.activeUsernameLabel = new System.Windows.Forms.Label();
            this.nurseAdminTabControl.SuspendLayout();
            this.appointmentTabPage.SuspendLayout();
            this.visitTabPage.SuspendLayout();
            this.patientTabPage.SuspendLayout();
            this.nurseTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // nurseAdminTabControl
            // 
            this.nurseAdminTabControl.Controls.Add(this.appointmentTabPage);
            this.nurseAdminTabControl.Controls.Add(this.visitTabPage);
            this.nurseAdminTabControl.Controls.Add(this.patientTabPage);
            this.nurseAdminTabControl.Controls.Add(this.nurseTabPage);
            this.nurseAdminTabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nurseAdminTabControl.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nurseAdminTabControl.ItemSize = new System.Drawing.Size(200, 40);
            this.nurseAdminTabControl.Location = new System.Drawing.Point(0, 54);
            this.nurseAdminTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nurseAdminTabControl.Name = "nurseAdminTabControl";
            this.nurseAdminTabControl.SelectedIndex = 0;
            this.nurseAdminTabControl.Size = new System.Drawing.Size(1314, 701);
            this.nurseAdminTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.nurseAdminTabControl.TabIndex = 2;
            this.nurseAdminTabControl.TabStop = false;
            this.nurseAdminTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.RefreshNurseList);
            // 
            // appointmentTabPage
            // 
            this.appointmentTabPage.Controls.Add(this.appointmentUserControl1);
            this.appointmentTabPage.Location = new System.Drawing.Point(4, 44);
            this.appointmentTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.appointmentTabPage.Name = "appointmentTabPage";
            this.appointmentTabPage.Size = new System.Drawing.Size(1306, 653);
            this.appointmentTabPage.TabIndex = 1;
            this.appointmentTabPage.Text = "Appointments";
            this.appointmentTabPage.UseVisualStyleBackColor = true;
            // 
            // appointmentUserControl1
            // 
            this.appointmentUserControl1.Location = new System.Drawing.Point(2, 2);
            this.appointmentUserControl1.Margin = new System.Windows.Forms.Padding(4);
            this.appointmentUserControl1.Name = "appointmentUserControl1";
            this.appointmentUserControl1.Size = new System.Drawing.Size(1305, 660);
            this.appointmentUserControl1.TabIndex = 0;
            // 
            // visitTabPage
            // 
            this.visitTabPage.Controls.Add(this.visitUserControl1);
            this.visitTabPage.Location = new System.Drawing.Point(4, 44);
            this.visitTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.visitTabPage.Name = "visitTabPage";
            this.visitTabPage.Size = new System.Drawing.Size(1306, 653);
            this.visitTabPage.TabIndex = 2;
            this.visitTabPage.Text = "Visits";
            this.visitTabPage.UseVisualStyleBackColor = true;
            // 
            // visitUserControl1
            // 
            this.visitUserControl1.Location = new System.Drawing.Point(3, 2);
            this.visitUserControl1.Margin = new System.Windows.Forms.Padding(4);
            this.visitUserControl1.Name = "visitUserControl1";
            this.visitUserControl1.Size = new System.Drawing.Size(1304, 661);
            this.visitUserControl1.TabIndex = 0;
            // 
            // patientTabPage
            // 
            this.patientTabPage.Controls.Add(this.patientUserControl1);
            this.patientTabPage.Location = new System.Drawing.Point(4, 44);
            this.patientTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.patientTabPage.Name = "patientTabPage";
            this.patientTabPage.Size = new System.Drawing.Size(1306, 653);
            this.patientTabPage.TabIndex = 3;
            this.patientTabPage.Text = "Patients";
            this.patientTabPage.UseVisualStyleBackColor = true;
            // 
            // patientUserControl1
            // 
            this.patientUserControl1.Location = new System.Drawing.Point(3, 2);
            this.patientUserControl1.Margin = new System.Windows.Forms.Padding(4);
            this.patientUserControl1.Name = "patientUserControl1";
            this.patientUserControl1.Size = new System.Drawing.Size(1304, 661);
            this.patientUserControl1.TabIndex = 0;
            // 
            // nurseTabPage
            // 
            this.nurseTabPage.Controls.Add(this.nurse1);
            this.nurseTabPage.Location = new System.Drawing.Point(4, 44);
            this.nurseTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nurseTabPage.Name = "nurseTabPage";
            this.nurseTabPage.Size = new System.Drawing.Size(1306, 653);
            this.nurseTabPage.TabIndex = 0;
            this.nurseTabPage.Text = "Nurses";
            this.nurseTabPage.UseVisualStyleBackColor = true;
            // 
            // nurse1
            // 
            this.nurse1.Location = new System.Drawing.Point(2, 2);
            this.nurse1.Margin = new System.Windows.Forms.Padding(4);
            this.nurse1.Name = "nurse1";
            this.nurse1.Size = new System.Drawing.Size(1305, 660);
            this.nurse1.TabIndex = 0;
            // 
            // logoutLinkLabel
            // 
            this.logoutLinkLabel.AutoSize = true;
            this.logoutLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLinkLabel.Location = new System.Drawing.Point(1184, 15);
            this.logoutLinkLabel.Name = "logoutLinkLabel";
            this.logoutLinkLabel.Size = new System.Drawing.Size(84, 26);
            this.logoutLinkLabel.TabIndex = 3;
            this.logoutLinkLabel.Text = "Logout";
            this.logoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLink_LinkClicked);
            // 
            // activeUsernameLabel
            // 
            this.activeUsernameLabel.AutoSize = true;
            this.activeUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeUsernameLabel.Location = new System.Drawing.Point(1041, 15);
            this.activeUsernameLabel.Name = "activeUsernameLabel";
            this.activeUsernameLabel.Size = new System.Drawing.Size(18, 26);
            this.activeUsernameLabel.TabIndex = 0;
            this.activeUsernameLabel.Text = ".";
            // 
            // NurseAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 755);
            this.Controls.Add(this.logoutLinkLabel);
            this.Controls.Add(this.nurseAdminTabControl);
            this.Controls.Add(this.activeUsernameLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NurseAdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nurse/Admin Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ApplicationFormsClosing);
            this.nurseAdminTabControl.ResumeLayout(false);
            this.appointmentTabPage.ResumeLayout(false);
            this.visitTabPage.ResumeLayout(false);
            this.patientTabPage.ResumeLayout(false);
            this.nurseTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl nurseAdminTabControl;
        private System.Windows.Forms.TabPage nurseTabPage;
        private UserControls.NurseUserControl nurse1;
        private System.Windows.Forms.LinkLabel logoutLinkLabel;
        private System.Windows.Forms.TabPage appointmentTabPage;
        private System.Windows.Forms.TabPage visitTabPage;
        private System.Windows.Forms.TabPage patientTabPage;
        private UserControls.PatientUserControl patientUserControl1;
        private UserControls.VisitUserControl visitUserControl1;
        private System.Windows.Forms.Label activeUsernameLabel;
        private UserControls.AppointmentUserControl appointmentUserControl1;
    }
}
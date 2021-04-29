
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
            this.visitTabPage = new System.Windows.Forms.TabPage();
            this.patientTabPage = new System.Windows.Forms.TabPage();
            this.nurseTabPage = new System.Windows.Forms.TabPage();
            this.logoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.activeUsernameLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.reportTabPage = new System.Windows.Forms.TabPage();
            this.appointmentUserControl1 = new Clinic.UserControls.AppointmentUserControl();
            this.visitUserControl1 = new Clinic.UserControls.VisitUserControl();
            this.patientUserControl1 = new Clinic.UserControls.PatientUserControl();
            this.nurse1 = new Clinic.UserControls.NurseUserControl();
            this.reportUserControl1 = new Clinic.UserControls.ReportUserControl();
            this.nurseAdminTabControl.SuspendLayout();
            this.appointmentTabPage.SuspendLayout();
            this.visitTabPage.SuspendLayout();
            this.patientTabPage.SuspendLayout();
            this.nurseTabPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.reportTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // nurseAdminTabControl
            // 
            this.nurseAdminTabControl.Controls.Add(this.appointmentTabPage);
            this.nurseAdminTabControl.Controls.Add(this.visitTabPage);
            this.nurseAdminTabControl.Controls.Add(this.patientTabPage);
            this.nurseAdminTabControl.Controls.Add(this.nurseTabPage);
            this.nurseAdminTabControl.Controls.Add(this.reportTabPage);
            this.nurseAdminTabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nurseAdminTabControl.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nurseAdminTabControl.ItemSize = new System.Drawing.Size(200, 40);
            this.nurseAdminTabControl.Location = new System.Drawing.Point(0, 98);
            this.nurseAdminTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nurseAdminTabControl.Name = "nurseAdminTabControl";
            this.nurseAdminTabControl.SelectedIndex = 0;
            this.nurseAdminTabControl.Size = new System.Drawing.Size(1518, 847);
            this.nurseAdminTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.nurseAdminTabControl.TabIndex = 2;
            this.nurseAdminTabControl.TabStop = false;
            // 
            // appointmentTabPage
            // 
            this.appointmentTabPage.Controls.Add(this.appointmentUserControl1);
            this.appointmentTabPage.Location = new System.Drawing.Point(4, 44);
            this.appointmentTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.appointmentTabPage.Name = "appointmentTabPage";
            this.appointmentTabPage.Size = new System.Drawing.Size(1510, 827);
            this.appointmentTabPage.TabIndex = 1;
            this.appointmentTabPage.Text = "Appointments";
            this.appointmentTabPage.UseVisualStyleBackColor = true;
            // 
            // visitTabPage
            // 
            this.visitTabPage.Controls.Add(this.visitUserControl1);
            this.visitTabPage.Location = new System.Drawing.Point(4, 44);
            this.visitTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.visitTabPage.Name = "visitTabPage";
            this.visitTabPage.Size = new System.Drawing.Size(1510, 827);
            this.visitTabPage.TabIndex = 2;
            this.visitTabPage.Text = "Visits";
            this.visitTabPage.UseVisualStyleBackColor = true;
            // 
            // patientTabPage
            // 
            this.patientTabPage.Controls.Add(this.patientUserControl1);
            this.patientTabPage.Location = new System.Drawing.Point(4, 44);
            this.patientTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.patientTabPage.Name = "patientTabPage";
            this.patientTabPage.Size = new System.Drawing.Size(1510, 827);
            this.patientTabPage.TabIndex = 3;
            this.patientTabPage.Text = "Patients";
            this.patientTabPage.UseVisualStyleBackColor = true;
            // 
            // nurseTabPage
            // 
            this.nurseTabPage.Controls.Add(this.nurse1);
            this.nurseTabPage.Location = new System.Drawing.Point(4, 44);
            this.nurseTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nurseTabPage.Name = "nurseTabPage";
            this.nurseTabPage.Size = new System.Drawing.Size(1510, 827);
            this.nurseTabPage.TabIndex = 0;
            this.nurseTabPage.Text = "Nurses";
            this.nurseTabPage.UseVisualStyleBackColor = true;
            // 
            // logoutLinkLabel
            // 
            this.logoutLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutLinkLabel.AutoSize = true;
            this.logoutLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLinkLabel.Location = new System.Drawing.Point(189, 44);
            this.logoutLinkLabel.Name = "logoutLinkLabel";
            this.logoutLinkLabel.Size = new System.Drawing.Size(78, 25);
            this.logoutLinkLabel.TabIndex = 3;
            this.logoutLinkLabel.TabStop = true;
            this.logoutLinkLabel.Text = "Logout";
            this.logoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLink_LinkClicked);
            // 
            // activeUsernameLabel
            // 
            this.activeUsernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.activeUsernameLabel.AutoSize = true;
            this.activeUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeUsernameLabel.Location = new System.Drawing.Point(250, 19);
            this.activeUsernameLabel.Name = "activeUsernameLabel";
            this.activeUsernameLabel.Size = new System.Drawing.Size(17, 25);
            this.activeUsernameLabel.TabIndex = 0;
            this.activeUsernameLabel.Text = ".";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.logoutLinkLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.activeUsernameLabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1202, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(270, 88);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // reportTabPage
            // 
            this.reportTabPage.Controls.Add(this.reportUserControl1);
            this.reportTabPage.Location = new System.Drawing.Point(4, 44);
            this.reportTabPage.Name = "reportTabPage";
            this.reportTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.reportTabPage.Size = new System.Drawing.Size(1510, 799);
            this.reportTabPage.TabIndex = 4;
            this.reportTabPage.Text = "Report";
            this.reportTabPage.UseVisualStyleBackColor = true;
            // 
            // appointmentUserControl1
            // 
            this.appointmentUserControl1.Location = new System.Drawing.Point(2, 2);
            this.appointmentUserControl1.Margin = new System.Windows.Forms.Padding(2);
            this.appointmentUserControl1.Name = "appointmentUserControl1";
            this.appointmentUserControl1.Size = new System.Drawing.Size(1468, 825);
            this.appointmentUserControl1.TabIndex = 0;
            // 
            // visitUserControl1
            // 
            this.visitUserControl1.Location = new System.Drawing.Point(3, 2);
            this.visitUserControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.visitUserControl1.Name = "visitUserControl1";
            this.visitUserControl1.Size = new System.Drawing.Size(1467, 826);
            this.visitUserControl1.TabIndex = 0;
            // 
            // patientUserControl1
            // 
            this.patientUserControl1.Location = new System.Drawing.Point(3, 2);
            this.patientUserControl1.Margin = new System.Windows.Forms.Padding(2);
            this.patientUserControl1.Name = "patientUserControl1";
            this.patientUserControl1.Size = new System.Drawing.Size(1467, 826);
            this.patientUserControl1.TabIndex = 0;
            this.patientUserControl1.Load += new System.EventHandler(this.PatientUserControl_Load);
            // 
            // nurse1
            // 
            this.nurse1.Location = new System.Drawing.Point(2, 2);
            this.nurse1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nurse1.Name = "nurse1";
            this.nurse1.Size = new System.Drawing.Size(1468, 825);
            this.nurse1.TabIndex = 0;
            // 
            // reportUserControl1
            // 
            this.reportUserControl1.Location = new System.Drawing.Point(8, 8);
            this.reportUserControl1.Margin = new System.Windows.Forms.Padding(5);
            this.reportUserControl1.Name = "reportUserControl1";
            this.reportUserControl1.Size = new System.Drawing.Size(1492, 800);
            this.reportUserControl1.TabIndex = 0;
            // 
            // NurseAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1518, 945);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.nurseAdminTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.reportTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.TabControl nurseAdminTabControl;
        private System.Windows.Forms.TabPage nurseTabPage;
        private UserControls.NurseUserControl nurse1;
        private System.Windows.Forms.LinkLabel logoutLinkLabel;
        public System.Windows.Forms.TabPage appointmentTabPage;
        private System.Windows.Forms.TabPage visitTabPage;
        private System.Windows.Forms.TabPage patientTabPage;
        private UserControls.PatientUserControl patientUserControl1;
        private UserControls.VisitUserControl visitUserControl1;
        private System.Windows.Forms.Label activeUsernameLabel;
        public UserControls.AppointmentUserControl appointmentUserControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabPage reportTabPage;
        private UserControls.ReportUserControl reportUserControl1;
    }
}

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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.nurseAdminTabControl.SuspendLayout();
            this.appointmentTabPage.SuspendLayout();
            this.visitTabPage.SuspendLayout();
            this.patientTabPage.SuspendLayout();
            this.nurseTabPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.nurseAdminTabControl.Location = new System.Drawing.Point(0, 45);
            this.nurseAdminTabControl.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.nurseAdminTabControl.Name = "nurseAdminTabControl";
            this.nurseAdminTabControl.SelectedIndex = 0;
            this.nurseAdminTabControl.Size = new System.Drawing.Size(985, 569);
            this.nurseAdminTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.nurseAdminTabControl.TabIndex = 2;
            this.nurseAdminTabControl.TabStop = false;
            this.nurseAdminTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.RefreshNurseList);
            // 
            // appointmentTabPage
            // 
            this.appointmentTabPage.Controls.Add(this.appointmentUserControl1);
            this.appointmentTabPage.Location = new System.Drawing.Point(4, 44);
            this.appointmentTabPage.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.appointmentTabPage.Name = "appointmentTabPage";
            this.appointmentTabPage.Size = new System.Drawing.Size(977, 521);
            this.appointmentTabPage.TabIndex = 1;
            this.appointmentTabPage.Text = "Appointments";
            this.appointmentTabPage.UseVisualStyleBackColor = true;
            // 
            // appointmentUserControl1
            // 
            this.appointmentUserControl1.Location = new System.Drawing.Point(1, 1);
            this.appointmentUserControl1.Margin = new System.Windows.Forms.Padding(2);
            this.appointmentUserControl1.Name = "appointmentUserControl1";
            this.appointmentUserControl1.Size = new System.Drawing.Size(979, 536);
            this.appointmentUserControl1.TabIndex = 0;
            // 
            // visitTabPage
            // 
            this.visitTabPage.Controls.Add(this.visitUserControl1);
            this.visitTabPage.Location = new System.Drawing.Point(4, 44);
            this.visitTabPage.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.visitTabPage.Name = "visitTabPage";
            this.visitTabPage.Size = new System.Drawing.Size(977, 521);
            this.visitTabPage.TabIndex = 2;
            this.visitTabPage.Text = "Visits";
            this.visitTabPage.UseVisualStyleBackColor = true;
            // 
            // visitUserControl1
            // 
            this.visitUserControl1.Location = new System.Drawing.Point(2, 1);
            this.visitUserControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.visitUserControl1.Name = "visitUserControl1";
            this.visitUserControl1.Size = new System.Drawing.Size(978, 537);
            this.visitUserControl1.TabIndex = 0;
            // 
            // patientTabPage
            // 
            this.patientTabPage.Controls.Add(this.patientUserControl1);
            this.patientTabPage.Location = new System.Drawing.Point(4, 44);
            this.patientTabPage.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.patientTabPage.Name = "patientTabPage";
            this.patientTabPage.Size = new System.Drawing.Size(977, 521);
            this.patientTabPage.TabIndex = 3;
            this.patientTabPage.Text = "Patients";
            this.patientTabPage.UseVisualStyleBackColor = true;
            // 
            // patientUserControl1
            // 
            this.patientUserControl1.Location = new System.Drawing.Point(2, 1);
            this.patientUserControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.patientUserControl1.Name = "patientUserControl1";
            this.patientUserControl1.Size = new System.Drawing.Size(978, 537);
            this.patientUserControl1.TabIndex = 0;
            this.patientUserControl1.Load += new System.EventHandler(this.PatientUserControl_Load);
            // 
            // nurseTabPage
            // 
            this.nurseTabPage.Controls.Add(this.nurse1);
            this.nurseTabPage.Location = new System.Drawing.Point(4, 44);
            this.nurseTabPage.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.nurseTabPage.Name = "nurseTabPage";
            this.nurseTabPage.Size = new System.Drawing.Size(977, 521);
            this.nurseTabPage.TabIndex = 0;
            this.nurseTabPage.Text = "Nurses";
            this.nurseTabPage.UseVisualStyleBackColor = true;
            // 
            // nurse1
            // 
            this.nurse1.Location = new System.Drawing.Point(1, 1);
            this.nurse1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nurse1.Name = "nurse1";
            this.nurse1.Size = new System.Drawing.Size(979, 536);
            this.nurse1.TabIndex = 0;
            // 
            // logoutLinkLabel
            // 
            this.logoutLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutLinkLabel.AutoSize = true;
            this.logoutLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLinkLabel.Location = new System.Drawing.Point(120, 28);
            this.logoutLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.logoutLinkLabel.Name = "logoutLinkLabel";
            this.logoutLinkLabel.Size = new System.Drawing.Size(58, 17);
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
            this.activeUsernameLabel.Location = new System.Drawing.Point(166, 11);
            this.activeUsernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.activeUsernameLabel.Name = "activeUsernameLabel";
            this.activeUsernameLabel.Size = new System.Drawing.Size(12, 17);
            this.activeUsernameLabel.TabIndex = 0;
            this.activeUsernameLabel.Text = ".";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.logoutLinkLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.activeUsernameLabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(801, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(180, 57);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // NurseAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 614);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.nurseAdminTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
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
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
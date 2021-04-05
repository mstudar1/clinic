
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
            this.appointmentUserControl = new Clinic.UserControls.AppointmentUserControl();
            this.visitUserControl = new Clinic.UserControls.VisitUserControl();
            this.patientUserControl = new Clinic.UserControls.PatientUserControl();
            this.nurseUserControl = new Clinic.UserControls.NurseUserControl();
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
            this.nurseAdminTabControl.Location = new System.Drawing.Point(0, 43);
            this.nurseAdminTabControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nurseAdminTabControl.Name = "nurseAdminTabControl";
            this.nurseAdminTabControl.SelectedIndex = 0;
            this.nurseAdminTabControl.Size = new System.Drawing.Size(986, 570);
            this.nurseAdminTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.nurseAdminTabControl.TabIndex = 2;
            this.nurseAdminTabControl.TabStop = false;
            this.nurseAdminTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.RefreshNurseList);
            // 
            // appointmentTabPage
            // 
            this.appointmentTabPage.Controls.Add(this.appointmentUserControl);
            this.appointmentTabPage.Location = new System.Drawing.Point(4, 44);
            this.appointmentTabPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.appointmentTabPage.Name = "appointmentTabPage";
            this.appointmentTabPage.Size = new System.Drawing.Size(978, 522);
            this.appointmentTabPage.TabIndex = 1;
            this.appointmentTabPage.Text = "Appointments";
            this.appointmentTabPage.UseVisualStyleBackColor = true;
            // 
            // visitTabPage
            // 
            this.visitTabPage.Controls.Add(this.visitUserControl);
            this.visitTabPage.Location = new System.Drawing.Point(4, 44);
            this.visitTabPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.visitTabPage.Name = "visitTabPage";
            this.visitTabPage.Size = new System.Drawing.Size(978, 522);
            this.visitTabPage.TabIndex = 2;
            this.visitTabPage.Text = "Visits";
            this.visitTabPage.UseVisualStyleBackColor = true;
            // 
            // patientTabPage
            // 
            this.patientTabPage.Controls.Add(this.patientUserControl);
            this.patientTabPage.Location = new System.Drawing.Point(4, 44);
            this.patientTabPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.patientTabPage.Name = "patientTabPage";
            this.patientTabPage.Size = new System.Drawing.Size(978, 522);
            this.patientTabPage.TabIndex = 3;
            this.patientTabPage.Text = "Patients";
            this.patientTabPage.UseVisualStyleBackColor = true;
            // 
            // nurseTabPage
            // 
            this.nurseTabPage.Controls.Add(this.nurseUserControl);
            this.nurseTabPage.Location = new System.Drawing.Point(4, 44);
            this.nurseTabPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nurseTabPage.Name = "nurseTabPage";
            this.nurseTabPage.Size = new System.Drawing.Size(978, 522);
            this.nurseTabPage.TabIndex = 0;
            this.nurseTabPage.Text = "Nurse";
            this.nurseTabPage.UseVisualStyleBackColor = true;
            // 
            // logoutLinkLabel
            // 
            this.logoutLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutLinkLabel.AutoSize = true;
            this.logoutLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLinkLabel.Location = new System.Drawing.Point(107, 24);
            this.logoutLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.logoutLinkLabel.Name = "logoutLinkLabel";
            this.logoutLinkLabel.Size = new System.Drawing.Size(71, 22);
            this.logoutLinkLabel.TabIndex = 3;
            this.logoutLinkLabel.TabStop = true;
            this.logoutLinkLabel.Text = "Logout";
            this.logoutLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLink_LinkClicked);
            // 
            // activeUsernameLabel
            // 
            this.activeUsernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.activeUsernameLabel.AutoSize = true;
            this.activeUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeUsernameLabel.Location = new System.Drawing.Point(163, 0);
            this.activeUsernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.activeUsernameLabel.Name = "activeUsernameLabel";
            this.activeUsernameLabel.Size = new System.Drawing.Size(15, 22);
            this.activeUsernameLabel.TabIndex = 0;
            this.activeUsernameLabel.Text = ".";
            this.activeUsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // appointmentUserControl
            // 
            this.appointmentUserControl.Location = new System.Drawing.Point(2, 2);
            this.appointmentUserControl.Margin = new System.Windows.Forms.Padding(2);
            this.appointmentUserControl.Name = "appointmentUserControl";
            this.appointmentUserControl.Size = new System.Drawing.Size(979, 536);
            this.appointmentUserControl.TabIndex = 0;
            // 
            // visitUserControl
            // 
            this.visitUserControl.Location = new System.Drawing.Point(2, 2);
            this.visitUserControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.visitUserControl.Name = "visitUserControl";
            this.visitUserControl.Size = new System.Drawing.Size(978, 537);
            this.visitUserControl.TabIndex = 0;
            // 
            // patientUserControl
            // 
            this.patientUserControl.Location = new System.Drawing.Point(2, 2);
            this.patientUserControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.patientUserControl.Name = "patientUserControl";
            this.patientUserControl.Size = new System.Drawing.Size(978, 537);
            this.patientUserControl.TabIndex = 0;
            // 
            // nurseUserControl
            // 
            this.nurseUserControl.Location = new System.Drawing.Point(2, 2);
            this.nurseUserControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nurseUserControl.Name = "nurseUserControl";
            this.nurseUserControl.Size = new System.Drawing.Size(979, 536);
            this.nurseUserControl.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.logoutLinkLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.activeUsernameLabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(805, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(180, 46);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // NurseAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 613);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.nurseAdminTabControl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private UserControls.NurseUserControl nurseUserControl;
        private System.Windows.Forms.LinkLabel logoutLinkLabel;
        private System.Windows.Forms.TabPage appointmentTabPage;
        private System.Windows.Forms.TabPage visitTabPage;
        private System.Windows.Forms.TabPage patientTabPage;
        private UserControls.PatientUserControl patientUserControl;
        private UserControls.VisitUserControl visitUserControl;
        private System.Windows.Forms.Label activeUsernameLabel;
        private UserControls.AppointmentUserControl appointmentUserControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
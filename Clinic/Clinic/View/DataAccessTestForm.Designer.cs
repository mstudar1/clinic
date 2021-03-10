
namespace Clinic.View
{
    partial class DataAccessTestForm
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
            this.credentialsAreValidGroupBox = new System.Windows.Forms.GroupBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.callCredentialsAreValidMethodButton = new System.Windows.Forms.Button();
            this.dataAccessTestTabControl = new System.Windows.Forms.TabControl();
            this.credentialControllerTabPage = new System.Windows.Forms.TabPage();
            this.patientControllerTabPage = new System.Windows.Forms.TabPage();
            this.appointmentControllerTabPage = new System.Windows.Forms.TabPage();
            this.addPatientGroupBox = new System.Windows.Forms.GroupBox();
            this.addPatientButton = new System.Windows.Forms.Button();
            this.editPatientGroupBox = new System.Windows.Forms.GroupBox();
            this.editPatientButton = new System.Windows.Forms.Button();
            this.addAppointmentGroupBox = new System.Windows.Forms.GroupBox();
            this.addAppointmentButton = new System.Windows.Forms.Button();
            this.doctorIsBookedGroupBox = new System.Windows.Forms.GroupBox();
            this.doctorIsBookedButton = new System.Windows.Forms.Button();
            this.doctorIdTextBox = new System.Windows.Forms.TextBox();
            this.dateAndTimeLabel = new System.Windows.Forms.Label();
            this.doctorIdLabel = new System.Windows.Forms.Label();
            this.editAppointmentGroupBox = new System.Windows.Forms.GroupBox();
            this.editAppointmentButton = new System.Windows.Forms.Button();
            this.dateAndTimeTextBox = new System.Windows.Forms.TextBox();
            this.credentialsAreValidGroupBox.SuspendLayout();
            this.dataAccessTestTabControl.SuspendLayout();
            this.credentialControllerTabPage.SuspendLayout();
            this.patientControllerTabPage.SuspendLayout();
            this.appointmentControllerTabPage.SuspendLayout();
            this.addPatientGroupBox.SuspendLayout();
            this.editPatientGroupBox.SuspendLayout();
            this.addAppointmentGroupBox.SuspendLayout();
            this.doctorIsBookedGroupBox.SuspendLayout();
            this.editAppointmentGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // credentialsAreValidGroupBox
            // 
            this.credentialsAreValidGroupBox.Controls.Add(this.callCredentialsAreValidMethodButton);
            this.credentialsAreValidGroupBox.Controls.Add(this.passwordTextBox);
            this.credentialsAreValidGroupBox.Controls.Add(this.usernameTextBox);
            this.credentialsAreValidGroupBox.Controls.Add(this.passwordLabel);
            this.credentialsAreValidGroupBox.Controls.Add(this.usernameLabel);
            this.credentialsAreValidGroupBox.Location = new System.Drawing.Point(6, 6);
            this.credentialsAreValidGroupBox.Name = "credentialsAreValidGroupBox";
            this.credentialsAreValidGroupBox.Size = new System.Drawing.Size(262, 104);
            this.credentialsAreValidGroupBox.TabIndex = 0;
            this.credentialsAreValidGroupBox.TabStop = false;
            this.credentialsAreValidGroupBox.Text = "CredentialsAreValid";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(6, 20);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(6, 46);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(67, 17);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(189, 20);
            this.usernameTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(67, 43);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(189, 20);
            this.passwordTextBox.TabIndex = 3;
            // 
            // callCredentialsAreValidMethodButton
            // 
            this.callCredentialsAreValidMethodButton.Location = new System.Drawing.Point(67, 70);
            this.callCredentialsAreValidMethodButton.Name = "callCredentialsAreValidMethodButton";
            this.callCredentialsAreValidMethodButton.Size = new System.Drawing.Size(189, 23);
            this.callCredentialsAreValidMethodButton.TabIndex = 4;
            this.callCredentialsAreValidMethodButton.Text = "Call CredentialsAreValid Method";
            this.callCredentialsAreValidMethodButton.UseVisualStyleBackColor = true;
            // 
            // dataAccessTestTabControl
            // 
            this.dataAccessTestTabControl.Controls.Add(this.credentialControllerTabPage);
            this.dataAccessTestTabControl.Controls.Add(this.patientControllerTabPage);
            this.dataAccessTestTabControl.Controls.Add(this.appointmentControllerTabPage);
            this.dataAccessTestTabControl.Location = new System.Drawing.Point(13, 13);
            this.dataAccessTestTabControl.Name = "dataAccessTestTabControl";
            this.dataAccessTestTabControl.SelectedIndex = 0;
            this.dataAccessTestTabControl.Size = new System.Drawing.Size(332, 268);
            this.dataAccessTestTabControl.TabIndex = 1;
            // 
            // credentialControllerTabPage
            // 
            this.credentialControllerTabPage.Controls.Add(this.credentialsAreValidGroupBox);
            this.credentialControllerTabPage.Location = new System.Drawing.Point(4, 22);
            this.credentialControllerTabPage.Name = "credentialControllerTabPage";
            this.credentialControllerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.credentialControllerTabPage.Size = new System.Drawing.Size(324, 238);
            this.credentialControllerTabPage.TabIndex = 0;
            this.credentialControllerTabPage.Text = "CredentialController";
            this.credentialControllerTabPage.UseVisualStyleBackColor = true;
            // 
            // patientControllerTabPage
            // 
            this.patientControllerTabPage.Controls.Add(this.editPatientGroupBox);
            this.patientControllerTabPage.Controls.Add(this.addPatientGroupBox);
            this.patientControllerTabPage.Location = new System.Drawing.Point(4, 22);
            this.patientControllerTabPage.Name = "patientControllerTabPage";
            this.patientControllerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.patientControllerTabPage.Size = new System.Drawing.Size(324, 238);
            this.patientControllerTabPage.TabIndex = 1;
            this.patientControllerTabPage.Text = "PatientController";
            this.patientControllerTabPage.UseVisualStyleBackColor = true;
            // 
            // appointmentControllerTabPage
            // 
            this.appointmentControllerTabPage.Controls.Add(this.editAppointmentGroupBox);
            this.appointmentControllerTabPage.Controls.Add(this.doctorIsBookedGroupBox);
            this.appointmentControllerTabPage.Controls.Add(this.addAppointmentGroupBox);
            this.appointmentControllerTabPage.Location = new System.Drawing.Point(4, 22);
            this.appointmentControllerTabPage.Name = "appointmentControllerTabPage";
            this.appointmentControllerTabPage.Size = new System.Drawing.Size(324, 242);
            this.appointmentControllerTabPage.TabIndex = 2;
            this.appointmentControllerTabPage.Text = "AppointmentController";
            this.appointmentControllerTabPage.UseVisualStyleBackColor = true;
            // 
            // addPatientGroupBox
            // 
            this.addPatientGroupBox.Controls.Add(this.addPatientButton);
            this.addPatientGroupBox.Location = new System.Drawing.Point(6, 6);
            this.addPatientGroupBox.Name = "addPatientGroupBox";
            this.addPatientGroupBox.Size = new System.Drawing.Size(262, 53);
            this.addPatientGroupBox.TabIndex = 0;
            this.addPatientGroupBox.TabStop = false;
            this.addPatientGroupBox.Text = "AddPatient";
            // 
            // addPatientButton
            // 
            this.addPatientButton.Location = new System.Drawing.Point(7, 20);
            this.addPatientButton.Name = "addPatientButton";
            this.addPatientButton.Size = new System.Drawing.Size(247, 23);
            this.addPatientButton.TabIndex = 0;
            this.addPatientButton.Text = "Add John Doe Patient";
            this.addPatientButton.UseVisualStyleBackColor = true;
            // 
            // editPatientGroupBox
            // 
            this.editPatientGroupBox.Controls.Add(this.editPatientButton);
            this.editPatientGroupBox.Location = new System.Drawing.Point(6, 65);
            this.editPatientGroupBox.Name = "editPatientGroupBox";
            this.editPatientGroupBox.Size = new System.Drawing.Size(262, 52);
            this.editPatientGroupBox.TabIndex = 1;
            this.editPatientGroupBox.TabStop = false;
            this.editPatientGroupBox.Text = "EditPatient";
            // 
            // editPatientButton
            // 
            this.editPatientButton.Location = new System.Drawing.Point(7, 20);
            this.editPatientButton.Name = "editPatientButton";
            this.editPatientButton.Size = new System.Drawing.Size(247, 23);
            this.editPatientButton.TabIndex = 0;
            this.editPatientButton.Text = "Change Patient Name to Jane Doe";
            this.editPatientButton.UseVisualStyleBackColor = true;
            // 
            // addAppointmentGroupBox
            // 
            this.addAppointmentGroupBox.Controls.Add(this.addAppointmentButton);
            this.addAppointmentGroupBox.Location = new System.Drawing.Point(6, 6);
            this.addAppointmentGroupBox.Name = "addAppointmentGroupBox";
            this.addAppointmentGroupBox.Size = new System.Drawing.Size(262, 53);
            this.addAppointmentGroupBox.TabIndex = 1;
            this.addAppointmentGroupBox.TabStop = false;
            this.addAppointmentGroupBox.Text = "AddAppointment";
            // 
            // addAppointmentButton
            // 
            this.addAppointmentButton.Location = new System.Drawing.Point(7, 20);
            this.addAppointmentButton.Name = "addAppointmentButton";
            this.addAppointmentButton.Size = new System.Drawing.Size(247, 23);
            this.addAppointmentButton.TabIndex = 0;
            this.addAppointmentButton.Text = "Add Appointment for John Doe";
            this.addAppointmentButton.UseVisualStyleBackColor = true;
            // 
            // doctorIsBookedGroupBox
            // 
            this.doctorIsBookedGroupBox.Controls.Add(this.dateAndTimeTextBox);
            this.doctorIsBookedGroupBox.Controls.Add(this.doctorIsBookedButton);
            this.doctorIsBookedGroupBox.Controls.Add(this.doctorIdTextBox);
            this.doctorIsBookedGroupBox.Controls.Add(this.dateAndTimeLabel);
            this.doctorIsBookedGroupBox.Controls.Add(this.doctorIdLabel);
            this.doctorIsBookedGroupBox.Location = new System.Drawing.Point(6, 65);
            this.doctorIsBookedGroupBox.Name = "doctorIsBookedGroupBox";
            this.doctorIsBookedGroupBox.Size = new System.Drawing.Size(262, 104);
            this.doctorIsBookedGroupBox.TabIndex = 2;
            this.doctorIsBookedGroupBox.TabStop = false;
            this.doctorIsBookedGroupBox.Text = "DoctorIsBooked";
            // 
            // doctorIsBookedButton
            // 
            this.doctorIsBookedButton.Location = new System.Drawing.Point(99, 69);
            this.doctorIsBookedButton.Name = "doctorIsBookedButton";
            this.doctorIsBookedButton.Size = new System.Drawing.Size(157, 23);
            this.doctorIsBookedButton.TabIndex = 4;
            this.doctorIsBookedButton.Text = "Call DoctorIsBooked Method";
            this.doctorIsBookedButton.UseVisualStyleBackColor = true;
            // 
            // doctorIdTextBox
            // 
            this.doctorIdTextBox.Location = new System.Drawing.Point(99, 17);
            this.doctorIdTextBox.Name = "doctorIdTextBox";
            this.doctorIdTextBox.Size = new System.Drawing.Size(157, 20);
            this.doctorIdTextBox.TabIndex = 2;
            // 
            // dateAndTimeLabel
            // 
            this.dateAndTimeLabel.AutoSize = true;
            this.dateAndTimeLabel.Location = new System.Drawing.Point(6, 46);
            this.dateAndTimeLabel.Name = "dateAndTimeLabel";
            this.dateAndTimeLabel.Size = new System.Drawing.Size(73, 13);
            this.dateAndTimeLabel.TabIndex = 1;
            this.dateAndTimeLabel.Text = "Date and time";
            // 
            // doctorIdLabel
            // 
            this.doctorIdLabel.AutoSize = true;
            this.doctorIdLabel.Location = new System.Drawing.Point(6, 20);
            this.doctorIdLabel.Name = "doctorIdLabel";
            this.doctorIdLabel.Size = new System.Drawing.Size(53, 13);
            this.doctorIdLabel.TabIndex = 0;
            this.doctorIdLabel.Text = "Doctor ID";
            // 
            // editAppointmentGroupBox
            // 
            this.editAppointmentGroupBox.Controls.Add(this.editAppointmentButton);
            this.editAppointmentGroupBox.Location = new System.Drawing.Point(6, 175);
            this.editAppointmentGroupBox.Name = "editAppointmentGroupBox";
            this.editAppointmentGroupBox.Size = new System.Drawing.Size(262, 53);
            this.editAppointmentGroupBox.TabIndex = 3;
            this.editAppointmentGroupBox.TabStop = false;
            this.editAppointmentGroupBox.Text = "EditAppointment";
            // 
            // editAppointmentButton
            // 
            this.editAppointmentButton.Location = new System.Drawing.Point(7, 20);
            this.editAppointmentButton.Name = "editAppointmentButton";
            this.editAppointmentButton.Size = new System.Drawing.Size(247, 23);
            this.editAppointmentButton.TabIndex = 0;
            this.editAppointmentButton.Text = "Edit Appointment for John Doe";
            this.editAppointmentButton.UseVisualStyleBackColor = true;
            // 
            // dateAndTimeTextBox
            // 
            this.dateAndTimeTextBox.Location = new System.Drawing.Point(99, 43);
            this.dateAndTimeTextBox.Name = "dateAndTimeTextBox";
            this.dateAndTimeTextBox.Size = new System.Drawing.Size(157, 20);
            this.dateAndTimeTextBox.TabIndex = 5;
            // 
            // DataAccessTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 291);
            this.Controls.Add(this.dataAccessTestTabControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataAccessTestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Access Test Form";
            this.credentialsAreValidGroupBox.ResumeLayout(false);
            this.credentialsAreValidGroupBox.PerformLayout();
            this.dataAccessTestTabControl.ResumeLayout(false);
            this.credentialControllerTabPage.ResumeLayout(false);
            this.patientControllerTabPage.ResumeLayout(false);
            this.appointmentControllerTabPage.ResumeLayout(false);
            this.addPatientGroupBox.ResumeLayout(false);
            this.editPatientGroupBox.ResumeLayout(false);
            this.addAppointmentGroupBox.ResumeLayout(false);
            this.doctorIsBookedGroupBox.ResumeLayout(false);
            this.doctorIsBookedGroupBox.PerformLayout();
            this.editAppointmentGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox credentialsAreValidGroupBox;
        private System.Windows.Forms.Button callCredentialsAreValidMethodButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TabControl dataAccessTestTabControl;
        private System.Windows.Forms.TabPage credentialControllerTabPage;
        private System.Windows.Forms.TabPage patientControllerTabPage;
        private System.Windows.Forms.TabPage appointmentControllerTabPage;
        private System.Windows.Forms.GroupBox editPatientGroupBox;
        private System.Windows.Forms.Button editPatientButton;
        private System.Windows.Forms.GroupBox addPatientGroupBox;
        private System.Windows.Forms.Button addPatientButton;
        private System.Windows.Forms.GroupBox doctorIsBookedGroupBox;
        private System.Windows.Forms.Button doctorIsBookedButton;
        private System.Windows.Forms.TextBox doctorIdTextBox;
        private System.Windows.Forms.Label dateAndTimeLabel;
        private System.Windows.Forms.Label doctorIdLabel;
        private System.Windows.Forms.GroupBox addAppointmentGroupBox;
        private System.Windows.Forms.Button addAppointmentButton;
        private System.Windows.Forms.GroupBox editAppointmentGroupBox;
        private System.Windows.Forms.Button editAppointmentButton;
        private System.Windows.Forms.TextBox dateAndTimeTextBox;
    }
}
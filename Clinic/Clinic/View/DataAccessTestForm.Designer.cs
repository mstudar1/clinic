
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
            this.credentialsAreValidButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.dataAccessTestTabControl = new System.Windows.Forms.TabControl();
            this.credentialControllerTabPage = new System.Windows.Forms.TabPage();
            this.getUserGroupBox = new System.Windows.Forms.GroupBox();
            this.getUserButton = new System.Windows.Forms.Button();
            this.getUserUsernameTextBox = new System.Windows.Forms.TextBox();
            this.getUserUsernameLabel = new System.Windows.Forms.Label();
            this.patientControllerTabPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lastNameTextBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.findPatientsButton3 = new System.Windows.Forms.Button();
            this.dateOfBirthTextBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.findPatientsButton2 = new System.Windows.Forms.Button();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.findPatientsGroupBox = new System.Windows.Forms.GroupBox();
            this.findPatientsButton = new System.Windows.Forms.Button();
            this.dateOfBirthTextBox = new System.Windows.Forms.TextBox();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.editPatientGroupBox = new System.Windows.Forms.GroupBox();
            this.editPatientButton = new System.Windows.Forms.Button();
            this.addPatientGroupBox = new System.Windows.Forms.GroupBox();
            this.addPatientButton = new System.Windows.Forms.Button();
            this.appointmentControllerTabPage = new System.Windows.Forms.TabPage();
            this.findAppointmentsGroupBox = new System.Windows.Forms.GroupBox();
            this.findAppointmentsButton = new System.Windows.Forms.Button();
            this.patientIdTextBox = new System.Windows.Forms.TextBox();
            this.patientIdLabel = new System.Windows.Forms.Label();
            this.editAppointmentGroupBox = new System.Windows.Forms.GroupBox();
            this.editAppointmentButton = new System.Windows.Forms.Button();
            this.doctorIsBookedGroupBox = new System.Windows.Forms.GroupBox();
            this.dateAndTimeTextBox = new System.Windows.Forms.TextBox();
            this.doctorIsBookedButton = new System.Windows.Forms.Button();
            this.doctorIdTextBox = new System.Windows.Forms.TextBox();
            this.dateAndTimeLabel = new System.Windows.Forms.Label();
            this.doctorIdLabel = new System.Windows.Forms.Label();
            this.addAppointmentGroupBox = new System.Windows.Forms.GroupBox();
            this.addAppointmentButton = new System.Windows.Forms.Button();
            this.addVisitTabPage = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.findVisitsButton = new System.Windows.Forms.Button();
            this.patientIdTextBox1 = new System.Windows.Forms.TextBox();
            this.patientIdLabel1 = new System.Windows.Forms.Label();
            this.addVisitGroupBox = new System.Windows.Forms.GroupBox();
            this.addVisitButton = new System.Windows.Forms.Button();
            this.credentialsAreValidGroupBox.SuspendLayout();
            this.dataAccessTestTabControl.SuspendLayout();
            this.credentialControllerTabPage.SuspendLayout();
            this.getUserGroupBox.SuspendLayout();
            this.patientControllerTabPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.findPatientsGroupBox.SuspendLayout();
            this.editPatientGroupBox.SuspendLayout();
            this.addPatientGroupBox.SuspendLayout();
            this.appointmentControllerTabPage.SuspendLayout();
            this.findAppointmentsGroupBox.SuspendLayout();
            this.editAppointmentGroupBox.SuspendLayout();
            this.doctorIsBookedGroupBox.SuspendLayout();
            this.addAppointmentGroupBox.SuspendLayout();
            this.addVisitTabPage.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.addVisitGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // credentialsAreValidGroupBox
            // 
            this.credentialsAreValidGroupBox.Controls.Add(this.credentialsAreValidButton);
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
            // credentialsAreValidButton
            // 
            this.credentialsAreValidButton.Location = new System.Drawing.Point(67, 70);
            this.credentialsAreValidButton.Name = "credentialsAreValidButton";
            this.credentialsAreValidButton.Size = new System.Drawing.Size(189, 23);
            this.credentialsAreValidButton.TabIndex = 4;
            this.credentialsAreValidButton.Text = "Call CredentialsAreValid Method";
            this.credentialsAreValidButton.UseVisualStyleBackColor = true;
            this.credentialsAreValidButton.Click += new System.EventHandler(this.CredentialsAreValidButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(67, 43);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(189, 20);
            this.passwordTextBox.TabIndex = 3;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(67, 17);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(189, 20);
            this.usernameTextBox.TabIndex = 2;
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
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(6, 20);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username";
            // 
            // dataAccessTestTabControl
            // 
            this.dataAccessTestTabControl.Controls.Add(this.credentialControllerTabPage);
            this.dataAccessTestTabControl.Controls.Add(this.patientControllerTabPage);
            this.dataAccessTestTabControl.Controls.Add(this.appointmentControllerTabPage);
            this.dataAccessTestTabControl.Controls.Add(this.addVisitTabPage);
            this.dataAccessTestTabControl.Location = new System.Drawing.Point(13, 13);
            this.dataAccessTestTabControl.Name = "dataAccessTestTabControl";
            this.dataAccessTestTabControl.SelectedIndex = 0;
            this.dataAccessTestTabControl.Size = new System.Drawing.Size(332, 436);
            this.dataAccessTestTabControl.TabIndex = 1;
            // 
            // credentialControllerTabPage
            // 
            this.credentialControllerTabPage.Controls.Add(this.getUserGroupBox);
            this.credentialControllerTabPage.Controls.Add(this.credentialsAreValidGroupBox);
            this.credentialControllerTabPage.Location = new System.Drawing.Point(4, 22);
            this.credentialControllerTabPage.Name = "credentialControllerTabPage";
            this.credentialControllerTabPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.credentialControllerTabPage.Size = new System.Drawing.Size(324, 410);
            this.credentialControllerTabPage.TabIndex = 0;
            this.credentialControllerTabPage.Text = "CredentialController";
            this.credentialControllerTabPage.UseVisualStyleBackColor = true;
            // 
            // getUserGroupBox
            // 
            this.getUserGroupBox.Controls.Add(this.getUserButton);
            this.getUserGroupBox.Controls.Add(this.getUserUsernameTextBox);
            this.getUserGroupBox.Controls.Add(this.getUserUsernameLabel);
            this.getUserGroupBox.Location = new System.Drawing.Point(6, 115);
            this.getUserGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.getUserGroupBox.Name = "getUserGroupBox";
            this.getUserGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.getUserGroupBox.Size = new System.Drawing.Size(262, 75);
            this.getUserGroupBox.TabIndex = 1;
            this.getUserGroupBox.TabStop = false;
            this.getUserGroupBox.Text = "GetUser";
            // 
            // getUserButton
            // 
            this.getUserButton.Location = new System.Drawing.Point(66, 40);
            this.getUserButton.Name = "getUserButton";
            this.getUserButton.Size = new System.Drawing.Size(189, 23);
            this.getUserButton.TabIndex = 5;
            this.getUserButton.Text = "Call GetUser Method";
            this.getUserButton.UseVisualStyleBackColor = true;
            this.getUserButton.Click += new System.EventHandler(this.GetUserButton_Click);
            // 
            // getUserUsernameTextBox
            // 
            this.getUserUsernameTextBox.Location = new System.Drawing.Point(67, 15);
            this.getUserUsernameTextBox.Name = "getUserUsernameTextBox";
            this.getUserUsernameTextBox.Size = new System.Drawing.Size(189, 20);
            this.getUserUsernameTextBox.TabIndex = 4;
            // 
            // getUserUsernameLabel
            // 
            this.getUserUsernameLabel.AutoSize = true;
            this.getUserUsernameLabel.Location = new System.Drawing.Point(6, 19);
            this.getUserUsernameLabel.Name = "getUserUsernameLabel";
            this.getUserUsernameLabel.Size = new System.Drawing.Size(55, 13);
            this.getUserUsernameLabel.TabIndex = 3;
            this.getUserUsernameLabel.Text = "Username";
            // 
            // patientControllerTabPage
            // 
            this.patientControllerTabPage.Controls.Add(this.groupBox2);
            this.patientControllerTabPage.Controls.Add(this.groupBox1);
            this.patientControllerTabPage.Controls.Add(this.findPatientsGroupBox);
            this.patientControllerTabPage.Controls.Add(this.editPatientGroupBox);
            this.patientControllerTabPage.Controls.Add(this.addPatientGroupBox);
            this.patientControllerTabPage.Location = new System.Drawing.Point(4, 22);
            this.patientControllerTabPage.Name = "patientControllerTabPage";
            this.patientControllerTabPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.patientControllerTabPage.Size = new System.Drawing.Size(324, 410);
            this.patientControllerTabPage.TabIndex = 1;
            this.patientControllerTabPage.Text = "PatientController";
            this.patientControllerTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lastNameTextBox2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.findPatientsButton3);
            this.groupBox2.Controls.Add(this.dateOfBirthTextBox2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(6, 304);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(262, 97);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FindPatients";
            // 
            // lastNameTextBox2
            // 
            this.lastNameTextBox2.Location = new System.Drawing.Point(67, 40);
            this.lastNameTextBox2.Name = "lastNameTextBox2";
            this.lastNameTextBox2.Size = new System.Drawing.Size(189, 20);
            this.lastNameTextBox2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last name";
            // 
            // findPatientsButton3
            // 
            this.findPatientsButton3.Location = new System.Drawing.Point(66, 64);
            this.findPatientsButton3.Name = "findPatientsButton3";
            this.findPatientsButton3.Size = new System.Drawing.Size(189, 23);
            this.findPatientsButton3.TabIndex = 2;
            this.findPatientsButton3.Text = "Call FindPatients Method";
            this.findPatientsButton3.UseVisualStyleBackColor = true;
            this.findPatientsButton3.Click += new System.EventHandler(this.FindPatientsButton3_Click);
            // 
            // dateOfBirthTextBox2
            // 
            this.dateOfBirthTextBox2.Location = new System.Drawing.Point(67, 15);
            this.dateOfBirthTextBox2.Name = "dateOfBirthTextBox2";
            this.dateOfBirthTextBox2.Size = new System.Drawing.Size(189, 20);
            this.dateOfBirthTextBox2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DOB";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.firstNameTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.findPatientsButton2);
            this.groupBox1.Controls.Add(this.lastNameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 202);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(262, 97);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FindPatients";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(67, 40);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(189, 20);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "First name";
            // 
            // findPatientsButton2
            // 
            this.findPatientsButton2.Location = new System.Drawing.Point(66, 64);
            this.findPatientsButton2.Name = "findPatientsButton2";
            this.findPatientsButton2.Size = new System.Drawing.Size(189, 23);
            this.findPatientsButton2.TabIndex = 2;
            this.findPatientsButton2.Text = "Call FindPatients Method";
            this.findPatientsButton2.UseVisualStyleBackColor = true;
            this.findPatientsButton2.Click += new System.EventHandler(this.FindPatientsButton2_Click);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(67, 15);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(189, 20);
            this.lastNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Last name";
            // 
            // findPatientsGroupBox
            // 
            this.findPatientsGroupBox.Controls.Add(this.findPatientsButton);
            this.findPatientsGroupBox.Controls.Add(this.dateOfBirthTextBox);
            this.findPatientsGroupBox.Controls.Add(this.dateOfBirthLabel);
            this.findPatientsGroupBox.Location = new System.Drawing.Point(6, 123);
            this.findPatientsGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.findPatientsGroupBox.Name = "findPatientsGroupBox";
            this.findPatientsGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.findPatientsGroupBox.Size = new System.Drawing.Size(262, 75);
            this.findPatientsGroupBox.TabIndex = 1;
            this.findPatientsGroupBox.TabStop = false;
            this.findPatientsGroupBox.Text = "FindPatients";
            // 
            // findPatientsButton
            // 
            this.findPatientsButton.Location = new System.Drawing.Point(66, 40);
            this.findPatientsButton.Name = "findPatientsButton";
            this.findPatientsButton.Size = new System.Drawing.Size(189, 23);
            this.findPatientsButton.TabIndex = 1;
            this.findPatientsButton.Text = "Call FindPatients Method";
            this.findPatientsButton.UseVisualStyleBackColor = true;
            this.findPatientsButton.Click += new System.EventHandler(this.FindPatientsButton_Click);
            // 
            // dateOfBirthTextBox
            // 
            this.dateOfBirthTextBox.Location = new System.Drawing.Point(67, 15);
            this.dateOfBirthTextBox.Name = "dateOfBirthTextBox";
            this.dateOfBirthTextBox.Size = new System.Drawing.Size(189, 20);
            this.dateOfBirthTextBox.TabIndex = 0;
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Location = new System.Drawing.Point(6, 19);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(30, 13);
            this.dateOfBirthLabel.TabIndex = 3;
            this.dateOfBirthLabel.Text = "DOB";
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
            this.editPatientButton.Click += new System.EventHandler(this.EditPatientButton_Click);
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
            this.addPatientButton.Click += new System.EventHandler(this.AddPatientButton_Click);
            // 
            // appointmentControllerTabPage
            // 
            this.appointmentControllerTabPage.Controls.Add(this.findAppointmentsGroupBox);
            this.appointmentControllerTabPage.Controls.Add(this.editAppointmentGroupBox);
            this.appointmentControllerTabPage.Controls.Add(this.doctorIsBookedGroupBox);
            this.appointmentControllerTabPage.Controls.Add(this.addAppointmentGroupBox);
            this.appointmentControllerTabPage.Location = new System.Drawing.Point(4, 22);
            this.appointmentControllerTabPage.Name = "appointmentControllerTabPage";
            this.appointmentControllerTabPage.Size = new System.Drawing.Size(324, 410);
            this.appointmentControllerTabPage.TabIndex = 2;
            this.appointmentControllerTabPage.Text = "AppointmentController";
            this.appointmentControllerTabPage.UseVisualStyleBackColor = true;
            // 
            // findAppointmentsGroupBox
            // 
            this.findAppointmentsGroupBox.Controls.Add(this.findAppointmentsButton);
            this.findAppointmentsGroupBox.Controls.Add(this.patientIdTextBox);
            this.findAppointmentsGroupBox.Controls.Add(this.patientIdLabel);
            this.findAppointmentsGroupBox.Location = new System.Drawing.Point(6, 234);
            this.findAppointmentsGroupBox.Name = "findAppointmentsGroupBox";
            this.findAppointmentsGroupBox.Size = new System.Drawing.Size(262, 73);
            this.findAppointmentsGroupBox.TabIndex = 4;
            this.findAppointmentsGroupBox.TabStop = false;
            this.findAppointmentsGroupBox.Text = "FindAppointments";
            // 
            // findAppointmentsButton
            // 
            this.findAppointmentsButton.Location = new System.Drawing.Point(99, 41);
            this.findAppointmentsButton.Name = "findAppointmentsButton";
            this.findAppointmentsButton.Size = new System.Drawing.Size(157, 23);
            this.findAppointmentsButton.TabIndex = 4;
            this.findAppointmentsButton.Text = "Call FindAppointments Method";
            this.findAppointmentsButton.UseVisualStyleBackColor = true;
            this.findAppointmentsButton.Click += new System.EventHandler(this.FindAppointmentsButton_Click);
            // 
            // patientIdTextBox
            // 
            this.patientIdTextBox.Location = new System.Drawing.Point(99, 17);
            this.patientIdTextBox.Name = "patientIdTextBox";
            this.patientIdTextBox.Size = new System.Drawing.Size(157, 20);
            this.patientIdTextBox.TabIndex = 2;
            // 
            // patientIdLabel
            // 
            this.patientIdLabel.AutoSize = true;
            this.patientIdLabel.Location = new System.Drawing.Point(6, 20);
            this.patientIdLabel.Name = "patientIdLabel";
            this.patientIdLabel.Size = new System.Drawing.Size(54, 13);
            this.patientIdLabel.TabIndex = 0;
            this.patientIdLabel.Text = "Patient ID";
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
            this.editAppointmentButton.Click += new System.EventHandler(this.EditAppointmentButton_Click);
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
            // dateAndTimeTextBox
            // 
            this.dateAndTimeTextBox.Location = new System.Drawing.Point(99, 43);
            this.dateAndTimeTextBox.Name = "dateAndTimeTextBox";
            this.dateAndTimeTextBox.Size = new System.Drawing.Size(157, 20);
            this.dateAndTimeTextBox.TabIndex = 5;
            // 
            // doctorIsBookedButton
            // 
            this.doctorIsBookedButton.Location = new System.Drawing.Point(99, 69);
            this.doctorIsBookedButton.Name = "doctorIsBookedButton";
            this.doctorIsBookedButton.Size = new System.Drawing.Size(157, 23);
            this.doctorIsBookedButton.TabIndex = 4;
            this.doctorIsBookedButton.Text = "Call DoctorIsBooked Method";
            this.doctorIsBookedButton.UseVisualStyleBackColor = true;
            this.doctorIsBookedButton.Click += new System.EventHandler(this.DoctorIsBookedButton_Click);
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
            this.addAppointmentButton.Click += new System.EventHandler(this.AddAppointmentButton_Click);
            // 
            // addVisitTabPage
            // 
            this.addVisitTabPage.Controls.Add(this.groupBox3);
            this.addVisitTabPage.Controls.Add(this.addVisitGroupBox);
            this.addVisitTabPage.Location = new System.Drawing.Point(4, 22);
            this.addVisitTabPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addVisitTabPage.Name = "addVisitTabPage";
            this.addVisitTabPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addVisitTabPage.Size = new System.Drawing.Size(324, 410);
            this.addVisitTabPage.TabIndex = 3;
            this.addVisitTabPage.Text = "VisitController";
            this.addVisitTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.findVisitsButton);
            this.groupBox3.Controls.Add(this.patientIdTextBox1);
            this.groupBox3.Controls.Add(this.patientIdLabel1);
            this.groupBox3.Location = new System.Drawing.Point(5, 65);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(262, 73);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "FindVisits";
            // 
            // findVisitsButton
            // 
            this.findVisitsButton.Location = new System.Drawing.Point(99, 41);
            this.findVisitsButton.Name = "findVisitsButton";
            this.findVisitsButton.Size = new System.Drawing.Size(157, 23);
            this.findVisitsButton.TabIndex = 4;
            this.findVisitsButton.Text = "Call FindVisits Method";
            this.findVisitsButton.UseVisualStyleBackColor = true;
            this.findVisitsButton.Click += new System.EventHandler(this.FindVisitsButton_Click);
            // 
            // patientIdTextBox1
            // 
            this.patientIdTextBox1.Location = new System.Drawing.Point(99, 17);
            this.patientIdTextBox1.Name = "patientIdTextBox1";
            this.patientIdTextBox1.Size = new System.Drawing.Size(157, 20);
            this.patientIdTextBox1.TabIndex = 2;
            // 
            // patientIdLabel1
            // 
            this.patientIdLabel1.AutoSize = true;
            this.patientIdLabel1.Location = new System.Drawing.Point(6, 20);
            this.patientIdLabel1.Name = "patientIdLabel1";
            this.patientIdLabel1.Size = new System.Drawing.Size(54, 13);
            this.patientIdLabel1.TabIndex = 0;
            this.patientIdLabel1.Text = "Patient ID";
            // 
            // addVisitGroupBox
            // 
            this.addVisitGroupBox.Controls.Add(this.addVisitButton);
            this.addVisitGroupBox.Location = new System.Drawing.Point(5, 6);
            this.addVisitGroupBox.Name = "addVisitGroupBox";
            this.addVisitGroupBox.Size = new System.Drawing.Size(262, 53);
            this.addVisitGroupBox.TabIndex = 1;
            this.addVisitGroupBox.TabStop = false;
            this.addVisitGroupBox.Text = "AddVisit";
            // 
            // addVisitButton
            // 
            this.addVisitButton.Location = new System.Drawing.Point(7, 20);
            this.addVisitButton.Name = "addVisitButton";
            this.addVisitButton.Size = new System.Drawing.Size(247, 23);
            this.addVisitButton.TabIndex = 0;
            this.addVisitButton.Text = "Add Visit";
            this.addVisitButton.UseVisualStyleBackColor = true;
            this.addVisitButton.Click += new System.EventHandler(this.AddVisitButton_Click);
            // 
            // DataAccessTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 456);
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
            this.getUserGroupBox.ResumeLayout(false);
            this.getUserGroupBox.PerformLayout();
            this.patientControllerTabPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.findPatientsGroupBox.ResumeLayout(false);
            this.findPatientsGroupBox.PerformLayout();
            this.editPatientGroupBox.ResumeLayout(false);
            this.addPatientGroupBox.ResumeLayout(false);
            this.appointmentControllerTabPage.ResumeLayout(false);
            this.findAppointmentsGroupBox.ResumeLayout(false);
            this.findAppointmentsGroupBox.PerformLayout();
            this.editAppointmentGroupBox.ResumeLayout(false);
            this.doctorIsBookedGroupBox.ResumeLayout(false);
            this.doctorIsBookedGroupBox.PerformLayout();
            this.addAppointmentGroupBox.ResumeLayout(false);
            this.addVisitTabPage.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.addVisitGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox credentialsAreValidGroupBox;
        private System.Windows.Forms.Button credentialsAreValidButton;
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
        private System.Windows.Forms.GroupBox getUserGroupBox;
        private System.Windows.Forms.Button getUserButton;
        private System.Windows.Forms.TextBox getUserUsernameTextBox;
        private System.Windows.Forms.Label getUserUsernameLabel;
        private System.Windows.Forms.GroupBox findPatientsGroupBox;
        private System.Windows.Forms.Button findPatientsButton;
        private System.Windows.Forms.TextBox dateOfBirthTextBox;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button findPatientsButton2;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox lastNameTextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button findPatientsButton3;
        private System.Windows.Forms.TextBox dateOfBirthTextBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox findAppointmentsGroupBox;
        private System.Windows.Forms.Button findAppointmentsButton;
        private System.Windows.Forms.TextBox patientIdTextBox;
        private System.Windows.Forms.Label patientIdLabel;
        private System.Windows.Forms.TabPage addVisitTabPage;
        private System.Windows.Forms.GroupBox addVisitGroupBox;
        private System.Windows.Forms.Button addVisitButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button findVisitsButton;
        private System.Windows.Forms.TextBox patientIdTextBox1;
        private System.Windows.Forms.Label patientIdLabel1;
    }
}
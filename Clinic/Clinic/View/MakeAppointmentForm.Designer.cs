﻿
namespace Clinic.View
{
    partial class MakeAppointmentForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.searchPatientButton = new System.Windows.Forms.Button();
            this.SearchPatientNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.doctorComboBox = new System.Windows.Forms.ComboBox();
            this.searchAppointmentsButton = new System.Windows.Forms.Button();
            this.reserveAppointmentButton = new System.Windows.Forms.Button();
            this.errorNoticeLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.searchPatientButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.SearchPatientNameTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.doctorComboBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.searchAppointmentsButton, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.reserveAppointmentButton, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.errorNoticeLabel, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 43);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 405);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search for patient by name:";
            // 
            // searchPatientButton
            // 
            this.searchPatientButton.Location = new System.Drawing.Point(623, 3);
            this.searchPatientButton.Name = "searchPatientButton";
            this.searchPatientButton.Size = new System.Drawing.Size(138, 19);
            this.searchPatientButton.TabIndex = 1;
            this.searchPatientButton.Text = "Search for Patient";
            this.searchPatientButton.UseVisualStyleBackColor = true;
            // 
            // SearchPatientNameTextBox
            // 
            this.SearchPatientNameTextBox.Location = new System.Drawing.Point(158, 3);
            this.SearchPatientNameTextBox.Name = "SearchPatientNameTextBox";
            this.SearchPatientNameTextBox.Size = new System.Drawing.Size(459, 20);
            this.SearchPatientNameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose the correct patient by name and D.O.B.:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Choose doctor to view available appointments:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Choose appointment from the list of available slots:";
            // 
            // doctorComboBox
            // 
            this.doctorComboBox.FormattingEnabled = true;
            this.doctorComboBox.Location = new System.Drawing.Point(158, 103);
            this.doctorComboBox.Name = "doctorComboBox";
            this.doctorComboBox.Size = new System.Drawing.Size(346, 21);
            this.doctorComboBox.TabIndex = 6;
            // 
            // searchAppointmentsButton
            // 
            this.searchAppointmentsButton.Location = new System.Drawing.Point(623, 103);
            this.searchAppointmentsButton.Name = "searchAppointmentsButton";
            this.searchAppointmentsButton.Size = new System.Drawing.Size(138, 40);
            this.searchAppointmentsButton.TabIndex = 7;
            this.searchAppointmentsButton.Text = "Search for Available Appointments";
            this.searchAppointmentsButton.UseVisualStyleBackColor = true;
            // 
            // reserveAppointmentButton
            // 
            this.reserveAppointmentButton.Location = new System.Drawing.Point(158, 353);
            this.reserveAppointmentButton.Name = "reserveAppointmentButton";
            this.reserveAppointmentButton.Size = new System.Drawing.Size(459, 19);
            this.reserveAppointmentButton.TabIndex = 8;
            this.reserveAppointmentButton.Text = "Reserve Appointment";
            this.reserveAppointmentButton.UseVisualStyleBackColor = true;
            // 
            // errorNoticeLabel
            // 
            this.errorNoticeLabel.AutoSize = true;
            this.errorNoticeLabel.ForeColor = System.Drawing.Color.Red;
            this.errorNoticeLabel.Location = new System.Drawing.Point(158, 375);
            this.errorNoticeLabel.Name = "errorNoticeLabel";
            this.errorNoticeLabel.Size = new System.Drawing.Size(0, 13);
            this.errorNoticeLabel.TabIndex = 9;
            // 
            // MakeAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MakeAppointmentForm";
            this.Text = "Make Appointment";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchPatientButton;
        private System.Windows.Forms.TextBox SearchPatientNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox doctorComboBox;
        private System.Windows.Forms.Button searchAppointmentsButton;
        private System.Windows.Forms.Button reserveAppointmentButton;
        private System.Windows.Forms.Label errorNoticeLabel;
    }
}
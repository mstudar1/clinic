
namespace Clinic.View
{
    partial class EnterLabTestResultForm
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
            this.formTitleLabel = new System.Windows.Forms.Label();
            this.patientNameLabel = new System.Windows.Forms.Label();
            this.testNameLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.resultTextLabel = new System.Windows.Forms.Label();
            this.conclusionLabel = new System.Windows.Forms.Label();
            this.prefillPatientNameLabel = new System.Windows.Forms.Label();
            this.prefillTestNameLabel = new System.Windows.Forms.Label();
            this.resultDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.normalRadioButton = new System.Windows.Forms.RadioButton();
            this.abnormalRadioButton = new System.Windows.Forms.RadioButton();
            this.submitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.alertTextLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.patientNameLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.testNameLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dateLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.resultTextLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.conclusionLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.prefillPatientNameLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.prefillTestNameLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.resultDateTimePicker, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.formTitleLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.submitButton, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.cancelButton, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.alertTextLabel, 1, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(604, 309);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // formTitleLabel
            // 
            this.formTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.formTitleLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.formTitleLabel, 2);
            this.formTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitleLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.formTitleLabel.Location = new System.Drawing.Point(3, 10);
            this.formTitleLabel.Name = "formTitleLabel";
            this.formTitleLabel.Size = new System.Drawing.Size(296, 29);
            this.formTitleLabel.TabIndex = 0;
            this.formTitleLabel.Text = "Enter Lab Test Results";
            this.formTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // patientNameLabel
            // 
            this.patientNameLabel.AutoSize = true;
            this.patientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientNameLabel.Location = new System.Drawing.Point(3, 50);
            this.patientNameLabel.Name = "patientNameLabel";
            this.patientNameLabel.Size = new System.Drawing.Size(97, 17);
            this.patientNameLabel.TabIndex = 1;
            this.patientNameLabel.Text = "Patient Name:";
            // 
            // testNameLabel
            // 
            this.testNameLabel.AutoSize = true;
            this.testNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testNameLabel.Location = new System.Drawing.Point(3, 85);
            this.testNameLabel.Name = "testNameLabel";
            this.testNameLabel.Size = new System.Drawing.Size(81, 17);
            this.testNameLabel.TabIndex = 2;
            this.testNameLabel.Text = "Test Name:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(3, 120);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(102, 17);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "Date of Result:";
            // 
            // resultTextLabel
            // 
            this.resultTextLabel.AutoSize = true;
            this.resultTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTextLabel.Location = new System.Drawing.Point(3, 155);
            this.resultTextLabel.Name = "resultTextLabel";
            this.resultTextLabel.Size = new System.Drawing.Size(52, 17);
            this.resultTextLabel.TabIndex = 4;
            this.resultTextLabel.Text = "Result:";
            // 
            // conclusionLabel
            // 
            this.conclusionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.conclusionLabel.AutoSize = true;
            this.conclusionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conclusionLabel.Location = new System.Drawing.Point(3, 204);
            this.conclusionLabel.Name = "conclusionLabel";
            this.conclusionLabel.Size = new System.Drawing.Size(81, 17);
            this.conclusionLabel.TabIndex = 5;
            this.conclusionLabel.Text = "Conclusion:";
            // 
            // prefillPatientNameLabel
            // 
            this.prefillPatientNameLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.prefillPatientNameLabel, 2);
            this.prefillPatientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prefillPatientNameLabel.ForeColor = System.Drawing.Color.Teal;
            this.prefillPatientNameLabel.Location = new System.Drawing.Point(154, 50);
            this.prefillPatientNameLabel.Name = "prefillPatientNameLabel";
            this.prefillPatientNameLabel.Size = new System.Drawing.Size(46, 17);
            this.prefillPatientNameLabel.TabIndex = 6;
            this.prefillPatientNameLabel.Text = "label1";
            // 
            // prefillTestNameLabel
            // 
            this.prefillTestNameLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.prefillTestNameLabel, 2);
            this.prefillTestNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prefillTestNameLabel.ForeColor = System.Drawing.Color.Teal;
            this.prefillTestNameLabel.Location = new System.Drawing.Point(154, 85);
            this.prefillTestNameLabel.Name = "prefillTestNameLabel";
            this.prefillTestNameLabel.Size = new System.Drawing.Size(46, 17);
            this.prefillTestNameLabel.TabIndex = 7;
            this.prefillTestNameLabel.Text = "label1";
            // 
            // resultDateTimePicker
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.resultDateTimePicker, 3);
            this.resultDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultDateTimePicker.Location = new System.Drawing.Point(154, 123);
            this.resultDateTimePicker.Name = "resultDateTimePicker";
            this.resultDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.resultDateTimePicker.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.textBox1, 3);
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(154, 158);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(447, 23);
            this.textBox1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.abnormalRadioButton);
            this.groupBox1.Controls.Add(this.normalRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(154, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 39);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // normalRadioButton
            // 
            this.normalRadioButton.AutoSize = true;
            this.normalRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normalRadioButton.Location = new System.Drawing.Point(6, 12);
            this.normalRadioButton.Name = "normalRadioButton";
            this.normalRadioButton.Size = new System.Drawing.Size(71, 21);
            this.normalRadioButton.TabIndex = 0;
            this.normalRadioButton.TabStop = true;
            this.normalRadioButton.Text = "Normal";
            this.normalRadioButton.UseVisualStyleBackColor = true;
            // 
            // abnormalRadioButton
            // 
            this.abnormalRadioButton.AutoSize = true;
            this.abnormalRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abnormalRadioButton.Location = new System.Drawing.Point(83, 12);
            this.abnormalRadioButton.Name = "abnormalRadioButton";
            this.abnormalRadioButton.Size = new System.Drawing.Size(86, 21);
            this.abnormalRadioButton.TabIndex = 1;
            this.abnormalRadioButton.TabStop = true;
            this.abnormalRadioButton.Text = "Abnormal";
            this.abnormalRadioButton.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(154, 238);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 29);
            this.submitButton.TabIndex = 11;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(305, 238);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 29);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // alertTextLabel
            // 
            this.alertTextLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.alertTextLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.alertTextLabel, 3);
            this.alertTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertTextLabel.ForeColor = System.Drawing.Color.Red;
            this.alertTextLabel.Location = new System.Drawing.Point(154, 281);
            this.alertTextLabel.Name = "alertTextLabel";
            this.alertTextLabel.Size = new System.Drawing.Size(0, 17);
            this.alertTextLabel.TabIndex = 13;
            // 
            // EnterLabTestResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 325);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EnterLabTestResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter Lab Test Result";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label formTitleLabel;
        private System.Windows.Forms.Label patientNameLabel;
        private System.Windows.Forms.Label testNameLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label resultTextLabel;
        private System.Windows.Forms.Label conclusionLabel;
        private System.Windows.Forms.Label prefillPatientNameLabel;
        private System.Windows.Forms.Label prefillTestNameLabel;
        private System.Windows.Forms.DateTimePicker resultDateTimePicker;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton abnormalRadioButton;
        private System.Windows.Forms.RadioButton normalRadioButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label alertTextLabel;
    }
}
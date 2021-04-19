
namespace Clinic.View
{
    partial class AddDiagnosisForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.diagnosisLabel = new System.Windows.Forms.Label();
            this.finalLabel = new System.Windows.Forms.Label();
            this.OkayButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.finalYesRadioButton = new System.Windows.Forms.RadioButton();
            this.finalNoRadioButton = new System.Windows.Forms.RadioButton();
            this.alertMessage = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel1.Controls.Add(this.titleLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.diagnosisLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.finalLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.OkayButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cancelButton, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.alertMessage, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(511, 228);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.titleLabel, 2);
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.titleLabel.Location = new System.Drawing.Point(130, 10);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(248, 29);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Record Diagnosis";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // diagnosisLabel
            // 
            this.diagnosisLabel.AutoSize = true;
            this.diagnosisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagnosisLabel.Location = new System.Drawing.Point(3, 50);
            this.diagnosisLabel.Name = "diagnosisLabel";
            this.diagnosisLabel.Size = new System.Drawing.Size(74, 17);
            this.diagnosisLabel.TabIndex = 1;
            this.diagnosisLabel.Text = "Diagnosis:";
            // 
            // finalLabel
            // 
            this.finalLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.finalLabel.AutoSize = true;
            this.finalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalLabel.Location = new System.Drawing.Point(3, 111);
            this.finalLabel.Name = "finalLabel";
            this.finalLabel.Size = new System.Drawing.Size(46, 17);
            this.finalLabel.TabIndex = 2;
            this.finalLabel.Text = "Final?";
            // 
            // OkayButton
            // 
            this.OkayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkayButton.Location = new System.Drawing.Point(130, 158);
            this.OkayButton.Name = "OkayButton";
            this.OkayButton.Size = new System.Drawing.Size(108, 29);
            this.OkayButton.TabIndex = 3;
            this.OkayButton.Text = "Okay";
            this.OkayButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(257, 158);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(108, 29);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.textBox1, 3);
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(130, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(378, 23);
            this.textBox1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.finalNoRadioButton);
            this.groupBox1.Controls.Add(this.finalYesRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(130, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 64);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // finalYesRadioButton
            // 
            this.finalYesRadioButton.AutoSize = true;
            this.finalYesRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalYesRadioButton.Location = new System.Drawing.Point(46, 20);
            this.finalYesRadioButton.Name = "finalYesRadioButton";
            this.finalYesRadioButton.Size = new System.Drawing.Size(50, 21);
            this.finalYesRadioButton.TabIndex = 0;
            this.finalYesRadioButton.Text = "Yes";
            this.finalYesRadioButton.UseVisualStyleBackColor = true;
            // 
            // finalNoRadioButton
            // 
            this.finalNoRadioButton.AutoSize = true;
            this.finalNoRadioButton.Checked = true;
            this.finalNoRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalNoRadioButton.Location = new System.Drawing.Point(174, 20);
            this.finalNoRadioButton.Name = "finalNoRadioButton";
            this.finalNoRadioButton.Size = new System.Drawing.Size(44, 21);
            this.finalNoRadioButton.TabIndex = 1;
            this.finalNoRadioButton.TabStop = true;
            this.finalNoRadioButton.Text = "No";
            this.finalNoRadioButton.UseVisualStyleBackColor = true;
            // 
            // alertMessage
            // 
            this.alertMessage.AutoSize = true;
            this.alertMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertMessage.ForeColor = System.Drawing.Color.Red;
            this.alertMessage.Location = new System.Drawing.Point(130, 190);
            this.alertMessage.Name = "alertMessage";
            this.alertMessage.Size = new System.Drawing.Size(0, 17);
            this.alertMessage.TabIndex = 7;
            // 
            // AddDiagnosisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 248);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddDiagnosisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Diagnosis";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label diagnosisLabel;
        private System.Windows.Forms.Label finalLabel;
        private System.Windows.Forms.Button OkayButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton finalNoRadioButton;
        private System.Windows.Forms.RadioButton finalYesRadioButton;
        private System.Windows.Forms.Label alertMessage;
    }
}
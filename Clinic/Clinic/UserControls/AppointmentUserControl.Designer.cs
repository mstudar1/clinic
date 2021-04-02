
namespace Clinic.UserControls
{
    partial class AppointmentUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.setAppointmentButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.resetButton = new System.Windows.Forms.Button();
            this.appointmentsLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.searchButton = new System.Windows.Forms.Button();
            this.appDateTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.NursListView = new System.Windows.Forms.ListView();
            this.nameClumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dobColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.doctorClumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.editColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deleteColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.NursListView, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.74725F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.25275F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 247F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(719, 362);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.847736F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.15226F));
            this.tableLayoutPanel2.Controls.Add(this.setAppointmentButton, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(713, 31);
            this.tableLayoutPanel2.TabIndex = 20;
            // 
            // setAppointmentButton
            // 
            this.setAppointmentButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.setAppointmentButton.AutoSize = true;
            this.setAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setAppointmentButton.Location = new System.Drawing.Point(66, 2);
            this.setAppointmentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.setAppointmentButton.Name = "setAppointmentButton";
            this.setAppointmentButton.Size = new System.Drawing.Size(223, 27);
            this.setAppointmentButton.TabIndex = 10;
            this.setAppointmentButton.Text = "Set Appointment";
            this.setAppointmentButton.UseVisualStyleBackColor = true;
            this.setAppointmentButton.Click += new System.EventHandler(this.SetAppointmentButton_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.58187F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.41813F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel3.Controls.Add(this.resetButton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.appointmentsLabel, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 79);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(713, 32);
            this.tableLayoutPanel3.TabIndex = 30;
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resetButton.AutoSize = true;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(553, 2);
            this.resetButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(96, 28);
            this.resetButton.TabIndex = 10;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // appointmentsLabel
            // 
            this.appointmentsLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.appointmentsLabel.AutoSize = true;
            this.appointmentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentsLabel.Location = new System.Drawing.Point(15, 3);
            this.appointmentsLabel.Name = "appointmentsLabel";
            this.appointmentsLabel.Size = new System.Drawing.Size(169, 29);
            this.appointmentsLabel.TabIndex = 99;
            this.appointmentsLabel.Text = "Appointments";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.35203F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.64797F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.Controls.Add(this.searchButton, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.appDateTextBox, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.nameTextBox, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(713, 36);
            this.tableLayoutPanel4.TabIndex = 10;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.searchButton.AutoSize = true;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(615, 2);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(93, 32);
            this.searchButton.TabIndex = 30;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // appDateTextBox
            // 
            this.appDateTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.appDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appDateTextBox.Location = new System.Drawing.Point(454, 3);
            this.appDateTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.appDateTextBox.Name = "appDateTextBox";
            this.appDateTextBox.Size = new System.Drawing.Size(155, 30);
            this.appDateTextBox.TabIndex = 20;
            this.appDateTextBox.Tag = "";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(248, 3);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 30);
            this.nameTextBox.TabIndex = 10;
            this.nameTextBox.Tag = "";
            // 
            // NursListView
            // 
            this.NursListView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.NursListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameClumnHeader,
            this.dobColumnHeader,
            this.doctorClumnHeader,
            this.dateColumnHeader,
            this.viewColumnHeader,
            this.editColumnHeader,
            this.deleteColumnHeader});
            this.NursListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NursListView.HideSelection = false;
            this.NursListView.Location = new System.Drawing.Point(13, 116);
            this.NursListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NursListView.Name = "NursListView";
            this.NursListView.Size = new System.Drawing.Size(693, 244);
            this.NursListView.TabIndex = 40;
            this.NursListView.TabStop = false;
            this.NursListView.UseCompatibleStateImageBehavior = false;
            this.NursListView.View = System.Windows.Forms.View.Details;
            // 
            // nameClumnHeader
            // 
            this.nameClumnHeader.Text = "Name";
            this.nameClumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameClumnHeader.Width = 185;
            // 
            // dobColumnHeader
            // 
            this.dobColumnHeader.Text = "DOB";
            this.dobColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dobColumnHeader.Width = 110;
            // 
            // doctorClumnHeader
            // 
            this.doctorClumnHeader.Text = "Doctor";
            this.doctorClumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.doctorClumnHeader.Width = 185;
            // 
            // dateColumnHeader
            // 
            this.dateColumnHeader.Text = "Date";
            this.dateColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dateColumnHeader.Width = 110;
            // 
            // viewColumnHeader
            // 
            this.viewColumnHeader.Text = "View";
            this.viewColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.viewColumnHeader.Width = 90;
            // 
            // editColumnHeader
            // 
            this.editColumnHeader.Text = "Edit";
            this.editColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.editColumnHeader.Width = 90;
            // 
            // deleteColumnHeader
            // 
            this.deleteColumnHeader.Text = "Delete";
            this.deleteColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deleteColumnHeader.Width = 90;
            // 
            // AppointmentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AppointmentUserControl";
            this.Size = new System.Drawing.Size(732, 380);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button setAppointmentButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label appointmentsLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox appDateTextBox;
        private System.Windows.Forms.ListView NursListView;
        private System.Windows.Forms.ColumnHeader nameClumnHeader;
        private System.Windows.Forms.ColumnHeader doctorClumnHeader;
        private System.Windows.Forms.ColumnHeader dobColumnHeader;
        private System.Windows.Forms.ColumnHeader viewColumnHeader;
        private System.Windows.Forms.ColumnHeader editColumnHeader;
        private System.Windows.Forms.ColumnHeader deleteColumnHeader;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ColumnHeader dateColumnHeader;
    }
}

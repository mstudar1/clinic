
namespace Clinic.View
{
    partial class OrderNewLabTestForm
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
            this.components = new System.ComponentModel.Container();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.testChoiceLabel = new System.Windows.Forms.Label();
            this.orderTestButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.alertTextLable = new System.Windows.Forms.Label();
            this.labTestListBox = new System.Windows.Forms.ListBox();
            this.labTestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labTestBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 4;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainTableLayoutPanel.Controls.Add(this.titleLabel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.testChoiceLabel, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.orderTestButton, 1, 2);
            this.mainTableLayoutPanel.Controls.Add(this.cancelButton, 2, 2);
            this.mainTableLayoutPanel.Controls.Add(this.alertTextLable, 1, 3);
            this.mainTableLayoutPanel.Controls.Add(this.labTestListBox, 1, 1);
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(2, 1);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 4;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(430, 323);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.AutoSize = true;
            this.mainTableLayoutPanel.SetColumnSpan(this.titleLabel, 4);
            this.titleLabel.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.titleLabel.Location = new System.Drawing.Point(2, 5);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(426, 54);
            this.titleLabel.TabIndex = 17;
            this.titleLabel.Text = "Order New Lab Tests";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // testChoiceLabel
            // 
            this.testChoiceLabel.AutoSize = true;
            this.testChoiceLabel.Location = new System.Drawing.Point(3, 64);
            this.testChoiceLabel.Name = "testChoiceLabel";
            this.testChoiceLabel.Size = new System.Drawing.Size(96, 13);
            this.testChoiceLabel.TabIndex = 18;
            this.testChoiceLabel.Text = "Choose Lab Tests:";
            // 
            // orderTestButton
            // 
            this.orderTestButton.Location = new System.Drawing.Point(110, 260);
            this.orderTestButton.Name = "orderTestButton";
            this.orderTestButton.Size = new System.Drawing.Size(101, 21);
            this.orderTestButton.TabIndex = 19;
            this.orderTestButton.Text = "Order Test(s)";
            this.orderTestButton.UseVisualStyleBackColor = true;
            this.orderTestButton.Click += new System.EventHandler(this.OrderTestButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(217, 260);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(101, 21);
            this.cancelButton.TabIndex = 20;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // alertTextLable
            // 
            this.alertTextLable.AutoSize = true;
            this.mainTableLayoutPanel.SetColumnSpan(this.alertTextLable, 3);
            this.alertTextLable.ForeColor = System.Drawing.Color.Red;
            this.alertTextLable.Location = new System.Drawing.Point(110, 289);
            this.alertTextLable.Name = "alertTextLable";
            this.alertTextLable.Size = new System.Drawing.Size(0, 13);
            this.alertTextLable.TabIndex = 21;
            // 
            // labTestListBox
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.labTestListBox, 2);
            this.labTestListBox.DataSource = this.labTestBindingSource;
            this.labTestListBox.DisplayMember = "Name";
            this.labTestListBox.FormattingEnabled = true;
            this.labTestListBox.Location = new System.Drawing.Point(110, 67);
            this.labTestListBox.Name = "labTestListBox";
            this.labTestListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.labTestListBox.Size = new System.Drawing.Size(208, 186);
            this.labTestListBox.TabIndex = 22;
            this.labTestListBox.ValueMember = "TestCode";
            // 
            // labTestBindingSource
            // 
            this.labTestBindingSource.DataSource = typeof(Clinic.Model.LabTest);
            // 
            // OrderNewLabTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 329);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderNewLabTestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Lab Test";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrderNewLabTestForm_FormClosed);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labTestBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.BindingSource labTestBindingSource;
        private System.Windows.Forms.Label testChoiceLabel;
        private System.Windows.Forms.Button orderTestButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label alertTextLable;
        private System.Windows.Forms.ListBox labTestListBox;
    }
}
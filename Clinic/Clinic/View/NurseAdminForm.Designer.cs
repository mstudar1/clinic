
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
            this.activeUsernameLabel = new System.Windows.Forms.Label();
            this.LogputButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // activeUsernameLabel
            // 
            this.activeUsernameLabel.AutoSize = true;
            this.activeUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeUsernameLabel.Location = new System.Drawing.Point(1168, 29);
            this.activeUsernameLabel.Name = "activeUsernameLabel";
            this.activeUsernameLabel.Size = new System.Drawing.Size(24, 36);
            this.activeUsernameLabel.TabIndex = 0;
            this.activeUsernameLabel.Text = ".";
            // 
            // LogputButton
            // 
            this.LogputButton.AutoSize = true;
            this.LogputButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogputButton.Location = new System.Drawing.Point(1342, 24);
            this.LogputButton.Name = "LogputButton";
            this.LogputButton.Size = new System.Drawing.Size(124, 46);
            this.LogputButton.TabIndex = 1;
            this.LogputButton.Text = "Logout";
            this.LogputButton.UseVisualStyleBackColor = true;
            // 
            // NurseAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 944);
            this.Controls.Add(this.LogputButton);
            this.Controls.Add(this.activeUsernameLabel);
            this.Name = "NurseAdminForm";
            this.Text = "Nurse/Admin Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label activeUsernameLabel;
        private System.Windows.Forms.Button LogputButton;
    }
}
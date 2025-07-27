// FrmDetails.Designer.cs
// CST-150 Activity 7
// Author: Eric Gathinji
// Date: 24 July 2025

namespace PresentationLayer
{
    partial class FrmDetails
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblNameValue = new System.Windows.Forms.Label();
            this.lblTypeValue = new System.Windows.Forms.Label();
            this.lblAgeValue = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // lblTitle
            this.lblTitle.Text = "Pet Details";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(110, 20);
            this.lblTitle.AutoSize = true;

            // lblName
            this.lblName.Text = "Name:";
            this.lblName.Location = new System.Drawing.Point(30, 70);
            this.lblName.AutoSize = true;

            // lblNameValue
            this.lblNameValue.Location = new System.Drawing.Point(100, 70);
            this.lblNameValue.AutoSize = true;

            // lblType
            this.lblType.Text = "Type:";
            this.lblType.Location = new System.Drawing.Point(30, 110);
            this.lblType.AutoSize = true;

            // lblTypeValue
            this.lblTypeValue.Location = new System.Drawing.Point(100, 110);
            this.lblTypeValue.AutoSize = true;

            // lblAge
            this.lblAge.Text = "Age:";
            this.lblAge.Location = new System.Drawing.Point(30, 150);
            this.lblAge.AutoSize = true;

            // lblAgeValue
            this.lblAgeValue.Location = new System.Drawing.Point(100, 150);
            this.lblAgeValue.AutoSize = true;

            // btnClose
            this.btnClose.Text = "Close";
            this.btnClose.Location = new System.Drawing.Point(110, 200);
            this.btnClose.Size = new System.Drawing.Size(75, 30);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // FrmDetails
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(300, 260);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblNameValue);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblTypeValue);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblAgeValue);
            this.Controls.Add(this.btnClose);
            this.Text = "Details";

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblNameValue;
        private System.Windows.Forms.Label lblTypeValue;
        private System.Windows.Forms.Label lblAgeValue;
        private System.Windows.Forms.Button btnClose;
    }
}

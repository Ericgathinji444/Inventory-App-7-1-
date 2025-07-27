// 
// CST-150 Activity 7
// Author: Eric Gathinji
// Date: 24 July 2025

using System.Windows.Forms;

namespace PresentationLayer
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtName;
        private TextBox txtType;
        private TextBox txtAge;
        private Button btnSubmit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtName = new TextBox();
            this.txtType = new TextBox();
            this.txtAge = new TextBox();
            this.btnSubmit = new Button();
            this.SuspendLayout();

            // txtName
            this.txtName.Location = new System.Drawing.Point(30, 30);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "Enter Pet Name";
            this.txtName.Size = new System.Drawing.Size(200, 27);

            // txtType
            this.txtType.Location = new System.Drawing.Point(30, 70);
            this.txtType.Name = "txtType";
            this.txtType.PlaceholderText = "Enter Pet Type";
            this.txtType.Size = new System.Drawing.Size(200, 27);

            // txtAge
            this.txtAge.Location = new System.Drawing.Point(30, 110);
            this.txtAge.Name = "txtAge";
            this.txtAge.PlaceholderText = "Enter Pet Age";
            this.txtAge.Size = new System.Drawing.Size(200, 27);

            // btnSubmit
            this.btnSubmit.Location = new System.Drawing.Point(30, 150);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 30);
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            // FrmMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(300, 220);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.btnSubmit);
            this.Name = "FrmMain";
            this.Text = "Pet Entry Form";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

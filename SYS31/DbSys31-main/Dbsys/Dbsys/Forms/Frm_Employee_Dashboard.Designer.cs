﻿namespace Dbsys.Forms
{
    partial class Frm_Employee_Dashboard
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
            this.SuspendLayout();
            // 
            // Frm_Employee_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 590);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Employee_Dashboard";
            this.Text = "Frm_Employee_Dashboard";
            this.Load += new System.EventHandler(this.Frm_Employee_Dashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
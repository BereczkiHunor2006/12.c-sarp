﻿
namespace ElsoForm
{
    partial class MainForm
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
            this.btnKattints = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKattints
            // 
            this.btnKattints.Location = new System.Drawing.Point(374, 172);
            this.btnKattints.Name = "btnKattints";
            this.btnKattints.Size = new System.Drawing.Size(75, 23);
            this.btnKattints.TabIndex = 0;
            this.btnKattints.Text = "Kattints";
            this.btnKattints.UseVisualStyleBackColor = true;
            this.btnKattints.Click += new System.EventHandler(this.btnKattints_Click);
            this.btnKattints.MouseEnter += new System.EventHandler(this.btnKattints_MouseHover);
            this.btnKattints.MouseLeave += new System.EventHandler(this.btnKattints_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(799, 445);
            this.Controls.Add(this.btnKattints);
            this.Name = "MainForm";
            this.Text = "próbálgatás";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKattints;
    }
}


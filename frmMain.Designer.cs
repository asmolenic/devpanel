﻿namespace DevPanel
{
    partial class frmMain
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
            this.btnAndrei = new System.Windows.Forms.Button();
            this.btnElisabeta = new System.Windows.Forms.Button();
            this.btnFlorin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAndrei
            // 
            this.btnAndrei.Location = new System.Drawing.Point(25, 22);
            this.btnAndrei.Name = "btnAndrei";
            this.btnAndrei.Size = new System.Drawing.Size(75, 23);
            this.btnAndrei.TabIndex = 0;
            this.btnAndrei.Text = "Andrei";
            this.btnAndrei.UseVisualStyleBackColor = true;
            this.btnAndrei.Click += new System.EventHandler(this.btnAndrei_Click);
            // 
            // btnElisabeta
            // 
            this.btnElisabeta.Location = new System.Drawing.Point(125, 21);
            this.btnElisabeta.Name = "btnElisabeta";
            this.btnElisabeta.Size = new System.Drawing.Size(75, 23);
            this.btnElisabeta.TabIndex = 1;
            this.btnElisabeta.Text = "Elisabeta";
            this.btnElisabeta.UseVisualStyleBackColor = true;
            this.btnElisabeta.Click += new System.EventHandler(this.btnElisabeta_Click);
            // 
            // btnFlorin
            // 
            this.btnFlorin.Location = new System.Drawing.Point(231, 21);
            this.btnFlorin.Name = "btnFlorin";
            this.btnFlorin.Size = new System.Drawing.Size(75, 23);
            this.btnFlorin.TabIndex = 2;
            this.btnFlorin.Text = "Florin";
            this.btnFlorin.UseVisualStyleBackColor = true;
            this.btnFlorin.Click += new System.EventHandler(this.btnFlorin_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 291);
            this.Controls.Add(this.btnFlorin);
            this.Controls.Add(this.btnElisabeta);
            this.Controls.Add(this.btnAndrei);
            this.Name = "frmMain";
            this.Text = "Dev Panel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAndrei;
        private System.Windows.Forms.Button btnElisabeta;
        private System.Windows.Forms.Button btnFlorin;
    }
}


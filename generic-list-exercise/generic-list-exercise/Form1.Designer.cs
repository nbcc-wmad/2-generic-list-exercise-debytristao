﻿namespace generic_list_exercise
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.btnFindGrade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score:";
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(106, 46);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(114, 22);
            this.txtScore.TabIndex = 1;
            // 
            // btnFindGrade
            // 
            this.btnFindGrade.Location = new System.Drawing.Point(106, 101);
            this.btnFindGrade.Name = "btnFindGrade";
            this.btnFindGrade.Size = new System.Drawing.Size(100, 23);
            this.btnFindGrade.TabIndex = 2;
            this.btnFindGrade.Text = "Find Grade";
            this.btnFindGrade.UseVisualStyleBackColor = true;
            this.btnFindGrade.Click += new System.EventHandler(this.btnFindGrade_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 194);
            this.Controls.Add(this.btnFindGrade);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Button btnFindGrade;
    }
}


﻿namespace OrvosiNobeldijasokGUI
{
    partial class Ev
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Nev = new System.Windows.Forms.TextBox();
            this.szh = new System.Windows.Forms.TextBox();
            this.orszag = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Eves = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Év:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Név:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sz/H:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ország:";
            // 
            // Nev
            // 
            this.Nev.Location = new System.Drawing.Point(96, 56);
            this.Nev.Name = "Nev";
            this.Nev.Size = new System.Drawing.Size(171, 20);
            this.Nev.TabIndex = 5;
            // 
            // szh
            // 
            this.szh.Location = new System.Drawing.Point(96, 88);
            this.szh.Name = "szh";
            this.szh.Size = new System.Drawing.Size(120, 20);
            this.szh.TabIndex = 6;
            // 
            // orszag
            // 
            this.orszag.Location = new System.Drawing.Point(96, 117);
            this.orszag.Name = "orszag";
            this.orszag.Size = new System.Drawing.Size(57, 20);
            this.orszag.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Adatok mentése";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Eves
            // 
            this.Eves.Location = new System.Drawing.Point(96, 26);
            this.Eves.Name = "Eves";
            this.Eves.Size = new System.Drawing.Size(57, 20);
            this.Eves.TabIndex = 9;
            // 
            // Ev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 217);
            this.Controls.Add(this.Eves);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.orszag);
            this.Controls.Add(this.szh);
            this.Controls.Add(this.Nev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ev";
            this.Text = "Orvosi Nobel-díjasok";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Nev;
        private System.Windows.Forms.TextBox szh;
        private System.Windows.Forms.TextBox orszag;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Eves;
    }
}


﻿namespace Budić_Marković_RacPrakt_Projekt
{
    partial class AdminForm
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
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.Button();
            this.btnPromet = new System.Windows.Forms.Button();
            this.btnDjelatnici = new System.Windows.Forms.Button();
            this.btnZaliha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.Location = new System.Drawing.Point(12, 9);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(95, 32);
            this.lblAdmin.TabIndex = 1;
            this.lblAdmin.Text = "Admin";
            // 
            // lblBack
            // 
            this.lblBack.Location = new System.Drawing.Point(696, 413);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(92, 25);
            this.lblBack.TabIndex = 2;
            this.lblBack.Text = "Back";
            this.lblBack.UseVisualStyleBackColor = true;
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // btnPromet
            // 
            this.btnPromet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromet.Location = new System.Drawing.Point(32, 130);
            this.btnPromet.Name = "btnPromet";
            this.btnPromet.Size = new System.Drawing.Size(95, 39);
            this.btnPromet.TabIndex = 3;
            this.btnPromet.Text = "Promet";
            this.btnPromet.UseVisualStyleBackColor = true;
            // 
            // btnDjelatnici
            // 
            this.btnDjelatnici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDjelatnici.Location = new System.Drawing.Point(32, 198);
            this.btnDjelatnici.Name = "btnDjelatnici";
            this.btnDjelatnici.Size = new System.Drawing.Size(95, 39);
            this.btnDjelatnici.TabIndex = 4;
            this.btnDjelatnici.Text = "Djelatnici";
            this.btnDjelatnici.UseVisualStyleBackColor = true;
            // 
            // btnZaliha
            // 
            this.btnZaliha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZaliha.Location = new System.Drawing.Point(32, 264);
            this.btnZaliha.Name = "btnZaliha";
            this.btnZaliha.Size = new System.Drawing.Size(95, 39);
            this.btnZaliha.TabIndex = 5;
            this.btnZaliha.Text = "Zalihe";
            this.btnZaliha.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnZaliha);
            this.Controls.Add(this.btnDjelatnici);
            this.Controls.Add(this.btnPromet);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.lblAdmin);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Button lblBack;
        private System.Windows.Forms.Button btnPromet;
        private System.Windows.Forms.Button btnDjelatnici;
        private System.Windows.Forms.Button btnZaliha;
    }
}
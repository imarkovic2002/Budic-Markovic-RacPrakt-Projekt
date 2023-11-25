namespace Budić_Marković_RacPrakt_Projekt
{
    partial class DjelatnikForm
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
            this.lblDjelatnik = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgOsobniPodaci = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgOsobniPodaci)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDjelatnik
            // 
            this.lblDjelatnik.AutoSize = true;
            this.lblDjelatnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDjelatnik.Location = new System.Drawing.Point(12, 9);
            this.lblDjelatnik.Name = "lblDjelatnik";
            this.lblDjelatnik.Size = new System.Drawing.Size(125, 32);
            this.lblDjelatnik.TabIndex = 0;
            this.lblDjelatnik.Text = "Djelatnik";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(696, 413);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(92, 25);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgOsobniPodaci
            // 
            this.dgOsobniPodaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOsobniPodaci.Location = new System.Drawing.Point(12, 90);
            this.dgOsobniPodaci.Name = "dgOsobniPodaci";
            this.dgOsobniPodaci.RowHeadersWidth = 51;
            this.dgOsobniPodaci.RowTemplate.Height = 24;
            this.dgOsobniPodaci.Size = new System.Drawing.Size(275, 150);
            this.dgOsobniPodaci.TabIndex = 2;
            // 
            // DjelatnikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgOsobniPodaci);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblDjelatnik);
            this.Name = "DjelatnikForm";
            this.Text = "Djelatnik";
            ((System.ComponentModel.ISupportInitialize)(this.dgOsobniPodaci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDjelatnik;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgOsobniPodaci;
    }
}
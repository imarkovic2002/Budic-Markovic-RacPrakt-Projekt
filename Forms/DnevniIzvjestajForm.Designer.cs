namespace Budić_Marković_RacPrakt_Projekt.Forms
{
    partial class DnevniIzvjestajForm
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
            this.dgDanasnjiPromet = new System.Windows.Forms.DataGridView();
            this.btnIzlaz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDanasnjiPromet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDanasnjiPromet
            // 
            this.dgDanasnjiPromet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDanasnjiPromet.Location = new System.Drawing.Point(12, 12);
            this.dgDanasnjiPromet.Name = "dgDanasnjiPromet";
            this.dgDanasnjiPromet.RowHeadersWidth = 51;
            this.dgDanasnjiPromet.RowTemplate.Height = 24;
            this.dgDanasnjiPromet.Size = new System.Drawing.Size(776, 392);
            this.dgDanasnjiPromet.TabIndex = 0;
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(700, 410);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(88, 28);
            this.btnIzlaz.TabIndex = 1;
            this.btnIzlaz.Text = "Izađi";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // DnevniIzvjestajForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.dgDanasnjiPromet);
            this.Name = "DnevniIzvjestajForm";
            this.Text = "DnevniIzvjestajForm";
            this.Load += new System.EventHandler(this.DnevniIzvjestajForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDanasnjiPromet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDanasnjiPromet;
        private System.Windows.Forms.Button btnIzlaz;
    }
}
namespace Budić_Marković_RacPrakt_Projekt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.Button();
            this.tabAdmin = new System.Windows.Forms.TabControl();
            this.Promet = new System.Windows.Forms.TabPage();
            this.Blagajna = new System.Windows.Forms.TabPage();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnMlijeko1l = new System.Windows.Forms.Button();
            this.btnHrana1 = new System.Windows.Forms.Button();
            this.btnSlatkisi1 = new System.Windows.Forms.Button();
            this.btnSok2 = new System.Windows.Forms.Button();
            this.btnSok1 = new System.Windows.Forms.Button();
            this.btnČokolada = new System.Windows.Forms.Button();
            this.Djelatnici = new System.Windows.Forms.TabPage();
            this.Skladiste = new System.Windows.Forms.TabPage();
            this.dgPromet = new System.Windows.Forms.DataGridView();
            this.tabAdmin.SuspendLayout();
            this.Promet.SuspendLayout();
            this.Blagajna.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPromet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.Location = new System.Drawing.Point(12, 9);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(0, 32);
            this.lblAdmin.TabIndex = 1;
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
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.Promet);
            this.tabAdmin.Controls.Add(this.Blagajna);
            this.tabAdmin.Controls.Add(this.Djelatnici);
            this.tabAdmin.Controls.Add(this.Skladiste);
            this.tabAdmin.Location = new System.Drawing.Point(18, 54);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(770, 343);
            this.tabAdmin.TabIndex = 7;
            // 
            // Promet
            // 
            this.Promet.Controls.Add(this.dgPromet);
            this.Promet.Location = new System.Drawing.Point(4, 25);
            this.Promet.Name = "Promet";
            this.Promet.Padding = new System.Windows.Forms.Padding(3);
            this.Promet.Size = new System.Drawing.Size(762, 314);
            this.Promet.TabIndex = 0;
            this.Promet.Text = "Promet";
            this.Promet.UseVisualStyleBackColor = true;
            this.Promet.Click += new System.EventHandler(this.Promet_Click);
            // 
            // Blagajna
            // 
            this.Blagajna.Controls.Add(this.button10);
            this.Blagajna.Controls.Add(this.button9);
            this.Blagajna.Controls.Add(this.button8);
            this.Blagajna.Controls.Add(this.button7);
            this.Blagajna.Controls.Add(this.button6);
            this.Blagajna.Controls.Add(this.button5);
            this.Blagajna.Controls.Add(this.btnMlijeko1l);
            this.Blagajna.Controls.Add(this.btnHrana1);
            this.Blagajna.Controls.Add(this.btnSlatkisi1);
            this.Blagajna.Controls.Add(this.btnSok2);
            this.Blagajna.Controls.Add(this.btnSok1);
            this.Blagajna.Controls.Add(this.btnČokolada);
            this.Blagajna.Location = new System.Drawing.Point(4, 25);
            this.Blagajna.Name = "Blagajna";
            this.Blagajna.Padding = new System.Windows.Forms.Padding(3);
            this.Blagajna.Size = new System.Drawing.Size(762, 314);
            this.Blagajna.TabIndex = 1;
            this.Blagajna.Text = "Blagajna";
            this.Blagajna.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button10.BackgroundImage")));
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button10.Location = new System.Drawing.Point(486, 216);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(96, 71);
            this.button10.TabIndex = 23;
            this.button10.Text = "Coca-cola 1L";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button9.BackgroundImage")));
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button9.Location = new System.Drawing.Point(384, 216);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(96, 71);
            this.button9.TabIndex = 22;
            this.button9.Text = "Coca-cola 1L";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button8.Location = new System.Drawing.Point(282, 216);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(96, 71);
            this.button8.TabIndex = 21;
            this.button8.Text = "Coca-cola 1L";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button7.Location = new System.Drawing.Point(180, 216);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(96, 71);
            this.button7.TabIndex = 20;
            this.button7.Text = "Coca-cola 1L";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button6.Location = new System.Drawing.Point(486, 123);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(96, 71);
            this.button6.TabIndex = 19;
            this.button6.Text = "Coca-cola 1L";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button5.Location = new System.Drawing.Point(384, 123);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 71);
            this.button5.TabIndex = 18;
            this.button5.Text = "Coca-cola 1L";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // btnMlijeko1l
            // 
            this.btnMlijeko1l.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMlijeko1l.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMlijeko1l.BackgroundImage")));
            this.btnMlijeko1l.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMlijeko1l.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMlijeko1l.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMlijeko1l.Location = new System.Drawing.Point(282, 123);
            this.btnMlijeko1l.Name = "btnMlijeko1l";
            this.btnMlijeko1l.Size = new System.Drawing.Size(96, 71);
            this.btnMlijeko1l.TabIndex = 17;
            this.btnMlijeko1l.Text = "Mlijeko 1L";
            this.btnMlijeko1l.UseVisualStyleBackColor = false;
            // 
            // btnHrana1
            // 
            this.btnHrana1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnHrana1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHrana1.BackgroundImage")));
            this.btnHrana1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHrana1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHrana1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHrana1.Location = new System.Drawing.Point(180, 123);
            this.btnHrana1.Name = "btnHrana1";
            this.btnHrana1.Size = new System.Drawing.Size(96, 71);
            this.btnHrana1.TabIndex = 16;
            this.btnHrana1.Text = "Lazanje";
            this.btnHrana1.UseVisualStyleBackColor = false;
            // 
            // btnSlatkisi1
            // 
            this.btnSlatkisi1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSlatkisi1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSlatkisi1.BackgroundImage")));
            this.btnSlatkisi1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSlatkisi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlatkisi1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSlatkisi1.Location = new System.Drawing.Point(486, 28);
            this.btnSlatkisi1.Name = "btnSlatkisi1";
            this.btnSlatkisi1.Size = new System.Drawing.Size(96, 71);
            this.btnSlatkisi1.TabIndex = 15;
            this.btnSlatkisi1.Text = "Haribo";
            this.btnSlatkisi1.UseVisualStyleBackColor = false;
            // 
            // btnSok2
            // 
            this.btnSok2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSok2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSok2.BackgroundImage")));
            this.btnSok2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSok2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSok2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSok2.Location = new System.Drawing.Point(384, 28);
            this.btnSok2.Name = "btnSok2";
            this.btnSok2.Size = new System.Drawing.Size(96, 71);
            this.btnSok2.TabIndex = 14;
            this.btnSok2.Text = "Coca-cola 0.33l";
            this.btnSok2.UseVisualStyleBackColor = false;
            // 
            // btnSok1
            // 
            this.btnSok1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSok1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSok1.BackgroundImage")));
            this.btnSok1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSok1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSok1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSok1.Location = new System.Drawing.Point(282, 28);
            this.btnSok1.Name = "btnSok1";
            this.btnSok1.Size = new System.Drawing.Size(96, 71);
            this.btnSok1.TabIndex = 13;
            this.btnSok1.Text = "Coca-cola 1L";
            this.btnSok1.UseVisualStyleBackColor = false;
            // 
            // btnČokolada
            // 
            this.btnČokolada.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnČokolada.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnČokolada.BackgroundImage")));
            this.btnČokolada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnČokolada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnČokolada.ForeColor = System.Drawing.Color.Transparent;
            this.btnČokolada.Location = new System.Drawing.Point(180, 28);
            this.btnČokolada.Name = "btnČokolada";
            this.btnČokolada.Size = new System.Drawing.Size(96, 71);
            this.btnČokolada.TabIndex = 12;
            this.btnČokolada.Text = "Čokolada";
            this.btnČokolada.UseVisualStyleBackColor = false;
            // 
            // Djelatnici
            // 
            this.Djelatnici.Location = new System.Drawing.Point(4, 25);
            this.Djelatnici.Name = "Djelatnici";
            this.Djelatnici.Padding = new System.Windows.Forms.Padding(3);
            this.Djelatnici.Size = new System.Drawing.Size(762, 314);
            this.Djelatnici.TabIndex = 2;
            this.Djelatnici.Text = "Djelatnici";
            this.Djelatnici.UseVisualStyleBackColor = true;
            // 
            // Skladiste
            // 
            this.Skladiste.Location = new System.Drawing.Point(4, 25);
            this.Skladiste.Name = "Skladiste";
            this.Skladiste.Padding = new System.Windows.Forms.Padding(3);
            this.Skladiste.Size = new System.Drawing.Size(762, 314);
            this.Skladiste.TabIndex = 3;
            this.Skladiste.Text = "Skladište";
            this.Skladiste.UseVisualStyleBackColor = true;
            // 
            // dgPromet
            // 
            this.dgPromet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPromet.Location = new System.Drawing.Point(64, 35);
            this.dgPromet.Name = "dgPromet";
            this.dgPromet.RowHeadersWidth = 51;
            this.dgPromet.RowTemplate.Height = 24;
            this.dgPromet.Size = new System.Drawing.Size(669, 200);
            this.dgPromet.TabIndex = 0;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabAdmin);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.lblAdmin);
            this.Name = "AdminForm";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.tabAdmin.ResumeLayout(false);
            this.Promet.ResumeLayout(false);
            this.Blagajna.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPromet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Button lblBack;
        private System.Windows.Forms.TabControl tabAdmin;
        private System.Windows.Forms.TabPage Promet;
        private System.Windows.Forms.TabPage Blagajna;
        private System.Windows.Forms.TabPage Djelatnici;
        private System.Windows.Forms.TabPage Skladiste;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnMlijeko1l;
        private System.Windows.Forms.Button btnHrana1;
        private System.Windows.Forms.Button btnSlatkisi1;
        private System.Windows.Forms.Button btnSok2;
        private System.Windows.Forms.Button btnSok1;
        private System.Windows.Forms.Button btnČokolada;
        private System.Windows.Forms.DataGridView dgPromet;
    }
}
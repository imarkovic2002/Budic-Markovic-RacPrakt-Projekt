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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DjelatnikForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Button();
            this.tabAdmin = new System.Windows.Forms.TabControl();
            this.Promet = new System.Windows.Forms.TabPage();
            this.dgPromet = new System.Windows.Forms.DataGridView();
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
            this.dgDjelatnici = new System.Windows.Forms.DataGridView();
            this.menuDjelatnici = new System.Windows.Forms.MenuStrip();
            this.toolSDodaj = new System.Windows.Forms.ToolStripMenuItem();
            this.toolAzuriraj = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsSObrisi = new System.Windows.Forms.ToolStripMenuItem();
            this.Skladiste = new System.Windows.Forms.TabPage();
            this.dgSkladiste = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsNoviProizvod = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsAzuriraj = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSObrisiProizvod = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.tabAdmin.SuspendLayout();
            this.Promet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPromet)).BeginInit();
            this.Blagajna.SuspendLayout();
            this.Djelatnici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDjelatnici)).BeginInit();
            this.menuDjelatnici.SuspendLayout();
            this.Skladiste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSkladiste)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            // lblExit
            // 
            this.lblExit.BackColor = System.Drawing.Color.OrangeRed;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblExit.Location = new System.Drawing.Point(693, 402);
            this.lblExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(93, 36);
            this.lblExit.TabIndex = 2;
            this.lblExit.Text = "Exit";
            this.lblExit.UseVisualStyleBackColor = false;
            this.lblExit.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.Promet);
            this.tabAdmin.Controls.Add(this.Blagajna);
            this.tabAdmin.Controls.Add(this.Djelatnici);
            this.tabAdmin.Controls.Add(this.Skladiste);
            this.tabAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabAdmin.Location = new System.Drawing.Point(0, 0);
            this.tabAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(809, 333);
            this.tabAdmin.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabAdmin.TabIndex = 7;
            // 
            // Promet
            // 
            this.Promet.Controls.Add(this.dgPromet);
            this.Promet.Location = new System.Drawing.Point(4, 25);
            this.Promet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Promet.Name = "Promet";
            this.Promet.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Promet.Size = new System.Drawing.Size(801, 304);
            this.Promet.TabIndex = 0;
            this.Promet.Text = "Promet";
            this.Promet.UseVisualStyleBackColor = true;
            this.Promet.Click += new System.EventHandler(this.Promet_Click);
            // 
            // dgPromet
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPromet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgPromet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPromet.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgPromet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPromet.Location = new System.Drawing.Point(3, 2);
            this.dgPromet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgPromet.Name = "dgPromet";
            this.dgPromet.RowHeadersWidth = 51;
            this.dgPromet.RowTemplate.Height = 24;
            this.dgPromet.Size = new System.Drawing.Size(795, 300);
            this.dgPromet.TabIndex = 0;
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
            this.Blagajna.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Blagajna.Name = "Blagajna";
            this.Blagajna.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Blagajna.Size = new System.Drawing.Size(801, 304);
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
            this.button10.Location = new System.Drawing.Point(485, 217);
            this.button10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.button9.Location = new System.Drawing.Point(384, 217);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.button8.Location = new System.Drawing.Point(283, 217);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.button7.Location = new System.Drawing.Point(180, 217);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.button6.Location = new System.Drawing.Point(485, 123);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btnMlijeko1l.Location = new System.Drawing.Point(283, 123);
            this.btnMlijeko1l.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btnHrana1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btnSlatkisi1.Location = new System.Drawing.Point(485, 28);
            this.btnSlatkisi1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btnSok2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btnSok1.Location = new System.Drawing.Point(283, 28);
            this.btnSok1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btnČokolada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnČokolada.Name = "btnČokolada";
            this.btnČokolada.Size = new System.Drawing.Size(96, 71);
            this.btnČokolada.TabIndex = 12;
            this.btnČokolada.Text = "Čokolada";
            this.btnČokolada.UseVisualStyleBackColor = false;
            // 
            // Djelatnici
            // 
            this.Djelatnici.Controls.Add(this.dgDjelatnici);
            this.Djelatnici.Controls.Add(this.menuDjelatnici);
            this.Djelatnici.Location = new System.Drawing.Point(4, 25);
            this.Djelatnici.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Djelatnici.Name = "Djelatnici";
            this.Djelatnici.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Djelatnici.Size = new System.Drawing.Size(801, 304);
            this.Djelatnici.TabIndex = 2;
            this.Djelatnici.Text = "Djelatnici";
            this.Djelatnici.UseVisualStyleBackColor = true;
            // 
            // dgDjelatnici
            // 
            this.dgDjelatnici.AllowUserToOrderColumns = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDjelatnici.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgDjelatnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDjelatnici.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgDjelatnici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDjelatnici.Location = new System.Drawing.Point(3, 32);
            this.dgDjelatnici.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgDjelatnici.Name = "dgDjelatnici";
            this.dgDjelatnici.RowHeadersWidth = 51;
            this.dgDjelatnici.RowTemplate.Height = 24;
            this.dgDjelatnici.Size = new System.Drawing.Size(795, 270);
            this.dgDjelatnici.TabIndex = 0;
            // 
            // menuDjelatnici
            // 
            this.menuDjelatnici.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuDjelatnici.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSDodaj,
            this.toolAzuriraj,
            this.toolsSObrisi});
            this.menuDjelatnici.Location = new System.Drawing.Point(3, 2);
            this.menuDjelatnici.Name = "menuDjelatnici";
            this.menuDjelatnici.Size = new System.Drawing.Size(795, 30);
            this.menuDjelatnici.TabIndex = 1;
            this.menuDjelatnici.Text = "menuDjelatnici";
            // 
            // toolSDodaj
            // 
            this.toolSDodaj.Name = "toolSDodaj";
            this.toolSDodaj.Size = new System.Drawing.Size(64, 26);
            this.toolSDodaj.Text = "Dodaj";
            this.toolSDodaj.Click += new System.EventHandler(this.toolSDodaj_Click);
            // 
            // toolAzuriraj
            // 
            this.toolAzuriraj.Name = "toolAzuriraj";
            this.toolAzuriraj.Size = new System.Drawing.Size(74, 26);
            this.toolAzuriraj.Text = "Ažuriraj";
            this.toolAzuriraj.Click += new System.EventHandler(this.toolAzuriraj_Click);
            // 
            // toolsSObrisi
            // 
            this.toolsSObrisi.Name = "toolsSObrisi";
            this.toolsSObrisi.Size = new System.Drawing.Size(62, 26);
            this.toolsSObrisi.Text = "Obriši";
            this.toolsSObrisi.Click += new System.EventHandler(this.toolsSObrisi_Click);
            // 
            // Skladiste
            // 
            this.Skladiste.Controls.Add(this.dgSkladiste);
            this.Skladiste.Controls.Add(this.menuStrip1);
            this.Skladiste.Location = new System.Drawing.Point(4, 25);
            this.Skladiste.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Skladiste.Name = "Skladiste";
            this.Skladiste.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Skladiste.Size = new System.Drawing.Size(801, 304);
            this.Skladiste.TabIndex = 3;
            this.Skladiste.Text = "Skladište";
            this.Skladiste.UseVisualStyleBackColor = true;
            // 
            // dgSkladiste
            // 
            this.dgSkladiste.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSkladiste.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgSkladiste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgSkladiste.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgSkladiste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSkladiste.Location = new System.Drawing.Point(3, 30);
            this.dgSkladiste.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgSkladiste.Name = "dgSkladiste";
            this.dgSkladiste.RowHeadersWidth = 51;
            this.dgSkladiste.RowTemplate.Height = 24;
            this.dgSkladiste.Size = new System.Drawing.Size(795, 272);
            this.dgSkladiste.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsNoviProizvod,
            this.toolsAzuriraj,
            this.toolSObrisiProizvod});
            this.menuStrip1.Location = new System.Drawing.Point(3, 2);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(795, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolsNoviProizvod
            // 
            this.toolsNoviProizvod.Name = "toolsNoviProizvod";
            this.toolsNoviProizvod.Size = new System.Drawing.Size(64, 24);
            this.toolsNoviProizvod.Text = "Dodaj";
            this.toolsNoviProizvod.Click += new System.EventHandler(this.toolStripMenuItem1_Click_1);
            // 
            // toolsAzuriraj
            // 
            this.toolsAzuriraj.Name = "toolsAzuriraj";
            this.toolsAzuriraj.Size = new System.Drawing.Size(78, 24);
            this.toolsAzuriraj.Text = "Ažuriraj ";
            this.toolsAzuriraj.Click += new System.EventHandler(this.toolsAzuriraj_Click);
            // 
            // toolSObrisiProizvod
            // 
            this.toolSObrisiProizvod.Name = "toolSObrisiProizvod";
            this.toolSObrisiProizvod.Size = new System.Drawing.Size(62, 24);
            this.toolSObrisiProizvod.Text = "Obriši";
            this.toolSObrisiProizvod.Click += new System.EventHandler(this.toolSObrisiProizvod_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(595, 402);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DjelatnikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 477);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabAdmin);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblAdmin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DjelatnikForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.DjelatnikForm_Load);
            this.tabAdmin.ResumeLayout(false);
            this.Promet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPromet)).EndInit();
            this.Blagajna.ResumeLayout(false);
            this.Djelatnici.ResumeLayout(false);
            this.Djelatnici.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDjelatnici)).EndInit();
            this.menuDjelatnici.ResumeLayout(false);
            this.menuDjelatnici.PerformLayout();
            this.Skladiste.ResumeLayout(false);
            this.Skladiste.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSkladiste)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Button lblExit;
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
        private System.Windows.Forms.DataGridView dgSkladiste;
        private System.Windows.Forms.DataGridView dgDjelatnici;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsNoviProizvod;
        private System.Windows.Forms.ToolStripMenuItem toolsAzuriraj;
        private System.Windows.Forms.ToolStripMenuItem toolSObrisiProizvod;
        private System.Windows.Forms.MenuStrip menuDjelatnici;
        private System.Windows.Forms.ToolStripMenuItem toolSDodaj;
        private System.Windows.Forms.ToolStripMenuItem toolAzuriraj;
        private System.Windows.Forms.ToolStripMenuItem toolsSObrisi;
    }
}
namespace Budić_Marković_RacPrakt_Projekt.Forms
{
    partial class AddEditDjelatnik
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtOib = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lbOib = new System.Windows.Forms.Label();
            this.lblCijena = new System.Windows.Forms.Label();
            this.lbIme = new System.Windows.Forms.Label();
            this.txBoxBrojMobitela = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.lbBroj_mobitela = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxLozinka = new System.Windows.Forms.TextBox();
            this.lbRole = new System.Windows.Forms.Label();
            this.lbLozink = new System.Windows.Forms.Label();
            this.lbDatumZaposlenja = new System.Windows.Forms.Label();
            this.lbDatumRod = new System.Windows.Forms.Label();
            this.dTPRodjenja = new System.Windows.Forms.DateTimePicker();
            this.dTPZaposlenja = new System.Windows.Forms.DateTimePicker();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBack.Location = new System.Drawing.Point(322, 385);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(116, 52);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "Izađi";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.Location = new System.Drawing.Point(13, 385);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 52);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Potvrdi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtOib
            // 
            this.txtOib.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtOib.Location = new System.Drawing.Point(193, 99);
            this.txtOib.Margin = new System.Windows.Forms.Padding(4);
            this.txtOib.Name = "txtOib";
            this.txtOib.Size = new System.Drawing.Size(197, 26);
            this.txtOib.TabIndex = 21;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPrezime.Location = new System.Drawing.Point(193, 54);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(197, 26);
            this.txtPrezime.TabIndex = 20;
            // 
            // txtIme
            // 
            this.txtIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtIme.Location = new System.Drawing.Point(193, 9);
            this.txtIme.Margin = new System.Windows.Forms.Padding(4);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(197, 26);
            this.txtIme.TabIndex = 19;
            // 
            // lbOib
            // 
            this.lbOib.AutoSize = true;
            this.lbOib.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbOib.Location = new System.Drawing.Point(13, 101);
            this.lbOib.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbOib.Name = "lbOib";
            this.lbOib.Size = new System.Drawing.Size(44, 20);
            this.lbOib.TabIndex = 18;
            this.lbOib.Text = "Oib:";
            // 
            // lblCijena
            // 
            this.lblCijena.AutoSize = true;
            this.lblCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCijena.Location = new System.Drawing.Point(13, 57);
            this.lblCijena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(84, 20);
            this.lblCijena.TabIndex = 17;
            this.lblCijena.Text = "Prezime:";
            // 
            // lbIme
            // 
            this.lbIme.AutoSize = true;
            this.lbIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbIme.Location = new System.Drawing.Point(13, 9);
            this.lbIme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIme.Name = "lbIme";
            this.lbIme.Size = new System.Drawing.Size(45, 20);
            this.lbIme.TabIndex = 16;
            this.lbIme.Text = "Ime:";
            // 
            // txBoxBrojMobitela
            // 
            this.txBoxBrojMobitela.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txBoxBrojMobitela.Location = new System.Drawing.Point(193, 231);
            this.txBoxBrojMobitela.Margin = new System.Windows.Forms.Padding(4);
            this.txBoxBrojMobitela.Name = "txBoxBrojMobitela";
            this.txBoxBrojMobitela.Size = new System.Drawing.Size(197, 26);
            this.txBoxBrojMobitela.TabIndex = 27;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxEmail.Location = new System.Drawing.Point(193, 142);
            this.txtBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(197, 26);
            this.txtBoxEmail.TabIndex = 26;
            // 
            // lbBroj_mobitela
            // 
            this.lbBroj_mobitela.AutoSize = true;
            this.lbBroj_mobitela.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbBroj_mobitela.Location = new System.Drawing.Point(13, 234);
            this.lbBroj_mobitela.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBroj_mobitela.Name = "lbBroj_mobitela";
            this.lbBroj_mobitela.Size = new System.Drawing.Size(127, 20);
            this.lbBroj_mobitela.TabIndex = 25;
            this.lbBroj_mobitela.Text = "Broj Mobitela:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Email:";
            // 
            // txtBoxLozinka
            // 
            this.txtBoxLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxLozinka.Location = new System.Drawing.Point(193, 187);
            this.txtBoxLozinka.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxLozinka.Name = "txtBoxLozinka";
            this.txtBoxLozinka.PasswordChar = '*';
            this.txtBoxLozinka.Size = new System.Drawing.Size(197, 26);
            this.txtBoxLozinka.TabIndex = 30;
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbRole.Location = new System.Drawing.Point(13, 272);
            this.lbRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(53, 20);
            this.lbRole.TabIndex = 29;
            this.lbRole.Text = "Role:";
            // 
            // lbLozink
            // 
            this.lbLozink.AutoSize = true;
            this.lbLozink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbLozink.Location = new System.Drawing.Point(13, 193);
            this.lbLozink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLozink.Name = "lbLozink";
            this.lbLozink.Size = new System.Drawing.Size(80, 20);
            this.lbLozink.TabIndex = 28;
            this.lbLozink.Text = "Lozinka:";
            // 
            // lbDatumZaposlenja
            // 
            this.lbDatumZaposlenja.AutoSize = true;
            this.lbDatumZaposlenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbDatumZaposlenja.Location = new System.Drawing.Point(13, 353);
            this.lbDatumZaposlenja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDatumZaposlenja.Name = "lbDatumZaposlenja";
            this.lbDatumZaposlenja.Size = new System.Drawing.Size(160, 20);
            this.lbDatumZaposlenja.TabIndex = 33;
            this.lbDatumZaposlenja.Text = "Datum Zaposlenja";
            // 
            // lbDatumRod
            // 
            this.lbDatumRod.AutoSize = true;
            this.lbDatumRod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbDatumRod.Location = new System.Drawing.Point(13, 309);
            this.lbDatumRod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDatumRod.Name = "lbDatumRod";
            this.lbDatumRod.Size = new System.Drawing.Size(138, 20);
            this.lbDatumRod.TabIndex = 32;
            this.lbDatumRod.Text = "Datum Rođenja";
            // 
            // dTPRodjenja
            // 
            this.dTPRodjenja.CustomFormat = "yyyy-MM-dd";
            this.dTPRodjenja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPRodjenja.Location = new System.Drawing.Point(193, 309);
            this.dTPRodjenja.Name = "dTPRodjenja";
            this.dTPRodjenja.Size = new System.Drawing.Size(200, 22);
            this.dTPRodjenja.TabIndex = 34;
            // 
            // dTPZaposlenja
            // 
            this.dTPZaposlenja.CustomFormat = "yyyy-MM-dd";
            this.dTPZaposlenja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPZaposlenja.Location = new System.Drawing.Point(193, 350);
            this.dTPZaposlenja.Name = "dTPZaposlenja";
            this.dTPZaposlenja.Size = new System.Drawing.Size(200, 22);
            this.dTPZaposlenja.TabIndex = 35;
            // 
            // cmbRole
            // 
            this.cmbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(193, 269);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(197, 28);
            this.cmbRole.TabIndex = 36;
            // 
            // AddEditDjelatnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.dTPZaposlenja);
            this.Controls.Add(this.dTPRodjenja);
            this.Controls.Add(this.lbDatumZaposlenja);
            this.Controls.Add(this.lbDatumRod);
            this.Controls.Add(this.txtBoxLozinka);
            this.Controls.Add(this.lbRole);
            this.Controls.Add(this.lbLozink);
            this.Controls.Add(this.txBoxBrojMobitela);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.lbBroj_mobitela);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtOib);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.lbOib);
            this.Controls.Add(this.lblCijena);
            this.Controls.Add(this.lbIme);
            this.Name = "AddEditDjelatnik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddEditDjelatnik";
            this.Load += new System.EventHandler(this.AddEditDjelatnik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtOib;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lbOib;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.Label lbIme;
        private System.Windows.Forms.TextBox txBoxBrojMobitela;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label lbBroj_mobitela;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxLozinka;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.Label lbLozink;
        private System.Windows.Forms.Label lbDatumZaposlenja;
        private System.Windows.Forms.Label lbDatumRod;
        private System.Windows.Forms.DateTimePicker dTPRodjenja;
        private System.Windows.Forms.DateTimePicker dTPZaposlenja;
        private System.Windows.Forms.ComboBox cmbRole;
    }
}
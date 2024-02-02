using Blagajna.DB.Stores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budić_Marković_RacPrakt_Projekt.Forms
{
    public partial class AddEditDjelatnik : Form
       
    {
        private int Djelatnik_ID = 0;
        private DjelatnikStore _djelatnikStore;
        public AddEditDjelatnik(Djelatnik djelatnik)
        {
            InitializeComponent();
            if (_djelatnikStore == null) 
                _djelatnikStore = new DjelatnikStore();

            cmbRole.Items.Add("Admin");
            cmbRole.Items.Add("Blagajnik");

            if (djelatnik!=null && djelatnik.ID != 0)
            {
                this.Text = "Ažuriraj Djelatnika";
                btnSave.Text = "Ažuriraj";

                txtIme.Text = djelatnik.Ime;
                txtPrezime.Text=djelatnik.Prezime;
                txtOib.Text = djelatnik.OIB;
                txtBoxEmail.Text = djelatnik.Email;
                txBoxBrojMobitela.Text = djelatnik.BrojMobitela;
                txtBoxLozinka.Text = djelatnik.Lozinka;
                dTPRodjenja.Value = djelatnik.DatumRodjenja;
                dTPZaposlenja.Value = djelatnik.DatumZaposlenja;
                Djelatnik_ID = djelatnik.ID;

                cmbRole.SelectedItem = djelatnik.Role;
            }
            else
            {
                this.Text = "Dodaj korisnika";
                btnSave.Text = "Dodaj";
            }
        }

        private void AddEditDjelatnik_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Djelatnik djelatnik=new Djelatnik();
            djelatnik.ID = Djelatnik_ID;
            djelatnik.Ime=txtIme.Text;
            djelatnik.Prezime=txtPrezime.Text;
            djelatnik.DatumRodjenja = dTPRodjenja.Value;
            djelatnik.OIB = txtOib.Text;
            djelatnik.BrojMobitela = txBoxBrojMobitela.Text;
            djelatnik.Email=txtBoxEmail.Text;
            djelatnik.Lozinka=txtBoxLozinka.Text;
            djelatnik.DatumZaposlenja = dTPZaposlenja.Value;
            djelatnik.Role = cmbRole.SelectedItem.ToString();

            

            if (Djelatnik_ID != 0)
            {
                _djelatnikStore.AzurirajDjelatnika(djelatnik);
            }
            else
            {
                _djelatnikStore.DodajDjelatnika(djelatnik);
            }
            this.DialogResult = DialogResult.OK;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


    }
}

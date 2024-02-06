using Blagajna.Abstract.Models;
using Blagajna.DB.Stores;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Budić_Marković_RacPrakt_Projekt.Forms
{
    public partial class AddEditProizvodForm : Form
    {
        private int Proizvod_Id = 0;
        private ProizvodStore _proizvodStore;
        private KategorijaStore _kategorijaStore;
        public AddEditProizvodForm(Proizvod proizvod)
        {
            InitializeComponent();

            if(_proizvodStore == null)
                _proizvodStore = new ProizvodStore();

            if (_kategorijaStore == null)
                _kategorijaStore = new KategorijaStore();

            List<Kategorija> kategorije = _kategorijaStore.GetKategorije();
            foreach (Kategorija kategorija in kategorije)
            {
                comboBox1.Items.Add(kategorija.Naziv);
            }

            if (proizvod != null & proizvod.ID != 0)
            {
                //Ažuriranje
                this.Text = "Ažuriraj podatak";
                btnSave.Text = "Ažuriraj";

                txtNaziv.Text = proizvod.Naziv;
                txtCijena.Text = proizvod.Cijena.ToString();
                txtKolicina.Text = proizvod.Kolicina;
                Proizvod_Id = proizvod.ID;
            }
            else
            {
                //dodavanje
                this.Text = "Novi proizvod";
                btnSave.Text = "Dodaj";
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Proizvod proizvod= new Proizvod();

            proizvod.Naziv = txtNaziv.Text;
            proizvod.Cijena = float.Parse(txtCijena.Text);
            proizvod.Kolicina= txtKolicina.Text;
            proizvod.ID = Proizvod_Id;

            if (Proizvod_Id != 0)
            {
                int selectedKategorijaID = comboBox1.SelectedIndex + 1;
                _proizvodStore.AzurirajProizvod(proizvod,selectedKategorijaID);
            }
            else
            {
                _proizvodStore.DodajProizvod(proizvod);
                
            }

            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}

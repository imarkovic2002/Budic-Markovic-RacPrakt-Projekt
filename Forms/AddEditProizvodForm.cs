using Blagajna.Abstract.Models;
using Blagajna.DB.Stores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Budić_Marković_RacPrakt_Projekt.Forms
{
    public partial class AddEditProizvodForm : Form
    {
        private int Proizvod_Id = 0;
        private ProizvodStore _proizvodStore;
        public AddEditProizvodForm(Proizvod proizvod)
        {
            InitializeComponent();

            if(_proizvodStore == null)
            
                _proizvodStore = new ProizvodStore();

            if (proizvod != null & proizvod.ID != 0)
            {
                //Ažuriranje
                this.Text = "Ažuriraj podatak";
                btnSave.Text = "Ažuriraj";

                txtNaziv.Text = proizvod.naziv;
                txtCijena.Text = proizvod.cijena;
                txtKolicina.Text = proizvod.kolicina;
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

            proizvod.naziv = txtNaziv.Text;
            proizvod.cijena = txtCijena.Text;
            proizvod.kolicina= txtKolicina.Text;
            proizvod.ID = Proizvod_Id;

            if (Proizvod_Id != 0)
            {
                _proizvodStore.AzurirajProizvod(proizvod);
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

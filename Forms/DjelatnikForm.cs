using Blagajna.Abstract.Models;
using Blagajna.DB;
using Blagajna.DB.Stores;
using Budić_Marković_RacPrakt_Projekt.Forms;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;



namespace Budić_Marković_RacPrakt_Projekt
{
    public partial class DjelatnikForm : Form
    {
        private SqlConnectionFactory connectionFactory;
        private ProizvodStore _proizvodStore;
        private DjelatnikStore _djelatnikStore;
        private TransakcijaStore _transakcijaStore;
        private StornoStore _stornoStore;
        private Djelatnik djelatnikUse;
        private List<Proizvod> kosarica = new List<Proizvod>();
        public DjelatnikForm(Djelatnik djelatnik)
        {
            InitializeComponent();
            
            connectionFactory = new SqlConnectionFactory();
            tabDjelatnici.TabPages.Remove(Profil);
            tabDjelatnici.TabPages.Remove(Promet);
            tabDjelatnici.TabPages.Remove(Blagajna);
            tabDjelatnici.TabPages.Remove(Djelatnici);
            tabDjelatnici.TabPages.Remove(Skladiste);
           
            btnProizvod1.Click += (sender, e) => DodajProizvodUKosaricu(1);
            btnProizvod2.Click += (sender, e) => DodajProizvodUKosaricu(2);
            btnProizvod3.Click += (sender, e) => DodajProizvodUKosaricu(3);
            btnProizvod4.Click += (sender, e) => DodajProizvodUKosaricu(4);
            btnProizvod5.Click += (sender, e) => DodajProizvodUKosaricu(5);
            btnProizvod6.Click += (sender, e) => DodajProizvodUKosaricu(6);



            OpenFormBasedOnRole(djelatnik.Role);
            if (_proizvodStore == null)
                _proizvodStore = new ProizvodStore();
            if (_djelatnikStore == null)
                _djelatnikStore = new DjelatnikStore();
            if (_transakcijaStore == null)
                _transakcijaStore = new TransakcijaStore();
            if (_stornoStore == null)
                _stornoStore = new StornoStore();
            dgPromet.DataSource = _transakcijaStore.getTransakcije();
            dgDjelatnici.DataSource = _djelatnikStore.getDjelatnici();
            var proizvodi = _proizvodStore.getProizvods();
            dgSkladiste.DataSource = proizvodi;
            this.DialogResult = DialogResult.OK;
            djelatnikUse = new Djelatnik();

            djelatnikUse = djelatnik;
            lblDobrosao.Text = lblDobrosao.Text + djelatnikUse.Ime.ToString() + " " + djelatnik.Prezime.ToString();
            lblDatumRodenja.Text = lblDatumRodenja.Text + " " + djelatnik.DatumRodjenja.ToShortDateString();
            lblEmail.Text = lblEmail.Text + " " + djelatnik.Email.ToString();
            lblBroj.Text += " " + djelatnik.BrojMobitela.ToString();
            lblRoleProfil.Text += " " + djelatnik.Role.ToString();
        }
        private void OpenFormBasedOnRole(string role)
        {
            if (role.ToLower() == "admin")
            {
                tabDjelatnici.TabPages.Add(Profil);
                tabDjelatnici.TabPages.Add(Promet);
                tabDjelatnici.TabPages.Add(Blagajna);
                tabDjelatnici.TabPages.Add(Djelatnici);
                tabDjelatnici.TabPages.Add(Skladiste);
            }
            else if (role.ToLower() == "blagajnik")
            {
                tabDjelatnici.TabPages.Add(Profil);
                tabDjelatnici.TabPages.Add(Blagajna);
                tabDjelatnici.TabPages.Add(Skladiste);
                toolsNoviProizvod.Visible = false;
                toolsAzuriraj.Visible=false;
                toolSObrisiProizvod.Visible=false;
            }
        }
        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Windows.Forms.Application.Exit();
        }
       
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddEditDjelatnik addEditDjelatnik = new AddEditDjelatnik(new Djelatnik());

            if (addEditDjelatnik.ShowDialog() == DialogResult.OK)
            {
                dgDjelatnici.DataSource = _djelatnikStore.getDjelatnici();
            }
        }
        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            AddEditProizvodForm addEditProizvodForm = new AddEditProizvodForm(new Proizvod());
            if (addEditProizvodForm.ShowDialog() == DialogResult.OK)
            {
                dgSkladiste.DataSource = _proizvodStore.getProizvods();
            }
        }
        private void toolsAzuriraj_Click(object sender, EventArgs e)
        {
            Proizvod proizvod = new Proizvod();

            proizvod.ID = Convert.ToInt32(dgSkladiste.SelectedRows[0].Cells["Id"].Value);
            proizvod.Naziv = dgSkladiste.SelectedRows[0].Cells["Naziv"].Value.ToString();
            proizvod.Cijena = float.Parse(dgSkladiste.SelectedRows[0].Cells["Cijena"].Value.ToString());
            proizvod.Kolicina = dgSkladiste.SelectedRows[0].Cells["Kolicina"].Value.ToString();

            AddEditProizvodForm addEditProizvodForm = new AddEditProizvodForm(proizvod);

            if (addEditProizvodForm.ShowDialog() == DialogResult.OK)
            {
                dgSkladiste.DataSource = _proizvodStore.getProizvods();
            }
        }
        private void toolSObrisiProizvod_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Dali ste sigurni?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int selectedId = Convert.ToInt32(dgSkladiste.SelectedRows[0].Cells["ID"].Value);
                _proizvodStore.ObrisiProizvod(selectedId);
                dgSkladiste.DataSource = _proizvodStore.getProizvods();
            }
        }

        private void toolSDodaj_Click(object sender, EventArgs e)
        {
            AddEditDjelatnik addEditDjelatnik = new AddEditDjelatnik(new Djelatnik());

            if (addEditDjelatnik.ShowDialog() == DialogResult.OK)
            {
                dgDjelatnici.DataSource = _djelatnikStore.getDjelatnici();
            }
        }
        private void toolAzuriraj_Click(object sender, EventArgs e)
        {
            Djelatnik djelatnik = new Djelatnik();
            djelatnik.ID = Convert.ToInt32(dgDjelatnici.SelectedRows[0].Cells["ID"].Value);
            djelatnik.Ime = dgDjelatnici.SelectedRows[0].Cells["Ime"].Value.ToString();
            djelatnik.Prezime = dgDjelatnici.SelectedRows[0].Cells["Prezime"].Value.ToString();
            djelatnik.DatumRodjenja = DateTime.Parse(dgDjelatnici.SelectedRows[0].Cells["DatumRodjenja"].Value.ToString());
            djelatnik.OIB = dgDjelatnici.SelectedRows[0].Cells["OIB"].Value.ToString();
            djelatnik.BrojMobitela = dgDjelatnici.SelectedRows[0].Cells["BrojMobitela"].Value.ToString();
            djelatnik.Email = dgDjelatnici.SelectedRows[0].Cells["Email"].Value.ToString();
            djelatnik.Role = dgDjelatnici.SelectedRows[0].Cells["Role"].Value.ToString();
            djelatnik.Lozinka = dgDjelatnici.SelectedRows[0].Cells["Lozinka"].Value.ToString();
            djelatnik.DatumZaposlenja = DateTime.Parse(dgDjelatnici.SelectedRows[0].Cells["DatumZaposlenja"].Value.ToString());
            AddEditDjelatnik addEditDjelatnik = new AddEditDjelatnik(djelatnik);

            if (addEditDjelatnik.ShowDialog() == DialogResult.OK)
            {
                dgDjelatnici.DataSource = _djelatnikStore.getDjelatnici();
            }
        }
        private void toolsSObrisi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Dali ste sigurni?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int selectedId = Convert.ToInt32(dgDjelatnici.SelectedRows[0].Cells["ID"].Value);
                _djelatnikStore.ObrisiDjelatnika(selectedId);
                dgDjelatnici.DataSource = _djelatnikStore.getDjelatnici();
            }
        }
        private void toolSChangeProfile_Click(object sender, EventArgs e)
        {
            Djelatnik originalDjelatnik = new Djelatnik();
            originalDjelatnik = djelatnikUse.Clone();

            AddEditDjelatnik addEditDjelatnik = new AddEditDjelatnik(djelatnikUse);
            addEditDjelatnik.ShowDialog();

            Djelatnik updatedDjelatnik = _djelatnikStore.GetDjelatnik(djelatnikUse.ID);

            if (originalDjelatnik.Role.ToLower() == "blagajnik" && updatedDjelatnik.Role.ToLower() != originalDjelatnik.Role.ToLower())
            {
                MessageBox.Show("Blagajnik ne može mijenjati sam sebi role.", "Role Change Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                djelatnikUse.Role = originalDjelatnik.Role;
            }
            else
            {
                djelatnikUse = updatedDjelatnik;
                lblDobrosao.Text = "Dobrodošao, " + djelatnikUse.Ime.ToString() + " " + djelatnikUse.Prezime.ToString();
                lblDatumRodenja.Text = "Datum rođenja: " + djelatnikUse.DatumRodjenja.ToShortDateString();
                lblEmail.Text = "Email: " + djelatnikUse.Email.ToString();
                lblBroj.Text = "Broj mobitela: " + djelatnikUse.BrojMobitela.ToString();
                lblRoleProfil.Text = "Role: " + djelatnikUse.Role.ToString();
            }
        }

        private void stornoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Dali ste sigurni?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Storno storno = new Storno();
                storno.Id_transakcija = Convert.ToInt32(dgPromet.SelectedRows[0].Cells["ID"].Value);
                storno.Datum_storno = DateTime.Now;
                storno.Ukupni_iznos = float.Parse(dgPromet.SelectedRows[0].Cells["ukupni_iznos"].Value.ToString());
                _stornoStore.DodajStorno(storno);

            }
        }

        private void stornoBlagajnaMenuStrip_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Dali ste sigurni?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Storno storno = new Storno();
                storno.Id_transakcija = Convert.ToInt32(dgPromet.SelectedRows[0].Cells["ID"].Value);
                storno.Datum_storno = DateTime.Now;
                storno.Ukupni_iznos = float.Parse(dgPromet.SelectedRows[0].Cells["ukupni_iznos"].Value.ToString());
                _stornoStore.DodajStorno(storno);

            }
        }

        private void DodajProizvodUKosaricu(int proizvodIndex)
        {
            if (proizvodIndex < 1 || proizvodIndex > dgSkladiste.Rows.Count)
            {
                MessageBox.Show("Neispravan indeks proizvoda.");
                return;
            }

            Proizvod odabraniProizvod = dgSkladiste.Rows[proizvodIndex - 1].DataBoundItem as Proizvod;

            if(odabraniProizvod.Kolicina == "0")
            {
                MessageBox.Show($"Proizvod '{odabraniProizvod.Naziv}' trenutno nije raspoloživ.", "Nedostupan proizvod", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            kosarica.Add(odabraniProizvod);

            OsvjeziPrikazKosarice();
        }

        private void OsvjeziPrikazKosarice()
        {
            float sum = 0;

            listBoxKosarica.Items.Clear();
            foreach (Proizvod proizvod in kosarica)
            {
                sum = sum + proizvod.Cijena;
                listBoxKosarica.Items.Add($"{proizvod.Naziv} - Cijena: {proizvod.Cijena}");
            }
            lbCijena.Text = sum.ToString();
        }

        private void btnProizvod1_Click(object sender, EventArgs e)
        {
            /*
            var slika = kosarica.Where(x => x.ID == 100);
            btnProizvod1.Image = (Image)slika.Select(x => x.Image );
            */
        }

        private void btnIspisiRacun_Click(object sender, EventArgs e)
        {
            float sum = 0;

            foreach (Proizvod proizvod in kosarica)
            {
                sum = sum + proizvod.Cijena;
            }
            if (float.Parse(textBoxDano.Text) != 0)
            {
                float ostatak = float.Parse(textBoxDano.Text) - sum;
                MessageBox.Show("Vrati ostatak od " + ostatak + "€");
                _transakcijaStore.dodajTransakciju(sum, djelatnikUse, "Gotovina");
            }
            else
            {
                MessageBox.Show("Odabrali ste plaćanje karticom.");
                _transakcijaStore.dodajTransakciju(sum, djelatnikUse, "Kartica");
            }
            foreach (Proizvod proizvod1 in kosarica)
            {
                Proizvod proizvodUpdate = new Proizvod();
                proizvodUpdate = _proizvodStore.getProizvod(proizvod1.ID);
                int kolicina = Convert.ToInt32(proizvodUpdate.Kolicina) - 1;
                proizvodUpdate.Kolicina = kolicina.ToString();
                _proizvodStore.AzurirajProizvod(proizvodUpdate);

            }
            kosarica.Clear();
            listBoxKosarica.Items.Clear();
            textBoxDano.Text = "0";
            lbCijena.Text = "0";
            dgPromet.DataSource = _transakcijaStore.getTransakcije();
            dgSkladiste.DataSource = _proizvodStore.getProizvods();


        }

        private void današnjiPrometToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DnevniIzvjestajForm dnevniIzvjestajForm = new DnevniIzvjestajForm();
            dnevniIzvjestajForm.Show();
        }

        private void btnUkloni_Click(object sender, EventArgs e)
        {
            if (listBoxKosarica.SelectedIndex != -1)
            {
                Proizvod proizvodToRemove = kosarica[listBoxKosarica.SelectedIndex];
                kosarica.RemoveAt(listBoxKosarica.SelectedIndex);

              
                OsvjeziPrikazKosarice();  
            }
        }
        
        private void SetButtonImages()
        {
            var buttons = kosarica.ToList().AsEnumerable().Select(x => x);

            foreach (var button in buttons)
            {
                var image = _proizvodStore.LoadImageFromDatabase(button.ID);


                if (image != null)
                {
                    button.Image = image;
                }
                else
                {
                    button.Image = null;
                }
            }


        }
        
        
    }
}

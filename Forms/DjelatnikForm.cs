using Blagajna.Abstract.Models;
using Blagajna.DB;
using Blagajna.DB.Stores;
using Budić_Marković_RacPrakt_Projekt.Forms;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Budić_Marković_RacPrakt_Projekt
{
    public partial class DjelatnikForm : Form
    {
        private SqlConnectionFactory connectionFactory;
        private ProizvodStore _proizvodStore;
        private DjelatnikStore _djelatnikStore;
        public DjelatnikForm(Djelatnik djelatnik)
        {
            InitializeComponent();
            connectionFactory = new SqlConnectionFactory();
            tabAdmin.TabPages[0].Visible = false;
            tabAdmin.TabPages[1].Visible = false;
            tabAdmin.TabPages[2].Visible = false;
            tabAdmin.TabPages[3].Visible = false;
            dgPromet.DataSource = getTransakcije();
            dgDjelatnici.DataSource = getDjelatnici();
            OpenFormBasedOnRole(djelatnik);
            if (_proizvodStore == null)
                _proizvodStore = new ProizvodStore();
            if (_djelatnikStore == null)    
                _djelatnikStore = new DjelatnikStore();
            var proizvodi = _proizvodStore.getProizvods();
            dgSkladiste.DataSource = proizvodi;
            this.DialogResult = DialogResult.OK;

            lblDobrosao.Text =lblDobrosao.Text + djelatnik.Ime.ToString() + " " + djelatnik.Prezime.ToString();
            lblDatumRodenja.Text = lblDatumRodenja.Text + " " + djelatnik.DatumRodjenja.ToShortDateString();
            lblEmail.Text = lblEmail.Text + " " + djelatnik.Email.ToString();
            lblBroj.Text += " " + djelatnik.BrojMobitela.ToString();
            lblRoleProfil.Text += " " + djelatnik.Role.ToString();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Windows.Forms.Application.Exit();
        }

       

        private void OpenFormBasedOnRole(Djelatnik djelatnik)
        {
            if(djelatnik.Role.ToLower() == "admin ")
            {
                foreach (TabPage tabPage in tabAdmin.TabPages)
                {
                    tabPage.Visible = true;
                }
            }
            else if (djelatnik.Role.ToLower() == "blagajnik")
            {
                tabAdmin.TabPages[1].Visible = true;
            }
        }

        private void Promet_Click(object sender, EventArgs e)
        {

        }

        List<Transakcija> getTransakcije()
        {
            List<Transakcija> tranksakcija = new List<Transakcija>();
            using (MySqlConnection connection = connectionFactory.GetNewConnection())
            {
                string query = "SELECT DATE_FORMAT(datum_transakcije, '%Y-%m-%d') AS datum_transakcije," +
                    " SUM(ukupni_iznos) AS UkupniIznosKupnje\r\nFROM transakcija\r\nGROUP BY DATE_FORMAT(datum_transakcije," +
                    " '%Y-%m-%d')\r\nORDER BY datum_transakcije;\r\n";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {


                    using (var reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            Transakcija trank = new Transakcija();
                            trank.Datum_transakcije = reader.GetDateTime("datum_transakcije");
                            trank.Ukupni_iznos = reader.GetFloat("UkupniIznosKupnje");
                            tranksakcija.Add(trank);


                        }
                    }
                }
            }
            return tranksakcija;
        }

        List<Djelatnik> getDjelatnici()
        {
            List<Djelatnik> djelatnici = new List<Djelatnik>();
            using (MySqlConnection connection = connectionFactory.GetNewConnection())
            {
                string query = "SELECT * FROM  djelatnik";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {


                    using (var reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {

                            Djelatnik djelatnik = new Djelatnik();
                            djelatnik.ID = reader.GetInt32("id");
                            djelatnik.Ime = reader.GetString("ime");
                            djelatnik.Prezime = reader.GetString("prezime");
                            djelatnik.DatumRodjenja = reader.GetDateTime("datum_rodjenja");
                            djelatnik.OIB = reader.GetString("oib");
                            djelatnik.BrojMobitela = reader.GetString("broj_mobitela");
                            djelatnik.Email = reader.GetString("email");
                            djelatnik.DatumZaposlenja = reader.GetDateTime("datum_zaposlenja");
                            djelatnik.Role = reader.GetString("role");
                            djelatnik.Lozinka = reader.GetString("lozinka");
                            djelatnici.Add(djelatnik);



                        }
                    }
                }
                return djelatnici;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddEditDjelatnik addEditDjelatnik = new AddEditDjelatnik(new Djelatnik());

            if (addEditDjelatnik.ShowDialog() == DialogResult.OK)
            {
                dgDjelatnici.DataSource = getDjelatnici();
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
            proizvod.naziv = dgSkladiste.SelectedRows[0].Cells["Naziv"].Value.ToString();
            proizvod.cijena = dgSkladiste.SelectedRows[0].Cells["Cijena"].Value.ToString();
            proizvod.kolicina = dgSkladiste.SelectedRows[0].Cells["Kolicina"].Value.ToString();

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolSDodaj_Click(object sender, EventArgs e)
        {
            AddEditDjelatnik addEditDjelatnik = new AddEditDjelatnik(new Djelatnik());

            if (addEditDjelatnik.ShowDialog() == DialogResult.OK)
            {
                dgDjelatnici.DataSource = getDjelatnici();
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
                dgDjelatnici.DataSource = getDjelatnici();
            }
        }

        private void toolsSObrisi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Dali ste sigurni?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int selectedId = Convert.ToInt32(dgDjelatnici.SelectedRows[0].Cells["ID"].Value);
                _djelatnikStore.ObrisiDjelatnika(selectedId);
                dgDjelatnici.DataSource = getDjelatnici();
            }
        }
       
        private void DjelatnikForm_Load(object sender, EventArgs e)
        {

        }

        

    }

}

using Blagajna.DB;
using MySqlConnector;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Budić_Marković_RacPrakt_Projekt
{
    public partial class LoginForm : Form
    {
        private SqlConnectionFactory connectionFactory;

        public LoginForm()
        {
            InitializeComponent();
            connectionFactory = new SqlConnectionFactory();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text;
            string password = txtPassword.Text;
            Djelatnik djelatnik = new Djelatnik();
            using (MySqlConnection connection = connectionFactory.GetNewConnection())
            {
                string query = "SELECT * FROM djelatnik WHERE email = @username AND lozinka = @Password";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                   
                    using (var reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                           

                            if (reader != null)
                            {
                                
                                djelatnik.Ime = reader.GetString("ime");
                                djelatnik.Prezime = reader.GetString("prezime");
                                djelatnik.DatumRodjenja = reader.GetDateTime("datum_rodjenja");
                                djelatnik.OIB = reader.GetString("oib");
                                djelatnik.BrojMobitela = reader.GetString("broj_mobitela");
                                djelatnik.Email = reader.GetString("email");
                                djelatnik.DatumZaposlenja = reader.GetDateTime("datum_zaposlenja");
                                djelatnik.Role = reader.GetString("role");




                            }
                            else
                            {
                                MessageBox.Show("Pogrešno korisničko ime ili lozinka.");
                            }
                        }
                    }
                }
            }
            AdminForm adminForm = new AdminForm(djelatnik);
             adminForm.Show();
            
        }
        
       

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }        
}



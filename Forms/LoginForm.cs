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

            using (MySqlConnection connection = connectionFactory.GetNewConnection())
            {
                string query = "SELECT role FROM djelatnik WHERE email = @username AND lozinka = @Password";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        string role = result.ToString();
                        OpenFormBasedOnRole(role);
                    }
                    else
                    {
                        MessageBox.Show("Pogrešno korisničko ime ili lozinka.");
                    }
                }
            }
        }
        
        private void OpenFormBasedOnRole(string role)
        {
            switch (role.ToLower())
            {
                case "admin":
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                    break;

                case "blagajnik":
                    DjelatnikForm djelatnikForm = new DjelatnikForm();
                    djelatnikForm.Show();
                    break;

                default:
                    MessageBox.Show("Nepoznata uloga korisnika,");
                    break;
            }
        }
    }        
}



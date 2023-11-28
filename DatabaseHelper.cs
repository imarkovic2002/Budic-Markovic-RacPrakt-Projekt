using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budić_Marković_RacPrakt_Projekt
{
    public class DatabaseHelper
    {
        private string GetConnectionString()
        {
            string connString = "Server = localhost; Database = blagajna; Uid = igor; Pwd = igor";

            return connString;
        }

        public bool AutorizirajKorisnika(string email, string pwd)
        {
            bool postoji = false;
            var connection = new MySqlConnection(GetConnectionString());
            connection.Open();


            var command = new MySqlCommand("SELECT ime,prezime FROM djelatnik " +
                    "WHERE email ='" + email + "'AND  lozinka = '" + pwd + "'", connection);

            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                postoji = reader.HasRows;
            }
            return postoji;
        }


        public User GetUser(string email)
        {
            User user = new User();

            var connection = new MySqlConnection(GetConnectionString());
            connection.Open();

            var command = new MySqlCommand("SELECT id, ime, prezime FROM djelatnik " +
                                                "WHERE email = '" + email + "'", connection);


            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                user.ID = reader.GetInt32("id");
                user.Ime = reader.GetString("Ime");
                user.Prezime = reader.GetString("Prezime");
            }

            return user;

        }

    }
}

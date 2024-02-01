using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blagajna.Abstract;
using Blagajna.Abstract.Models;
using Budić_Marković_RacPrakt_Projekt;
using MySqlConnector;

namespace Blagajna.DB.Stores
{
    public class DjelatnikStore
    {
        private SqlConnectionFactory connectionFactory=new SqlConnectionFactory();
        public void DodajDjelatnika(Djelatnik djelatnik)
        {
            var connectionManager = new SqlConnectionFactory();

            using (var con = connectionManager.GetNewConnection())
            {
                if (con != null)
                {
                    string upit = "INSERT INTO djelatnik(ime,prezime,datum_rodjenja,oib," +
                        "broj_mobitela,email,lozinka,datum_zaposlenja,role)" +
                        " VALUES(@Ime,@Prezime,@Datum_Rodjenja,@Oib," +
                        "@Broj_Mobitela,@Email,@Lozinka,@Datum_zaposlenja,@Role)";

                    using (var command = new MySqlCommand(upit, con))
                    {
                        command.Parameters.AddWithValue("@Ime", djelatnik.Ime);
                        command.Parameters.AddWithValue("@Prezime", djelatnik.Prezime);
                        command.Parameters.AddWithValue("@Datum_Rodjenja", djelatnik.DatumRodjenja);
                        command.Parameters.AddWithValue("@Oib", djelatnik.OIB);
                        command.Parameters.AddWithValue("@Broj_Mobitela", djelatnik.BrojMobitela);
                        command.Parameters.AddWithValue("@Email", djelatnik.Email);
                        command.Parameters.AddWithValue("@Lozinka", djelatnik.Lozinka);
                        command.Parameters.AddWithValue("@Datum_zaposlenja", djelatnik.DatumZaposlenja);
                        command.Parameters.AddWithValue("@Role", djelatnik.Role);



                        command.ExecuteNonQuery();
                    }

                    connectionManager.CloseConnection(con);
                }
            }
        }
        public void AzurirajDjelatnika(Djelatnik djelatnik)
        {
            var connectionManager = new SqlConnectionFactory();

            using (var connection = connectionManager.GetNewConnection())
            {
                if (connection != null)
                {
                    string upit = "UPDATE djelatnik SET ime = @Ime," +
                        " prezime = @Prezime, datum_rodjenja=@Datum_rodjenja" +
                        ",oib=@Oib, broj_mobitela = @BrojMobitela" +
                        ",email=@Email,lozinka=@Lozinka," +
                        "datum_zaposlenja=@Datum_zaposlenja,role=@Role WHERE id = @Id";

                    using (var command = new MySqlCommand(upit, connection))
                    {
                        command.Parameters.AddWithValue("@Id", djelatnik.ID);
                        command.Parameters.AddWithValue("@Ime", djelatnik.Ime);
                        command.Parameters.AddWithValue("@Prezime", djelatnik.Prezime);
                        command.Parameters.AddWithValue("@Oib", djelatnik.OIB);
                        command.Parameters.AddWithValue("@Datum_rodjenja", djelatnik.DatumRodjenja);
                        command.Parameters.AddWithValue("@BrojMobitela", djelatnik.BrojMobitela);
                        command.Parameters.AddWithValue("@Email", djelatnik.Email);
                        command.Parameters.AddWithValue("@Lozinka", djelatnik.Lozinka);
                        command.Parameters.AddWithValue("@Datum_zaposlenja", djelatnik.DatumZaposlenja);
                        command.Parameters.AddWithValue("@Role", djelatnik.Role);

                        command.ExecuteNonQuery();
                    }

                    connectionManager.CloseConnection(connection);
                }
            }
        }
        public void ObrisiDjelatnika(int djelatnik_id)
        {
            var connectionManager = new SqlConnectionFactory();

            using (var conn = connectionManager.GetNewConnection())
            {
                if (conn != null)
                {
                    string upit = "DELETE FROM djelatnik WHERE id = @Id";

                    using (var command = new MySqlCommand(upit, conn))
                    {
                        command.Parameters.AddWithValue("@Id", djelatnik_id);
                        command.ExecuteNonQuery();
                    }

                    connectionManager.CloseConnection(conn);
                }
            }
        }
        public List<Djelatnik> getDjelatnici()
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
    }
}

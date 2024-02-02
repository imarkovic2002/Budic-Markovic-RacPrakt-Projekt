using Blagajna.Abstract.Models;
using Budić_Marković_RacPrakt_Projekt;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Blagajna.DB.Stores
{
    public  class TransakcijaStore
    {
        private SqlConnectionFactory connectionFactory=new SqlConnectionFactory();
        public List<Transakcija> getTransakcije()
        {
            List<Transakcija> tranksakcija = new List<Transakcija>();
            using (MySqlConnection connection = connectionFactory.GetNewConnection())
            {
                string query = "SELECT * FROM transakcija";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {


                    using (var reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            Transakcija trank = new Transakcija();
                            trank.id=reader.GetInt32("id");
                            trank.Datum_transakcije = reader.GetDateTime("datum_transakcije");
                            trank.Ukupni_iznos = reader.GetFloat("ukupni_iznos");
                            trank.nacin_placanja = reader.GetString("nacin_placanja");

                            tranksakcija.Add(trank);
                        }
                    }
                }
            }
            return tranksakcija;
        }
        public void dodajTransakciju(float ukupni_iznos,Djelatnik djelatnik,string nacinPlacanja)
        {
            var connectionManager = new SqlConnectionFactory();

            using (var con = connectionManager.GetNewConnection())
            {
                if (con != null)
                {
                    string upit = "INSERT INTO transakcija(datum_transakcije,ukupni_iznos," +
                        "nacin_placanja,djelatnik_id)" +
                        "VALUES(@datum_transakcije,@ukupni_iznos,@nacin_placanja,@djelatnik_id)";

                    using (var command = new MySqlCommand(upit, con))
                    {
                        command.Parameters.AddWithValue("@datum_transakcije",DateTime.Now);
                        command.Parameters.AddWithValue("@ukupni_iznos",ukupni_iznos );
                        command.Parameters.AddWithValue("@nacin_placanja",nacinPlacanja );
                        command.Parameters.AddWithValue("@djelatnik_id", djelatnik.ID);

                        command.ExecuteNonQuery();
                    }

                    connectionManager.CloseConnection(con);
                }
            }
        }
    }
    }
        





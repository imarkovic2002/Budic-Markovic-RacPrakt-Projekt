using Blagajna.Abstract.Models;
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
    }
        /*public List<Transakcija> getTransakcije()
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
        }*/
}




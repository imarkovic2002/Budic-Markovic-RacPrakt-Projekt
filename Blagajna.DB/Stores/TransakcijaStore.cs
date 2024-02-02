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
        
}




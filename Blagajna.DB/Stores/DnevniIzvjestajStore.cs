using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blagajna.Abstract.Models;
using MySqlConnector;

namespace Blagajna.DB.Stores
{
    public class DnevniIzvjestajStore
    {
        private SqlConnectionFactory connectionFactory = new SqlConnectionFactory();
        public List<DnevniIzvjestaj> getDnevniIzvjestaj()
        {
            List<DnevniIzvjestaj> dnevniIzvjestaj = new List<DnevniIzvjestaj>();
            using (MySqlConnection connection = connectionFactory.GetNewConnection())
            {
                string query = "SELECT DATE_FORMAT(datum_transakcije, '%Y-%m-%d') AS" +
                    " datum_transakcije,\r\nSUM(transakcija.ukupni_iznos) AS UkupniIznosKupnje," +
                    "\r\nSUM(storno.ukupni_iznos) AS UskupniIznosStorna" +
                    "\r\nFROM transakcija,storno\r\n" +
                    "WHERE transakcija.datum_transakcije=storno.datum_storna || transakcija.storno_id=0\r\n" +
                    "GROUP BY DATE_FORMAT(datum_transakcije, '%Y-%m-%d')\r\n" +
                    "ORDER BY datum_transakcije;";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {


                    using (var reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            DnevniIzvjestaj dnevni = new DnevniIzvjestaj();
                            dnevni.Datum = reader.GetDateTime("datum_transakcije");
                            dnevni.Utrzak = reader.GetFloat("UkupniIznosKupnje");
                            dnevni.Storno = reader.GetFloat("UskupniIznosStorna");
                            dnevniIzvjestaj.Add(dnevni);
                        }
                    }
                }
            }
            return dnevniIzvjestaj;
        }
    }
}

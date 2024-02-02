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
                string query = "SELECT DATE_FORMAT(transakcija.datum_transakcije, '%Y-%m-%d') AS datum_transakcije, " +
                    "SUM(transakcija.ukupni_iznos) AS UkupniIznosKupnje, " +
                    "COALESCE(SUM(storno.ukupni_iznos), 0) AS UskupniIznosStorna FROM transakcija " +
                    "LEFT JOIN storno ON transakcija.storno_id = storno.id " +
                    "WHERE transakcija.datum_transakcije = storno.datum_storna OR transakcija.storno_id = 0 " +
                    "GROUP BY DATE_FORMAT(transakcija.datum_transakcije, '%Y-%m-%d') ORDER BY datum_transakcije;";
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

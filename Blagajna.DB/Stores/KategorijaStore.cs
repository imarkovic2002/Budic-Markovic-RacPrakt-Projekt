using Blagajna.Abstract.Models;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blagajna.DB.Stores
{
    public class KategorijaStore
    {
        public List<Kategorija> GetKategorije()
        {
            var connectionManager = new SqlConnectionFactory();
            List<Kategorija> kategorijaList = new List<Kategorija>();

            using (var connection = connectionManager.GetNewConnection())
            {
                if (connection != null)
                {
                    string query = "SELECT id, naziv FROM kategorija";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Kategorija kategorija = new Kategorija();
                                kategorija.Id = reader.GetInt32("id");
                                kategorija.Naziv = reader.GetString("naziv");

                                kategorijaList.Add(kategorija);
                            }
                        }
                    }
                }
                connectionManager.CloseConnection(connection);
            }
            return kategorijaList;
        }
    }
}

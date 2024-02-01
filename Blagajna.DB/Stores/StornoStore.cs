using Blagajna.Abstract.Models;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blagajna.DB.Stores
{
    public class StornoStore
    {
        public void DodajStorno(Storno storno)
        {
            var connectionManager = new SqlConnectionFactory();

            using (var con = connectionManager.GetNewConnection())
            {
                if (con != null)
                {
                    string upit = "INSERT INTO storno (ukupni_iznos, datum_storna, id_transakcija)"+
"VALUES(@ukupni_iznos,@datum_storna,(SELECT Id FROM transakcija WHERE Id = @id_transakcija))";
                    



                    using (var command = new MySqlCommand(upit, con))
                    {
                        command.Parameters.AddWithValue("@ukupni_iznos", storno.Ukupni_iznos);
                        command.Parameters.AddWithValue("@datum_storna", storno.Datum_storno);
                        command.Parameters.AddWithValue("@id_transakcija", storno.Id_transakcija);

                        command.ExecuteNonQuery();
                    }

                    connectionManager.CloseConnection(con);
                }
            }
        }
    }
}

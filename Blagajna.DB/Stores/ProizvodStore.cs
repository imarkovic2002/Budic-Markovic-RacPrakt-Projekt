using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blagajna.Abstract.Models;


namespace Blagajna.DB.Stores
{
    public class ProizvodStore
    {
        public List<Proizvod> getProizvods()
        {
            var connectionManager = new SqlConnectionFactory();
            List<Proizvod> proizvodList = new List<Proizvod>();
            

            using (var connection = connectionManager.GetNewConnection())
            {
                if (connection != null)
                {
                    string query = String.Format("SELECT id,naziv,kolicina,cijena FROM proizvod");

                    using (var command = new MySqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader()) {
                            while (reader.Read())
                            {
                                Proizvod proizvod = new Proizvod();
                                proizvod.ID = reader.GetInt32("id");
                                proizvod.Naziv = reader.GetString("naziv");
                                proizvod.Kolicina = reader.GetString("kolicina");
                                proizvod.Cijena = reader.GetString("cijena");

                                proizvodList.Add(proizvod);
                            }
                        }
                    }
                }
                connectionManager.CloseConnection(connection);
            }
            return proizvodList.ToList(); 
        }

        public void DodajProizvod (Proizvod proizvod)
        {
            var connectionManager = new SqlConnectionFactory();

            using (var  con = connectionManager.GetNewConnection())
            {
                if (con != null)
                {
                    string upit = "INSERT INTO proizvod(naziv, cijena, kolicina )" +
                        "VALUES(@Naziv, @Cijena, @Kolicina)";

                    using (var command = new MySqlCommand(upit, con))
                    {
                        command.Parameters.AddWithValue("@Naziv", proizvod.Naziv);
                        command.Parameters.AddWithValue("@Cijena", proizvod.Cijena);
                        command.Parameters.AddWithValue("@Kolicina", proizvod.Kolicina);

                        command.ExecuteNonQuery();
                    }

                    connectionManager.CloseConnection(con);
                }
            }
        }

        public void ObrisiProizvod (int proizvod_id)
        {
            var connectionManager = new SqlConnectionFactory();

            using (var conn = connectionManager.GetNewConnection())
            {
                if (conn != null)
                {
                    string upit = "DELETE FROM proizvod WHERE id = @Id";

                    using (var command = new MySqlCommand(upit, conn))
                    {
                        command.Parameters.AddWithValue("@Id", proizvod_id);
                        command.ExecuteNonQuery ();
                    }

                    connectionManager.CloseConnection(conn);
                }
            }
        }

        public void AzurirajProizvod(Proizvod proizvod)
        {
            var connectionManager = new SqlConnectionFactory();

            using (var connection = connectionManager.GetNewConnection())
            {
                if (connection != null)
                {
                    string upit = "UPDATE proizvod SET naziv = @Naziv, cijena = @Cijena, kolicina = @Kolicina WHERE id = @Id";

                    using (var command = new MySqlCommand(upit, connection))
                    {
                        command.Parameters.AddWithValue("@Id", proizvod.ID);
                        command.Parameters.AddWithValue("@Naziv", proizvod.Naziv);
                        command.Parameters.AddWithValue("@Cijena", proizvod.Cijena);
                        command.Parameters.AddWithValue("@Kolicina", proizvod.Kolicina);

                        command.ExecuteNonQuery();
                    }

                    connectionManager.CloseConnection(connection);
                }
            }
        }
    }
}

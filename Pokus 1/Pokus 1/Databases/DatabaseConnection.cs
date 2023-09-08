using System;
using System.Data.SqlClient;
using static Pokus_1.osoby.Osoba;
using System.Windows.Forms; // Přidáno pro MessageBox
using Pokus_1.osoby;

namespace Pokus_1.Databases
{
    internal class DatabaseConnection
    {
        private string connectionString = "Data Source=DESKTOP-IT7JJ8B;Initial Catalog=DatabazeOsob;Integrated Security=True";

        public SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }

        public void CloseConnection(SqlConnection connection)
        {
            connection.Close();
        }
    }

    internal class DatabaseOperations
    {
        private DatabaseConnection dbConnection = new DatabaseConnection();
        public int GetHighestID()
        {
            using (SqlConnection connection = dbConnection.GetConnection())
            {
                string sqlQuery = "SELECT MAX(ID) FROM [DatabazeOsob].[dbo].[osoby]";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        // Pokud v tabulce nejsou žádné záznamy, vrátíme 0 nebo jinou počáteční hodnotu podle potřeby.
                        return 0;
                    }
                }
            }
        }

        public List<Osoba> LoadDataFromDatabase()
        {
            List<Osoba> loadedOsoby = new List<Osoba>();

            using (SqlConnection connection = dbConnection.GetConnection())
            {
                try
                {
                    string sqlQuery = "SELECT id, jmeno, prijmeni, vek, misto, pohlavi FROM dbo.osoby";

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0); // První sloupec (id)
                                string jmeno = reader.GetString(1); // Druhý sloupec (jmeno)
                                string prijmeni = reader.GetString(2); // Třetí sloupec (prijmeni)
                                int vek = reader.GetInt32(3); // Čtvrtý sloupec (vek)
                                string misto = reader.GetString(4); // Pátý sloupec (misto)
                                string pohlaviStr = reader.GetString(5); // Šestý sloupec (pohlavi)

                                // Převedení textového záznamu na enum Pohlavi
                                Osoba.Pohlavi pohlavi = (Osoba.Pohlavi)Enum.Parse(typeof(Osoba.Pohlavi), pohlaviStr);

                                // Vytvoření instance Osoba a přidání do seznamu
                                Osoba osoba = new Osoba(id, jmeno, prijmeni, vek, misto, pohlavi);
                                loadedOsoby.Add(osoba);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Chyba při načítání dat z databáze: " + ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    dbConnection.CloseConnection(connection);
                }
            }

            return loadedOsoby;
        }
        public bool CheckIfIdExists(int id)
        {
            using (SqlConnection connection = dbConnection.GetConnection())
            {
                try
                {
                    string sqlQuery = "SELECT COUNT(*) FROM dbo.osoby WHERE id = @Id";
                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Chyba při kontrole existence záznamu: " + ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    dbConnection.CloseConnection(connection);
                }
            }
        }
        public void UpdateData(Osoba osoba)
        {
            using (SqlConnection connection = dbConnection.GetConnection())
            {
                try
                {
                    string sqlQuery = "UPDATE dbo.osoby SET jmeno = @Jmeno, prijmeni = @Prijmeni, vek = @Vek, misto = @Misto, pohlavi = @pohlavi WHERE id = @Id";

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Id", osoba.getId());
                        command.Parameters.AddWithValue("@Jmeno", osoba.jmeno);
                        command.Parameters.AddWithValue("@Prijmeni", osoba.prijmeni);
                        command.Parameters.AddWithValue("@Vek", osoba.vek);
                        command.Parameters.AddWithValue("@Misto", osoba.misto);
                        command.Parameters.AddWithValue("@pohlavi", osoba.gender.ToString());

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                          }
                        else
                        {
                            MessageBox.Show("Nepodařilo se aktualizovat záznam v databázi.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Chyba při aktualizaci záznamu: " + ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    dbConnection.CloseConnection(connection);
                  
                }
            }
        }


        public void DeleteData(int id)
        {
            using (SqlConnection connection = dbConnection.GetConnection())
            {
                try
                {
                    string sqlQuery = "DELETE FROM dbo.osoby WHERE id = @Id";

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Záznam byl úspěšně smazán z databáze
                        }
                        else
                        {
                            MessageBox.Show("Nepodařilo se smazat záznam v databázi.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Chyba při mazání záznamu z databáze: " + ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    dbConnection.CloseConnection(connection);
                }
            }
        }



        public void InsertData(Osoba o)
        {

        
            using (SqlConnection connection = dbConnection.GetConnection())
            {
                try
                {
                    string sqlQuery = "INSERT INTO dbo.osoby (id,jmeno, prijmeni, vek, misto, pohlavi) " +
                                      "VALUES (@Id, @Jmeno, @Prijmeni, @Vek, @Misto, @pohlavi)";

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Id", o.getId());
                        command.Parameters.AddWithValue("@Jmeno", o.jmeno);
                        command.Parameters.AddWithValue("@Prijmeni", o.prijmeni);
                        command.Parameters.AddWithValue("@Vek", o.vek);
                        command.Parameters.AddWithValue("@Misto",o.misto);
                        command.Parameters.AddWithValue("@pohlavi", o.gender.ToString()); // Použijte ToString() pro uložení názvu enumu

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                           
                        }
                        else
                        {
                            MessageBox.Show("Nepodařilo se vložit záznam do databáze.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Chyba při vkládání záznamu: " + ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    dbConnection.CloseConnection(connection);
                }
            }
        }
    }
}

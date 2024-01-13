using MySqlConnector;
using System;
using System.Collections.Generic;
using Adresar.Models;
using System.Linq;


namespace Adresar.DB.Stores
{
    public class KontaktStore
    {
        public List<Kontakt> GetKontakt()
        {
            var connectionManager = new SqlConnectionFactory();
            List<Kontakt> userList = new List<Kontakt>();

            using (var connection = connectionManager.GetNewConnection())
            {
                if (connection != null)
                {
                    string upit = String.Format("SELECT * FROM kontakti");

                    using (var command = new MySqlCommand(upit, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        { 
                            
                            while (reader.Read())
                            {
                                Kontakt kontakt = new Kontakt();
                                kontakt.ID = reader.GetInt32("Id");
                                kontakt.Ime = reader.GetString("Ime");
                                kontakt.Prezime = reader.GetString("Prezime");
                                kontakt.Adresa = reader.GetString("Adresa");
                                kontakt.Broj_telefona = reader.GetString("Broj_telefona");

                                userList.Add(kontakt);
                            }
                        }
                    }
                }
                connectionManager.CloseConnection(connection);
            }
            return userList.OrderBy(kontakt => kontakt.Prezime).ToList();
        }

        public void DodajKontakt(Kontakt kontakt)
        {
            var connectionManager = new SqlConnectionFactory();

            using (var connection = connectionManager.GetNewConnection())
            {
                if (connection != null)
                {
                    string upit = "INSERT INTO kontakti(ime, prezime, adresa, broj_telefona) " +
                                  "VALUES(@Ime, @Prezime, @Adresa, @BrojTelefona)";

                    using (var command = new MySqlCommand(upit, connection))
                    {
                        command.Parameters.AddWithValue("@Ime", kontakt.Ime);
                        command.Parameters.AddWithValue("@Prezime", kontakt.Prezime);
                        command.Parameters.AddWithValue("@Adresa", kontakt.Adresa);
                        command.Parameters.AddWithValue("@BrojTelefona", kontakt.Broj_telefona);

                        command.ExecuteNonQuery();
                    }

                    connectionManager.CloseConnection(connection);
                }
            }
        }

        public void AžurirajKontakt(Kontakt kontakt)
        {
            var connectionManager = new SqlConnectionFactory();

            using (var connection = connectionManager.GetNewConnection())
            {
                if (connection != null)
                {
                    string upit = "UPDATE kontakti SET ime = @Ime, prezime = @Prezime, adresa = @Adresa, broj_telefona = @BrojTelefona WHERE id = @Id";

                    using (var command = new MySqlCommand(upit, connection))
                    {
                        command.Parameters.AddWithValue("@Id", kontakt.ID);
                        command.Parameters.AddWithValue("@Ime", kontakt.Ime);
                        command.Parameters.AddWithValue("@Prezime", kontakt.Prezime);
                        command.Parameters.AddWithValue("@Adresa", kontakt.Adresa);
                        command.Parameters.AddWithValue("@BrojTelefona", kontakt.Broj_telefona);

                        command.ExecuteNonQuery();
                    }

                    connectionManager.CloseConnection(connection);
                }
            }
        }

        public void ObrišiKontakt(Kontakt kontakt) {
            var connectionManager = new SqlConnectionFactory();
            using (var connection = connectionManager.GetNewConnection())
            {
                if (connection != null)
                {
                    string upit = "DELETE FROM kontakti WHERE id = @Id";

                    using (var command = new MySqlCommand(upit, connection))
                    {
                        command.Parameters.AddWithValue("@Id", kontakt.ID);
                        command.ExecuteNonQuery();
                    }

                    connectionManager.CloseConnection(connection);
                }
            }
        }

        public List<Kontakt> Pretraga( string traži)
        {
            KontaktStore kontaktStore = new KontaktStore();
            var kontakti = kontaktStore.GetKontakt();
            List<Kontakt> rezultati = kontakti.Where(kontakt => kontakt.Ime.IndexOf(traži, StringComparison.OrdinalIgnoreCase) >= 0 ||
            kontakt.Prezime.IndexOf(traži, StringComparison.OrdinalIgnoreCase) >= 0 ||
            kontakt.Broj_telefona.IndexOf(traži, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            return rezultati;
        }
    }
}

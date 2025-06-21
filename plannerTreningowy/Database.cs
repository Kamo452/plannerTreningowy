using System;
using System.Data.OleDb;

namespace plannerTreningowy
{
    public static class Database
    {
        private static readonly string connectionString =
            "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\planer.accdb";

        public static bool SprawdzLogowanie(string login, string haslo, out string imie)
        {
            imie = "";
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                string query = "SELECT imie FROM uzytkownicy WHERE login=? AND haslo=?";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@haslo", haslo);

                    conn.Open();
                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        imie = reader.GetString(0);
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool DodajUzytkownika(string login, string haslo, string imie)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                string query = "INSERT INTO uzytkownicy (login, haslo, imie) VALUES (?, ?, ?)";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@haslo", haslo);
                    cmd.Parameters.AddWithValue("@imie", imie);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
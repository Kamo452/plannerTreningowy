using System;
using System.Data.OleDb;

namespace plannerTreningowy
{
    public static class Database
    {
        public static List<Cwiczenie> WszystkieCwiczenia { get; private set; } = new List<Cwiczenie>();

        private static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\planer.accdb";

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

        
        public static void WczytajCwiczeniaZBazy()
        {
            string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\planer.accdb";
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                string query = "SELECT Nazwa_cwiczenia, grupa, Opis, kcal FRom cwiczenia";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                conn.Open();

                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Cwiczenie c = new Cwiczenie()
                    {
                        Nazwa = reader["Nazwa_cwiczenia"].ToString() ?? string.Empty,
                        Grupa = reader["grupa"].ToString() ?? string.Empty,
                        Opis = reader["Opis"].ToString() ?? string.Empty,
                        Kcal = Convert.ToInt32(reader["kcal"])
                    };
                    WszystkieCwiczenia.Add(c);
                    
                }
                reader.Close();
            }
        }

    }
}
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace plannerTreningowy
{
    public partial class FormRejestracja : Form
    {
        public FormRejestracja()
        {
            InitializeComponent();
        }

        private void btnUtworz_Click(object sender, EventArgs e)
        {
            string imie = txtImie.Text.Trim();
            string login = txtLogin.Text.Trim();
            string haslo = txtHaslo.Text.Trim();

            if (string.IsNullOrWhiteSpace(imie) || string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(haslo))
            {
                MessageBox.Show("Wypełnij wszystkie pola.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CzyLoginIstnieje(login))
            {
                MessageBox.Show("Podany login już istnieje. Wybierz inny.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Database.DodajUzytkownika(imie, login, haslo))
            {
                MessageBox.Show("Konto zostało utworzone.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormLogowanie form = new FormLogowanie();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wystąpił błąd podczas tworzenia konta.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CzyLoginIstnieje(string login)
        {
            string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\planer.accdb";
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                string query = "SELECT COUNT(*) FROM uzytkownicy WHERE login = ?";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@login", login);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        private void btnPowrot_Click(object sender, EventArgs e)
        {
            FormLogowanie form = new FormLogowanie();
            form.Show();
            this.Hide();
        }
    }
}

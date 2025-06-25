using plannerTreningowy;
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace plannerTreningowy
{
    public partial class FormLogowanie : Form
    {
        public FormLogowanie()
        {
            InitializeComponent();
        }

        private void btnZaloguj_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string haslo = txtHaslo.Text.Trim();

            if (Database.SprawdzLogowanie(login, haslo, out string imie))
            {
                MessageBox.Show($"Witaj, {imie}!");
                Hide();
                FormPlaner planner = new FormPlaner(imie);
                planner.Show();
            }
            else
            {
                MessageBox.Show("Błędny login lub hasło.");
            }
        }

        private void btnRejestracja_Click(object sender, EventArgs e)
        {
            FormRejestracja rejestracja = new FormRejestracja();
            rejestracja.ShowDialog();
        }
    }
}
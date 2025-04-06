using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace plannerTreningowy
{
    public partial class Logowanie : Form
    {
        public Logowanie()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rejestracja rejestracjaForm = new Rejestracja();
            rejestracjaForm.FormClosed += (s, args) => this.Show();
            rejestracjaForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\plannerTreningowy.accdb";
            string login = textBox1.Text;
            string haslo = textBox2.Text;
            string zapytanie = $"SELECT * FROM uzytkownicy WHERE login ='{login}' AND haslo = '{haslo}';";
            using (OleDbConnection connection = new OleDbConnection(conn))
            {
                OleDbCommand command = new OleDbCommand(zapytanie, connection);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                if (reader.Read() == true)
                {
                   MessageBox.Show($"Pomyślnie zalogowano!\nWitaj {reader.GetString(1)}! \nID użytkownika: {reader.GetInt32(0)}");
                   menuGlowne menuGlowneForm = new menuGlowne(login);
                   reader.Close();
                   connection.Close();
                   menuGlowneForm.Show();
                   this.Hide();
                } else
                {
                    MessageBox.Show("Nieprawidłowy login lub hasło!");
                }


            }
        }

    }

}

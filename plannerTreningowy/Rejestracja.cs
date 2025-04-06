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
    public partial class Rejestracja : Form
    {
        public Rejestracja()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\plannerTreningowy.accdb";
            string imie = textBox1.Text;
            string login = textBox2.Text;
            string haslo = textBox3.Text;
            string zapytanie = $"INSERT INTO uzytkownicy (login, haslo, imie) VALUES ('{login}','{haslo}','{imie}');";
            using (OleDbConnection connection = new OleDbConnection(conn))
            {
                try
                {
                    OleDbCommand command = new OleDbCommand(zapytanie, connection);
                    connection.Open();
                    try
                    {
                        int wynik = command.ExecuteNonQuery();
                        if (wynik < 0)
                        {
                            Console.WriteLine("Wystąpił błąd przy tworzeniu konta!");
                        } else
                        {
                            MessageBox.Show($"Pomyślnie utworzono konto!\nWitaj {login}");
                            menuGlowne menuGlowneForm = new menuGlowne(login);
                            menuGlowneForm.Show();
                            this.Hide();
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show($"Wystąpił błąd przy tworzeniu konta: {ex}");
                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Wystąpił błąd: {ex}");
                }
            }

        }
    }
}

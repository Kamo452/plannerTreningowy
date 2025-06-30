using System;
using System.Collections.Generic;
using System.Data;
using plannerTreningowy;
using System.Data.OleDb;
using System.Windows.Forms;

namespace plannerTreningowy
{
    public partial class FormPlaner : Form
    {
        private string imieUzytkownika;
        public FormPlaner(string imie)
        {
            InitializeComponent();
            imieUzytkownika = imie;
            lblPowitanie.Text = $"Witaj {imieUzytkownika}!";
            WczytajCwiczenia();
        }
        private void WczytajCwiczenia()
        {
            Database.WczytajCwiczeniaZBazy();
            foreach (var c in Database.WszystkieCwiczenia)
            {
                lstCwiczenia.Items.Add(c);
            }
        }
        private void lstCwiczenia_WyborZListy(object sender, EventArgs e)
        {
            if (lstCwiczenia.SelectedItem is Cwiczenie c)
            {
                txtOpis.Text = c.Opis;
                lblPartia.Text = $"Partia mięśni: {c.Grupa}";
            }
        }
        private void btnDodajCwiczenie(object sender, EventArgs e)
        {
            if (lstCwiczenia.SelectedItem is Cwiczenie c)
            {
                lstPlan.Items.Add(c);
            }
        }
        private void btnUsunCwiczenie(object sender, EventArgs e)
        {
            lstPlan.Items.Remove(lstPlan.SelectedItem);
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Zapis planu treningowego | PlannerTreningowy";
            saveFileDialog.Filter = "Pliki tekstowe (*.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    writer.WriteLine($"Plan treningowy autorstwa {imieUzytkownika}:");
                    writer.WriteLine();
                    foreach (Cwiczenie cw in lstPlan.Items)
                    {
                        writer.WriteLine($"- {cw.Nazwa} ({cw.Kcal} kcal/serię)");
                    }
                    writer.WriteLine();
                }
                MessageBox.Show("Plan zapisano pomyślnie! \nŻyczymy udanych treningów!", "Gratulacje sportowcu!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}

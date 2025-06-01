using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;
using plannerTreningowy.Domain;
using plannerTreningowy.Gui;

namespace plannerTreningowy
{
    public partial class menuGlowne : Form
    {
        private readonly List<Exercise> _exercises = new List<Exercise>();

        public menuGlowne(string login)
        {
            InitializeComponent();
            lblWelcome.Text = $"Witaj, {login}!";
            LoadExercisesFromDatabase();
        }

        private void LoadExercisesFromDatabase()
        {
            _exercises.Clear();
            string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=plannerTreningowy.accdb";
            using (var conn = new OleDbConnection(connStr))
            {
                conn.Open();
                var cmd = new OleDbCommand("SELECT Identyfikator, Nazwa_cwiczenia, grupa1, grupa2, Opis FROM cwiczenia", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string nazwa = reader["Nazwa_cwiczenia"].ToString();
                        string grupal = reader["grupa1"].ToString();
                        string opis = reader["Opis"].ToString();

                        Exercise ex;

                        if (grupal.ToLower().Contains("bieg") || grupal.ToLower().Contains("cardio") || grupal.ToLower().Contains("tlen"))
                        {
                            ex = new CardioExercise(nazwa);
                        }
                        else
                        {
                            ex = new StrengthExercise(nazwa);
                        }

                        ex.Description = opis;
                        _exercises.Add(ex);
                    }
                }


            }
        }

        private void LoadExercises<TExercise>() where TExercise : Exercise
        {
            flowPanel.Controls.Clear();

            foreach (Exercise ex in _exercises.Where(e => e is TExercise))
            {
                IExerciseView view = ex is CardioExercise
                    ? new CardioExerciseControl()
                    : new StrengthExerciseControl() as IExerciseView;

                view.Display(ex);
                flowPanel.Controls.Add((Control)view);
            }
        }

        private void btnCardio_Click(object sender, EventArgs e) => LoadExercises<CardioExercise>();
        private void btnStrength_Click(object sender, EventArgs e) => LoadExercises<StrengthExercise>();
        private void btnStats_Click(object sender, EventArgs e) => MessageBox.Show("Statystyki w budowie :)");
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Logowanie"]?.Show();
            Close();
        }
    }
}

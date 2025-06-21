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
            lblPowitanie.Text = $"Witaj, {imieUzytkownika}!";
        }

    }
}

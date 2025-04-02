using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            Rejestracja rejestracjaForm = new Rejestracja();
            this.Hide();
            rejestracjaForm.ShowDialog();
            this.Show(); 
        }

    }

}

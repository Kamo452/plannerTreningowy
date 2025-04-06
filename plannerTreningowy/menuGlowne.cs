using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace plannerTreningowy
{
    public partial class menuGlowne : Form
    {
        public string NazwaUzytkownika { get; }
        public menuGlowne(string login)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            label1.Text = $"Witaj {login}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

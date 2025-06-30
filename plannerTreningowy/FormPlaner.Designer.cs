using Microsoft.VisualBasic.Logging;

namespace plannerTreningowy
{
    partial class FormPlaner
    {
        private Label lblPowitanie;
        private ListBox lstCwiczenia;
        private TextBox txtOpis;
        private Label lblPartia;
        private Button btnDodaj;
        private Button btnUsun;
        private ListBox lstPlan;
        private Button btnZapisz;
        private PictureBox logo;
        private Label lblTekstPlan;
        private void InitializeComponent()
        {
            lblPowitanie = new Label();
            lstCwiczenia = new ListBox();
            txtOpis = new TextBox();
            btnDodaj = new Button();
            btnUsun = new Button();
            btnZapisz = new Button();
            lstPlan = new ListBox();
            logo = new PictureBox();
            lblTekstPlan = new Label();
            lblPartia = new Label();
            SuspendLayout();
            // 
            // lblPowitanie
            // 
            lblPowitanie.AutoSize = true;
            lblPowitanie.Location = new Point(20, 20);
            lblPowitanie.Name = "lblPowitanie";
            lblPowitanie.Size = new Size(18, 23);
            lblPowitanie.TabIndex = 0;
            lblPowitanie.Text = "x";
            // 
            // lstCwiczenia
            // 
            lstCwiczenia.BackColor = Color.Azure;
            lstCwiczenia.HorizontalScrollbar = true;
            lstCwiczenia.ItemHeight = 23;
            lstCwiczenia.Location = new Point(20, 60);
            lstCwiczenia.Name = "lstCwiczenia";
            lstCwiczenia.Size = new Size(200, 188);
            lstCwiczenia.TabIndex = 1;
            lstCwiczenia.SelectedIndexChanged += lstCwiczenia_WyborZListy;
            // 
            // txtOpis
            // 
            txtOpis.BackColor = Color.White;
            txtOpis.Location = new Point(230, 90);
            txtOpis.Multiline = true;
            txtOpis.Name = "txtOpis";
            txtOpis.ReadOnly = true;
            txtOpis.ScrollBars = ScrollBars.Vertical;
            txtOpis.Size = new Size(360, 110);
            txtOpis.TabIndex = 2;
            txtOpis.Text = "Tutaj pojawi się opis ćwiczenia. Po lewej stronie widnieje lista. Wybierz pierwsze ćwiczenie, aby zacząć. Kalorie szacowane są na ok. 12 powtórzeń w jednej serii.";
            // 
            // btnDodaj
            // 
            btnDodaj.BackColor = Color.MediumSlateBlue;
            btnDodaj.FlatStyle = FlatStyle.Flat;
            btnDodaj.ForeColor = Color.White;
            btnDodaj.Location = new Point(276, 210);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(120, 35);
            btnDodaj.TabIndex = 4;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = false;
            btnDodaj.Click += btnDodajCwiczenie;
            // 
            // btnUsun
            // 
            btnUsun.BackColor = Color.IndianRed;
            btnUsun.FlatStyle = FlatStyle.Flat;
            btnUsun.ForeColor = Color.White;
            btnUsun.Location = new Point(416, 210);
            btnUsun.Name = "btnUsun";
            btnUsun.Size = new Size(120, 35);
            btnUsun.TabIndex = 5;
            btnUsun.Text = "Usuń";
            btnUsun.UseVisualStyleBackColor = false;
            btnUsun.Click += btnUsunCwiczenie;
            // 
            // btnZapisz
            // 
            btnZapisz.BackColor = Color.SlateGray;
            btnZapisz.FlatStyle = FlatStyle.Flat;
            btnZapisz.ForeColor = Color.White;
            btnZapisz.Location = new Point(276, 251);
            btnZapisz.Name = "btnZapisz";
            btnZapisz.Size = new Size(260, 35);
            btnZapisz.TabIndex = 6;
            btnZapisz.Text = "Zapisz plan";
            btnZapisz.UseVisualStyleBackColor = false;
            btnZapisz.Click += btnZapisz_Click;
            // 
            // lstPlan
            // 
            lstPlan.BackColor = Color.Azure;
            lstPlan.HorizontalScrollbar = true;
            lstPlan.ItemHeight = 23;
            lstPlan.Location = new Point(610, 60);
            lstPlan.Name = "lstPlan";
            lstPlan.Size = new Size(200, 188);
            lstPlan.TabIndex = 7;
            // 
            // logo
            // 
            logo.BorderStyle = BorderStyle.Fixed3D;
            logo.Image = plannerTreningowy.Properties.Resources.logo;
            logo.Location = new Point(355, 4);
            logo.Name = "logo";
            logo.Size = new Size(102, 53);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 10;
            logo.TabStop = false;
            // 
            // lblPartia
            // 
            lblPartia.BackColor = Color.DarkCyan;
            lblPartia.Font = new Font("MS Reference Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblPartia.ForeColor = SystemColors.Control;
            lblPartia.Location = new Point(230, 60);
            lblPartia.Name = "lblPartia";
            lblPartia.Size = new Size(360, 25);
            lblPartia.TabIndex = 3;
            lblPartia.Text = "Partia mięśni: -";
            // 
            // lblTekstPlan
            // 
            lblTekstPlan.AutoSize = true;
            lblTekstPlan.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblTekstPlan.Location = new Point(666, 32);
            lblTekstPlan.Name = "lblTekstPlan";
            lblTekstPlan.Size = new Size(96, 25);
            lblTekstPlan.TabIndex = 11;
            lblTekstPlan.Text = "Twój plan:";
            // 
            // FormPlaner
            // 
            BackColor = Color.Gainsboro;
            ClientSize = new Size(840, 310);
            Controls.Add(lblTekstPlan);
            Controls.Add(lstCwiczenia);
            Controls.Add(lblPowitanie);
            Controls.Add(txtOpis);
            Controls.Add(btnDodaj);
            Controls.Add(btnZapisz);
            Controls.Add(btnUsun);
            Controls.Add(logo);
            Controls.Add(lblPartia);
            Controls.Add(lstPlan);
            Font = new Font("Segoe UI", 10F);
            Name = "FormPlaner";
            Text = "Planner Treningów :)";

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
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
        private void InitializeComponent()
        {
            lblPowitanie = new Label();
            lstCwiczenia = new ListBox();
            txtOpis = new TextBox();
            btnDodaj = new Button();
            btnUsun = new Button();
            lstPlan = new ListBox();
            SuspendLayout();
            // Tekst na powitanie
            lblPowitanie.AutoSize = true;
            lblPowitanie.Location = new Point(20, 20);
            lblPowitanie.Name = "lblPowitanie";
            lblPowitanie.Size = new Size(16, 20);
            lblPowitanie.TabIndex = 0;
            lblPowitanie.Text = "x";
            // Lista ćwiczeń 
            lstCwiczenia.BackColor = Color.Azure;
            lstCwiczenia.HorizontalScrollbar = true;
            lstCwiczenia.ItemHeight = 23;
            lstCwiczenia.Location = new Point(20, 60);
            lstCwiczenia.Name = "lstCwiczenia";
            lstCwiczenia.Size = new Size(200, 188);
            lstCwiczenia.TabIndex = 1;
            lstCwiczenia.SelectedIndexChanged += lstCwiczenia_WyborZListy;
            // Opis tekstowy jak wykonać ćwiczenie wyciągnięte z bazy
            txtOpis.BackColor = Color.White;
            txtOpis.Location = new Point(230, 90);
            txtOpis.Multiline = true;
            txtOpis.Name = "txtOpis";
            txtOpis.ReadOnly = true;
            txtOpis.ScrollBars = ScrollBars.Vertical;
            txtOpis.Size = new Size(360, 110);
            txtOpis.TabIndex = 2;
            // Dodawanie ćwiczenia do własnej listy użytkownika
            btnDodaj.Location = new Point(276, 210);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(120, 35);
            btnDodaj.TabIndex = 4;
            btnDodaj.Text = "Dodaj";
            btnDodaj.Click += btnDodajCwiczenie;
            // Lista dodanych ćwiczeń do planu 
            lstPlan.BackColor = Color.Azure;
            lstPlan.HorizontalScrollbar = true;
            lstPlan.ItemHeight = 23;
            lstPlan.Location = new Point(610, 60);
            lstPlan.Name = "lstPlan";
            lstPlan.Size = new Size(200, 188);
            lstPlan.TabIndex = 7;
            // Usuwanie ćwiczenia z własnej listy użytkownika
            btnUsun.Location = new Point(416, 210);
            btnUsun.Name = "btnUsun";
            btnUsun.Size = new Size(120, 35);
            btnUsun.TabIndex = 5;
            btnUsun.Text = "Usuń";
            btnUsun.Click += btnUsunCwiczenie;
            // Ogólnie ustawienia 
            BackColor = Color.Gainsboro;
            ClientSize = new Size(840, 310);
            Font = new Font("Segoe UI", 10F);
            Controls.Add(lstCwiczenia);
            Controls.Add(lblPowitanie);
            Controls.Add(txtOpis);
            Controls.Add(lblPartia);
            Controls.Add(btnDodaj);
            Controls.Add(btnUsun);
            Controls.Add(lstPlan);
            Name = "FormPlaner";
            Text = "Planner Treningów :)";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
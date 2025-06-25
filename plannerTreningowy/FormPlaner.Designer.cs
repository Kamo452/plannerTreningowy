namespace plannerTreningowy
{
    partial class FormPlaner
    {
        private Label lblPowitanie;
        private ListBox lstCwiczenia;
        private TextBox txtOpis;
        private void InitializeComponent()
        {
            lblPowitanie = new Label();
            lstCwiczenia = new ListBox();
            txtOpis = new TextBox();
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
            txtOpis.Location = new Point(365, 104);
            txtOpis.Multiline = true;
            txtOpis.Name = "txtOpis";
            txtOpis.ReadOnly = true;
            txtOpis.ScrollBars = ScrollBars.Vertical;
            txtOpis.Size = new Size(360, 110);
            txtOpis.TabIndex = 2;
            // Ogólnie ustawienia 
            BackColor = Color.Gainsboro;
            ClientSize = new Size(840, 310);
            Font = new Font("Segoe UI", 10F);
            Controls.Add(lstCwiczenia);
            Controls.Add(lblPowitanie);
            Controls.Add(txtOpis);
            Name = "FormPlaner";
            Text = "Planner Treningów :)";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
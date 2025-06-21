namespace plannerTreningowy
{
    partial class FormPlaner
    {
        private Label lblPowitanie;
        private void InitializeComponent()
        {
            this.lblPowitanie = new Label();
            SuspendLayout();
            // 
            // lblPowitanie
            // 
            this.lblPowitanie.AutoSize = true;
            this.lblPowitanie.Location = new Point(479, 161);
            this.lblPowitanie.Name = "lblPowitanie";
            this.lblPowitanie.Size = new Size(16, 20);
            this.lblPowitanie.TabIndex = 0;
            this.lblPowitanie.Text = "x";
            // 
            // FormPlaner
            // 
            ClientSize = new Size(969, 401);
            Controls.Add(this.lblPowitanie);
            Name = "FormPlaner";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
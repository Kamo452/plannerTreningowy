namespace plannerTreningowy
{
    partial class FormLogowanie
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblHaslo;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtHaslo;
        private System.Windows.Forms.Button btnZaloguj;
        private System.Windows.Forms.Button btnRejestracja;
        private System.Windows.Forms.PictureBox logo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblLogin = new Label();
            lblHaslo = new Label();
            txtLogin = new TextBox();
            txtHaslo = new TextBox();
            btnZaloguj = new Button();
            btnRejestracja = new Button();
            logo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(100, 170);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(56, 23);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login:";
            // 
            // lblHaslo
            // 
            lblHaslo.AutoSize = true;
            lblHaslo.Location = new Point(100, 210);
            lblHaslo.Name = "lblHaslo";
            lblHaslo.Size = new Size(57, 23);
            lblHaslo.TabIndex = 2;
            lblHaslo.Text = "Hasło:";
            // 
            // txtLogin
            // 
            txtLogin.Font = new Font("Segoe UI", 10F);
            txtLogin.Location = new Point(180, 170);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(200, 30);
            txtLogin.TabIndex = 1;
            // 
            // txtHaslo
            // 
            txtHaslo.Font = new Font("Segoe UI", 10F);
            txtHaslo.Location = new Point(180, 210);
            txtHaslo.Name = "txtHaslo";
            txtHaslo.Size = new Size(200, 30);
            txtHaslo.TabIndex = 3;
            txtHaslo.UseSystemPasswordChar = true;
            // 
            // btnZaloguj
            // 
            btnZaloguj.BackColor = Color.SteelBlue;
            btnZaloguj.FlatStyle = FlatStyle.Flat;
            btnZaloguj.ForeColor = Color.White;
            btnZaloguj.Location = new Point(180, 260);
            btnZaloguj.Name = "btnZaloguj";
            btnZaloguj.Size = new Size(120, 35);
            btnZaloguj.TabIndex = 4;
            btnZaloguj.Text = "Zaloguj";
            btnZaloguj.UseVisualStyleBackColor = false;
            btnZaloguj.Click += btnZaloguj_Click;
            // 
            // btnRejestracja
            // 
            btnRejestracja.BackColor = Color.Gray;
            btnRejestracja.FlatStyle = FlatStyle.Flat;
            btnRejestracja.ForeColor = Color.White;
            btnRejestracja.Location = new Point(180, 310);
            btnRejestracja.Name = "btnRejestracja";
            btnRejestracja.Size = new Size(120, 35);
            btnRejestracja.TabIndex = 5;
            btnRejestracja.Text = "Rejestracja";
            btnRejestracja.UseVisualStyleBackColor = false;
            btnRejestracja.Click += btnRejestracja_Click;
            // 
            // logo
            // 
            logo.Image = Properties.Resources.logo;
            logo.Location = new Point(89, 23);
            logo.Name = "logo";
            logo.Size = new Size(300, 130);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 6;
            logo.TabStop = false;
            // 
            // FormLogowanie
            // 
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(500, 400);
            Controls.Add(lblLogin);
            Controls.Add(txtLogin);
            Controls.Add(lblHaslo);
            Controls.Add(txtHaslo);
            Controls.Add(btnZaloguj);
            Controls.Add(btnRejestracja);
            Controls.Add(logo);
            Font = new Font("Segoe UI", 10F);
            Name = "FormLogowanie";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Logowanie";
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
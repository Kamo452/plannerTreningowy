namespace plannerTreningowy
{
    partial class FormRejestracja
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblImie;
        private Label lblLogin;
        private Label lblHaslo;
        private TextBox txtImie;
        private TextBox txtLogin;
        private TextBox txtHaslo;
        private Button btnUtworz;
        private Button btnPowrot;
        private PictureBox logo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblImie = new Label();
            lblLogin = new Label();
            lblHaslo = new Label();
            txtImie = new TextBox();
            txtLogin = new TextBox();
            txtHaslo = new TextBox();
            btnUtworz = new Button();
            btnPowrot = new Button();
            logo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // lblImie
            // 
            lblImie.AutoSize = true;
            lblImie.Location = new Point(100, 170);
            lblImie.Name = "lblImie";
            lblImie.Size = new Size(47, 23);
            lblImie.TabIndex = 0;
            lblImie.Text = "Imię:";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(100, 210);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(56, 23);
            lblLogin.TabIndex = 2;
            lblLogin.Text = "Login:";
            // 
            // lblHaslo
            // 
            lblHaslo.AutoSize = true;
            lblHaslo.Location = new Point(100, 250);
            lblHaslo.Name = "lblHaslo";
            lblHaslo.Size = new Size(57, 23);
            lblHaslo.TabIndex = 4;
            lblHaslo.Text = "Hasło:";
            // 
            // txtImie
            // 
            txtImie.Font = new Font("Segoe UI", 10F);
            txtImie.Location = new Point(180, 170);
            txtImie.Name = "txtImie";
            txtImie.Size = new Size(200, 30);
            txtImie.TabIndex = 1;
            // 
            // txtLogin
            // 
            txtLogin.Font = new Font("Segoe UI", 10F);
            txtLogin.Location = new Point(180, 210);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(200, 30);
            txtLogin.TabIndex = 3;
            // 
            // txtHaslo
            // 
            txtHaslo.Font = new Font("Segoe UI", 10F);
            txtHaslo.Location = new Point(180, 250);
            txtHaslo.Name = "txtHaslo";
            txtHaslo.Size = new Size(200, 30);
            txtHaslo.TabIndex = 5;
            txtHaslo.UseSystemPasswordChar = true;
            // 
            // btnUtworz
            // 
            btnUtworz.BackColor = Color.ForestGreen;
            btnUtworz.FlatStyle = FlatStyle.Flat;
            btnUtworz.ForeColor = Color.White;
            btnUtworz.Location = new Point(180, 300);
            btnUtworz.Name = "btnUtworz";
            btnUtworz.Size = new Size(130, 35);
            btnUtworz.TabIndex = 6;
            btnUtworz.Text = "Utwórz konto";
            btnUtworz.UseVisualStyleBackColor = false;
            btnUtworz.Click += btnUtworz_Click;
            // 
            // btnPowrot
            // 
            btnPowrot.BackColor = Color.DimGray;
            btnPowrot.FlatStyle = FlatStyle.Flat;
            btnPowrot.ForeColor = Color.White;
            btnPowrot.Location = new Point(180, 350);
            btnPowrot.Name = "btnPowrot";
            btnPowrot.Size = new Size(130, 35);
            btnPowrot.TabIndex = 7;
            btnPowrot.Text = "Powrót";
            btnPowrot.UseVisualStyleBackColor = false;
            btnPowrot.Click += btnPowrot_Click;
            // 
            // logo
            // 
            logo.Image = Properties.Resources.logo;
            logo.Location = new Point(90, 23);
            logo.Name = "logo";
            logo.Size = new Size(300, 130);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 8;
            logo.TabStop = false;
            // 
            // FormRejestracja
            // 
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(500, 420);
            Controls.Add(lblImie);
            Controls.Add(txtImie);
            Controls.Add(lblLogin);
            Controls.Add(txtLogin);
            Controls.Add(lblHaslo);
            Controls.Add(txtHaslo);
            Controls.Add(btnUtworz);
            Controls.Add(btnPowrot);
            Controls.Add(logo);
            Font = new Font("Segoe UI", 10F);
            Name = "FormRejestracja";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rejestracja";
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

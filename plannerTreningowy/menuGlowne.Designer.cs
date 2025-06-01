namespace plannerTreningowy
{
    partial class menuGlowne
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnCardio;
        private System.Windows.Forms.Button btnStrength;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.FlowLayoutPanel flowPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnCardio = new System.Windows.Forms.Button();
            this.btnStrength = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.Location = new System.Drawing.Point(20, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(90, 28);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Witaj, ...";
            // 
            // btnCardio
            // 
            this.btnCardio.Location = new System.Drawing.Point(25, 60);
            this.btnCardio.Name = "btnCardio";
            this.btnCardio.Size = new System.Drawing.Size(120, 35);
            this.btnCardio.TabIndex = 1;
            this.btnCardio.Text = "Cardio";
            this.btnCardio.UseVisualStyleBackColor = true;
            this.btnCardio.Click += new System.EventHandler(this.btnCardio_Click);
            // 
            // btnStrength
            // 
            this.btnStrength.Location = new System.Drawing.Point(155, 60);
            this.btnStrength.Name = "btnStrength";
            this.btnStrength.Size = new System.Drawing.Size(120, 35);
            this.btnStrength.TabIndex = 2;
            this.btnStrength.Text = "Siłowe";
            this.btnStrength.UseVisualStyleBackColor = true;
            this.btnStrength.Click += new System.EventHandler(this.btnStrength_Click);
            // 
            // btnStats
            // 
            this.btnStats.Location = new System.Drawing.Point(285, 60);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(120, 35);
            this.btnStats.TabIndex = 3;
            this.btnStats.Text = "Statystyki";
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(640, 20);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(90, 28);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Wyloguj";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // flowPanel
            // 
            this.flowPanel.AutoScroll = true;
            this.flowPanel.Location = new System.Drawing.Point(25, 110);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(705, 320);
            this.flowPanel.TabIndex = 5;
            // 
            // menuGlowne
            // 
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.flowPanel);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btnStrength);
            this.Controls.Add(this.btnCardio);
            this.Controls.Add(this.lblWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "menuGlowne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu główne";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

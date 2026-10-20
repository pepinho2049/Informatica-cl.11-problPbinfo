namespace TestFinal
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitlu = new Label();
            lblNume = new Label();
            lblPunctaj = new Label();
            lblCorecte = new Label();
            lblGresite = new Label();
            lblTimp = new Label();
            btnInchide = new Button();
            SuspendLayout();

            lblTitlu.AutoSize = true;
            lblTitlu.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitlu.ForeColor = Color.DarkGreen;
            lblTitlu.Location = new Point(140, 30);
            lblTitlu.Name = "lblTitlu";
            lblTitlu.Size = new Size(189, 37);
            lblTitlu.TabIndex = 0;
            lblTitlu.Text = "Test Finalizat!";

            lblNume.AutoSize = true;
            lblNume.Font = new Font("Segoe UI", 14F);
            lblNume.Location = new Point(50, 90);
            lblNume.Name = "lblNume";
            lblNume.Size = new Size(78, 25);
            lblNume.TabIndex = 1;
            lblNume.Text = "nume";

            lblPunctaj.AutoSize = true;
            lblPunctaj.Font = new Font("Segoe UI", 14F);
            lblPunctaj.Location = new Point(50, 130);
            lblPunctaj.Name = "lblPunctaj";
            lblPunctaj.Size = new Size(56, 25);
            lblPunctaj.TabIndex = 2;
            lblPunctaj.Text = "pct";

            lblCorecte.AutoSize = true;
            lblCorecte.Font = new Font("Segoe UI", 14F);
            lblCorecte.ForeColor = Color.Green;
            lblCorecte.Location = new Point(50, 170);
            lblCorecte.Name = "lblCorecte";
            lblCorecte.Size = new Size(84, 25);
            lblCorecte.TabIndex = 3;
            lblCorecte.Text = "corecte";

            lblGresite.AutoSize = true;
            lblGresite.Font = new Font("Segoe UI", 14F);
            lblGresite.ForeColor = Color.Red;
            lblGresite.Location = new Point(50, 210);
            lblGresite.Name = "lblGresite";
            lblGresite.Size = new Size(70, 25);
            lblGresite.TabIndex = 4;
            lblGresite.Text = "gresite";

            lblTimp.AutoSize = true;
            lblTimp.Font = new Font("Segoe UI", 14F);
            lblTimp.Location = new Point(50, 250);
            lblTimp.Name = "lblTimp";
            lblTimp.Size = new Size(52, 25);
            lblTimp.TabIndex = 5;
            lblTimp.Text = "timp";

            btnInchide.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnInchide.Location = new Point(160, 310);
            btnInchide.Name = "btnInchide";
            btnInchide.Size = new Size(150, 40);
            btnInchide.TabIndex = 6;
            btnInchide.Text = "Închide";
            btnInchide.UseVisualStyleBackColor = true;
            btnInchide.Click += btnInchide_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 400);
            Controls.Add(btnInchide);
            Controls.Add(lblTimp);
            Controls.Add(lblGresite);
            Controls.Add(lblCorecte);
            Controls.Add(lblPunctaj);
            Controls.Add(lblNume);
            Controls.Add(lblTitlu);
            Name = "Form3";
            Text = "Rezultate Test";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitlu;
        private Label lblNume;
        private Label lblPunctaj;
        private Label lblCorecte;
        private Label lblGresite;
        private Label lblTimp;
        private Button btnInchide;
    }
}

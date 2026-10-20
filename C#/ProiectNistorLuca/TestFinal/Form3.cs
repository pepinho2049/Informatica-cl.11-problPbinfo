namespace TestFinal
{
    public partial class Form3 : Form
    {
        public Form3(string nume, int punctaj, int corecte, int gresite, int total, TimeSpan timp)
        {
            InitializeComponent();
            lblNume.Text = $"Utilizator: {nume}";
            lblPunctaj.Text = $"Punctaj: {punctaj} / {total}";
            lblCorecte.Text = $"Răspunsuri corecte: {corecte}";
            lblGresite.Text = $"Răspunsuri greșite: {gresite}";
            lblTimp.Text = $"Timp: {timp.Minutes} min {timp.Seconds} sec";
        }

        private void btnInchide_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

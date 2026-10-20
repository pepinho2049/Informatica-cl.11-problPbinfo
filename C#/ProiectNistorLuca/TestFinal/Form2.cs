using System.Diagnostics;

namespace TestFinal
{
    public partial class Form2 : Form
    {
        private string nume;
        private int punctaj = 0;
        private int intrebariCorecte = 0;
        private int intrebariGresite = 0;
        private Stopwatch stopwatch;
        private System.Windows.Forms.Timer timerClock;

        public Form2(string nume)
        {
            this.nume = nume;
            InitializeComponent();
            stopwatch = new Stopwatch();
            timerClock = new System.Windows.Forms.Timer();
            timerClock.Interval = 1000;
            timerClock.Tick += TimerClock_Tick;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblUtilizator.Text = $"Utilizator: {nume}";
            lblInfoTab10.Text = $"Bine ai venit, {nume}!\n\nRăspunde la toate întrebările de pe cele 9 pagini (1-9), apoi apasă butonul 'Finalizare' pentru a vedea rezultatul.\n\nSucces!";
            stopwatch.Start();
            timerClock.Start();
        }

        private void TimerClock_Tick(object? sender, EventArgs e)
        {
            TimeSpan ts = stopwatch.Elapsed;
            lblTimer.Text = $"Timp: {ts.Minutes:D2}:{ts.Seconds:D2}";
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblTrackValue.Text = $"Valoare selectată: {trackBar1.Value}";
        }

        private void btnFinalizare_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
            timerClock.Stop();

            DialogResult result = MessageBox.Show(
                "Sigur doriți să finalizați testul?",
                "Confirmare finalizare",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                VerificaRaspunsuri();
                Form3 f3 = new Form3(nume, punctaj, intrebariCorecte, intrebariGresite, 9, stopwatch.Elapsed);
                f3.Show();
                this.Hide();
            }
            else
            {
                stopwatch.Start();
                timerClock.Start();
            }
        }

        private void VerificaRaspunsuri()
        {
            punctaj = 0;
            intrebariCorecte = 0;
            intrebariGresite = 0;

            if (q1a2.Checked)
            {
                punctaj++;
                intrebariCorecte++;
            }
            else
            {
                intrebariGresite++;
            }

            if (q2a1.Checked && q2a2.Checked && !q2a3.Checked && q2a4.Checked)
            {
                punctaj++;
                intrebariCorecte++;
            }
            else
            {
                intrebariGresite++;
            }

            if (q3a.SelectedIndex == 2)
            {
                punctaj++;
                intrebariCorecte++;
            }
            else
            {
                intrebariGresite++;
            }

            if (listBox1.SelectedIndex == 2)
            {
                punctaj++;
                intrebariCorecte++;
            }
            else
            {
                intrebariGresite++;
            }

            string raspuns = q5a.Text.Trim().ToLower();
            if (raspuns == "albedo" || raspuns == "albedoul" || raspuns == "albedo-ul")
            {
                punctaj++;
                intrebariCorecte++;
            }
            else
            {
                intrebariGresite++;
            }

            if (trackBar1.Value == 7)
            {
                punctaj++;
                intrebariCorecte++;
            }
            else
            {
                intrebariGresite++;
            }

            if (dateTimePicker1.Value.Year == 1992)
            {
                punctaj++;
                intrebariCorecte++;
            }
            else
            {
                intrebariGresite++;
            }

            if (numericUpDown1.Value == 1.5m)
            {
                punctaj++;
                intrebariCorecte++;
            }
            else
            {
                intrebariGresite++;
            }

            if (checkedListBox1.CheckedIndices.Count == 3 &&
                checkedListBox1.GetItemChecked(0) &&
                checkedListBox1.GetItemChecked(1) &&
                checkedListBox1.GetItemChecked(2) &&
                !checkedListBox1.GetItemChecked(3))
            {
                punctaj++;
                intrebariCorecte++;
            }
            else
            {
                intrebariGresite++;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton2_CheckedChanged(object sender, EventArgs e) { }
        private void q1a3_CheckedChanged(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}

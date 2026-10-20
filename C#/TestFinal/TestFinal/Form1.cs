namespace TestFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nume = textBox1.Text;
            string parola = textBox2.Text;
            if(parola == "moisil")
            {
                Form2 f = new Form2(nume);
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Autentificarea este nereușită! Încercați din nou!");
            }
        }
    }
}

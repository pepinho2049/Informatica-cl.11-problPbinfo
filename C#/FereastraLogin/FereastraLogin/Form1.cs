namespace FereastraLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nume = textBox1.Text;
            if(nume == "elev" && textBox2.Text == "moisil")
            {
                Form2 f = new Form2(nume);  
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("AUTENTIFICARE NEREUSITA!");
            }
        }
    }
}

namespace TestGrila
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
            if(nume == "elev" && parola == "moisil")
            {
                Form2 f = new Form2();
                f.ShowDialog(); 
            }
            else
            {
                MessageBox.Show("Logare invalida!");
            }
        }
    }
}

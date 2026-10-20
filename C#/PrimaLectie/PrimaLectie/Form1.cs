namespace PrimaLectie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ai câstigat un milion de euro!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nume = textBox1.Text;
            Form2 f = new Form2(nume);
            ///Form2 f = new Form2();
            ///f.Show();
            f.ShowDialog(); // nu ma mai pot intoarce in primul form daca nu il inchid pe al doilea
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}

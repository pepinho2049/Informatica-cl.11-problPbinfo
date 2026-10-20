using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGrila
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int punctaj = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 2) punctaj = punctaj + 1;
            label2.Text = punctaj.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 2) punctaj = punctaj + 1;
            label2.Text = punctaj.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedIndex == 2) punctaj = punctaj + 1;
            label2.Text = punctaj.ToString();
        }
        string nume = "Carmen";
        private void button4_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4(nume, punctaj);
            f.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        int index = -1;
        private void button5_Click(object sender, EventArgs e)
        {
            index = index + 1;
            if (index == 3) index = 0;
            pictureBox1.Image = imageList1.Images[index];
        }
    }
}

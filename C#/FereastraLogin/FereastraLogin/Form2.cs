using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FereastraLogin
{
    public partial class Form2 : Form
    {
        private string nume;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string nume)/// generam un constructor pt nume
        {
            InitializeComponent();
            this.nume = nume;
        }
        int punctaj = 0;
        private void Form2_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = nume;
            label2.Text = punctaj.ToString(); /// convertire int in string
            label3.Text = "puncte";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                punctaj += 10;
            }
            label2.Text = punctaj.ToString();
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            button1.Enabled = false;
            radioButton1.BackColor = Color.Red;
            radioButton2.BackColor = Color.Red;
            radioButton3.BackColor = Color.Green;
            button2.Visible = true;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3(nume, punctaj);
            f.ShowDialog();
        }
    }
}

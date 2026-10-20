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
    public partial class Form3 : Form
    {
        private string nume;
        private int punctaj;

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(string nume, int punctaj)
        {
            InitializeComponent();
            this.nume = nume;
            this.punctaj = punctaj;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = nume;
            label2.Text = punctaj.ToString();
            label3.Text = "puncte";
        }
    }
}

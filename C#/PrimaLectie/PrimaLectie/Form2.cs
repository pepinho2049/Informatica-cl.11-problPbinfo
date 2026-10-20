using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimaLectie
{
    public partial class Form2 : Form
    {
        private string nume;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string nume)
        {
            InitializeComponent();
            this.nume = nume;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = nume;
            
        }
    }
}

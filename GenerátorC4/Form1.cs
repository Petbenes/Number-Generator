using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenerátorC4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btGeneruj_Click(object sender, EventArgs e)
        {
            int a, c, x, m, k;

            a = 1664525;
            c = 1013904223;
            m = 1731513;

            x = Convert.ToInt32(txtSeed.Text);

            for (int i = 0; i < 20; i++)
            {
                x = ((a * x) + c) % m;
                k = (Math.Abs(x) % 6) + 1;
                txtVysledek.Text = txtVysledek.Text + k.ToString() + ", ";
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            txtVysledek.Text = "";
        }
    }
}

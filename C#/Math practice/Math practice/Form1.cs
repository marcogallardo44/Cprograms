using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            int number, a, b,c;
            number = Int32.Parse(txtNumber.Text);
            c = number / 100;
            number = number % 100;
            a = number / 10;
            b = number % 10;
            txt100.Text = c.ToString();
            txt10.Text = a.ToString();
            txt1.Text = b.ToString();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtNumber.Clear();
            txt10.Clear();
            txt1.Text = "";
            txt100.Clear();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

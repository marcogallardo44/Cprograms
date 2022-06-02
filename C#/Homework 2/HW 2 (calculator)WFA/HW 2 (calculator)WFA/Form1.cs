using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_2__calculator_WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            double num1, num2, result;
            num1 = Double.Parse(txt1.Text);
            num2 = Double.Parse(txt2.Text);
            result = num1 + num2;
            txt3.Text = Convert.ToString(result);

        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            double num1, num2, result;
            num1 = Double.Parse(txt1.Text);
            num2 = Double.Parse(txt2.Text);
            result = num1 - num2;
            txt3.Text = Convert.ToString(result);
        }

        private void BtnMult_Click(object sender, EventArgs e)
        {
            double num1, num2, result;
            num1 = Double.Parse(txt1.Text);
            num2 = Double.Parse(txt2.Text);
            result = num1 * num2;
            txt3.Text = Convert.ToString(result);
        }

        private void BtnAvr_Click(object sender, EventArgs e)
        {
            double num1, num2, result;
            num1 = Double.Parse(txt1.Text);
            num2 = Double.Parse(txt2.Text);
            result = (num1 + num2)/2;
            txt3.Text = Convert.ToString(result);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

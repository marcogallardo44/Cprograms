using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            double num1, num2, result;
            num1 = Double.Parse(txtNum1.Text);
            num2 = Double.Parse(txtNum2.Text);
            result = num1 + num2;
            txtResult.Text = Convert.ToString(result);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            double num1, num2, result;
            num1 = Double.Parse(txtNum1.Text);
            num2 = Double.Parse(txtNum2.Text);
            result = num1 - num2;
            txtResult.Text = Convert.ToString(result);
        }

        private void BtnMult_Click(object sender, EventArgs e)
        {
            double num1, num2, result;
            num1 = Double.Parse(txtNum1.Text);
            num2 = Double.Parse(txtNum2.Text);
            result = num1 * num2;
            txtResult.Text = Convert.ToString(result);
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            double num1, num2, result;
            num1 = Double.Parse(txtNum1.Text);
            num2 = Double.Parse(txtNum2.Text);
            result = num1 / num2;
            txtResult.Text = Convert.ToString(result);
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            double mile, km;
            mile = Double.Parse(txtMile.Text);
          
            km = mile * 1.609;
            txtKm.Text = Convert.ToString(km);
        }

        private void TxtMile_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtKm_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

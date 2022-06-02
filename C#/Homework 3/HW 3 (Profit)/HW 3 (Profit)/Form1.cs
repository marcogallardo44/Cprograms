using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_3__Profit_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProfit_Click(object sender, EventArgs e)
        {
            txtTotal.BackColor = Color.White;
            double num1, num2, num3, result;
            bool v11 = Double.TryParse(txtTotal.Text, out num1);
            if (v11 & num1 > 0)
            {
                num1 = Double.Parse(txtTotal.Text);
                if (num1 >= 10000)
                {
                    txtSales.Text = "$" + Convert.ToString(num1);
                    txtRatio.Text = "4.5%";
                    result = num1 * .045;
                    result = Math.Round(result, 2);
                    txtProf.Text = "$" + Convert.ToString(result);
                }
                else if (num1 >= 5000.00 && num1 < 10000)
                {
                    txtSales.Text = "$" + Convert.ToString(num1);
                    txtRatio.Text = "4%";
                    result = num1 * .04;
                    result = Math.Round(result, 2);
                    txtProf.Text = "$" + Convert.ToString(result);
                }
                else if (num1 >= 1000.00 && num1 < 5000)
                {
                    txtSales.Text = "$" + Convert.ToString(num1);
                    txtRatio.Text = "3.5%";
                    result = num1 * .035;
                    result = Math.Round(result, 2);
                    txtProf.Text = "$" + Convert.ToString(result);
                }
                else if (num1 >= 0 && num1 < 1000)
                {
                    txtSales.Text = "$" + Convert.ToString(num1);
                    txtRatio.Text = "3%";
                    result = num1 * .03;
                    result = Math.Round(result, 2);
                    txtProf.Text = "$" + Convert.ToString(result);
                }
            }
            else if (!v11)
            {
                MessageBox.Show("Invalid input of height"); //shows box
                txtTotal.BackColor = Color.Red;
            }
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtTotal.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtTotal.Text = txtTotal.Text.Remove(txtTotal.Text.Length - 1);
            }
        }

        private void txtSales_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtRatio_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtProf_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

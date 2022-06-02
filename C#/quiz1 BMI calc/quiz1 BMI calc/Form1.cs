using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz1_BMI_calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            txtFeet.BackColor = Color.White;
            txtInch.BackColor = Color.White;
            txtLbs.BackColor = Color.White;
            txtBMI.Text = "";
            string str1, str2, str3;
            double num1 =0, num2=0, num3=0, result=0;
            bool v11 = Double.TryParse(txtFeet.Text, out num1);
            bool v21 = Double.TryParse(txtInch.Text, out num2);
            bool v31 = Double.TryParse(txtLbs.Text, out num3);
            if (v11 & v21 & v31 & num1 > 0 & num2 >= 0 && num2 < 12 && num3 > 0)
            {
                num1 = (num1 * 12) + num2;
                num1 = num1 * num1;
                num3 = num3 * 705;
                result = num3 / num1;
                result = Math.Round(result, 1);
                txtBMI.Text = Convert.ToString(result);
                if(result < 18.5)
                {
                    MessageBox.Show("Underweight");
                }
                else if (result >= 18.5 && result < 25)
                {
                    MessageBox.Show("Normal weight");
                }
                else if (result >= 25 && result < 30)
                {
                    MessageBox.Show("Overweight");
                }
                else if (result >= 30)
                {
                    MessageBox.Show("Obesity");
                }
            }
            else if (!v11)
            {
                MessageBox.Show("Invalid input of height"); //shows box
                txtFeet.BackColor = Color.Red;
            }
            else if (num1 < 0)
            {
                MessageBox.Show("Invalid input of height, enter a positive number."); //shows box
                txtFeet.BackColor = Color.Red;
            }
            else if (!v21)
            {
                MessageBox.Show("Invalid input of height in inches"); //shows box
                txtInch.BackColor = Color.Red;
            }
            else if (num2 < 0 || num2 >= 12)
            {
                MessageBox.Show("Invalid input of inches, out of range."); //shows box
                txtInch.BackColor = Color.Red;
            }
            else if (!v31)
            {
                MessageBox.Show("Invalid input of weight"); //shows box
                txtLbs.BackColor = Color.Red;
            }
            else if (num3 < 0)
            {
                MessageBox.Show("Invalid input of weight, enter a positive number."); //shows box
                txtLbs.BackColor = Color.Red;
            }
            else;




        }

        private void TxtFeet_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtFeet.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtFeet.Text = txtFeet.Text.Remove(txtFeet.Text.Length - 1);
            }
        }

        private void TxtInch_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtInch.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtInch.Text = txtInch.Text.Remove(txtInch.Text.Length - 1);
            }
        }

        private void TxtLbs_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtLbs.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtLbs.Text = txtLbs.Text.Remove(txtLbs.Text.Length - 1);
            }
        }
    }
}

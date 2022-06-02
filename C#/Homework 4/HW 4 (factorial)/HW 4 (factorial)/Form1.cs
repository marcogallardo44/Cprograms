using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_4__factorial_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtFacto.BackColor = Color.White;
            



            double num1, num2;


            bool v11 = Double.TryParse(txtFacto.Text, out num1);

           
            List<string> nList = new List<string>();
            if (v11 & num1 > 0)
            {

                num1 = Double.Parse(txtFacto.Text);
                double x = 1;
                double i = 1;
                while (i <= num1)
                {

                    x = x * i;
                    nList.Add(Convert.ToString(i) + "!");
                    i++;
                }
                nList.Add(Convert.ToString(x));

                nList.Add("e = ");
                num2 = Double.Parse(txtFacto.Text);

                double j = 1;
                double y = 1;
                double a = 0;
                double b = 1;

                while (j <= num2)
                {


                    while (y <= j)
                    {

                        b = b * y;
                        y++;
                    }
                    if (j == 5)
                    {
                        nList.Add("1/" + Convert.ToString(b) + " = ");
                    }
                    else
                        nList.Add("1/" + Convert.ToString(b) + " + ");
                    a = a + 1 / b;

                    j++;
                }
                nList.Add(Convert.ToString(Math.Round(a, 6)));
                listBox1.DataSource = nList;
            }
            else if(!v11)
            {
                MessageBox.Show("Invalid input of height"); //shows box
                txtFacto.BackColor = Color.Red;

            }
        }

        private void txtFacto_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtFacto.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtFacto.Text = txtFacto.Text.Remove(txtFacto.Text.Length - 1);
            }

        }
    }
}

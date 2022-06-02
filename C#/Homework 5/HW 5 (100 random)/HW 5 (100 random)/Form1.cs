using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_5__100_random_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRng_Click(object sender, EventArgs e)
        {
            txtMax.BackColor = Color.White;
            txtMin.BackColor = Color.White;
            listBox1.Items.Clear();
            double max, min;
            bool v11 = Double.TryParse(txtMax.Text, out max);
            bool v12 = Double.TryParse(txtMin.Text, out min);


            List<string> nList = new List<string>();
            if (v11 & max >0 && v12 & min > 0)
            {

                max = double.Parse(txtMax.Text);
                min = double.Parse(txtMin.Text);
                Random r_obj = new Random();
                double mean = 0;

                double[] x = new double[100];
                double[] y = new double[100];
                double[] n1 = new double[100];
                for (int i = 0; i < 100; i++)
                {
                    x[i] = r_obj.NextDouble();


                }
                for (int i = 0; i < 100; i++)
                {
                    y[i] = r_obj.NextDouble();


                }

                for (int i = 0; i < 100; i++)
                {
                    n1[i] = Math.Cos(2 * Math.PI * y[i]) * Math.Sqrt(-2 * Math.Log(x[i]));
                    mean = mean + n1[i];


                }
                mean = mean / 100;
                Array.Sort(n1);
                Array.Reverse(n1);

                for (int i = 0; i < 100; i++)
                {
                    listBox1.Items.Add(n1[i].ToString());
                }

                listBox1.Items.Add("the mean is: " + mean.ToString());
            }
            else if (!v11 && !v12)
            {
                MessageBox.Show("Invalid input of both"); //shows box
                txtMax.BackColor = Color.Red;
                
                txtMin.BackColor = Color.Red;

            }
            else if (!v11)
            {
                MessageBox.Show("Invalid input of max"); //shows box
                txtMax.BackColor = Color.Red;

            }
            else if (!v12)
            {
                MessageBox.Show("Invalid input of min"); //shows box
                txtMin.BackColor = Color.Red;

            }


        }

        private void TxtMax_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtMax.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtMax.Text = txtMax.Text.Remove(txtMax.Text.Length - 1);
            }

        }

        private void TxtMin_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtMin.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtMin.Text = txtMin.Text.Remove(txtMin.Text.Length - 1);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

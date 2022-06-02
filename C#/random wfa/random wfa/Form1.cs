using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace random_wfa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnInt_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random r_obj = new Random();
            int x;
            double y;
            for (int i = 1; i < 11; i++)
            {
                x = r_obj.Next(5, 11);
                listBox1.Items.Add(x.ToString());
            }
            
        }

        private void BtnDeci_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            Random r_obj = new Random();
            double x;
            double large =0, small=100;
            double max, min, N;
            max = double.Parse(txtMax.Text);
            min = double.Parse(txtMin.Text);

            N = int.Parse(txtN.Text);
            for (int i = 1; i <= N; i++)
            {
                x = r_obj.NextDouble()*(max-min)+min;
                x = Math.Round(x, 2);
                if (large < x)
                    large = x;
                if (small > x)
                    small = x;
                listBox2.Items.Add(x.ToString());

            }
            listBox2.Items.Add("The smallest number is: " + small.ToString());
            MessageBox.Show("The largest number is: " + large);
           

        }
    }
}

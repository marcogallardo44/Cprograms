using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ref_or_value_WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void GetInput(ref double n, string input, double l, double h)
        {
            bool valid = Double.TryParse(input, out n);
            if (!valid)
            {
                MessageBox.Show("Invalid! Enter a number");
                return;
            }

            else if (n < 1 || n > h)
            {
                MessageBox.Show("Invalid, must be between" + 1 + " and " + h);
                return;
            }
            else
                return;
        }



        double Average(double[] x)
        {
            double ave = 0;
            for(int i =0; i<x.Length;i++)
            {
                ave += x[i];
                
            }
            return ave / x.Length;
        }



        void GetInput(ref double n, string input)
        {
            bool valid = Double.TryParse(input, out n);
            if (!valid)
            {
                MessageBox.Show("Invalid! Enter a number");
                return;
            }

          
        }




        double[] GetRandom(int k, double a, double b)
        {
            Random r = new Random();
            double[] x = new double[k];
            for (int i = 0; i < k; i++)
            {
                x[i] = a + (b - a) * r.NextDouble();
            }
            return x;
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            /*double[] test = { 3, 5, 2 };
            MessageBox.Show(Average(test).ToString());*/


            listBox1.Items.Clear();
            double N = 0, a =0,b=0;
            GetInput(ref N, textN.Text, 1, 99999);
            GetInput(ref a, textA.Text);
            GetInput(ref b, textB.Text);
            //MessageBox.Show("N= " + N.ToString());


            double[] y = new double[(int) N];
            GetRandom((int) N, a, b, ref y);

           // double[] y = GetRandom((int)N, a, b);
            for (int i =0; i < (int)N;i++)
                listBox1.Items.Add(y[i].ToString());

            listBox1.Items.Add("the average: " + Average(y).ToString());

            /*int a = 1,b = 2;
            What(ref a, ref b);
            MessageBox.Show("a=" + a.ToString() + ", b= " + b.ToString());*/
        }


        void GetRandom(int k, double a, double b, ref double[] x)
        {
            Random r = new Random();
            
            for (int i = 0; i < k; i++)
            {
                x[i] = a + (b - a) * r.NextDouble();
            }

        }



        void What(ref int x, ref int y)
        {
            x = x + 1;
            y = y * 2;
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}

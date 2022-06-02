using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_7__take_home_pay_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            textSales.BackColor = Color.White;
            textName.BackColor = Color.White;

            double sales, fed, retire, social;
            
            bool v11 = Double.TryParse(textSales.Text, out sales);
            if (v11 & sales > 0)
            {
                sales = Double.Parse(textSales.Text);
                sales = sales * .07;

                fed = sales * .18;
                retire = sales * .15;
                social = sales * .09;

                textFederal.Text = "$" + Convert.ToString(fed);
                textRetire.Text = "$" + Convert.ToString(retire);
                textSocial.Text = "$" + Convert.ToString(social);

                sales = sales - fed - retire - social;

                textTotal.Text = "$" + Convert.ToString(sales);

            }
            else if (!v11)
            {
                MessageBox.Show("Invalid input of Sales"); //shows box
                textSales.BackColor = Color.Red;
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            textName.Clear();
            textSales.Clear();
            textFederal.Clear();
            textRetire.Clear();
            textSocial.Clear();
            textTotal.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

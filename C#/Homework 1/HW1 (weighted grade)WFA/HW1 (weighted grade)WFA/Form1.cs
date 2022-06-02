using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW1__weighted_grade_WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double hw, quiz, proj, exam,final , total;
            hw = double.Parse(txtHw.Text);
            quiz = double.Parse(txtQuiz.Text);
            proj = double.Parse(txtProject.Text);
            exam = double.Parse(txtExam.Text);
            final = double.Parse(txtFinal.Text);
            total = (hw * .1) + (quiz * .2) + (proj * .25) + (exam * .2) + (final * .25);
            total = Math.Round(total, 1);
            txtTotal.Text = Convert.ToString(total);

        }
    }
}

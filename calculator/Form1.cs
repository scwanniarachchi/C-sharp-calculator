using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double no1 = double.Parse(txt1.Text);
            double no2 = double.Parse(txt2.Text);
            double sum = no1 + no2;
            lblanswer.Text = "Addition = "+ sum.ToString(); 


        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double no1 = double.Parse(txt1.Text);
            double no2 = double.Parse(txt2.Text);
            double sum = no1 - no2;
            lblanswer.Text = "Substract = " + sum.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double no1 = double.Parse(txt1.Text);
            double no2 = double.Parse(txt2.Text);
            double mul = no1 * no2;
            lblanswer.Text = "Multiplication = " + mul.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            lblanswer.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double no1 = double.Parse(txt1.Text);
            double no2 = double.Parse(txt2.Text);
            double div = no1 / no2;
            lblanswer.Text = "Division = " + div.ToString();
        }
    }
}

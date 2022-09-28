using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPF_28._09_Z1
{
    public partial class Form1 : Form
    {
        public double result=0;
        public double oldValue;
        public double a;
        int count;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Desc.Text = "";
            calculate();
           

        }

        private void zero_Click(object sender, EventArgs e)
        {
            Desc.Text += "0";
       
        }

        private void one_Click(object sender, EventArgs e)
        {
            Desc.Text += "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            Desc.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Desc.Text += "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            Desc.Text += "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            Desc.Text += "5";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Desc.Text += "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            Desc.Text += "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            Desc.Text += "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {

            Desc.Text += "9";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            
            a = double.Parse(Desc.Text);
            
            //Desc.Text = a.ToString() + "+";
            count = 1;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            a = double.Parse(Desc.Text);
            //Desc.Text = a.ToString() + "-";
            count = 2;
        }

        private void mult_Click(object sender, EventArgs e)
        {
            a = double.Parse(Desc.Text);
           // Desc.Text = a.ToString() + "*";
            count = 3;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            a = double.Parse(Desc.Text);
           // Desc.Text = a.ToString() + "/";
            count = 4;
        }

        private void sqr_Click(object sender, EventArgs e)
        {

        }

        private void calculate()
        {
            switch (count)
            {
                case 1:
                    result = a + double.Parse(Desc.Text);
                    Desc.Text = result.ToString();
                    break;
                case 2:
                    result = a - double.Parse(Desc.Text);
                    Desc.Text = result.ToString();
                    break;
                case 3:
                    result = a * double.Parse(Desc.Text);
                    Desc.Text = result.ToString();
                    break;
                case 4:
                    result = a / double.Parse(Desc.Text);
                    Desc.Text = result.ToString();
                    break;

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double RS1, RS2, TR1;
            try
            {
                RS1 = double.Parse(textBox1.Text);
                RS2 = double.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("INPUT ERROR");
                RS1 = 0.0;
                RS2 = 0.0;
            }

            TR1 = RS1 + RS2;
            MessageBox.Show(TR1.ToString());
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double RS3, RS4, RS5, TR2;
            try
            {
                RS3 = double.Parse(textBox3.Text);
                RS4 = double.Parse(textBox4.Text);
                RS5 = double.Parse(textBox5.Text);
            }
            catch
            {
                MessageBox.Show("INPUT ERROR");
                RS3 = 0.0;
                RS4 = 0.0;
                RS5 = 0.0;
            }
            TR2 = RS3 + RS4 + RS5;
            MessageBox.Show(TR2.ToString());
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            double RP1, RP2, TR3;
            try
            {
                RP1 = double.Parse(textBox6.Text);
                RP2 = double.Parse(textBox7.Text);
            }
            catch
            {
                MessageBox.Show("INPUT ERROR");
                RP1 = 0.0;
                RP2 = 0.0;
            }
            TR3 = 1.0 / ((1.0 / RP1) + (1.0 / RP2));
            MessageBox.Show(TR3.ToString());
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            double RP3, RP4, RP5, TR4;
            try
            {
                RP3 = double.Parse(textBox8.Text);
                RP4 = double.Parse(textBox9.Text);
                RP5 = double.Parse(textBox10.Text);
            }
            catch
            {
                MessageBox.Show("INPUT ERROR");
                RP3 = 0.0;
                RP4 = 0.0;
                RP5 = 0.0;
            }
            TR4 = 1.0 / ((1.0 / RP3) + (1.0 / RP4) + (1.0 / RP5));
            MessageBox.Show(TR4.ToString());
        }
    }
}

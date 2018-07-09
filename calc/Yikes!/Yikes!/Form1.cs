using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Yikes_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double currnum1 = Convert.ToDouble(textBox1.Text), currnum2 = Convert.ToDouble(textBox2.Text);
            double endres = currnum1 / currnum2;
            label1.Text = Convert.ToString(endres);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double currnum1 = Convert.ToDouble(textBox1.Text), currnum2 = Convert.ToDouble(textBox2.Text);
            double endres = currnum1 + currnum2;
            label1.Text = Convert.ToString(endres);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double currnum1 = Convert.ToDouble(textBox1.Text), currnum2 = Convert.ToDouble(textBox2.Text);
            double endres = currnum1 - currnum2;
            label1.Text = Convert.ToString(endres);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double currnum1 = Convert.ToDouble(textBox1.Text), currnum2 = Convert.ToDouble(textBox2.Text);
            double endres = currnum1 * currnum2;
            label1.Text = Convert.ToString(endres);
        }
    }
}

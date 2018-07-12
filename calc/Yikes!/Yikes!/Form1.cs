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

        private void rnd_Click2(object sender, EventArgs e)
        {
            ITwoarg cal2 = FactoryTwoArg.CreateCalculator(((Button)sender).Name);
            double currnum1 = Convert.ToDouble(textBox1.Text), currnum2 = Convert.ToDouble(textBox2.Text);
            double endres = cal2.Calculate(currnum1, currnum2);
            label1.Text = Convert.ToString(endres);
        }

        private void rnd_Click1(object sender, EventArgs e)
        {
            IOnearg cal1 = FactoryOneArg.CreateCalculator(((Button)sender).Name);
            double currnum = Convert.ToDouble(textBox1.Text);
            double endres = cal1.Calculate(currnum);
            label1.Text = Convert.ToString(endres);
        }
    }
}

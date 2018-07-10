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

        private void rnd_Click(object sender, EventArgs e)
        {
            double currnum1 = Convert.ToDouble(textBox1.Text), currnum2 = Convert.ToDouble(textBox2.Text), endres;
            switch (((Button)sender).Name)
            {
                case ("bplus"): endres = currnum1 + currnum2; break;
                case ("bdiv"): endres = currnum1 / currnum2;  break;
                case ("bminus"): endres = currnum1 - currnum2; break;
                case ("bmult"): endres = currnum1 * currnum2;  break;
                default: throw new Exception("Неизвестная операция");
            }
            label1.Text = Convert.ToString(endres);
        }
    }
}

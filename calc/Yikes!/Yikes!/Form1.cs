using System;
using System.Windows.Forms;
using Yikes_.OneArgument;
using Yikes_.TwoArgument;

namespace Yikes_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Эта часть кода отвечает за функции, с двумя операндами.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rnd_Click2(object sender, EventArgs e)
        {
            try
            {
                ITwoArgument cal2 = FactoryTwoArguments.CreateCalculator(((Button) sender).Name);
                double currnum1 = Convert.ToDouble(textBox1.Text), currnum2 = Convert.ToDouble(textBox2.Text);
                double endres = cal2.Calculate(currnum1, currnum2);
                label1.Text = Convert.ToString(endres);
            }
            catch (Exception exc)
            {
                label1.Text = exc.Message;
            }
        }

        /// <summary>
        /// Эта часть кода отвечает за функции с одним операндом.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rnd_Click1(object sender, EventArgs e)
        {
            try
            {
                IOneArgument cal1 = FactoryOneArgument.CreateCalculator(((Button) sender).Name);
                double currnum = Convert.ToDouble(textBox1.Text);
                double endres = cal1.Calculate(currnum);
                label1.Text = Convert.ToString(endres);
            }
            catch (Exception exc)
            {
                label1.Text = exc.Message;
            }
        }
    }
}

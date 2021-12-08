using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assign6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Answer.Text = "The answer is " + Convert.ToString(Convert.ToDouble(Num1.Text) + Convert.ToDouble(Num2.Text));
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            Answer.Text = "The answer is " + Convert.ToString(Convert.ToDouble(Num1.Text) - Convert.ToDouble(Num2.Text));
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            Answer.Text = "The answer is " + Convert.ToString(Convert.ToDouble(Num1.Text) * Convert.ToDouble(Num2.Text));
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            Answer.Text = "The answer is " + Convert.ToString(Convert.ToDouble(Num1.Text) / Convert.ToDouble(Num2.Text));
        }
    }
}

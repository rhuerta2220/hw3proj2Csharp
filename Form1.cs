using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1hw3proj2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cost = Convert.ToDouble(textBox1.Text) * 100;
            int change = 100;
            change = change - (int)cost;
            int quarter = (change / 25);
            change = change - (25 * quarter);
            int dime = (change / 10);
            change = change - (10 * dime);
            int nickel = (change / 5);
            change = change - (5 * nickel);

            label3.Text = "You bought an item for\n"+ cost + " cents and gave me a dollar, so your change is\n"
                +quarter +" quarters,\n"
                +dime + " dimes, and\n"
                + nickel + " nickels";
        }
    }
}

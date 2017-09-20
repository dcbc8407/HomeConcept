using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SavingGrace
{
    public partial class QuoteBuilder : Form
    {
        public QuoteBuilder()
        {
            InitializeComponent();
            textBox1.Text = "1";
            label4.Text = "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Closes QuoteBuilder Window
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem=="Shoes")
            {
                label4.Text = "$35.00";
            }
            else if(comboBox1.SelectedItem=="Socks")
            {
                label4.Text = "$7.00";
            }
            else
            {
                label4.Text = null;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*int toInteger;
            int toInteger2;
            int sum;
            toInteger = int.Parse(textBox1.Text);
            toInteger2= int.Parse(label4.Text);
            sum = toInteger * toInteger2;
            label6.Text = sum.ToString();*/


        }
    }
}

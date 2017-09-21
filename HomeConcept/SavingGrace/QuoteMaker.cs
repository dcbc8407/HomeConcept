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
    public partial class QuoteMaker : Form
    {
        public QuoteMaker()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*ComboBox cb = (ComboBox)sender;
            string item = cb.Text;
            if (item != null)
                MessageBox.Show(item);*/
            
            if (comboBox1.Text=="John Doe Enterprises")
            {
                textBox1.Text = "1111 West Dreamer St. \r\n" + "New York, NY   10025";
                textBox2.Text = "Jim Dugan";
                textBox12.Text = textBox1.Text;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

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
    
    public partial class main : Form
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new main());
        }
        public main()
        {
            InitializeComponent();
            //CustomersGrid.Visible = false;
            //SchedulingGrid.Visible = true;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CustomersButton_Click(object sender, EventArgs e)
        {
            Customers CL = new Customers();
            CL.Show();
        }

        private void ScheduleButton_Click(object sender, EventArgs e)
        {
            Scheduling SCH = new Scheduling();
            SCH.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //This closes the entire program
            Close();
        }

        private void QuoteButton_Click(object sender, EventArgs e)
        {
            QuoteBuilder qb = new QuoteBuilder();
            qb.Show();
        }

        private void InvoicingButton_Click(object sender, EventArgs e)
        {
            Invoicing inv = new Invoicing();
            inv.Show();
        }
    }
}

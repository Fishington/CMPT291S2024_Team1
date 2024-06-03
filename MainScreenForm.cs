using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team1CMPT291_Final
{
    public partial class MainScreenForm : Form
    {
        public MainScreenForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        { }

        private void button4_Click_1(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InventoryForm inventoryForm = new InventoryForm();  
            inventoryForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RentalTransactionForm transactionForm = new RentalTransactionForm();   
            transactionForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            ReportForm reportForm = new ReportForm();
            reportForm.Show();
        }
    }
}

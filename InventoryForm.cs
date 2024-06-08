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
    public partial class InventoryForm : Form
    {

        private DBConnection DBConnectionInstance;
        public InventoryForm()
        {
            InitializeComponent();
            DBConnectionInstance = new DBConnection();

            string query = "SELECT * FROM Cars";
            DataTable results = DBConnectionInstance.Query(query);
            dataGridView1.DataSource = results;
        }


        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();

            MainScreenForm mainScreenForm = new MainScreenForm();
            mainScreenForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

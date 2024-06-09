using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team1CMPT291_Final
{
    public partial class ReportForm : Form
    {

        private DBConnection DBConnectionInstance;

        public ReportForm()
        {
            InitializeComponent();
            DBConnectionInstance = new DBConnection();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            MainScreenForm mainScreenForm = new MainScreenForm();
            mainScreenForm.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM CarType WHERE Type = 'SMALL'";
            DataTable results = DBConnection.Query(query);
            dataGridView1.DataSource = results;
        }
    }
}

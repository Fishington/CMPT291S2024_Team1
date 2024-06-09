using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team1CMPT291_Final
{
    public partial class InventoryForm : Form
    {

        public string PublicQuery { get; set; }

        public InventoryForm()
        {
            InitializeComponent();
            PublicQuery = "SELECT * FROM Cars"; //              ====== Important Query ======
            DataTable results = DBConnection.Query(PublicQuery);
            dataGridView1.DataSource = results;
        }


        private void button_back_Click(object sender, EventArgs e)
        {
            Close();
            MainScreenForm mainScreenForm = new MainScreenForm();
            mainScreenForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectionMode == DataGridViewSelectionMode.FullRowSelect && dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                // Access data from the selected row cells
                string cellValue1_VIN = selectedRow.Cells[0].Value?.ToString();
                string cellValue2_LP = selectedRow.Cells[1].Value?.ToString();
                string cellValue3_Make = selectedRow.Cells[2].Value?.ToString();
                string cellValue4_Model = selectedRow.Cells[3].Value?.ToString();
                string cellValue5_Trans = selectedRow.Cells[4].Value?.ToString();
                string cellValue6_BID = selectedRow.Cells[5].Value?.ToString();
                string cellValue7_Type = selectedRow.Cells[6].Value?.ToString();

                // OR (if your DataGridView is data-bound)
                var dataItem = dataGridView1.SelectedRows[0].DataBoundItem;
                // Access data properties from your data item class

                // Update your TestLabel with the retrieved data
                TestLabel.Text = $"Selected Row: {cellValue1_VIN}, {cellValue2_LP}, {cellValue3_Make}" +
                                $",{cellValue4_Model}, {cellValue5_Trans}, {cellValue6_BID}, {cellValue7_Type} ";
            }
            else
            {
                // Handle the case where no row is selected or selection mode is not FullRowSelect
                TestLabel.Text = "No row selected.";
            }
        }

        private void button_delete_car_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectionMode == DataGridViewSelectionMode.FullRowSelect && dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                string selectedVIN = selectedRow.Cells[0].Value?.ToString(); // Assuming VIN will stay in first collumn


                DialogResult confirmation = MessageBox.Show("Are you sure you want to delete this car?", "Delete Confirmation", MessageBoxButtons.YesNo);
                if (confirmation == DialogResult.Yes)
                {
                    string deleteQuery = $"DELETE FROM Cars WHERE VIN = '{selectedVIN}';";

                    int rowsAffected = DBConnection.Delete(deleteQuery);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Car deleted successfully.");
                        // Refresh DataGridView (Optional)

                        dataGridView1.DataSource = null;

                        // Reload data from database
                        DataTable data = DBConnection.Query(PublicQuery);
                        dataGridView1.DataSource = data;
                    }
                    else
                    {
                        MessageBox.Show("No car was deleted.");
                    }


                }
            }
            else
            {
                MessageBox.Show("No row selected.");
            }
        }

        private void button_modify_car_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectionMode == DataGridViewSelectionMode.FullRowSelect && dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                string selectedVIN = selectedRow.Cells[0].Value?.ToString(); // Assuming VIN is in the first column


                // Create ModifyCarForm instance and pass selectedVIN
                ModifyCarForm modifyForm = new ModifyCarForm(selectedVIN);
                modifyForm.ShowDialog(); // Show the popup form modally
            }
            else
            {
                MessageBox.Show("No row selected.");
            }
        }

        private void button_add_car_Click(object sender, EventArgs e)
        {
            this.Close();

            AddCarForm addCarForm = new AddCarForm();
            addCarForm.Show();


        }
    }
}

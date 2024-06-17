using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Diagnostics;
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
        private DBConnection DBConnectionInstance;

        public void UpdateDataGrid(string query)

        {
            DBConnectionInstance = new DBConnection();
            DataTable results = DBConnectionInstance.Query(query);
            dataGridView1.DataSource = results;
        }
        public InventoryForm()
        {
            InitializeComponent();
            UpdateDataGrid("SELECT * FROM Cars where Branch_ID IS NOT NULL");
            populate_combo_boxes();
        }

        private void populate_combo_boxes()
        {
            DBConnection dbConnection = new DBConnection();
            DataTable carTypes = dbConnection.Query("SELECT Distinct Type FROM CarType");
            DataRow carTypesRow = carTypes.NewRow();
            carTypesRow["Type"] = "";
            carTypes.Rows.InsertAt(carTypesRow, 0);
            ComboBox_Type.DataSource = carTypes;
            ComboBox_Type.DisplayMember = "Type";
            ComboBox_Type.ValueMember = "Type";
            ComboBox_Type.SelectedIndex = 0;

            DataTable carMakes = dbConnection.Query("SELECT Distinct Make FROM Cars");
            DataRow carMakesRow = carMakes.NewRow();
            carMakesRow["Make"] = "";
            carMakes.Rows.InsertAt(carMakesRow, 0);
            Combo_Make.DataSource = carMakes;
            Combo_Make.DisplayMember = "Make";
            Combo_Make.ValueMember = "Make";
            Combo_Make.SelectedIndex = 0;

            DataTable carTransmissions = dbConnection.Query("SELECT Distinct Transmission FROM Cars");
            DataRow carTransmissionsRow = carTransmissions.NewRow();
            carTransmissionsRow["Transmission"] = "";
            carTransmissions.Rows.InsertAt(carTransmissionsRow, 0);
            Combo_Transmission.DataSource = carTransmissions;
            Combo_Transmission.DisplayMember = "Transmission";
            Combo_Transmission.ValueMember = "Transmission";
            Combo_Transmission.SelectedIndex = 0;

            DataTable carModel = dbConnection.Query("SELECT Distinct Model FROM Cars");
            DataRow carModelRow = carModel.NewRow();
            carModelRow["Model"] = "";
            carModel.Rows.InsertAt(carModelRow, 0);
            Combo_Model.DataSource = carModel;
            Combo_Model.DisplayMember = "Model";
            Combo_Model.ValueMember = "Model";
            Combo_Model.SelectedIndex = 0;

            DataTable carBranch = dbConnection.Query("SELECT Distinct Branch_ID, Name FROM Branches");
            DataRow carBranchRow = carBranch.NewRow();
            carBranchRow["Name"] = "";
            carBranch.Rows.InsertAt(carBranchRow, 0);
            ComboBox_Branch.DataSource = carBranch;
            ComboBox_Branch.DisplayMember = "Name";
            ComboBox_Branch.ValueMember = "Branch_ID";
            ComboBox_Branch.SelectedIndex = 0;
        }

        private string build_search_query()
        {
            StringBuilder query = new StringBuilder("SELECT * FROM Cars WHERE 1=1");

            if (!string.IsNullOrEmpty(ComboBox_Type.Text))
            {
                query.Append($" AND Type = '{ComboBox_Type.Text}'");
            }

            if (!string.IsNullOrEmpty(Combo_Make.Text))
            {
                query.Append($" AND Make = '{Combo_Make.Text}'");
            }

            if (!string.IsNullOrEmpty(Combo_Transmission.Text))
            {
                query.Append($" AND Transmission = '{Combo_Transmission.Text}'");
            }

            if (!string.IsNullOrEmpty(Combo_Model.Text))
            {
                query.Append($" AND Model = '{Combo_Model.Text}'");
            }

            if (!string.IsNullOrEmpty(ComboBox_Branch.Text))
            {
                query.Append($" AND Branch_ID = '{ComboBox_Branch.SelectedValue}'");
            }
            Debug.WriteLine(query.ToString());
            return query.ToString();
        }


        private void button_back_Click(object sender, EventArgs e)
        {
            Close();
            var mainScreenForm = new MainScreenForm();
            mainScreenForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectionMode == DataGridViewSelectionMode.FullRowSelect && dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                // Access data from the selected row cells
                var cellValue1_VIN = selectedRow.Cells[0].Value?.ToString();
                var cellValue2_LP = selectedRow.Cells[1].Value?.ToString();
                var cellValue3_Make = selectedRow.Cells[2].Value?.ToString();
                var cellValue4_Model = selectedRow.Cells[3].Value?.ToString();
                var cellValue5_Trans = selectedRow.Cells[4].Value?.ToString();
                var cellValue6_BID = selectedRow.Cells[5].Value?.ToString();
                var cellValue7_Type = selectedRow.Cells[6].Value?.ToString();

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
                var selectedVIN = selectedRow.Cells[0].Value?.ToString(); // Assuming VIN will stay in first collumn


                DialogResult confirmation = MessageBox.Show("Are you sure you want to delete this car?", "Delete Confirmation", MessageBoxButtons.YesNo);
                if (confirmation == DialogResult.Yes)
                {
                    var deleteQuery = $"UPDATE Cars SET Branch_ID = null WHERE VIN = '{selectedVIN}';";

                    var rowsAffected = DBConnectionInstance.Delete(deleteQuery);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Car deleted successfully.");
                        UpdateDataGrid("SELECT * FROM Cars");
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
                var selectedVIN = selectedRow.Cells[0].Value?.ToString(); // Assuming VIN is in the first column


                // Create ModifyCarForm instance and pass selectedVIN
                var modifyForm = new ModifyCarForm(selectedVIN);
                modifyForm.ShowDialog(); // Show the popup form modally
                UpdateDataGrid("SELECT * FROM Cars"); // Refresh the DataGridView after the form is closed
            }
            else
            {
                MessageBox.Show("No row selected.");
            }
        }

        private void button_add_car_Click(object sender, EventArgs e)
        {
            Close();
            var addCarForm = new AddCarForm();
            addCarForm.Show();

            UpdateDataGrid("SELECT * FROM Cars");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = build_search_query();
            UpdateDataGrid(query);
        }


    }
}

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
    public partial class ModifyCarForm : Form
    {

        public ModifyCarForm(string selectedVIN)
        {
            InitializeComponent();

            textbox_VIN.Text = selectedVIN;
            var dBConnection = new DBConnection();
            var results = dBConnection.Query("SELECT * FROM Cars WHERE VIN = '" + selectedVIN + "'");
            // Show result in message box
            DataRow row = results.Rows[0];
            textBox_LicensePlate.Text = row["License_Plate"].ToString();
            textBox_Make.Text = row["Make"].ToString();
            textBox_Model.Text = row["Model"].ToString();
            textBox_Transmission.Text = row["Transmission"].ToString();
            textBox_BranchID.Text = row["Branch_ID"].ToString();
            textBox_Type.Text = row["Type"].ToString();

        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            var UpdateQuery = "UPDATE Cars SET License_Plate = '" + textBox_LicensePlate.Text + "', Make = '" + textBox_Make.Text + "', Model = '" + textBox_Model.Text + "', Transmission = '" + textBox_Transmission.Text + "', Branch_ID = '" + textBox_BranchID.Text + "', Type = '" + textBox_Type.Text + "' WHERE VIN = '" + textbox_VIN.Text + "'";
            var rowsAffected = new DBConnection().Update(UpdateQuery);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Car updated successfully!");
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("No changes were made. Please check your data.");
                DialogResult = DialogResult.None; // Stays on the form.
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

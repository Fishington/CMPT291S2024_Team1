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
            DBConnection dBConnection = new DBConnection();
            DataTable results = dBConnection.Query("SELECT * FROM Cars WHERE VIN = '" + selectedVIN + "'");
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
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            String UpdateQuery = "UPDATE Cars SET License_Plate = '" + textBox_LicensePlate.Text + "', Make = '" + textBox_Make.Text + "', Model = '" + textBox_Model.Text + "', Transmission = '" + textBox_Transmission.Text + "', Branch_ID = '" + textBox_BranchID.Text + "', Type = '" + textBox_Type.Text + "' WHERE VIN = '" + textbox_VIN.Text + "'";
            new DBConnection().Query(UpdateQuery);
        }
    }
}

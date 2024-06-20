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

            DBConnection dbConnection = new DBConnection();
            // Get all the different types of cars from the database
            DataTable carTypes = dbConnection.Query("SELECT Type FROM CarType");
            ComboBox_Type.DataSource = carTypes;
            ComboBox_Type.DisplayMember = "Type";
            ComboBox_Type.ValueMember = "Type";
            DataTable branches = dbConnection.Query("SELECT Branch_ID, Name FROM Branches");
            ComboBox_Branch.DataSource = branches;
            ComboBox_Branch.DisplayMember = "Name";
            ComboBox_Branch.ValueMember = "Branch_ID";
            DataTable transmission = new DataTable();
            transmission.Columns.Add("transmission", typeof(string));
            transmission.Rows.Add(new object[] { "Manual" });
            transmission.Rows.Add(new object[] { "Automatic" });
            ComboBox_Transmission.DataSource = transmission;
            ComboBox_Transmission.DisplayMember = "transmission";
            ComboBox_Transmission.ValueMember = "transmission";

            textbox_VIN.Text = selectedVIN;
            DataTable results = dbConnection.Query("SELECT * FROM Cars WHERE VIN = '" + selectedVIN + "'");

            // Show result in message box
            DataRow row = results.Rows[0];
            textBox_LicensePlate.Text = row["License_Plate"].ToString();
            textBox_Make.Text = row["Make"].ToString();
            textBox_Model.Text = row["Model"].ToString();
            ComboBox_Transmission.SelectedValue = row["Transmission"].ToString();
            ComboBox_Branch.SelectedValue = row["Branch_ID"].ToString();
            ComboBox_Type.SelectedIndex = ComboBox_Type.FindStringExact(row["Type"].ToString());
                

        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //display message box with currently selected type
            String UpdateQuery = "UPDATE Cars SET License_Plate = '" + textBox_LicensePlate.Text + "', Make = '" + textBox_Make.Text + "', Model = '" + textBox_Model.Text + "', Transmission = '" + ComboBox_Transmission.SelectedValue.ToString() + "', Branch_ID = '" + ComboBox_Branch.SelectedValue.ToString() + "', Type = '" + ComboBox_Type.SelectedValue.ToString() + "' WHERE VIN = '" + textbox_VIN.Text + "'";
            new DBConnection().Query(UpdateQuery);
            this.Close();
        }
    }
}

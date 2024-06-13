using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Data.Common;
using System.Collections;
using System.Data.Odbc;

namespace Team1CMPT291_Final
{
    public partial class AddCarForm : Form
    {
        public string PublicQuery { get; set; }
        private DBConnection DBConnectionInstance;

        public AddCarForm()
        {
            InitializeComponent();

            DBConnectionInstance = new DBConnection();

            // Get all the different types of cars from the database
            DataTable carTypes = DBConnectionInstance.Query("SELECT Type FROM CarType");
            ComboBox_Type.DataSource = carTypes;
            ComboBox_Type.DisplayMember = "Type";
            ComboBox_Type.ValueMember = "Type";
            DataTable branches = DBConnectionInstance.Query("SELECT Branch_ID, Name FROM Branches");
            ComboBox_Branch.DataSource = branches;
            ComboBox_Branch.DisplayMember = "Name";
            ComboBox_Branch.ValueMember = "Branch_ID";

        }


        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();

            InventoryForm inventoryForm = new InventoryForm();
            inventoryForm.Show();
        }

        private void VIN_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            string insertQuery = $"INSERT INTO Cars (VIN, License_Plate, Make, Model, Transmission, Branch_ID, Type) VALUES" +
                $" ('{VIN_Box.Text}', '{Plate_Box.Text}', '{Make_Box.Text}', '{Model_Box.Text}', '{Transmission_Box.Text}', {ComboBox_Branch.SelectedValue.ToString()}, '{ComboBox_Type.SelectedValue.ToString()}')";


            int toss = DBConnectionInstance.Insert(insertQuery);



            this.Close();

            InventoryForm inventoryForm = new InventoryForm();
            inventoryForm.Show();
        }
    }
}

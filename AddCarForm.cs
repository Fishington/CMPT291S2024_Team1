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

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void VIN_Label_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
            var inventoryForm = new InventoryForm();
            inventoryForm.Show();
        }

        private void VIN_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            var insertQuery = $"INSERT INTO Cars (VIN, License_Plate, Make, Model, Transmission, Branch_ID, Type) VALUES" +
                $" ('{VIN_Box.Text}', '{Plate_Box.Text}', '{Make_Box.Text}', '{Model_Box.Text}', '{Transmission_Box.Text}', {Branch_ID_Box.Text}, '{Type_Box.Text}')";
            var rowsAffected = DBConnectionInstance.Insert(insertQuery);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Car added successfully!");
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Failed to add car.");
                DialogResult = DialogResult.None;
            }
        }
    }
}

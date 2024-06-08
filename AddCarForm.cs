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

namespace Team1CMPT291_Final
{
    public partial class AddCarForm : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

            public AddCarForm()
        {
            InitializeComponent();

            String connectionString = "Server=localhost;Database=CarRental;Trusted_Connection=yes;";

            SqlConnection myConnection = new SqlConnection(connectionString);

            try
            {
                myConnection.Open();
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void VIN_Label_TextChanged(object sender, EventArgs e)
        {

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
            try
            {
                myCommand.CommandText = "insert into car database (" + VIN_Box.Text + "," + Plate_Box.Text + ',' + Make_Box.Text + ',' 
                    + Model_Box.Text + ',' + Transmission_Box.Text + ',' + Branch_ID_Box.Text + ',' + Type_Box.Text + ')';
                MessageBox.Show(myCommand.CommandText);

                myCommand.ExecuteNonQuery();
            }
            catch(Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }


            this.Close();

            InventoryForm inventoryForm = new InventoryForm();
            inventoryForm.Show();
        }
    }
}

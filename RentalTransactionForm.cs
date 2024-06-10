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
    public partial class RentalTransactionForm : Form
    {
        public RentalTransactionForm()
        {
            InitializeComponent();
            DataTable branches = new DBConnection().Query("SELECT Branch_ID, Name FROM Branches");
            comboBox_Branch.DataSource = branches;
            comboBox_Branch.DisplayMember = "Name";
            comboBox_Branch.ValueMember = "Branch_ID";
        }



        private void dateTimePickerPickup_ValueChanged_1(object sender, EventArgs e)
        {
            // This disables previous/impossible dates from showing up in the picker.
            dateTimePickerDropoff.MinDate = dateTimePickerPickup.Value;

            // This adjusts the dropoff date if the pickup date is changed to a later date.
            if (dateTimePickerDropoff.Value < dateTimePickerPickup.Value) { dateTimePickerDropoff.Value = dateTimePickerPickup.Value; }
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Close();

            MainScreenForm mainScreenForm = new MainScreenForm();
            mainScreenForm.Show();
        }
    }
}

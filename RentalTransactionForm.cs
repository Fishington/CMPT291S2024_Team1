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
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();

            MainScreenForm mainScreenForm = new MainScreenForm();  
            mainScreenForm.Show();


        }

        private void dateTimePickerPickup_ValueChanged_1(object sender, EventArgs e)
        {
            // This disables previous/impossible dates from showing up in the picker.
            dateTimePickerDropoff.MinDate = dateTimePickerPickup.Value;

            // This adjusts the dropoff date if the pickup date is changed to a later date.
            if (dateTimePickerDropoff.Value < dateTimePickerPickup.Value) { dateTimePickerDropoff.Value = dateTimePickerPickup.Value; }
        }
    }
}

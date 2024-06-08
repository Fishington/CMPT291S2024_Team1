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
    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();
        }


        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();

            MainScreenForm mainScreenForm = new MainScreenForm();
            mainScreenForm.Show();
        }

        private void button_add_car_Click(object sender, EventArgs e)
        {
            this.Close();

            AddCarForm addCarForm = new AddCarForm();
            addCarForm.Show();

        }
    }
}

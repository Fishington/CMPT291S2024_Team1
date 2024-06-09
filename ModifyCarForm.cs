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


        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

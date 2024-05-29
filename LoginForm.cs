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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            Cursor = System.Windows.Forms.Cursors.Hand;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainScreenForm mainScreenForm = new MainScreenForm();
            mainScreenForm.Show();

            Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}

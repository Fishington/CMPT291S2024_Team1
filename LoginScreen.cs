﻿using System;
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
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();

            MainScreenForm mainScreenForm = new MainScreenForm();
            mainScreenForm.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainScreenForm mainScreenForm = new MainScreenForm();
            mainScreenForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

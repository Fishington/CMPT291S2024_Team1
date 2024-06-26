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
    public partial class RentalTransactionForm : Form
    {
        public void UpdateDataGrid()
        {
            String branchID = comboBox_Branch.SelectedValue?.ToString();
            string startDate = dateTimePickerPickup.Value.ToString("yyyyMMdd");
            string endDate = dateTimePickerDropoff.Value.ToString("yyyyMMdd");
            String query = "select * from Cars as C where C.Branch_ID = '" + branchID +"' AND C.VIN not in (select R.VIN from Reservations as R where R.Start_Date BETWEEN '" + startDate+"' AND '" + endDate + "' OR r.End_Date BETWEEN '" + startDate + "' AND '" + endDate + "')";
            dataGridView1.DataSource = new DBConnection().Query(query);
        }
        public RentalTransactionForm()
        {
            InitializeComponent();

            // Dynamic date picker settings.
            dateTimePickerPickup.MinDate  = DateTime.Today;
            dateTimePickerDropoff.MinDate = DateTime.Today;

            DataTable branches = new DBConnection().Query("SELECT Branch_ID, Name FROM Branches");
            comboBox_Branch.DataSource = branches;
            comboBox_Branch.DisplayMember = "Name";
            comboBox_Branch.ValueMember = "Branch_ID";
            comboBox_Dropoff.BindingContext = new BindingContext();
            comboBox_Dropoff.DataSource = branches;
            comboBox_Dropoff.DisplayMember = "Name";
            comboBox_Dropoff.ValueMember = "Branch_ID";
            DataTable employees = new DBConnection().Query("SELECT Employee_ID, CONCAT(Employee_ID, ': ', FirstName, ' ', LastName) as Name FROM Employees");
            comboBox_Employee.DataSource = employees;
            comboBox_Employee.DisplayMember = "Name";
            comboBox_Employee.ValueMember = "Employee_ID";
            DataTable customers = new DBConnection().Query("SELECT Customer_ID, CONCAT(Customer_ID, ': ', FirstName, ' ', LastName) as Name FROM Customers");
            comboBox_Customer.DataSource = customers;
            comboBox_Customer.DisplayMember = "Name";
            comboBox_Customer.ValueMember = "Customer_ID";
            UpdateDataGrid();
        }



        private void dateTimePickerPickup_ValueChanged_1(object sender, EventArgs e)
        {
            // This disables previous/impossible dates from showing up in the picker.
            dateTimePickerDropoff.MinDate = dateTimePickerPickup.Value;

            // This adjusts the dropoff date if the pickup date is changed to a later date.
            if (dateTimePickerDropoff.Value < dateTimePickerPickup.Value) { dateTimePickerDropoff.Value = dateTimePickerPickup.Value; }
            UpdateDataGrid();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Close();

            MainScreenForm mainScreenForm = new MainScreenForm();
            mainScreenForm.Show();
        }

        private void button_Check_Click(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }

        private void comboBox_Branch_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDataGrid();
            comboBox_Dropoff.SelectedValue = comboBox_Branch.SelectedValue;

        }

        private void dateTimePickerDropoff_ValueChanged(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }

        private void button_Book_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime startDate = dateTimePickerPickup.Value;
                DateTime endDate = dateTimePickerDropoff.Value;
                String Customer_ID = comboBox_Customer.SelectedValue.ToString();
                String Employee_ID = comboBox_Employee.SelectedValue.ToString();
                String Branch_Pickup_ID = comboBox_Branch.SelectedValue.ToString();
                String Branch_Dropoff_ID = comboBox_Dropoff.SelectedValue.ToString();
                String VIN = dataGridView1.SelectedRows[0].Cells[0].Value?.ToString();
                //String query = "INSERT INTO Reservations (Start_Date, End_Date, TotalPrice, Customer_ID, Employee_ID, Branch_Pickup_ID, Branch_Dropoff_ID, VIN) VALUES ('" + startDate + "', '" + endDate + "', '" + price + "', '" + Customer_ID + "', '" + Employee_ID + "', '" + Branch_Pickup_ID + "', '" + Branch_Dropoff_ID + "', '" + VIN + "')";
                //new DBConnection().Insert(query);
                PriceConfirmationForm priceConfirmationForm = new PriceConfirmationForm(startDate, endDate, Customer_ID, Employee_ID, Branch_Pickup_ID, Branch_Dropoff_ID, VIN);
                priceConfirmationForm.Show();
                this.Close();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Not all selections were made.");
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong.");
            }
        }
    }
}

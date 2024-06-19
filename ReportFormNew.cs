﻿using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Team1CMPT291_Final
{
    public partial class ReportFormNew : Form
    {

        private DBConnection DBConnectionInstance;

        public ReportFormNew()
        {
            InitializeComponent();
            DBConnectionInstance = new DBConnection();
        }

        private void ReportFormNew_Load(object sender, EventArgs e)
        {
            DataTable branches = new DBConnection().Query("SELECT Branch_ID, Name FROM Branches");
            comboBox_Busy_Branch.DataSource = branches;
            comboBox_Busy_Branch.DisplayMember = "Name";
            comboBox_Busy_Branch.ValueMember = "Branch_ID";

        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            Close();
            var mainScreenForm = new MainScreenForm();
            mainScreenForm.Show();
        }

        private void CarUsagesSubmit_Click(object sender, EventArgs e)
        {
            var query   = "SELECT C.Model, COUNT(R.Reservation_ID) as RentalCount FROM Cars as C, Reservations as R WHERE C.VIN = R.VIN GROUP BY C.Model ORDER BY RentalCount DESC";
            var results = DBConnectionInstance.Query(query);
            CarUsageResults.DataSource = results;
        }

        private void FrequentFlyersSubmit_Click(object sender, EventArgs e)
        {
            var query   = "SELECT * FROM CarType WHERE Type = 'SMALL'";
            var results = DBConnectionInstance.Query(query);
            FrequentFlyerResults.DataSource = results;
        }

        private void MonthlyRevenueSubmit_Click(object sender, EventArgs e)
        {
            var query   = "SELECT * FROM CarType WHERE Type = 'SMALL'";
            var results = DBConnectionInstance.Query(query);
            MonthlyRevenueResults.DataSource = results;
        }

        private void BusyBranchTimesSubmit_Click(object sender, EventArgs e)
        {

            var query2   = "SELECT FORMAT(Start_Date, 'yyyy.MMMM') as Month, Count(*) as Rentals FROM Reservations WHERE Branch_Pickup_ID = " + comboBox_Busy_Branch.SelectedValue + " GROUP BY FORMAT(Start_Date, 'yyyy.MMMM') ORDER BY COUNT(*) DESC";
            var query = @"
                SELECT MonthCounts.Month, B.Name, MonthCounts.Rentals
                FROM (SELECT FORMAT(Start_Date, 'yyyy-MM') as Month, Branch_Pickup_ID AS Branch ,Count(*) as Rentals
                    FROM Reservations
                    GROUP BY FORMAT(Start_Date, 'yyyy-MM'), Branch_Pickup_ID
                    ) As MonthCounts , Branches as B
                WHERE MonthCounts.Rentals = (
                    SELECT MAX(MC2.Rentals)
                    FROM (
                        SELECT FORMAT(Start_Date, 'yyyy-MM') as Month, Branch_Pickup_ID AS Branch ,Count(*) as Rentals
                        FROM Reservations
                        GROUP BY FORMAT(Start_Date, 'yyyy-MM'), Branch_Pickup_ID
                        ) As MC2
                    WHERE MC2.Month = MonthCounts.Month
                ) AND MonthCounts.Branch = B.Branch_ID
                ORDER BY MonthCounts.Month";
            var results = DBConnectionInstance.Query(query);
            BusyBranchTimesResults.DataSource = results;
        }

        private void UnderPerformingEmpsSubmit_Click(object sender, EventArgs e)
        {
            const string query = @"
                SELECT 
                    e.Employee_ID,
                    CONCAT(e.FirstName, ' ', e.LastName) AS FullName,
                    SUM(r.TotalPrice)                    AS TotalRevenue,
                    COUNT(DISTINCT r.Reservation_ID)     AS TotalBookings,
                    b.Name                               AS HomeBranch
                FROM Employees e
                    LEFT JOIN Reservations AS r ON e.Employee_ID = r.Employee_ID
                    LEFT JOIN Branches     AS b ON b.Branch_ID   = e.Branch_ID
                GROUP BY 
                    e.Employee_ID,
                    e.FirstName,
                    e.LastName,
                    b.Name
                HAVING COUNT(r.Reservation_ID) > 0
                ORDER BY TotalRevenue ASC, TotalBookings ASC;
            ";

            var results = DBConnectionInstance.Query(query);

            // Data source
            UnderPerformingEmpsResults.DataSource = results;

            // Header widths
            UnderPerformingEmpsResults.Columns[0].Width = 75;
            UnderPerformingEmpsResults.Columns[1].Width = 150;
            UnderPerformingEmpsResults.Columns[2].Width = 150;
            UnderPerformingEmpsResults.Columns[3].Width = 150;
            UnderPerformingEmpsResults.Columns[4].Width = 150;

            // Header names
            UnderPerformingEmpsResults.Columns[0].HeaderText = "Employee ID";
            UnderPerformingEmpsResults.Columns[1].HeaderText = "Employee";
            UnderPerformingEmpsResults.Columns[2].HeaderText = "Revenue Made";
            UnderPerformingEmpsResults.Columns[3].HeaderText = "Number of Bookings";
            UnderPerformingEmpsResults.Columns[4].HeaderText = "Home Branch";

            // Bolded headers
            var headerFont = new Font(UnderPerformingEmpsResults.Font, FontStyle.Bold);
            UnderPerformingEmpsResults.Columns[0].HeaderCell.Style.Font = headerFont;
            UnderPerformingEmpsResults.Columns[1].HeaderCell.Style.Font = headerFont;
            UnderPerformingEmpsResults.Columns[2].HeaderCell.Style.Font = headerFont;
            UnderPerformingEmpsResults.Columns[3].HeaderCell.Style.Font = headerFont;
            UnderPerformingEmpsResults.Columns[4].HeaderCell.Style.Font = headerFont;

            // Revenue column formatting type
            UnderPerformingEmpsResults.Columns[2].DefaultCellStyle.Format = "c";
        }


    }
}

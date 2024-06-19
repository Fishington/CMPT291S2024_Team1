﻿using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            branches.Rows.Add(new Object[] { -1, "Best Branch" });
            comboBox_Busy_Branch.DataSource = branches;
            comboBox_Busy_Branch.DisplayMember = "Name";
            comboBox_Busy_Branch.ValueMember = "Branch_ID";

            comboBox_CarUsage.Items.Add("Make");
            comboBox_CarUsage.Items.Add("Model");
            comboBox_CarUsage.Items.Add("Transmission");
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            Close();
            var mainScreenForm = new MainScreenForm();
            mainScreenForm.Show();
        }

        private void CarUsagesSubmit_Click(object sender, EventArgs e)
        {
            if (comboBox_CarUsage.SelectedIndex != -1)
            {
                string selectedColumn = comboBox_CarUsage.SelectedItem.ToString();

                string query = $@"
                    SELECT C.{selectedColumn}, COUNT(R.Reservation_ID) as RentalCount 
                    FROM Cars as C
                    JOIN Reservations as R ON C.VIN = R.VIN 
                    WHERE C.{selectedColumn} IS NOT NULL
                    GROUP BY C.{selectedColumn} 
                    ORDER BY RentalCount DESC";

                var results = DBConnectionInstance.Query(query);
                CarUsageResults.DataSource = results;
            }
            
            
        }

        private void FrequentFlyersSubmit_Click(object sender, EventArgs e)
        {
            var query   = "SELECT * FROM CarType WHERE Type = 'SMALL'";
            var results = DBConnectionInstance.Query(query);
            FrequentFlyerResults.DataSource = results;
        }

        private void MonthlyRevenueSubmit_Click(object sender, EventArgs e)
        {
            //Aidan TODO
            var query   = @" 
                   SELECT 
                        r.Start_Date AS Rental_Date,
                        b.Name,
                        SUM(r.TotalPrice) AS Daily_Revenue
                    FROM Reservations r, Branches b 
                    where r.Branch_Pickup_ID = b.Branch_ID
                    GROUP BY r.Start_Date, b.Name
                    HAVING SUM(r.TotalPrice) = (
                        SELECT MAX(Daily_Revenue)
                        FROM (
                            SELECT 
                              Start_Date,
                              Branch_Pickup_ID,
                              SUM(TotalPrice) AS Daily_Revenue
                        FROM Reservations
                        GROUP BY Start_Date, Branch_Pickup_ID
                      ) AS subquery
                      WHERE subquery.Start_Date = r.Start_Date
                    )
                    ORDER BY Rental_Date;";

            var results = DBConnectionInstance.Query(query);
            MonthlyRevenueResults.DataSource = results;
        }

        private void BusyBranchTimesSubmit_Click(object sender, EventArgs e)
        {
            string query;
            int selectedbranch = (int)comboBox_Busy_Branch.SelectedValue;
            if (selectedbranch == -1)
            {query = @"
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
            } else {query = @"
                    SELECT FORMAT(Start_Date, 'yyyy-MM') as Month, Count(*) as Rentals 
                    FROM Reservations 
                    WHERE Branch_Pickup_ID = " + selectedbranch + @" 
                    GROUP BY FORMAT(Start_Date, 'yyyy-MM') 
                    ORDER BY COUNT(*) DESC"; }
            var results = DBConnectionInstance.Query(query);
            BusyBranchTimesResults.DataSource = results;
        }

        private void UnderPerformingEmpsSubmit_Click(object sender, EventArgs e)
        {
            const string query = @"
            SELECT 

                e.Employee_ID,
                CONCAT(e.FirstName, ' ', e.LastName) AS FullName,
                totals.revenue                       AS TotalRevenue,
                totals.bookings                      AS TotalBookings,
                totals.revenue / totals.bookings     AS AvgRevenuePerBooking,
                b.Name                               AS HomeBranch

            FROM Employees AS e, Reservations AS r, Branches AS b,
                (
                    SELECT
                        r.Employee_ID,
                        SUM(r.TotalPrice)                AS revenue,
                        COUNT(DISTINCT r.Reservation_ID) AS bookings
                    FROM Reservations AS r
                    GROUP BY r.Employee_ID
                ) AS totals

            WHERE   e.Employee_ID = r.Employee_ID
                AND b.Branch_ID   = e.Branch_ID
                AND e.Employee_ID = totals.Employee_ID

            GROUP BY 
                e.Employee_ID,
                e.FirstName,
                e.LastName,
                b.Name,
                totals.revenue,
                totals.bookings

            HAVING COUNT(r.Reservation_ID) > 0
            ORDER BY TotalRevenue ASC, TotalBookings ASC;
            ";

            var results = DBConnectionInstance.Query(query);

            // Data source
            UnderPerformingEmpsResults.DataSource = results;

            // Header widths
            UnderPerformingEmpsResults.Columns[0].Width = 75;
            UnderPerformingEmpsResults.Columns[1].Width = 150;
            UnderPerformingEmpsResults.Columns[2].Width = 100;
            UnderPerformingEmpsResults.Columns[3].Width = 75;
            UnderPerformingEmpsResults.Columns[4].Width = 150;
            UnderPerformingEmpsResults.Columns[5].Width = 150;

            // Header names
            UnderPerformingEmpsResults.Columns[0].HeaderText = "Employee ID";
            UnderPerformingEmpsResults.Columns[1].HeaderText = "Employee";
            UnderPerformingEmpsResults.Columns[2].HeaderText = "Revenue Made";
            UnderPerformingEmpsResults.Columns[3].HeaderText = "# of Bookings";
            UnderPerformingEmpsResults.Columns[4].HeaderText = "Avg. Revenue per Booking";
            UnderPerformingEmpsResults.Columns[5].HeaderText = "Home Branch";

            // Bolded headers
            var headerFont = new Font(UnderPerformingEmpsResults.Font, FontStyle.Bold);
            UnderPerformingEmpsResults.Columns[0].HeaderCell.Style.Font = headerFont;
            UnderPerformingEmpsResults.Columns[1].HeaderCell.Style.Font = headerFont;
            UnderPerformingEmpsResults.Columns[2].HeaderCell.Style.Font = headerFont;
            UnderPerformingEmpsResults.Columns[3].HeaderCell.Style.Font = headerFont;
            UnderPerformingEmpsResults.Columns[4].HeaderCell.Style.Font = headerFont;
            UnderPerformingEmpsResults.Columns[5].HeaderCell.Style.Font = headerFont;

            // Revenue columns formatting type
            UnderPerformingEmpsResults.Columns[2].DefaultCellStyle.Format = "c";
            UnderPerformingEmpsResults.Columns[4].DefaultCellStyle.Format = "c";
        }


    }
}

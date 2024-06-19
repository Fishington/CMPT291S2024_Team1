using System;
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

                // Header names
                CarUsageResults.Columns[1].HeaderText = "Rental Count";

                // Bolded headers
                var headerFont = new Font(CarUsageResults.Font, FontStyle.Bold);
                CarUsageResults.Columns[0].HeaderCell.Style.Font = headerFont;
                CarUsageResults.Columns[1].HeaderCell.Style.Font = headerFont;

            }


        }

        private void FrequentFlyersSubmit_Click(object sender, EventArgs e)
        {
            var query = "select CONCAT(C2.FirstName, ' ', C2.LastName) as Name, G.number_of_days, G.Total \r\nfrom (select C.Customer_ID, sum(R.TotalPrice) as Total, SUM(DATEDIFF(day, R.Start_Date, R.End_Date)) as number_of_days\r\nfrom Customers C, Reservations R\r\nwhere C.Customer_ID = R.Customer_ID\r\ngroup by C.Customer_ID) G, Customers C2\r\nwhere C2.Customer_ID = G.Customer_ID\r\norder by number_of_days desc;";
            var results = DBConnectionInstance.Query(query);
            FrequentFlyerResults.DataSource = results;

            // Header widths
            FrequentFlyerResults.Columns[0].Width = 150;

            // Header names
            FrequentFlyerResults.Columns[1].HeaderText = "Total Days Booked";

            // Bolded headers
            var headerFont = new Font(FrequentFlyerResults.Font, FontStyle.Bold);
            FrequentFlyerResults.Columns[0].HeaderCell.Style.Font = headerFont;
            FrequentFlyerResults.Columns[1].HeaderCell.Style.Font = headerFont;
            FrequentFlyerResults.Columns[2].HeaderCell.Style.Font = headerFont;

            // Revenue columns formatting type
            FrequentFlyerResults.Columns[2].DefaultCellStyle.Format = "c";
        }

        private void MonthlyRevenueSubmit_Click(object sender, EventArgs e)
        {
            string query = "";

            if (!checkBox1.Checked)
            {
                   query   = @" 
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

                // Header names
                MonthlyRevenueResults.Columns[0].HeaderText = "Rental Date";
                MonthlyRevenueResults.Columns[2].HeaderText = "Daily Revenue";

                // Bolded headers
                var headerFont = new Font(MonthlyRevenueResults.Font, FontStyle.Bold);
                MonthlyRevenueResults.Columns[0].HeaderCell.Style.Font = headerFont;
                MonthlyRevenueResults.Columns[1].HeaderCell.Style.Font = headerFont;
                MonthlyRevenueResults.Columns[2].HeaderCell.Style.Font = headerFont;

                // Revenue columns formatting type
                MonthlyRevenueResults.Columns[2].DefaultCellStyle.Format = "c";


            }
            else
            {
                query = @"
                    DECLARE @MinDate AS Date;
                    DECLARE @MaxDate AS Date;

                    SET @MinDate = (
                    SELECT MIN(R.Start_Date)
                    FROM Reservations as R);

                    SET @MaxDate = (
                    SELECT MAX(R.Start_Date)
                    FROM Reservations as R);

                    WITH Dates(day) AS 
                    (
                    SELECT @MinDate as day
                    UNION ALL
                    SELECT CAST(DATEADD(day, 1 , day) as Date) as day
                    FROM Dates
                    WHERE CAST(DATEADD(day, 1, day) as Date) < @MaxDate
                    )
                     Select TOP 100 dates.day, ISNULL(SUM(R.TotalPrice),0) as Revenue
                    FROM dates
                    LEFT JOIN Reservations as R ON dates.day = R.Start_Date
                    GROUP By dates.day
                    HAVING ISNULL(SUM(R.TotalPrice),0) = (
                        SELECT ISNULL(MAX(SumPrices.TotalPrice),0)
                        FROM (
                            SELECT R2.Start_Date, SUM(R2.TotalPrice) as TotalPrice
                            FROM Reservations as R2
                            GROUP BY R2.Start_Date
                        ) AS SumPrices
                        WHERE SumPrices.Start_Date = dates.day
                        )
                    ORDER BY dates.day";

                var results = DBConnectionInstance.Query(query);
                MonthlyRevenueResults.DataSource = results;

                // Header names
                MonthlyRevenueResults.Columns[0].HeaderText = "Rental Date";
                MonthlyRevenueResults.Columns[1].HeaderText = "Total Revenue";

                // Bolded headers
                var headerFont = new Font(MonthlyRevenueResults.Font, FontStyle.Bold);
                MonthlyRevenueResults.Columns[0].HeaderCell.Style.Font = headerFont;
                MonthlyRevenueResults.Columns[1].HeaderCell.Style.Font = headerFont;
 

                // Revenue columns formatting type
                MonthlyRevenueResults.Columns[1].DefaultCellStyle.Format = "c";


            }

            
        }

        private void BusyBranchTimesSubmit_Click(object sender, EventArgs e)
        {
            string query;
            int selectedbranch = (int)comboBox_Busy_Branch.SelectedValue;
            if (selectedbranch == -1)
            {query = @"
            SELECT MC3.Month, B.Name ,MC3.Rentals, COUNT(C.VIN) as Available_Cars
			FROM 
                (SELECT MonthCounts.Month, MonthCounts.Branch, MonthCounts.Rentals
                FROM (SELECT FORMAT(Start_Date, 'yyyy-MM') as Month, Branch_Pickup_ID AS Branch ,Count(*) as Rentals
                    FROM Reservations
                    GROUP BY FORMAT(Start_Date, 'yyyy-MM'), Branch_Pickup_ID
                    ) As MonthCounts 
                WHERE MonthCounts.Rentals = (
                    SELECT MAX(MC2.Rentals)
                    FROM (
                        SELECT FORMAT(Start_Date, 'yyyy-MM') as Month, Branch_Pickup_ID AS Branch ,Count(*) as Rentals
                        FROM Reservations
                        GROUP BY FORMAT(Start_Date, 'yyyy-MM'), Branch_Pickup_ID
                        ) As MC2
                    WHERE MC2.Month = MonthCounts.Month
                )
				) as MC3, Branches as B, Cars as C
			WHERE B.Branch_ID= MC3.Branch
			AND C.Branch_ID = MC3.Branch
			GROUP BY MC3.Month, B.Name ,MC3.Rentals
			ORDER BY MC3.Month";
            } else {query = @"
                    SELECT FORMAT(Start_Date, 'yyyy-MM') as Month, Count(*) as Rentals 
                    FROM Reservations 
                    WHERE Branch_Pickup_ID = " + selectedbranch + @" 
                    GROUP BY FORMAT(Start_Date, 'yyyy-MM') 
                    ORDER BY COUNT(*) DESC"; }
            var results = DBConnectionInstance.Query(query);
            BusyBranchTimesResults.DataSource = results;

            // Bolded headers
            var headerFont = new Font(BusyBranchTimesResults.Font, FontStyle.Bold);
            BusyBranchTimesResults.Columns[0].HeaderCell.Style.Font = headerFont;
            BusyBranchTimesResults.Columns[1].HeaderCell.Style.Font = headerFont;

            if (selectedbranch == -1) { BusyBranchTimesResults.Columns[2].HeaderCell.Style.Font = headerFont; }
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label7.Text = "Total Company Reveune in daily order.";
                
            }
            else
            {
                label7.Text = "#1 revenue branches in daily order. (Nothing is shown if there are no rentals)";

            }
        }
    }
}

using System;
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
            var query   = "SELECT * FROM CarType WHERE Type = 'SMALL'";
            var results = DBConnectionInstance.Query(query);
            BusyBranchTimesResults.DataSource = results;
        }

        private void UnderPerformingEmpsSubmit_Click(object sender, EventArgs e)
        {
            const string query = @"
                SELECT 
                    e.Employee_ID,
                    CONCAT(e.FirstName, ' ', e.LastName) AS FullName,
                    COUNT(DISTINCT r.Reservation_ID)     AS TotalBookings,
                    SUM(r.TotalPrice)                    AS TotalRevenue,
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

            // Report data source
            UnderPerformingEmpsResults.DataSource = results;

            // Report column headers widths
            UnderPerformingEmpsResults.Columns[0].Width = 75;
            UnderPerformingEmpsResults.Columns[1].Width = 150;
            UnderPerformingEmpsResults.Columns[2].Width = 150;
            UnderPerformingEmpsResults.Columns[3].Width = 150;
            UnderPerformingEmpsResults.Columns[4].Width = 150;

            // Report column headers names
            UnderPerformingEmpsResults.Columns[0].HeaderText = "Employee ID";
            UnderPerformingEmpsResults.Columns[1].HeaderText = "Employee";
            UnderPerformingEmpsResults.Columns[2].HeaderText = "Number of Bookings";
            UnderPerformingEmpsResults.Columns[3].HeaderText = "Revenue Made";
            UnderPerformingEmpsResults.Columns[4].HeaderText = "Home Branch";

            // Revenue made column money formatting style
            UnderPerformingEmpsResults.Columns[3].DefaultCellStyle.Format = "c";
        }
    }
}

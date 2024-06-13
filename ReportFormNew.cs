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
            var query   = "SELECT C.Model, COUNT(R.Reservation_ID) as RentalCount FROM Cars as C, Reservations as R WHERE C.VIN = R.VIN GROUP BY C.Model ORDER BY UsageCount DESC";
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
            var query   = "SELECT * FROM CarType WHERE Type = 'SMALL'";
            var results = DBConnectionInstance.Query(query);
            UnderPerformingEmpsResults.DataSource = results;
        }
    }
}

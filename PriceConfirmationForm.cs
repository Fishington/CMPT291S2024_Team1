using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Team1CMPT291_Final
{
    public partial class PriceConfirmationForm : Form
    {

        public DateTime startDate {  get; private set; }
        public DateTime endDate { get; private set; }
        public string Customer_ID { get; private set; }
        public string Employee_ID { get; private set; }
        public string Branch_Pickup_ID { get; private set; }
        public string Branch_Dropoff_ID { get; private set; }
        public string VIN { get; private set; }

        public string price {  get; private set; }

        public PriceConfirmationForm(DateTime startDate, DateTime endDate, string Customer_ID, string Employee_ID, string Branch_Pickup_ID, string Branch_Dropoff_ID, string VIN)
        {
            InitializeComponent();

            //Do Logic For Price Here

            price = "0";
            //Assign pass var to public vars
            this.startDate = startDate;
            this.endDate = endDate;
            this.Customer_ID = Customer_ID;
            this.Employee_ID = Employee_ID;
            this.Branch_Pickup_ID= Branch_Pickup_ID;
            this.Branch_Dropoff_ID = Branch_Dropoff_ID;
            this.VIN = VIN;

            // Data to Label
            String VINQuery = $"select DailyPrice, WeeklyPrice, MonthlyPrice, Cars.Type from CarType, Cars where CarType.Type = Cars.Type and VIN = '" + VIN + "';";
            
            DataTable PriceTable = new DBConnection().Query(VINQuery);
            DataRow PriceRow = PriceTable.Rows[0];
            var DailyPrice = Convert.ToDecimal(PriceRow["DailyPrice"]);
            var WeeklyPrice = Convert.ToDecimal(PriceRow["WeeklyPrice"]);
            var MonthlyPrice = Convert.ToDecimal(PriceRow["MonthlyPrice"]);
            var Type = PriceRow["Type"];

            lap.Text = $"" + Type;

            Label_DP.Text =   $"$" + String.Format("{0:0.00}", DailyPrice);
            Label_WP.Text =   $"$" + String.Format("{0:0.00}", WeeklyPrice);
            Label_MP.Text =   $"$" + String.Format("{0:0.00}", MonthlyPrice);

            // Date Math
            int TotalDays = Convert.ToInt16(GetNumberOfDaysBetween(startDate, endDate));
            Label_TotalDays.Text = TotalDays.ToString();

            //Price Math

            if (TotalDays <= 0 || DailyPrice <= 0 || WeeklyPrice <= 0 || MonthlyPrice <= 0)
            {
                throw new ArgumentOutOfRangeException("Days and prices must be positive values.");
            }
            // Calculate the number of weeks and months

            int months = TotalDays / 30;
            int remainingDays = TotalDays % 30;

            decimal rate = months * MonthlyPrice;

            // Calculate full weeks from remaining days
            int fullWeeks = remainingDays / 7;
            remainingDays %= 7;

            // Add cost of full weeks
            rate += fullWeeks * WeeklyPrice;

            // Add cost of remaining days
            rate += remainingDays * DailyPrice;

            price = rate.ToString();

            Label_Total.Text = $"$" + String.Format("{0:0.00}", rate);



        }
        //====================================== MITCHEL CAN YOU CHECK THIS PLZ ===============================================
        public double GetNumberOfDaysBetween(DateTime startDate, DateTime endDate)
        {
            double days = (endDate - startDate).Days;
            return Math.Floor(days) + 1;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            RentalTransactionForm rentalTransactionForm = new RentalTransactionForm();
            rentalTransactionForm.Show();

            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            String query = "INSERT INTO Reservations (Start_Date, End_Date, TotalPrice, Customer_ID, Employee_ID, Branch_Pickup_ID, Branch_Dropoff_ID, VIN) VALUES ('" + startDate + "', '" + endDate + "', '" + price + "', '" + Customer_ID + "', '" + Employee_ID + "', '" + Branch_Pickup_ID + "', '" + Branch_Dropoff_ID + "', '" + VIN + "')";
            new DBConnection().Insert(query);
            
            RentalTransactionForm rentalTransactionForm = new RentalTransactionForm();
            rentalTransactionForm.Show();
            
            
            this.Close();

            


        }
    }
}

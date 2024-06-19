using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Team1CMPT291_Final
{
    internal static class Program
    {
        const string serverConnectionString = "Server=localhost;Integrated Security=true;";
        const string databaseConnectionString = "Server=localhost;Database=CarRental;Integrated Security=true;";
        const string databaseName = "CarRental";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                EnsureDatabaseExists();
                EnsureTablesExist();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new LoginScreen());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static void EnsureDatabaseExists()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(serverConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(
                        $"IF DB_ID('{databaseName}') IS NULL CREATE DATABASE [{databaseName}]", connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to ensure database exists: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        static void EnsureTablesExist()
        {
            string createTablesSql = @"
                USE CarRental;

                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Branches')
                BEGIN
                    CREATE TABLE Branches (
                        Branch_ID INT PRIMARY KEY IDENTITY(1, 1),
                        Name NVARCHAR(60) NOT NULL,
                        Street NVARCHAR(40) NOT NULL,
                        City NVARCHAR(50) NOT NULL,
                        Postal_Code NVARCHAR(10) NOT NULL,
                        Province NVARCHAR(2) NOT NULL,
                        Country NVARCHAR(50) NOT NULL
                    );
                END;

                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Customers')
                BEGIN
                    CREATE TABLE Customers (
                        Customer_ID INT PRIMARY KEY IDENTITY(1, 1),
                        FirstName NVARCHAR(40) NOT NULL,
                        LastName NVARCHAR(40) NOT NULL,
                        Street NVARCHAR(40) NOT NULL,
                        City NVARCHAR(50) NOT NULL,
                        Postal_Code NVARCHAR(10) NOT NULL,
                        Province NVARCHAR(2) NOT NULL,
                        Country NVARCHAR(50) NOT NULL,
                        PhoneNumber NVARCHAR(20) NOT NULL
                    );
                END;

                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Employees')
                BEGIN
                    CREATE TABLE Employees (
                        Employee_ID INT PRIMARY KEY IDENTITY(1, 1),
                        FirstName NVARCHAR(40) NOT NULL,
                        LastName NVARCHAR(40) NOT NULL,
                        Street NVARCHAR(40) NOT NULL,
                        City NVARCHAR(50) NOT NULL,
                        Postal_Code NVARCHAR(10) NOT NULL,
                        Province NVARCHAR(2) NOT NULL,
                        Country NVARCHAR(50) NOT NULL,
                        PhoneNumber NVARCHAR(20) NOT NULL,
                        Branch_ID INT NOT NULL,
                        FOREIGN KEY (Branch_ID) REFERENCES Branches(Branch_ID)
                    );
                END;

                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'CarType')
                BEGIN
                    CREATE TABLE CarType (
                        Type NVARCHAR(20) PRIMARY KEY,
                        DailyPrice SMALLMONEY NOT NULL,
                        WeeklyPrice SMALLMONEY NOT NULL,
                        MonthlyPrice SMALLMONEY NOT NULL
                    );
                END;

                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Cars')
                BEGIN
                    CREATE TABLE Cars (
                        VIN NVARCHAR(17) PRIMARY KEY,
                        License_Plate NVARCHAR(20) NOT NULL,
                        Make NVARCHAR(50) NOT NULL,
                        Model NVARCHAR(50) NOT NULL,
                        Transmission NVARCHAR(20) NOT NULL,
                        Branch_ID INT,
                        Type NVARCHAR(20) NOT NULL,
                        FOREIGN KEY (Branch_ID) REFERENCES Branches(Branch_ID),
                        FOREIGN KEY (Type) REFERENCES CarType(Type)
                    );
                END;

                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Reservations')
                BEGIN
                    CREATE TABLE Reservations (
                        Reservation_ID INT PRIMARY KEY IDENTITY(1, 1),
                        Start_Date DATE NOT NULL,
                        End_Date DATE NOT NULL,
                        TotalPrice SMALLMONEY,
                        Customer_ID INT NOT NULL,
                        Employee_ID INT NOT NULL,
                        Branch_Pickup_ID INT NOT NULL,
                        Branch_Dropoff_ID INT NOT NULL,
                        VIN NVARCHAR(17) NOT NULL,
                        FOREIGN KEY (Customer_ID) REFERENCES Customers(Customer_ID),
                        FOREIGN KEY (Employee_ID) REFERENCES Employees(Employee_ID),
                        FOREIGN KEY (Branch_Pickup_ID) REFERENCES Branches(Branch_ID),
                        FOREIGN KEY (Branch_Dropoff_ID) REFERENCES Branches(Branch_ID),
                        FOREIGN KEY (VIN) REFERENCES Cars(VIN)
                    );
                END;";

            try
            {
                using (SqlConnection connection = new SqlConnection(databaseConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(createTablesSql, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to ensure tables exist: {ex.Message}", "Table Creation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}

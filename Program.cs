using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            EnsureDatabaseExists();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginScreen());
        }

        static void EnsureDatabaseExists()
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

        static void EnsureDatabaseExists()
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
    }
}

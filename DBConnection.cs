using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Team1CMPT291_Final
{
    public class DBConnection
    {
        internal SqlConnection connection;
        internal SqlCommand command;
        internal SqlDataReader reader;
        private const string connectionString = "Server=localhost;Database=CarRental;Trusted_Connection=yes;";

        public DBConnection()
        {
            connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                MessageBox.Show("Connected to the CarRental database!");
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"SQL Error: {sqlEx.Message}", "Error");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"General Error: {ex.Message}", "Error");
                Close();
            }
        }

        internal void Close()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
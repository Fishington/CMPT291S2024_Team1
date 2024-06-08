using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Team1CMPT291_Final
{
    public class DBConnection
    {
        private const string connectionString = "Server=localhost;Database=CarRental;Trusted_Connection=yes;";

        private SqlConnection OpenConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                MessageBox.Show("Connected to CarRental DB.");
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"SQL Error: {sqlEx.Message}", "Error");
                connection = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"General Error: {ex.Message}", "Error");
                connection = null;
            }

            return connection;
        }

        private void CloseConnection(SqlConnection connection)
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public DataTable Query(string query)
        {
            DataTable results = new DataTable();

            using (SqlConnection connection = OpenConnection())
            {
                if (connection != null)
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        try
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                results.Load(reader);
                            }
                        }
                        catch (SqlException sqlEx)
                        {
                            MessageBox.Show($"SQL Error: {sqlEx.Message}", "Error");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"General Error: {ex.Message}", "Error");
                        }
                    }
                    CloseConnection(connection);
                }
            }
            return results;
        }
        public int Insert(string query)
        {
            using (SqlConnection connection = OpenConnection())
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        return command.ExecuteNonQuery();
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show($"SQL Error: {sqlEx.Message}", "Error");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"General Error: {ex.Message}", "Error");
                }
            }
            return 0;
        }

        // Use deleteQuery string : $"DELETE FROM Cars WHERE VIN = '{selectedVIN}';";
        public int Delete(string query) // Takes DELETE query String as Input
        {
            int rowsAffected = 0;

            using (SqlConnection connection = OpenConnection())
            {
                if (connection != null)
                {
                    try
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            rowsAffected = command.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException sqlEx)
                    {
                        MessageBox.Show($"SQL Error: {sqlEx.Message}", "Error");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"General Error: {ex.Message}", "Error");
                    }
                    CloseConnection(connection);
                }
            }

            return rowsAffected;
        }


    }
}

using System;
using System.Data;
using System.Data.SqlClient;

namespace Team1CMPT291_Final
{
    public class DBConnection
    {
        private const string connectionString = "Server=localhost;Database=CarRental;Trusted_Connection=yes;";

        private static SqlConnection OpenConnection()
        {
            var connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                Console.WriteLine("Connected to CarRental DB.");
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine($"SQL Error: {sqlEx.Message}");
                connection = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General Error: {ex.Message}");
                connection = null;
            }

            return connection;
        }

        private static void CloseConnection(SqlConnection connection)
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public static DataTable Query(string query)
        {
            var results = new DataTable();

            using (var connection = OpenConnection())
            {
                if (connection != null)
                {
                    using (var command = new SqlCommand(query, connection))
                    {
                        try
                        {
                            using (var reader = command.ExecuteReader())
                            {
                                results.Load(reader);
                            }
                        }
                        catch (SqlException sqlEx)
                        {
                            Console.WriteLine($"SQL Error: {sqlEx.Message}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"General Error: {ex.Message}");
                        }
                    }
                    CloseConnection(connection);
                }
            }
            return results;
        }

        public static int Insert(string query)
        {
            using (var connection = OpenConnection())
            {
                try
                {
                    using (var command = new SqlCommand(query, connection))
                    {
                        return command.ExecuteNonQuery();
                    }
                }
                catch (SqlException sqlEx)
                {
                    Console.WriteLine($"SQL Error: {sqlEx.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"General Error: {ex.Message}");
                }
            }
            return 0;
        }

        public static int Delete(string query)
        {
            var rowsAffected = 0;

            using (SqlConnection connection = OpenConnection())
            {
                if (connection != null)
                {
                    try
                    {
                        using (var command = new SqlCommand(query, connection))
                        {
                            rowsAffected = command.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException sqlEx)
                    {
                        Console.WriteLine($"SQL Error: {sqlEx.Message}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"General Error: {ex.Message}");
                    }
                    CloseConnection(connection);
                }
            }

            return rowsAffected;
        }
    }
}

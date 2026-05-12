using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;    
using System.Data;




namespace Proiect_Final.Data
{

    internal class DbHelper
    {
        private readonly string connectionString = @"Server=localhost;Database=SalaFIT;Trusted_Connection=True;TrustServerCertificate=True";

        public int Execute(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetData(string query)
        {
            DataTable table = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(table);
            }
            return table;
        }
    }
}

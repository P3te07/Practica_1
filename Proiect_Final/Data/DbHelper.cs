using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Microsoft.Data.SqlClient;




namespace Proiect_Final.Data
{

    internal class DbHelper
    {
        private readonly string connectionString = @"Server=localhost;Database=SalaFIT;Trusted_Connection=True;TrustServerCertificate=True";

        // metoda pt INSERT, UPDAETE, DELETE etc.
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

        //metoda pt SELECT 
        public DataTable GetData(string query, SqlParameter[] parameters = null)
        {
            DataTable table = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                if (parameters != null)
                {
                    adapter.SelectCommand.Parameters.AddRange(parameters);
                }
                adapter.Fill(table);
            }
            return table;
        }

        //metoda pt single value SELECT
        public object GetScalar(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    connection.Open();
                    return cmd.ExecuteScalar();
                }

            }
        }
    }
}

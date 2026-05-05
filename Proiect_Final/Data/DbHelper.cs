using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;    
using System.Data;
using System.Configuration;
using Microsoft.SqlServer;



namespace Proiect_Final.Data
{

    internal class DbHelper
    {
        private readonly string connectionString = "Server=localhost;Database=SalaFIT;User=ag_app_user;Password=HelloWorld!;Trusted_Connection=true";

        public int Execute(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Connection opened successfully.");

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Nu sa conectat");                    
                    throw;
                } 
            }
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
    } 
}

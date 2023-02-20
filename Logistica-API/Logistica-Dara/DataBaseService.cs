﻿using Dapper;
using System.Data.SqlClient;

namespace Logistica_Data
{
    public static class DataBaseService
    {
        private const string ConnectionString = "Server=ADRIAN-DUQUE; Integrated Security=true;";
        private const string DataBaseName = "SI-LOGISTICA";
        public static string GetResponsable()
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString: ConnectionString))
                {
                    var query = "SELECT * FROM Responsable";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    connection.ChangeDatabase(DataBaseName);
                    var r = connection.Query(query, commandType: System.Data.CommandType.Text);
                    var y = r?.ToList();
                }
            }
            catch (Exception)
            {
                return "";
            }

            return "";
        }
    }
}
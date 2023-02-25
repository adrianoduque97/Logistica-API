using Dapper;
using System.Data.SqlClient;

namespace Logistica_Data
{
    public static class DataBaseService
    {
        private static readonly string ConnectionString = Environment.GetEnvironmentVariable("databaseConnection") ?? "";
        private const string DataBaseName = "SI-LOGISTICA";
        public static string GetResponsable()
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString: ConnectionString))
                {
                    var query = @"SELECT * FROM Viaje v
                                  JOIN Vehiculos h ON (v.VehiculoId = h.VehiculoId)";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    connection.ChangeDatabase(DataBaseName);
                    var r = connection.Query(query, commandType: System.Data.CommandType.Text);
                    var y = r?.ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message, "Error");
                return "";
            }

            return "";
        }
    }
}
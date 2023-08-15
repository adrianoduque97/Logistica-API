using Dapper;
using Logistica_Data.DataModels;
using System.Data.SqlClient;

namespace Logistica_Data
{
    public static class DataBaseService
    {
        private static readonly string ConnectionString = Environment.GetEnvironmentVariable("databaseConnection") ?? "";
        private const string DataBaseName = "SI-LOGISTICA";
        public static IList<Viajes> GetViajes()
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString: ConnectionString))
                {
                    var query = @"SELECT * FROM Viaje v
                                  JOIN Vehiculos h ON (v.VehiculoId = h.VehiculoId)
                                  JOIN Rutas result ON (v.RutaId = result.RutaId)
                                  JOIN Responsables e ON (v.ResponsableId = e.ResponsableId)";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    connection.ChangeDatabase(DataBaseName);
                    // Add multi-mapping for dependant tables
                    var result = connection.Query<Viajes, Vehiculos, Rutas, Responsables,Viajes>(query, (a, b, c, d) => { a.Vehiculo = b; a.Ruta = c; a.Responsable = d ; return a; },splitOn:"VehiculoId, RutaId, ResponsableId"  , commandType: System.Data.CommandType.Text);
                    return result.ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message, "Error");
                return new List<Viajes>();
            }
        }

        public static IList<Vehiculos> GetVehiculos()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString: ConnectionString))
                {
                    var query = @"SELECT * FROM Vehiculos";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    connection.ChangeDatabase(DataBaseName);
                    var result = connection.Query<Vehiculos>(query, commandType: System.Data.CommandType.Text);
                    return result.ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message, "Error");
                return new List<Vehiculos>();
            }
        }

        public static IList<Rutas> GetRutas()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString: ConnectionString))
                {
                    var query = @"SELECT * FROM Rutas";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    connection.ChangeDatabase(DataBaseName);
                    var result = connection.Query<Rutas>(query, commandType: System.Data.CommandType.Text);
                    return result.ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message, "Error");
                return new List<Rutas>();
            }
        }
    }
}
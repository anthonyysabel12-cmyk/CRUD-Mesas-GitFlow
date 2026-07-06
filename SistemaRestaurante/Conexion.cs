using Microsoft.Data.SqlClient;

namespace SistemaRestaurante
{
    public class Conexion
    {
        private readonly string cadenaConexion =
            "Server=DESKTOP-VMH94CA;Database=RestauranteDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}
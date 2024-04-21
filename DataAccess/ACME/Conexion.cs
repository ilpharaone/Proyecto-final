using Microsoft.Data.SqlClient;
using System;

namespace DataAccess.ACME
{
    public class Conexion
    {
        private readonly string? _cadenaConexion;

        public Conexion()
        {
            string? cadenaConexion;

            cadenaConexion = Environment.GetEnvironmentVariable("SQLServerXE");
        }

        public SqlConnection Conectar()
        {
            SqlConnection sqlConn;

            //Instanciar la conexion utilizando la cadena de conexion obtenida

            sqlConn = new SqlConnection(_cadenaConexion);

            return sqlConn;

        }
    }
}

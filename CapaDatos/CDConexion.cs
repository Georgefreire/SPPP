using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql;

namespace CapaDatos
{
    public class CDConexion
    {
        #region Datos

        NpgsqlConnection conn;
        String _cadenaConexion;

        #endregion

        public NpgsqlConnection ConexionBDD()
        {
            conn = new NpgsqlConnection();

            try
            {

                _cadenaConexion = "Server=localhost;Port=5432;User Id=postgres;" + "Password=123;Database=sppp";
                conn.ConnectionString = _cadenaConexion;
                return conn;
            }
            catch (NpgsqlException ex)
            {
                //error
                return conn;
            }
        }
    }
}

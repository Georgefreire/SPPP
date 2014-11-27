using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql;

namespace CapaNegocio
{
    public static class CNDatosConexion
    {
        private static NpgsqlConnection _conexionPG;

        public static NpgsqlConnection ConexionPG
        {
            get { return CNDatosConexion._conexionPG; }
            set { CNDatosConexion._conexionPG = value; }
        }
    }
}

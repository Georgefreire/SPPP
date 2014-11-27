using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Npgsql;
using CapaNegocio;

namespace CapaDatos
{
    public class CDPerfil
    {
        public void SelectPerfil(DataSet dsP, string nombre, int codCar)
        {
            NpgsqlCommand cmd = new NpgsqlCommand();

            cmd.Connection = CNDatosConexion.ConexionPG;
            cmd.Parameters.Add("@codcarr", NpgsqlTypes.NpgsqlDbType.Integer, 10).Value = codCar;
            cmd.CommandText = "sp_select_perfil";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dsP, nombre);
        }
    }
}

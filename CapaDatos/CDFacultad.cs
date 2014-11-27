using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using CapaNegocio;
using Npgsql;

namespace CapaDatos
{
    public class CDFacultad
    {
        DataTable dt;
        NpgsqlDataReader reader;
        public DataTable SelectFacultad1()
        {
            NpgsqlCommand cmd = new NpgsqlCommand();
            

            cmd.CommandText = "sp_select_facultad1";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Connection = CNDatosConexion.ConexionPG;

            CNDatosConexion.ConexionPG.Open();
            reader = cmd.ExecuteReader();

            dt = new DataTable();
            dt.Load(reader);
            return dt;
        }

        public void SelectFacultad(DataSet dsF,string nombre)
        {
            NpgsqlCommand cmd = new NpgsqlCommand();

            cmd.Connection = CNDatosConexion.ConexionPG;
            cmd.CommandText = "sp_select_facultad";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dsF,nombre);
        }

    }
}

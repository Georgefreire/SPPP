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
    public class CDCarreras
    {
        public void SelectCarreras(DataSet dsC, string nombre,int codFac)
        {
            NpgsqlCommand cmd = new NpgsqlCommand();

            cmd.Connection = CNDatosConexion.ConexionPG;
            cmd.Parameters.Add("@codfac", NpgsqlTypes.NpgsqlDbType.Integer, 10).Value = codFac;
            cmd.CommandText = "sp_select_carrera";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dsC, nombre);
        }


        public DataTable SelectCarrerasTable(int codFac)
        {  NpgsqlConnection coneccion = new NpgsqlConnection();
                NpgsqlCommand cmd = new NpgsqlCommand();

                cmd.Connection = CNDatosConexion.ConexionPG;
            try
            {
              

                cmd.CommandText = "SELECT nombre_carr   FROM carrera  where cod_fac = " + codFac + " ;";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection.Close();
                cmd.Connection.Open();
                NpgsqlDataReader lector = cmd.ExecuteReader();

                DataTable tablaStates = new DataTable();


                tablaStates.Load(lector);


                return tablaStates;
            }
            finally {
                cmd.Connection.Close();
            }
        }




    }
}

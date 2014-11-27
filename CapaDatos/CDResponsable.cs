using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio;
using Npgsql;

namespace CapaDatos
{
    public class CDResponsable
    {
        
            public void SelectCargo(DataSet dsCa, string nombre)
            {
                NpgsqlCommand cmd = new NpgsqlCommand();

                cmd.Connection = CNDatosConexion.ConexionPG;
                cmd.CommandText = "sp_select_cargo";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(dsCa, nombre);
            }

            public int InsertResponsable()
            {
                NpgsqlCommand cmd = new NpgsqlCommand();

                cmd.Connection = CNDatosConexion.ConexionPG;
                CNDatosConexion.ConexionPG.Open();
                cmd.Parameters.Add("@cod_car", NpgsqlTypes.NpgsqlDbType.Integer, 10).Value = CNResponsable.CodCargo;
                cmd.Parameters.Add("@ci_resp", NpgsqlTypes.NpgsqlDbType.Varchar, 10).Value = CNResponsable.Cedula;
                cmd.Parameters.Add("@nombres_res", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = CNResponsable.Nombres;
                cmd.Parameters.Add("@apellidos_res", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = CNResponsable.Apellidos;
                cmd.Parameters.Add("@sexo_res", NpgsqlTypes.NpgsqlDbType.Varchar, 1).Value = CNResponsable.Sexo;               
                cmd.Parameters.Add("@movil_res", NpgsqlTypes.NpgsqlDbType.Varchar, 10).Value = CNResponsable.Movil;
                cmd.Parameters.Add("@correo_res", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = CNResponsable.Correo;
                cmd.Parameters.Add("@titulo_res", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = CNResponsable.Titulo;
                
                cmd.CommandText = "sp_insert_responsable";

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                int i = cmd.ExecuteNonQuery();
                return i;

            }
            public void SelectResponsable(DataSet dsF, string nombre)
            {
                NpgsqlCommand cmd = new NpgsqlCommand();

                cmd.Connection = CNDatosConexion.ConexionPG;
                cmd.CommandText = "sp_select_responsable";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(dsF, nombre);
            }
        }
}


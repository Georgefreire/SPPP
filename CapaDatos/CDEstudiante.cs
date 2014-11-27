using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio;
using Npgsql;
using System.Windows.Forms;
namespace CapaDatos
{
    public class CDEstudiante
    {
        public int InsertEsrudiante()
        {
            
            NpgsqlCommand cmd = new NpgsqlCommand();
            CNDatosConexion.ConexionPG.Close();
            cmd.Connection = CNDatosConexion.ConexionPG;
            CNDatosConexion.ConexionPG.Open();
            cmd.Parameters.Add("@ci_estu", NpgsqlTypes.NpgsqlDbType.Varchar, 10).Value = CNEstudiante.Cedula;
            cmd.Parameters.Add("@nombre_est", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = CNEstudiante.Nombres;
            cmd.Parameters.Add("@apellido_est", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = CNEstudiante.Apellidos;
            cmd.Parameters.Add("@sexo_est", NpgsqlTypes.NpgsqlDbType.Varchar, 1).Value =CNEstudiante.Sexo;
            cmd.Parameters.Add("@conven_est", NpgsqlTypes.NpgsqlDbType.Varchar, 9).Value = CNEstudiante.Convencional;
            cmd.Parameters.Add("@movil_est", NpgsqlTypes.NpgsqlDbType.Varchar, 10).Value = CNEstudiante.Movil;
            cmd.Parameters.Add("@correo_est", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = CNEstudiante.Correo;
            cmd.Parameters.Add("@creditos", NpgsqlTypes.NpgsqlDbType.Integer, 10).Value = CNEstudiante.Creditos;
            cmd.Parameters.Add("@codcarr", NpgsqlTypes.NpgsqlDbType.Integer, 10).Value = CNEstudiante.Codcarr;
            
            cmd.CommandText = "sp_insert_estudiante";
            
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            int i=cmd.ExecuteNonQuery();

            
            return i;
        
        }




        public void SelectEstudiante(DataSet dsF, string nombre)
        {
            NpgsqlCommand cmd = new NpgsqlCommand();

            cmd.Connection = CNDatosConexion.ConexionPG;
            cmd.CommandText = "sp_select_estudiante";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;            
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dsF, nombre);
        }

        public void UpdateEstudiante(DataSet dsF, string nombre)
        {
            NpgsqlCommand cmd = new NpgsqlCommand();

            cmd.Connection = CNDatosConexion.ConexionPG;
            cmd.Parameters.Add("@ciestu", NpgsqlTypes.NpgsqlDbType.Varchar, 10).Value = CNEstudiante.Cedula;
            cmd.Parameters.Add("@nombreest", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = CNEstudiante.Nombres;
            cmd.Parameters.Add("@apellidoest", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = CNEstudiante.Apellidos;
            cmd.Parameters.Add("@sexoest", NpgsqlTypes.NpgsqlDbType.Varchar, 1).Value = CNEstudiante.Sexo;
            cmd.Parameters.Add("@convenest", NpgsqlTypes.NpgsqlDbType.Varchar, 9).Value = CNEstudiante.Convencional;
            cmd.Parameters.Add("@movilest", NpgsqlTypes.NpgsqlDbType.Varchar, 10).Value = CNEstudiante.Movil;
            cmd.Parameters.Add("@correoest", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = CNEstudiante.Correo;
            cmd.Parameters.Add("@creditos", NpgsqlTypes.NpgsqlDbType.Integer, 10).Value = CNEstudiante.Creditos;

            cmd.CommandText = "sp_update_estudiante";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dsF, nombre);
        }
        public DataTable VerificaEstudiante(string cedula)
        {
            NpgsqlConnection coneccion = new NpgsqlConnection();
            NpgsqlCommand cmd = new NpgsqlCommand();

            cmd.Connection = CNDatosConexion.ConexionPG;
            try
            {


                cmd.CommandText = "select count(cod_est) from estudiante where ci_est='"+cedula+"'";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection.Close();
                cmd.Connection.Open();
                NpgsqlDataReader lector = cmd.ExecuteReader();

                DataTable tablaStates = new DataTable();


                tablaStates.Load(lector);


                return tablaStates;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        public DataTable SelectPeriodoTable()
        {
            NpgsqlConnection coneccion = new NpgsqlConnection();
            NpgsqlCommand cmd = new NpgsqlCommand();

            cmd.Connection = CNDatosConexion.ConexionPG;
            try
            {


                cmd.CommandText = "select cod_carr,nombre_carr from carrera ;";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection.Close();
                cmd.Connection.Open();
                NpgsqlDataReader lector = cmd.ExecuteReader();

                DataTable tablaStates = new DataTable();


                tablaStates.Load(lector);


                return tablaStates;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
    }
}

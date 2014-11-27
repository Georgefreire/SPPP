using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio;
using Npgsql;
using System.Windows.Forms;
using System.Data;
namespace CapaDatos
{
    public class CDEntidad
    {
        public int InsertEntidad()
        {
            NpgsqlCommand cmd = new NpgsqlCommand();

            cmd.Connection = CNDatosConexion.ConexionPG;
            CNDatosConexion.ConexionPG.Open();

            cmd.Parameters.Add("@ruc_enti", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = CNEntidad.Ruc;
            cmd.Parameters.Add("@nombre_enti", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = CNEntidad.NombreEnt;
            cmd.Parameters.Add("@tipo_ent", NpgsqlTypes.NpgsqlDbType.Varchar, 30).Value = CNEntidad.TipoEnt;
            cmd.Parameters.Add("@direccion_ent", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = CNEntidad.DireccionEnt;
            cmd.Parameters.Add("@telefono_ent", NpgsqlTypes.NpgsqlDbType.Varchar, 10).Value = CNEntidad.TelefonoEnt;
            cmd.Parameters.Add("@correo_ent", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = CNEntidad.CorreoEnt;
            cmd.Parameters.Add("@representante_ent", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = CNEntidad.RepresentanteEnt;
            cmd.Parameters.Add("@titulo_representante", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = CNEntidad.TituloRep;
            cmd.Parameters.Add("@cargo_representante", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = CNEntidad.CargoRep;
            cmd.Parameters.Add("@telefono_representante", NpgsqlTypes.NpgsqlDbType.Varchar, 10).Value = CNEntidad.TelefonoEnt;
            cmd.Parameters.Add("@correo_representante", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = CNEntidad.CorreoEnt;           
            cmd.CommandText = "sp_insert_entidad";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            int i = cmd.ExecuteNonQuery();

            return i;

        }
        public void SelectEntidad(DataSet dsF, string nombre)
        {
            NpgsqlCommand cmd = new NpgsqlCommand();

            cmd.Connection = CNDatosConexion.ConexionPG;
            cmd.CommandText = "sp_select_entidad";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dsF, nombre);
        }
        public void SelectEnt(DataSet dsF, string nombre, string entidad)
        {
            NpgsqlCommand cmd = new NpgsqlCommand();

            cmd.Connection = CNDatosConexion.ConexionPG;
            cmd.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = entidad;
            cmd.CommandText = "sp_select_ent";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dsF, nombre);
        }
        public void UpdateEnt(DataSet dsF, string nombre, string entidad, string tipo, string direccion, string representante, string telefono, string correo)
        {
            NpgsqlCommand cmd = new NpgsqlCommand();

            cmd.Connection = CNDatosConexion.ConexionPG;
            cmd.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = entidad;
            cmd.Parameters.Add("@tipo", NpgsqlTypes.NpgsqlDbType.Varchar, 30).Value = tipo;
            cmd.Parameters.Add("@direccion", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = direccion;          
            cmd.Parameters.Add("@representante", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = representante;           
            cmd.Parameters.Add("@telefono", NpgsqlTypes.NpgsqlDbType.Varchar, 10).Value = telefono;
            cmd.Parameters.Add("@correo", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = correo; 
            cmd.CommandText = "sp_update_entidad";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dsF, nombre);
        }
    }
}

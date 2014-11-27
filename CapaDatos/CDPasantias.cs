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
   public  class CDPasantias
    {
        public int InsertPasantias()
        {

            NpgsqlCommand cmd = new NpgsqlCommand();
            CNDatosConexion.ConexionPG.Close();
            cmd.Connection = CNDatosConexion.ConexionPG;
            CNDatosConexion.ConexionPG.Open();
            
            
            
            cmd.Parameters.Add("@cod_est", NpgsqlTypes.NpgsqlDbType.Integer, 10).Value = CNPasantia.CodEstud;
            cmd.Parameters.Add("@fechain_pas", NpgsqlTypes.NpgsqlDbType.Varchar, 10).Value = CNPasantia.FechaIni;
            cmd.Parameters.Add("@fechafin_pas", NpgsqlTypes.NpgsqlDbType.Varchar, 10).Value = CNPasantia.FechaFin;
            cmd.Parameters.Add("@Numero_Resolucion", NpgsqlTypes.NpgsqlDbType.Varchar, 10).Value = CNPasantia.Numero_Resolucion;
            cmd.Parameters.Add("@fechaapro", NpgsqlTypes.NpgsqlDbType.Varchar, 10).Value = CNPasantia.Fechaapro;
            
            
            //cmd.Parameters.Add("@cod_carr", NpgsqlTypes.NpgsqlDbType.Integer, 10).Value = CNPasantia.EstadoPas;                     
            cmd.CommandText = "sp_insert_pasantias";
            //MessageBox.Show("Periodo  "+CNPasantia.CodPeriodo + "  Responsable " + CNPasantia.CodRespon + "  Estudiante" + CNPasantia.CodEstud + " inicio " + CNPasantia.FechaIni +"  Fin  "+ CNPasantia.FechaFin + "  horas  " + CNPasantia.NumHoras + " Estado  " + CNPasantia.EstadoPas);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            int i = cmd.ExecuteNonQuery();
            return i;
            cmd.Connection.Close();
        }
        public void SelectSeguimiento(DataSet dsF, string nombre)
        {
            NpgsqlCommand cmd = new NpgsqlCommand();

            cmd.Connection = CNDatosConexion.ConexionPG;            
            cmd.CommandText = "sp_select_estudiante";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;           
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dsF, nombre);
            cmd.Connection.Close();
        }
        public void SelectPracticas(DataSet dsF, string nombre,int i)
        {
            NpgsqlCommand cmd = new NpgsqlCommand();

            cmd.Connection = CNDatosConexion.ConexionPG;
            cmd.Parameters.Add("@codigo", NpgsqlTypes.NpgsqlDbType.Integer, 10).Value = i;
            cmd.CommandText = "sp_select_practicas";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dsF, nombre);
            cmd.Connection.Close();
        }
        public void SelectSeguimientoCarrera(DataSet dsF, string nombre, int carrera)
        {
            NpgsqlCommand cmd = new NpgsqlCommand();

            cmd.Connection = CNDatosConexion.ConexionPG;
            cmd.Parameters.Add("@carr", NpgsqlTypes.NpgsqlDbType.Integer, 10).Value = carrera;
            cmd.CommandText = "sp_select_estudiante_carr";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dsF, nombre);
            cmd.Connection.Close();
        }
        public DataTable SelectPasantia() {
            NpgsqlConnection coneccion = new NpgsqlConnection();
            NpgsqlCommand cmd = new NpgsqlCommand();

            cmd.Connection = CNDatosConexion.ConexionPG;
            try
            {
                cmd.CommandText = "select cod_pas, cod_est from pasantias where cod_est=" + CNPasantia.CodEstud;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection.Open();
                NpgsqlDataReader lector = cmd.ExecuteReader();
                DataTable tablapasantias = new DataTable();
                tablapasantias.Load(lector);
                return tablapasantias;
            }
            finally
            {
                cmd.Connection.Close();
            }
        
        }

        public DataTable ExistePasantia()
        {
            NpgsqlConnection coneccion = new NpgsqlConnection();
            NpgsqlCommand cmd = new NpgsqlCommand();

            cmd.Connection = CNDatosConexion.ConexionPG;
            try
            {
                cmd.CommandText = "select count(cod_pas) from pasantias where cod_est=" + CNPasantia.CodEstud;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection.Close();
                cmd.Connection.Open();
                NpgsqlDataReader lector = cmd.ExecuteReader();
                DataTable tablapasantias = new DataTable();
                tablapasantias.Load(lector);
                return tablapasantias;
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


                cmd.CommandText = "select  cod_per as Codigo , (iniperiodo || '-'|| finperiodo) as Periodo  from periodo;";
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

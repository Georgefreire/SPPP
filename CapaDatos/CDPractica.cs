using CapaNegocio;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDPractica
    {
        public void SelectPracti(DataSet dsF, string nombre, string ci)
        {
            //NpgsqlCommand cmd = new NpgsqlCommand();

            //cmd.Connection = CNDatosConexion.ConexionPG;
            //cmd.Parameters.Add("@codigo", NpgsqlTypes.NpgsqlDbType.Varchar, 10).Value = ci;
            //cmd.CommandText = "sp_select_p";
            //cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            //adapter.SelectCommand = cmd;
            //adapter.Fill(dsF, nombre);
        }
        public int InsertPractica() 
        {
            NpgsqlCommand cmd = new NpgsqlCommand();
            CNDatosConexion.ConexionPG.Close();
            cmd.Connection = CNDatosConexion.ConexionPG;
            CNDatosConexion.ConexionPG.Open();
            
            cmd.Parameters.Add("@cod_pas", NpgsqlTypes.NpgsqlDbType.Integer, 10).Value = CNPracticas.CodPasantia;
            cmd.Parameters.Add("@cod_ent", NpgsqlTypes.NpgsqlDbType.Integer, 10).Value = CNPracticas.CodEntidad;
            cmd.Parameters.Add("@cod_resp", NpgsqlTypes.NpgsqlDbType.Integer, 10).Value = CNPracticas.Cod_resp;
            cmd.Parameters.Add("@cod_per", NpgsqlTypes.NpgsqlDbType.Integer, 10).Value = CNPracticas.Cod_per;
            cmd.Parameters.Add("@fechain_prac", NpgsqlTypes.NpgsqlDbType.Varchar, 10).Value = CNPracticas.FechaIni;
            cmd.Parameters.Add("@fechafin_prac", NpgsqlTypes.NpgsqlDbType.Varchar, 10).Value = CNPracticas.FechaFin;
            cmd.Parameters.Add("@numhoras_prac", NpgsqlTypes.NpgsqlDbType.Integer, 10).Value = CNPracticas.NumHoras;
            cmd.Parameters.Add("@estado_prac", NpgsqlTypes.NpgsqlDbType.Varchar, 10).Value = CNPracticas.EstadoPra;                     
            cmd.CommandText = "sp_insert_practicas";
            //MessageBox.Show("Periodo  "+CNPasantia.CodPeriodo + "  Responsable " + CNPasantia.CodRespon + "  Estudiante" + CNPasantia.CodEstud + " inicio " + CNPasantia.FechaIni +"  Fin  "+ CNPasantia.FechaFin + "  horas  " + CNPasantia.NumHoras + " Estado  " + CNPasantia.EstadoPas);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            int i = cmd.ExecuteNonQuery();
            return i;
            cmd.Connection.Close();
        }
        public int InsertDetalle(int codPasantia,int codEntidad, int codResponsable, int codPeriodo,string fechain,string fechafin,string numhoras,string estado)
        {
            NpgsqlCommand cmd = new NpgsqlCommand();
            CNDatosConexion.ConexionPG.Close();
            cmd.Connection = CNDatosConexion.ConexionPG;
            CNDatosConexion.ConexionPG.Open();

            cmd.Parameters.Add("@cod_pas", NpgsqlTypes.NpgsqlDbType.Integer, 10).Value = codPasantia;
            cmd.Parameters.Add("@cod_ent", NpgsqlTypes.NpgsqlDbType.Integer, 10).Value = codEntidad;
            cmd.Parameters.Add("@cod_resp", NpgsqlTypes.NpgsqlDbType.Integer, 10).Value = codResponsable;
            cmd.Parameters.Add("@cod_per", NpgsqlTypes.NpgsqlDbType.Integer, 10).Value = codPeriodo;
            cmd.Parameters.Add("@fechain_prac", NpgsqlTypes.NpgsqlDbType.Varchar, 10).Value = fechain;
            cmd.Parameters.Add("@fechafin_prac", NpgsqlTypes.NpgsqlDbType.Varchar, 10).Value = fechafin;
            cmd.Parameters.Add("@numhoras_prac", NpgsqlTypes.NpgsqlDbType.Integer, 10).Value = numhoras;
            cmd.Parameters.Add("@estado_prac", NpgsqlTypes.NpgsqlDbType.Varchar, 10).Value = estado;
            cmd.CommandText = "sp_insert_practicas";
            //MessageBox.Show("Periodo  "+CNPasantia.CodPeriodo + "  Responsable " + CNPasantia.CodRespon + "  Estudiante" + CNPasantia.CodEstud + " inicio " + CNPasantia.FechaIni +"  Fin  "+ CNPasantia.FechaFin + "  horas  " + CNPasantia.NumHoras + " Estado  " + CNPasantia.EstadoPas);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            int i = cmd.ExecuteNonQuery();
            return i;
            cmd.Connection.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using Npgsql;
using CapaNegocio;

namespace SPPP
{
    public partial class IngresoEntidad : Form
    {
        #region CARGAR/ENVIAR DATOS

        public void CargarDatos()
        {
            txtCargoRep.Text = CNEntidad.CargoRep;
            txtCorreoEmp.Text = CNEntidad.CorreoEnt;
            txtCorreoRep.Text = CNEntidad.CorreoRep;
            txtDireccionEmp.Text = CNEntidad.DireccionEnt;
            txtMoviRep.Text = CNEntidad.TelefonoRep;
            txtNombreEmp.Text = CNEntidad.NombreEnt;
            txtNombreRep.Text = CNEntidad.RepresentanteEnt;
            txtTelefonoEmp.Text = CNEntidad.TelefonoEnt;
            txtTituloRep.Text = CNEntidad.TituloRep;
        }

        public void EnviarDatos()
        {
            CNEntidad.Ruc = txtRuc.Text;
            CNEntidad.CargoRep=txtCargoRep.Text;
            CNEntidad.CorreoEnt=txtCorreoEmp.Text;
            CNEntidad.CorreoRep=txtCorreoRep.Text;
            CNEntidad.DireccionEnt=txtDireccionEmp.Text;
            CNEntidad.TelefonoRep=txtMoviRep.Text;
            CNEntidad.NombreEnt=txtNombreEmp.Text.ToUpper();
            CNEntidad.RepresentanteEnt=txtNombreRep.Text;
            CNEntidad.TelefonoEnt=txtTelefonoEmp.Text;
            CNEntidad.TituloRep = txtTituloRep.Text;
            CNEntidad.TipoEnt = tipoempresa;
        }

        #endregion

        public IngresoEntidad()
        {
            InitializeComponent();
        }
        private void Insert()
        {
            EnviarDatos();
            try
            {
                CDEntidad obj = new CDEntidad();
                int i = obj.InsertEntidad();
                if (i == 1)
                {
                    MessageBox.Show("Se ingreso!" + i);
                }
                else
                {
                    MessageBox.Show("No se ingreso!" + i);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CNDatosConexion.ConexionPG.Close();
            }

        }
        private void btnGuardarP_Click(object sender, EventArgs e)
        {
            if (txtNombreEmp.Text == "" || tipoempresa == "" || txtDireccionEmp.Text == "" || txtTelefonoEmp.Text == "" || txtCorreoEmp.Text == "" || txtNombreRep.Text == "" || txtTituloRep.Text == "" || txtCargoRep.Text == "" || txtMoviRep.Text == "" || txtCorreoRep.Text == "")
            { 
                    MessageBox.Show("LLene todo los campos de la entidad"); 
            }
            else { 
                Insert(); 
            }
             
                
        }
      

        private void IngresoEntidad_Load(object sender, EventArgs e)
        {

        }
        string tipoempresa;
        private void rbPublica_CheckedChanged(object sender, EventArgs e)
        {
            tipoempresa = "Publica";
        }

        private void rbPrivada_CheckedChanged(object sender, EventArgs e)
        {
            tipoempresa = "Privada";
        }
    }
}

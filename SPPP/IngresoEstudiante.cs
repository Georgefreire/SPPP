using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using CapaNegocio;
using CapaDatos;
namespace SPPP
{
    public partial class IngresoEstudiante : Form
    {
        CDEstudiante cdEstudiante;
        public void llenadocombo()
        {
            cdEstudiante = new CDEstudiante();

            cmbCarrera.DataSource = cdEstudiante.SelectPeriodoTable();
            cmbCarrera.ValueMember = "cod_carr";
            cmbCarrera.DisplayMember = "nombre_carr";

        }
        #region  CARGAR/ENVIAR DATOS

        public void CargarDatos()
        {
            txtApellidos.Text = CNEstudiante.Apellidos;
            txtCedula.Text = CNEstudiante.Cedula;
            txtConvencional.Text = CNEstudiante.Convencional;
            txtCorreo.Text = CNEstudiante.Correo;
            txtCreditos.Text = Convert.ToString(CNEstudiante.Creditos);
            txtMovil.Text = CNEstudiante.Movil;
            txtNombres.Text = CNEstudiante.Nombres;
        }

        public void EnviarDatos()
        {
            CNEstudiante.Apellidos=txtApellidos.Text;
            CNEstudiante.Cedula=txtCedula.Text;
            CNEstudiante.Convencional=txtConvencional.Text;
            CNEstudiante.Correo=txtCorreo.Text;
            CNEstudiante.Creditos=Convert.ToInt32(txtCreditos.Text); 
            CNEstudiante.Movil=txtMovil.Text;
            CNEstudiante.Nombres = txtNombres.Text;
            CNEstudiante.Sexo = sexo;
            CNEstudiante.Codcarr = Int16.Parse(cmbCarrera.SelectedValue.ToString());
        }

        #endregion




        #region INSERT
      
        private void Insert()
        {
            EnviarDatos();
            try
            {
                
             

                if(! (verificaEstudiante(txtCedula.Text)))
                {
                    cdEstudiante.InsertEsrudiante();
                    MessageBox.Show("Se ingreso!");
                }
                else
                { 
                    MessageBox.Show("No se ingreso!" );
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }        
            finally 
            {
                CNDatosConexion.ConexionPG.Close();
            }
        
        }
        #endregion
        Boolean verificaEstudiante(string cedula) { 
            int existe=Int16.Parse(cdEstudiante.VerificaEstudiante(cedula).Rows[0][0].ToString());
            if (existe > 0)
            {
                return true;
            }
            else 
            {
                return false;
            }
        
        }
        public IngresoEstudiante()
        {
            InitializeComponent();
            llenadocombo();
        }
        private void btnGuardarP_Click(object sender, EventArgs e)
        {
            Insert();
        }

        private void cmbCarrera_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }
        string sexo;
        private void rbFemenino_CheckedChanged(object sender, EventArgs e)
        {
            sexo = "F";
        }

        private void rbMasculino_CheckedChanged(object sender, EventArgs e)
        {
            sexo = "M";
        }
    }
}

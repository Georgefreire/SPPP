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
    public partial class IngresoResponsable : Form
    {
        #region DATOS
        DataSet DsCa;
        CDResponsable cdResponsable;
        #endregion

        #region CARGAR/ENVIAR DATOS

        public void CargarDatos()
        {
            txtApellidosR.Text = CNResponsable.Apellidos;
            txtCIR.Text = CNResponsable.Cedula;
            txtCorreoR.Text = CNResponsable.Correo;
            txtMovilR.Text = CNResponsable.Movil;
            txtNombreR.Text = CNResponsable.Nombres;
            txtTituloR.Text = CNResponsable.Titulo;
        }

        public void EnviarDatos()
        {
            CNResponsable.Cedula = txtCIR.Text;   
            CNResponsable.Apellidos = txtApellidosR.Text;                   
            CNResponsable.Correo = txtCorreoR.Text;           
            CNResponsable.Movil = txtMovilR.Text;
            CNResponsable.Nombres = txtNombreR.Text;
            CNResponsable.Sexo = cmbSexoR.SelectedItem.ToString().Trim();
            CNResponsable.Titulo = txtTituloR.Text;
            CargarCodigos();
        }
        public void CargarCodigos()
        {            
            CNResponsable.CodCargo = (int)cmbCargoR.SelectedValue;
            MessageBox.Show("codigo resp" + CNResponsable.CodCargo);
        }

        #endregion

        #region METODOS
        public void cargarCargos()
        {
            
            cdResponsable= new CDResponsable();
            DsCa = new DataSet();
            cdResponsable.SelectCargo(DsCa, "cargo");
            cmbCargoR.DataSource = DsCa.Tables[0].DefaultView;
            cmbCargoR.ValueMember = "Codigo";
            cmbCargoR.DisplayMember = "Cargo";           
        }
        public void Insert() 
        {
            EnviarDatos();
            try
            {
                CDResponsable obj = new CDResponsable();
                int i = obj.InsertResponsable();
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
        #endregion

        public IngresoResponsable()
        {
            InitializeComponent();
        }

        private void btnGuardarE_Click(object sender, EventArgs e)
        {
            Insert();
        }

        private void IngresoResponsable_Load(object sender, EventArgs e)
        {
            cargarCargos();
        }

        private void cmbCargoR_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCargoR.SelectedValue.ToString() == "System.Data.DataRowView")
            {
            }
            else
            {
                CargarCodigos();
               
            }
        }
    }
}

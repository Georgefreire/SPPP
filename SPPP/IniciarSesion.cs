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
using CapaNegocio;

namespace SPPP
{
    public partial class IniciarSesion : Form
    {
        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CDConexion conexionPG = new CDConexion();
            try
            {
                //variable estatica de conexion q se utilizara en todo el proyecto
                CNDatosConexion.ConexionPG = conexionPG.ConexionBDD();
                this.Close();
                //conexion exitosa
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAvanzadas_Click(object sender, EventArgs e)
        {
            ConexionBDD conexion = new ConexionBDD();
            conexion.ShowDialog();
        }
    }
}

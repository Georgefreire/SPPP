using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPPP
{
    public partial class ConexionBDD : Form
    {

        string connectionString = "";

        public ConexionBDD()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            connectionString = "Server="+txtServidor.Text+";Port="+txtPuerto.Text+";User Id="+txtUsuario.Text+";" + "Password="+txtContraseña.Text+";Database="+txtBdd.Text+"";


        }
    }
}

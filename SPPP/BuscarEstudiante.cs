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
    public partial class BuscarEstudiante : Form
    {

        public delegate void pasar();
        public event pasar pasado;
   
        public BuscarEstudiante()

        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            IngresoEstudiante ingEst = new IngresoEstudiante();
            ingEst.ShowDialog();
        }

        private void dgvEstudiante_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModificar.Enabled = true;
            btnBorrar.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }
        CDEstudiante cdEstudiante;
        DataSet dsE;
        DataView _vista;

        public void CargarEstudiante()
        {
            cdEstudiante = new CDEstudiante();
          
            dsE = new DataSet();
            cdEstudiante.SelectEstudiante(dsE, "Estudiantes");
            dgvEstudiante.DataSource = dsE.Tables[0].DefaultView;
            _vista = dsE.Tables[0].DefaultView;
        }


        private void BuscarEstudiante_Load(object sender, EventArgs e)
        {
            CargarEstudiante();
        }

        private void txtFiltarNombre_TextChanged(object sender, EventArgs e)
        {
            _vista.RowFilter = "Nombres LIKE '" + txtFiltarNombre.Text.Trim() + "%' ";
            _vista.RowStateFilter = DataViewRowState.OriginalRows;
            dgvEstudiante.DataSource=_vista;
        }

        private void dgvEstudiante_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string nombre = (dgvEstudiante.CurrentRow.Cells["Nombres"].Value.ToString());
            string apellido = (dgvEstudiante.CurrentRow.Cells["Apellidos"].Value.ToString());
            CNPasantia.CodEstud = Convert.ToInt32(dgvEstudiante.CurrentRow.Cells["Codigo"].Value.ToString());
            IngresoPractica.estudiante = nombre + " " + apellido;
            //MessageBox.Show(CNPasantia.CodRespon.ToString());
           
            pasado();
            this.Close();
        }

        private void dgvEstudiante_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string nombre = (dgvEstudiante.CurrentRow.Cells["Nombres"].Value.ToString());
            string apellido = (dgvEstudiante.CurrentRow.Cells["Apellidos"].Value.ToString());
            CNPasantia.CodEstud = Convert.ToInt32(dgvEstudiante.CurrentRow.Cells["Codigo"].Value.ToString());
            CNPasantia.Ci_Est1 = dgvEstudiante.CurrentRow.Cells["Cedula"].Value.ToString();
            IngresoPractica.estudiante = nombre + " " + apellido;
          //  MessageBox.Show(CNPasantia.CodRespon.ToString());
           
            pasado();
            this.Close();
        }

    
    }
}

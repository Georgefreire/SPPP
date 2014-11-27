using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaDatos;
namespace SPPP
{
    public partial class BuscarEntidad : Form
    {
        public delegate void pasar();
        public event pasar pasado;

        public BuscarEntidad()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            IngresoEntidad ingEnt = new IngresoEntidad();
            ingEnt.ShowDialog();
        }

        private void dgvEntidad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModificar.Enabled = true;
            btnBorrar.Enabled = true;
        }
        CDEntidad cdEntidad;
        DataSet dsE;
        DataView _vista;

        public void CargarEntidad()
        {
            cdEntidad = new CDEntidad();

            dsE = new DataSet();
            cdEntidad.SelectEntidad(dsE, "Entidad");
            dgvEntidad.DataSource = dsE.Tables[0].DefaultView;
            _vista = dsE.Tables[0].DefaultView;
        }

        private void BuscarEntidad_Load(object sender, EventArgs e)
        {
            CargarEntidad();
        }

        private void txtFiltarNombre_TextChanged(object sender, EventArgs e)
        {
            _vista.RowFilter = "Nombre LIKE '" + txtFiltarNombre.Text.Trim() + "%' ";
            _vista.RowStateFilter = DataViewRowState.OriginalRows;
            dgvEntidad.DataSource = _vista;
        }

        private void dgvEntidad_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string nombre = ( dgvEntidad.CurrentRow.Cells["Nombre"].Value.ToString());
            CNPracticas.CodEntidad = Convert.ToInt32(dgvEntidad.CurrentRow.Cells["Codigo"].Value.ToString());
            IngresoPractica.entidad = nombre;
            IngresoPract.entidad = nombre;
            //MessageBox.Show(dgvEntidad.CurrentRow.Cells["Codigo"].Value.ToString());
                pasado();
                this.Close();


        }

        private void dgvEntidad_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string nombre = (dgvEntidad.CurrentRow.Cells["Nombre"].Value.ToString());
            CNPracticas.CodEntidad = Convert.ToInt32(dgvEntidad.CurrentRow.Cells["Codigo"].Value.ToString());
            IngresoPractica.entidad = nombre;
            IngresoPract.entidad = nombre;
            //MessageBox.Show(dgvEntidad.CurrentRow.Cells["Codigo"].Value.ToString());
            pasado();
            this.Close();

        }

        private void dgvEntidad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

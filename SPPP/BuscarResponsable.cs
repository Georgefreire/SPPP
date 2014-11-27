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
    public partial class BuscarResponsable : Form
    {
        public delegate void pasar();
        public event pasar pasado;


        public BuscarResponsable()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            IngresoResponsable ingResponsable = new IngresoResponsable();
            ingResponsable.ShowDialog();
        }

        private void dgvResponsable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModificar.Enabled = true;
            btnBorrar.Enabled = true;
        }
        CDResponsable cdResponsable;
        DataSet dsE;
        DataView _vista;

        public void CargarResponsable()
        {
            cdResponsable = new CDResponsable();

            dsE = new DataSet();
            cdResponsable.SelectResponsable(dsE, "Responsable");
            dgvResponsable.DataSource = dsE.Tables[0].DefaultView;
            _vista = dsE.Tables[0].DefaultView;
        }

        private void txtFiltarNombre_TextChanged(object sender, EventArgs e)
        {
            _vista.RowFilter = "Nombres LIKE '" + txtFiltarNombre.Text.Trim() + "%' ";
            _vista.RowStateFilter = DataViewRowState.OriginalRows;
            dgvResponsable.DataSource = _vista;
        }

        private void BuscarResponsable_Load(object sender, EventArgs e)
        {
            CargarResponsable();
        }

        private void dgvResponsable_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            string nombre = (dgvResponsable.CurrentRow.Cells["Nombres"].Value.ToString());
            string apellido = (dgvResponsable.CurrentRow.Cells["Apellidos"].Value.ToString());
            CNPracticas.Cod_resp= Convert.ToInt32(dgvResponsable.CurrentRow.Cells["Codigo"].Value.ToString());
            IngresoPractica.responsable = nombre + " " + apellido;
            IngresoPract.responsable = nombre + " " + apellido;
            //MessageBox.Show(dgvResponsable.CurrentRow.Cells["Codigo"].Value.ToString());
            pasado();
            this.Close();
        }

        private void dgvResponsable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string nombre = (dgvResponsable.CurrentRow.Cells["Nombres"].Value.ToString());
            string apellido = (dgvResponsable.CurrentRow.Cells["Apellidos"].Value.ToString());
            CNPracticas.Cod_resp = Convert.ToInt32(dgvResponsable.CurrentRow.Cells["Codigo"].Value.ToString());
            IngresoPractica.responsable = nombre + " " + apellido;
            IngresoPract.responsable = nombre + " " + apellido;
            //MessageBox.Show(dgvResponsable.CurrentRow.Cells["Codigo"].Value.ToString());
            pasado();
            this.Close();
        }

        private void dgvResponsable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}

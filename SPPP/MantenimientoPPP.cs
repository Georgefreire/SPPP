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
using CapaDatos;
using CapaNegocio;
namespace SPPP
{
    public partial class MantenimientoPPP : Form
    {
        public static int COFIGOFACU=1;
        CDEstudiante cdEstudiante;
        DataSet dsE;
        public MantenimientoPPP()
        {
            InitializeComponent();
            llenadotreeview();
            cdEstudiante = new CDEstudiante();
            dsE = new DataSet();
            bloqueoEntidad();
            bloqueoPasante();
        }
        DataSet dsC;

       


        public void llenadotreeview(){
            CDCarreras cdCarreras = new CDCarreras();
            dsC = new DataSet();


            cdCarreras.SelectCarreras(dsC, "carreras", CNCarrera.CodFacu);
            TreeNode padre = null;

            DataTable dt = cdCarreras.SelectCarrerasTable(COFIGOFACU);

            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {

                    padre = new TreeNode(dr.ItemArray[0].ToString());
                    treeView1.Nodes.Add(padre);

                }





            }
        }
        CDPasantias cdPasantia;
        DataSet dsP;
        DataView _vista;
        public void CargarSeguimiento()
        {
            cdPasantia = new CDPasantias();

            dsP = new DataSet();
            cdPasantia.SelectSeguimiento(dsP, "Estudiantes");
            dgvEstudiantes.DataSource = dsP.Tables[0].DefaultView;
            _vista = dsP.Tables[0].DefaultView;
        }
        public void CargarSeguimientoFiltrado(int i)
        {
            cdPasantia = new CDPasantias();

            dsP = new DataSet();
            cdPasantia.SelectSeguimientoCarrera(dsP, "Estudiantes",i);
            dgvEstudiantes.DataSource = dsP.Tables[0].DefaultView;
            _vista = dsP.Tables[0].DefaultView;
        }
        private void MantenimientoPPP_Load(object sender, EventArgs e)
        {
            TreeNode nodo = new TreeNode();
            CargarSeguimiento();

        }
        
        private void btnNPasantia_Click(object sender, EventArgs e)
        {
            IngresoPractica.DefInstance.ShowDialog();
        }

        private void btnNuevoEst_Click(object sender, EventArgs e)
        {
            IngresoEstudiante ingEst = new IngresoEstudiante();
            ingEst.ShowDialog();
        }

        private void btnNuevaEnt_Click(object sender, EventArgs e)
        {
            IngresoEntidad ingEnt = new IngresoEntidad();
            ingEnt.ShowDialog();
        }

        private void dgvEstudiantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnNDocumento.Enabled = true;
            txtCedula.Text = (dgvEstudiantes.CurrentRow.Cells["Cedula"].Value.ToString());
            txtNombre.Text = (dgvEstudiantes.CurrentRow.Cells["Nombres"].Value.ToString());
            txtApellidos.Text = (dgvEstudiantes.CurrentRow.Cells["Apellidos"].Value.ToString());
            txtSexo.Text = (dgvEstudiantes.CurrentRow.Cells["Sexo"].Value.ToString());
            txtCreditos.Text = (dgvEstudiantes.CurrentRow.Cells["Creditos"].Value.ToString());
            txtConvencional.Text = (dgvEstudiantes.CurrentRow.Cells["Convencional"].Value.ToString());
            txtMovil.Text = (dgvEstudiantes.CurrentRow.Cells["Movil"].Value.ToString());
            txtCorreo.Text = (dgvEstudiantes.CurrentRow.Cells["Correo"].Value.ToString());
            cdPasantia = new CDPasantias();
            dsP = new DataSet();
            cdPasantia.SelectPracticas(dsP, "Practicas", Int16.Parse(dgvEstudiantes.CurrentRow.Cells["Codigo"].Value.ToString()));
            dgvPracticas.DataSource = dsP.Tables[0].DefaultView;
            _vista = dsP.Tables[0].DefaultView;
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
switch (e.Node.Text)
	{
    case "Sistemas":
          CargarSeguimientoFiltrado(1);
        break;
    case "Electronica":
        CargarSeguimientoFiltrado(2);
        break;
    case "Industrial":
        CargarSeguimientoFiltrado(3);
        break;		
	}
                     
              
         
        }

        private void dgvEstudiantes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCedula.Text = (dgvEstudiantes.CurrentRow.Cells["Cedula"].Value.ToString());
            txtNombre.Text= (dgvEstudiantes.CurrentRow.Cells["Nombres"].Value.ToString());
            txtApellidos.Text = (dgvEstudiantes.CurrentRow.Cells["Apellidos"].Value.ToString());
            txtSexo.Text = (dgvEstudiantes.CurrentRow.Cells["Sexo"].Value.ToString());
            txtCreditos.Text = (dgvEstudiantes.CurrentRow.Cells["Creditos"].Value.ToString());
            txtConvencional.Text = (dgvEstudiantes.CurrentRow.Cells["Convencional"].Value.ToString());
            txtMovil.Text = (dgvEstudiantes.CurrentRow.Cells["Movil"].Value.ToString());
            txtCorreo.Text = (dgvEstudiantes.CurrentRow.Cells["Correo"].Value.ToString());
         
        }

        private void dgvEstudiantes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCedula.Text = (dgvEstudiantes.CurrentRow.Cells["Cedula"].Value.ToString());
            txtNombre.Text = (dgvEstudiantes.CurrentRow.Cells["Nombres"].Value.ToString());
            txtApellidos.Text = (dgvEstudiantes.CurrentRow.Cells["Apellidos"].Value.ToString());
            txtSexo.Text = (dgvEstudiantes.CurrentRow.Cells["Sexo"].Value.ToString());
            txtCreditos.Text = (dgvEstudiantes.CurrentRow.Cells["Creditos"].Value.ToString());
            txtConvencional.Text = (dgvEstudiantes.CurrentRow.Cells["Convencional"].Value.ToString());
            txtMovil.Text = (dgvEstudiantes.CurrentRow.Cells["Movil"].Value.ToString());
            txtCorreo.Text = (dgvEstudiantes.CurrentRow.Cells["Correo"].Value.ToString());
            cdPasantia= new CDPasantias();
            dsP = new DataSet();
            cdPasantia.SelectPracticas(dsP, "Practicas", Int16.Parse(dgvEstudiantes.CurrentRow.Cells["Codigo"].Value.ToString()));
            dgvPracticas.DataSource = dsP.Tables[0].DefaultView;
            _vista = dsP.Tables[0].DefaultView;
        }
        
        #region MandarDatos 
        void MandarDatos() 
        {
            CNEstudiante.Cedula = txtCedula.Text;
            CNEstudiante.Nombres = txtNombre.Text;
            CNEstudiante.Apellidos = txtApellidos.Text;
            CNEstudiante.Sexo = txtSexo.Text;
            CNEstudiante.Creditos = Int16.Parse(txtCreditos.Text);
            CNEstudiante.Convencional = txtConvencional.Text;
            CNEstudiante.Movil = txtMovil.Text;
            CNEstudiante.Correo = txtCorreo.Text;    
        }
        void Actualizar() 
        {
           
            cdEstudiante.UpdateEstudiante(dsE, "Estudiantes");
        }
        #endregion

        #region Actualizar
        private void btnGuardarDP_Click(object sender, EventArgs e)
        {
            //Comunicacion capa de negocio - presentacion
            MandarDatos();
            //Comunicacion capa de datos - presentacion
            Actualizar();
            btnGuardarDP.Enabled = false;
            btnCancelarDP.Enabled = false;
            btnEditarDP.Enabled = true;

        }
        #endregion

        CDEntidad cdEntidad;
        DataSet dsEnt;
        DataTable dtEnt;
        private void dgvPracticas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            txtEntidad.Text=   (dgvPracticas.CurrentRow.Cells["Entidad"].Value.ToString());
            cdEntidad = new CDEntidad();
            dsEnt = new DataSet();
            cdEntidad.SelectEnt(dsEnt, "Practicas", txtEntidad.Text);
            txtTipo.Text = dsEnt.Tables[0].Rows[0][1].ToString();
            txtResponsable.Text = dsEnt.Tables[0].Rows[0][2].ToString();
            txtDireccionEntidad.Text = dsEnt.Tables[0].Rows[0][3].ToString();
            txtTelefonoEntidad.Text = dsEnt.Tables[0].Rows[0][4].ToString();
            txtCorreoEntidad.Text = dsEnt.Tables[0].Rows[0][5].ToString();
            _vista = dsP.Tables[0].DefaultView;
        }

        private void dgvEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cdPasantia = new CDPasantias();
            dsP = new DataSet();
            cdPasantia.SelectPracticas(dsP, "Practicas", Int16.Parse(dgvEstudiantes.CurrentRow.Cells["Codigo"].Value.ToString()));
            dgvPracticas.DataSource = dsP.Tables[0].DefaultView;
            _vista = dsP.Tables[0].DefaultView;
        }

        private void dgvPracticas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEntidad.Text = (dgvPracticas.CurrentRow.Cells["Entidad"].Value.ToString());
            cdEntidad = new CDEntidad();
            dsEnt = new DataSet();
            cdEntidad.SelectEnt(dsEnt, "Practicas", txtEntidad.Text);
            txtTipo.Text = dsEnt.Tables[0].Rows[0][1].ToString();
            txtResponsable.Text = dsEnt.Tables[0].Rows[0][2].ToString();
            txtDireccionEntidad.Text = dsEnt.Tables[0].Rows[0][3].ToString();
            txtTelefonoEntidad.Text = dsEnt.Tables[0].Rows[0][4].ToString();
            txtCorreoEntidad.Text = dsEnt.Tables[0].Rows[0][5].ToString();
            _vista = dsP.Tables[0].DefaultView;
        }

        private void dgvPracticas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEntidad.Text = (dgvPracticas.CurrentRow.Cells["Entidad"].Value.ToString());
            cdEntidad = new CDEntidad();
            dsEnt = new DataSet();
            cdEntidad.SelectEnt(dsEnt, "Practicas", txtEntidad.Text);
            txtTipo.Text = dsEnt.Tables[0].Rows[0][1].ToString();
            txtResponsable.Text = dsEnt.Tables[0].Rows[0][2].ToString();
            txtDireccionEntidad.Text = dsEnt.Tables[0].Rows[0][3].ToString();
            txtTelefonoEntidad.Text = dsEnt.Tables[0].Rows[0][4].ToString();
            txtCorreoEntidad.Text = dsEnt.Tables[0].Rows[0][5].ToString();
            _vista = dsP.Tables[0].DefaultView;
        }
        void ActualizarEmpresa() 
        {
            cdEntidad = new CDEntidad();
            dsEnt = new DataSet();
            cdEntidad.UpdateEnt(dsEnt, "Entidad", dgvPracticas.CurrentRow.Cells["Entidad"].Value.ToString(), txtTipo.Text, txtResponsable.Text, txtDireccionEntidad.Text, txtTelefonoEntidad.Text, txtCorreoEntidad.Text);
        }
        private void btnGuardarEmp_Click(object sender, EventArgs e)
        {
            ActualizarEmpresa();
            desbloqueoEntidad();
          
            btnEditarEmp.Enabled = true;
            btnCancelarEmp.Enabled = false;
            btnGuardarEmp.Enabled = false;
            MessageBox.Show("Actualizacion Exitosa");
            bloqueoEntidad();
        }
        #region controles
        bool controlPasante() 
        {
            if (!(txtCedula.Text == "" && txtNombre.Text == "" &&txtApellidos.Text == "" &&  txtSexo.Text == ""  && txtCreditos.Text=="" &&   txtConvencional.Text == ""&&     txtMovil.Text == ""&&    txtCorreo.Text == ""))
                return true;
            else
                return false;
        }
        bool controlEmpresa()
        {
            if (!( txtEntidad.Text == "" &&txtTipo.Text == "" && txtResponsable.Text == "" &&    txtDireccionEntidad.Text == ""&&    txtTelefonoEntidad.Text == ""  &&  txtCorreoEntidad.Text == "" ))
                return true;
            else
                return false;
        }
        #endregion
        private void btnEditarDP_Click(object sender, EventArgs e)
        {
            if (controlPasante())
            {
                desbloqueoPasante();
                btnEditarDP.Enabled = false;
                btnCancelarDP.Enabled = true;
                btnGuardarDP.Enabled = true;
               // MessageBox.Show("Actualizacion Exitosa");
            }
            else {
                MessageBox.Show("Elija un pasante");
            }
            
            
        }

        #region bloqueo y debloqueo de botones
        void desbloqueoPasante()
        {
            txtCedula.Enabled = true;
            txtNombre.Enabled = true;
            txtApellidos.Enabled = true;
            txtSexo.Enabled = true;
            txtCreditos.Enabled = true;
            txtConvencional.Enabled = true;
            txtMovil.Enabled = true;
            txtCorreo.Enabled = true;
        }
        void desbloqueoEntidad()
        {
            txtEntidad.Enabled = true;
            txtTipo.Enabled = true;
            txtResponsable.Enabled = true;
            txtDireccionEntidad.Enabled = true;
            txtTelefonoEntidad.Enabled = true;
            txtCorreoEntidad.Enabled = true;           
        }
        void bloqueoPasante()
        {
            txtCedula.Enabled = false;
            txtNombre.Enabled = false;
            txtApellidos.Enabled = false;
            txtSexo.Enabled = false;
            txtCreditos.Enabled = false;
            txtConvencional.Enabled = false;
            txtMovil.Enabled = false;
            txtCorreo.Enabled = false;
        }
        void bloqueoEntidad()
        {
            txtEntidad.Enabled = false;
            txtTipo.Enabled = false;
            txtResponsable.Enabled = false;
            txtDireccionEntidad.Enabled = false;
            txtTelefonoEntidad.Enabled = false;
            txtCorreoEntidad.Enabled = false;         
        }
    #endregion

        private void btnCancelarDP_Click(object sender, EventArgs e)
        {
            btnGuardarDP.Enabled = false;
            btnCancelarDP.Enabled = false;
            btnEditarDP.Enabled = true;
            limpiarPasante();
            bloqueoPasante();
        }
        #region limpiar texto
        void limpiarPasante()
        {
            txtCedula.Text ="";
            txtNombre.Text= "";
            txtApellidos.Text = "";
            txtSexo.Text = "";
            txtCreditos.Text= "";
            txtConvencional.Text = "";
            txtMovil.Text = "";
            txtCorreo.Text = "";
        }
        void limpiarEmpresa()
        {
            txtEntidad.Text= "";
            txtTipo.Text = "";
            txtResponsable.Text = "";
            txtDireccionEntidad.Text = "";
            txtTelefonoEntidad.Text = "";
            txtCorreoEntidad.Text = "";         
        }
        #endregion

        private void btnEditarEmp_Click(object sender, EventArgs e)
        {
            if (controlEmpresa())
            {
                desbloqueoEntidad();
                btnEditarEmp.Enabled = false;
                btnCancelarEmp.Enabled = true;
                btnGuardarEmp.Enabled = true;
               // MessageBox.Show("Actualizacion Exitosa");
            }
            else
            {
                MessageBox.Show("Elija una Practica");
            }
        }

        private void btnCancelarEmp_Click(object sender, EventArgs e)
        {
            limpiarEmpresa();
            bloqueoEntidad();
            btnGuardarEmp.Enabled = false;
            btnCancelarEmp.Enabled = false;
            btnEditarEmp.Enabled = true;
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            _vista.RowFilter = "Nombres LIKE '" + txtFiltrar.Text.Trim() + "%' ";
            _vista.RowStateFilter = DataViewRowState.OriginalRows;
            dgvEstudiantes.DataSource = _vista;
        }





        //#region Metodo de Nodos
    //public void mostrarNodos(TreeNode pad)
    //{
    
    //DataSet dts = new DataSet();
    //    int i = 0;
    //    dts = cn.dtsUbigeoListar("nodos", Convert.ToInt32(pad.Value));
    //    for(i = 1; i <= dts.Tables["consulta"].Rows.Count; i++)
    //    {
    //        TreeNode nodo = new TreeNode();
    //        nodo.Text = dts.Tables["consulta"].Rows[i - 1]["tm_nomubigeo"].ToString() + " --- " + dts.Tables["consulta"].Rows[i - 1]["tipoubigeo"].ToString();
    //        nodo.Value = dts.Tables["consulta"].Rows[i - 1]["tm_idubigeo"].ToString();
    //        pad.ChildNodes.Add(nodo);
    //        mostrarNodos(nodo);
    //    }
    //}
    //#endregion

    }

   



    #region METODOS PARA CREAR LA BARRA DE PROGRESO EN EL DATAGRID

    public class DataGridViewProgressColumn : DataGridViewImageColumn
    {
        public DataGridViewProgressColumn()
        {
            CellTemplate = new DataGridViewProgressCell();
        }
    }

    class DataGridViewProgressCell : DataGridViewImageCell
    {
        static Image emptyImage;

        static DataGridViewProgressCell()
        {
            emptyImage = new Bitmap(1, 1, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        }
        public DataGridViewProgressCell()
        {
            this.ValueType = typeof(int);
        }

        protected override object GetFormattedValue(object value, int rowIndex, ref DataGridViewCellStyle cellStyle, TypeConverter valueTypeConverter, TypeConverter formattedValueTypeConverter, DataGridViewDataErrorContexts context)
        {
            return emptyImage;
        }

        protected override void Paint(System.Drawing.Graphics g, System.Drawing.Rectangle clipBounds, System.Drawing.Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            int progressVal;
            if (value != null && value.GetType() == typeof(Int32))
                progressVal = (int)value;
            else
                progressVal = 1;

            float percentage = ((float)progressVal / 100.0f);

            Brush backColorBrush = new SolidBrush(cellStyle.BackColor);

            Brush foreColorBrush = new SolidBrush(cellStyle.ForeColor);

            base.Paint(g, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, (paintParts & ~DataGridViewPaintParts.ContentForeground));

            const int margin = 4;

            ProgressBar pb = new ProgressBar();
            pb.Height = cellBounds.Bottom - cellBounds.Top - (margin * 2);
            pb.Width = cellBounds.Right - cellBounds.Left - (margin * 2);
            pb.Value = progressVal;

            Bitmap bmp = new Bitmap(pb.Width, pb.Height);

            pb.DrawToBitmap(bmp, pb.ClientRectangle);

            g.DrawImage(bmp, new Point(cellBounds.X + margin, cellBounds.Y + margin));
        }
    }

    #endregion
}

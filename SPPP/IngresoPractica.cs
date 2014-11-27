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
    public partial class IngresoPractica : Form
    {
       
        public static string estudiante;
        public static string entidad;
        public static string responsable;
        DataTable dt;
        public void llenadoest()
        {

            txtEstudiante.Text = estudiante;
        }
        public void creagrid() {
             dt = new DataTable();
            dt.Columns.Add("ENTIDAD");
            dt.Columns.Add("RESPONSABLE");
            dt.Columns.Add("INICIO");
            dt.Columns.Add("FIN");
            dt.Columns.Add("HORAS");
            dt.Columns.Add("ESTADO");
            dgvPracticas.DataSource = dt;
        }
      
        //public void llenadoent()
        //{

        //   txtEntidad.Text = entidad;
        //}
        //public void llenadoresp()
        //{

        //    txtResponsable.Text = responsable;
        //}


        //public void llenadocombo() {
        //    CapaDatos.CDPasantias obj = new CapaDatos.CDPasantias();

        //    cmbPeriodo.DataSource = obj.SelectPeriodoTable();
        //    cmbPeriodo.ValueMember = "Codigo";
        //    cmbPeriodo.DisplayMember = "Periodo";

        //}

        #region METODO UNA SOLA INSTANCIA

        private static IngresoPractica m_FormDefInstance;
        public static IngresoPractica DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new IngresoPractica();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        #endregion
        
        public IngresoPractica()
        {
            InitializeComponent();
            tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
            //llenadocombo();

            creagrid();
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControl1.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControl1.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.DarkBlue);
                g.FillRectangle(Brushes.AliceBlue, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Arial", (float)10.0, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        private void IngresoPractica_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarRes_Click(object sender, EventArgs e)
        {
            BuscarResponsable bscrres = new BuscarResponsable();
        //    bscrres.pasado += new BuscarResponsable.pasar(llenadoresp);
            bscrres.ShowDialog();
        }

        private void btnBuscarEs_Click(object sender, EventArgs e)
        {
            BuscarEstudiante bscres = new BuscarEstudiante();
             bscres.pasado += new BuscarEstudiante.pasar(llenadoest);
            bscres.ShowDialog();
        }

        private void btnBuscarEn_Click(object sender, EventArgs e)
        {
            BuscarEntidad bscrent = new BuscarEntidad();
          //  bscrent.pasado += new BuscarEntidad.pasar(llenadoent);
            bscrent.ShowDialog();
        }
        public void EnviarDatos()
        {

          //  CNPasantia.CodPeriodo = Int32.Parse(cmbPeriodo.SelectedValue.ToString()); 
            CNPasantia.FechaIni = dtpFechaInicioPr.Value.Date.ToShortDateString();
            CNPasantia.FechaFin = dtpFechaFinPr.Value.Date.ToShortDateString();
            //CNPasantia.NumHoras = Int32.Parse(txtHorasPrev.Text);
            
        }

        #region INSERT
        private void Insert()
        {
            EnviarDatos();
            try
            {
                CDPasantias obj = new CDPasantias();
                int i = obj.InsertPasantias();
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
        private void btnGuardarP_Click(object sender, EventArgs e)
        {
            Insert();
        }
        CDPractica cdPractica;
        DataSet dsPr;
        DataView _vista;
        private void txtEstudiante_TextChanged(object sender, EventArgs e)
        {
            cdPractica = new CDPractica();
            dsPr = new DataSet();
            //cdPractica.SelectPracti(dsPr, "Practicas", CNPasantia.Ci_Est1);
           // dgvPracticas.DataSource = dsPr.Tables[0].DefaultView;
            //_vista = dsPr.Tables[0].DefaultView;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
            //IngresoPract.DefInstance.ShowDialog();
        }
        public void agregargrid(string ent, string resp, string inicio, string fin, int horas, string estado) 
        {

            dt.Rows.Add(ent, resp, inicio, fin,horas,estado);
            
        }

        private void cmbPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (!(verificaPasantia()))
            {
                mandar();
                ejecutar();
            }
            
            IngresoPract insertPract = new IngresoPract();
            insertPract.pasado += new IngresoPract.pasar(agregargrid);
            insertPract.ShowDialog();
        }
        #region capapresentacion - negocio
        void mandar() {
           // CNPasantia.CodEstud
            CNPasantia.Numero_Resolucion=txtResolucion.Text;
           CNPasantia.FechaIni=dtpFechaInicioPr.Value.Date.ToShortDateString();
           CNPasantia.FechaFin = dtpFechaFinPr.Value.Date.ToShortDateString();
           CNPasantia.Fechaapro = dtpAprobacion.Value.Date.ToShortDateString();
 
        
        }
        #endregion
        #region capapresentacion - datos
        CDPasantias cdPasantias = new CDPasantias();
        void ejecutar() {
            try
            {
                cdPasantias.InsertPasantias();
            }
            catch (Exception ex)
            { 
            
            }
            
        }
        #endregion
        private void button2_Click(object sender, EventArgs e)
        {
         
        }
        void llenaPracticas() 
        {           
            for (int i = 0; i < IngresoPract.contador - 1; i++)
            {
                cdPractica.InsertDetalle(Int16.Parse(IngresoPract.ab[i, 0]), Int16.Parse(IngresoPract.ab[i, 1]), Int16.Parse(IngresoPract.ab[i, 2]), Int16.Parse(IngresoPract.ab[i, 3]), IngresoPract.ab[i, 4], IngresoPract.ab[i, 5], IngresoPract.ab[i, 6], IngresoPract.ab[i, 7]);               
            }                
        }

        Boolean verificaPasantia()
        {
            int existe;
         //   MessageBox.Show(cdPasantias.ExistePasantia().Rows[0][0].ToString());
            existe=Int16.Parse(cdPasantias.ExistePasantia().Rows[0][0].ToString());
            if (existe > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (verificaPasantia())
            {
                llenaPracticas();
            }
            else
            {
                mandar();
                ejecutar();
            }
            
        }

        private void dtpAprobacion_ValueChanged(object sender, EventArgs e)
        {

        }

    }
}

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
    public partial class Opciones : Form
    {
        #region METODO UNA SOLA INSTANCIA

        private static Opciones m_FormDefInstance;
        public static Opciones DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Opciones();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        #endregion

        #region Datos

        CDFacultad cdFacultad;
        CDCarreras cdCarreras;
        CDPerfil cdPerfil;

        DataSet dsF;
        DataSet dsC;
        DataSet dsP;

        #endregion

        #region METODOS

        /// <summary>
        /// metodos para tabla carreras
        /// </summary>

        public void cargarFacultad()
        {
            cdFacultad= new CDFacultad();
            dsF = new DataSet();

            cdFacultad.SelectFacultad(dsF,"facultad");
            cmbElgFacultad.DataSource = dsF.Tables[0].DefaultView;
            cmbElgFacultad.ValueMember = "cod_fac";
            cmbElgFacultad.DisplayMember = "nombre_fac";

            cmbFacultad.DataSource = dsF.Tables[0].DefaultView;
            cmbFacultad.ValueMember = "cod_fac";
            cmbFacultad.DisplayMember = "nombre_fac";
        }

        public void CargarCarrera()
        {
            cdCarreras = new CDCarreras();
            dsC = new DataSet();

            //MessageBox.Show("" + cmbElgFacultad.SelectedValue);
            CNCarrera.CodFacu = (int)cmbElgFacultad.SelectedValue;
            cdCarreras.SelectCarreras(dsC, "carreras", CNCarrera.CodFacu);

            dgvCarreras.DataSource = dsC.Tables[0].DefaultView;      
    
        }


        /// <summary>
        /// metodos tabla perfiles
        /// </summary>
        public void CargarCarreraPorfacu()
        {
            cdCarreras = new CDCarreras();
            dsC = new DataSet();

            CNCarrera.CodFacu = (int)cmbFacultad.SelectedValue;
            cdCarreras.SelectCarreras(dsC, "carreras", CNCarrera.CodFacu);
            dgvCarreras.DataSource = dsC.Tables[0].DefaultView;

            cmbCarrera.DataSource = dsC.Tables[0].DefaultView;
            cmbCarrera.ValueMember = "Codigo";
            cmbCarrera.DisplayMember = "Carrera";
            CNCarrera.Codigo = (int)cmbCarrera.SelectedValue;
        }

        public void CargarCodigos()
        {
            CNCarrera.CodFacu = (int)cmbFacultad.SelectedValue;            
            CNCarrera.Codigo = (int)cmbCarrera.SelectedValue;            
        }

        public void CargarTablaPerfiles()
        {
            cdPerfil = new CDPerfil();
            dsP = new DataSet();

            cdPerfil.SelectPerfil(dsP, "perfiles", CNCarrera.Codigo);
            dgvPerfiles.DataSource = dsP.Tables[0].DefaultView;            
        }

        #endregion

        public Opciones()
        {
            InitializeComponent();
            tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
            cargarFacultad();
            
        }

        private void Opciones_Load(object sender, EventArgs e)
        {
            //cmbElgFacultad.Items.Add("");
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

        private void btnBuscarRes_Click(object sender, EventArgs e)
        {
            BuscarResponsable bscrRes = new BuscarResponsable();
            bscrRes.ShowDialog();
        }

        private void cmbElgFacultad_SelectedIndexChanged(object sender, EventArgs e)
        {
                
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCarrera();
            CargarCarreraPorfacu();
        }

        private void cmbCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCarrera.SelectedValue.ToString() == "System.Data.DataRowView")
            {
            }
            else
            {
                CargarCodigos();
                //MessageBox.Show("codifo fac :" + CNCarrera.CodFacu + " codigo carrera :" + CNCarrera.Codigo);
                CargarTablaPerfiles();
            }
        }

    }
}

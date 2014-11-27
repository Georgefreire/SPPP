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
    public partial class IngresoPract : Form
    {
        public delegate void pasar(string ent,string resp, string inicio, string fin, int horas, string estado);
        public event pasar pasado;
        public static string entidad;
        public static string responsable;

 
        public void llenadoent()
        {

            txtEntidad.Text = entidad;
        }
        public void llenadoresp()
        {

            txtResponsable.Text = responsable;
        }

        public IngresoPract()
        {
            InitializeComponent();
            llenadocombo();
        }
        #region instacia unica
        private static IngresoPract m_FormDefInstance;
        public static IngresoPract DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new IngresoPract();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            BuscarEntidad bscrent = new BuscarEntidad();
            bscrent.pasado += new BuscarEntidad.pasar(llenadoent);
            bscrent.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BuscarResponsable bscrres = new BuscarResponsable();
            bscrres.pasado += new BuscarResponsable.pasar(llenadoresp);
            bscrres.ShowDialog();
        }
        CDPasantias cdPasantias;
        public void llenadocombo()
        {
            cdPasantias = new CDPasantias();

            cmbPeriodo.DataSource = cdPasantias.SelectPeriodoTable();
            cmbPeriodo.ValueMember = "Codigo";
            cmbPeriodo.DisplayMember = "Periodo";

        }
        public static int cod_est;
        void llenadoest() {
            cod_est = CNPasantia.CodEstud;
        }

        Boolean verificaPasantia()
        {
            int existe;
            MessageBox.Show(cdPasantias.ExistePasantia().Rows[0][0].ToString());
            existe = Int16.Parse(cdPasantias.ExistePasantia().Rows[0][0].ToString());
            if (existe > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #region mandar-datos
        public static string [,]ab=new  string [10,8];
        public static int contador=0;
        void manda() {
         
                CNPracticas.Cod_per = Int16.Parse(cmbPeriodo.SelectedValue.ToString());
                //MessageBox.Show("" + CNPracticas.Cod_per + "codigo estudiante " + CNPasantia.CodEstud);
                CNPracticas.CodPasantia = Int16.Parse(cdPasantias.SelectPasantia().Rows[0][0].ToString());
                CNPracticas.FechaIni = dtpInicio.Value.Date.ToShortDateString();
                CNPracticas.FechaFin = dtpFin.Value.Date.ToShortDateString();
                CNPracticas.NumHoras = Int16.Parse(txtHoras.Text);
                CNPracticas.EstadoPra = estado;
                ab[contador, 0] = CNPracticas.CodPasantia.ToString();
                ab[contador, 1] = CNPracticas.CodEntidad.ToString();
                ab[contador, 2] = CNPracticas.Cod_resp.ToString();
                ab[contador, 3] = CNPracticas.Cod_per.ToString();
                ab[contador, 4] = CNPracticas.FechaIni.ToString();
                ab[contador, 5] = CNPracticas.FechaFin.ToString();
                ab[contador, 6] = CNPracticas.NumHoras.ToString();
                ab[contador, 7] = CNPracticas.EstadoPra.ToString();
                contador++;          
        }
        #endregion

        #region ejecutar
        void insertar() {
            CDPractica cdPractica = new CDPractica();
            cdPractica.InsertPractica();
        } 

        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            manda();
            insertar();
            pasado(entidad, responsable, dtpInicio.Value.Date.ToShortDateString(), dtpFin.Value.Date.ToShortDateString(), Int16.Parse(txtHoras.Text), estado);
            this.Close();
        }
        public static string estado;
        private void rbTerminado_CheckedChanged(object sender, EventArgs e)
        {
            estado = "T";
        }
        public static string proceso;
        private void rbProceso_CheckedChanged(object sender, EventArgs e)
        {
            estado = "P";
        }

        private void cmbPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IngresoPract_Load(object sender, EventArgs e)
        {

        }
    }
}

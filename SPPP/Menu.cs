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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            IniciarSesion iniciarSesion = new IniciarSesion();
            iniciarSesion.MdiParent = this;
            iniciarSesion.Show();
        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoPPP mantenimiento = new MantenimientoPPP();
            mantenimiento.MdiParent = this;
            mantenimiento.Show();
        }

        private void opcionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Opciones.DefInstance.MdiParent = this;
            Opciones.DefInstance.Show();
        }

        private void estudianteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BuscarEstudiante bscrEst = new BuscarEstudiante();
            bscrEst.MdiParent = this;
            bscrEst.Show();
        }

        private void responsableToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BuscarResponsable bscrRes = new BuscarResponsable();
            bscrRes.MdiParent = this;
            bscrRes.Show();
        }

        private void entidadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BuscarEntidad bscrEnt = new BuscarEntidad();
            bscrEnt.MdiParent = this;
            bscrEnt.Show();
        }

        private void practicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresoPractica.DefInstance.ShowDialog();
        }

        private void estudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresoEstudiante ingEst = new IngresoEstudiante();
            ingEst.ShowDialog();
        }

        private void responsableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresoResponsable ingRes = new IngresoResponsable();
            ingRes.ShowDialog();
        }

        private void entidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresoEntidad ingEnt = new IngresoEntidad();
            ingEnt.ShowDialog();
        }

    }
}

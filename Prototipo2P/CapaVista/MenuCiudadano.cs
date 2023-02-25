using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class MenuCiudadano : Form
    {
        public MenuCiudadano()
        {
            InitializeComponent();
        }

        private void bancosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void controlChequesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void catalogosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void citaParaMayoresDeEdadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Citas_Mayores emPas = new Citas_Mayores();
            emPas.MdiParent = this;
            emPas.Show();
        }

        private void citaParaMenoresDeEdadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Citas_Menores emPas = new Citas_Menores();
            emPas.MdiParent = this;
            emPas.Show();
        }

        private void cancelaciónDeCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancelacionCita emPas = new CancelacionCita();
            emPas.MdiParent = this;
            emPas.Show();
        }

        private void reprogramarCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReprogramarCita emPas = new ReprogramarCita();
            emPas.MdiParent = this;
            emPas.Show();
        }
    }
}

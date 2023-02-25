// Autora: Ester Daniela López Cruz 0901 - 19 - 314
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
    public partial class MenuAdministrativo : Form
    {
        public MenuAdministrativo()
        {
            InitializeComponent();
        }

        private void emisiónDePasaporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmisionPasaporte emPas = new EmisionPasaporte();
            emPas.MdiParent = this;
            emPas.Show();
        }

        private void registroDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 m = new Form1();
            m.MdiParent = this;
            m.Show();
        }

        private void MenuAdministrativo_Load(object sender, EventArgs e)
        {

        }

        private void regresarAInicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
        }
    }
}

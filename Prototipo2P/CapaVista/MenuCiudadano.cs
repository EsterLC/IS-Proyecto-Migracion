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
            Bancos b = new Bancos();
            b.MdiParent = this;
            b.Show();
        }

        private void controlChequesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control_de_Cheques b = new Control_de_Cheques();
            b.MdiParent = this;
            b.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

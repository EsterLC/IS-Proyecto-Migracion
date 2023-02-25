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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuAdministrativo m = new MenuAdministrativo();
            m.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuCiudadano m = new MenuCiudadano();
            m.Show();
        }
    }
}

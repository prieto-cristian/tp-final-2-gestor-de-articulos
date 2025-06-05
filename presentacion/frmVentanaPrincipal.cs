using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class frmVentanaPrincipal : Form
    {
        private Form hijoActual = null;
        private Button botonActivoActual = null;
        public frmVentanaPrincipal()
        {
            InitializeComponent();
        }

        private void frmVentanaPrincipal_Load(object sender, EventArgs e)
        {
            frmResumenArticulos frmResumen = new frmResumenArticulos();
            frmResumen.MdiParent = this;
            panel1.Controls.Add(frmResumen);
            panel1.Tag = frmResumen;
            frmResumen.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            cerrarVentanaActual();
            frmResumenArticulos frmResumen = new frmResumenArticulos();
            frmResumen.MdiParent = this;
            panel1.Controls.Add(frmResumen);
            panel1.Tag = frmResumen;
            frmResumen.Show();
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            cerrarVentanaActual();
            frmListadoArticulos frmListado = new frmListadoArticulos();
            frmListado.MdiParent = this;
            panel1.Controls.Add(frmListado);
            panel1.Tag = frmListado;
            frmListado.Show();
        }
        private void cerrarVentanaActual()
        {
            if (hijoActual != null) {
                hijoActual.Close();
            }
        }
    }
}

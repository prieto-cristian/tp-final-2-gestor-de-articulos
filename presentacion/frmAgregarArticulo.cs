using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;

namespace presentacion
{
    public partial class frmAgregarArticulo : Form
    {
        public frmAgregarArticulo()
        {
            InitializeComponent();
        }

        public frmAgregarArticulo(Articulo unArticulo)
        {
            InitializeComponent();
            Text = "Modificar Artículo";
            btnCrear.Text = "Modificar";
            lblTitulo.Text = "Modificar Artículo";
            txtNombre.Text = unArticulo.Nombre;
            txtPrecio.Text = unArticulo.Precio.ToString();
            txtUrlImagen.Text = unArticulo.UrlImagen;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

        }
    }
}

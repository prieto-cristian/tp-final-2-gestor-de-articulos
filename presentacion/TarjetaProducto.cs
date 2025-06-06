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
    public partial class TarjetaProducto : UserControl
    {
        private Articulo articulo = null;
        public TarjetaProducto()
        {
            InitializeComponent();
        }
        public TarjetaProducto(Articulo articulo)
        {
            this.articulo = articulo;
            InitializeComponent();
            lblNombreProducto.ForeColor = SystemColors.ControlText;
            lblPrecioProducto.ForeColor = SystemColors.ControlText;
        }
        private void cargarImagen(string urlImagen)
        {
            try
            {
                pbxImagenProducto.Load(urlImagen);
            }
            catch (Exception ex){
                throw ex;
            }
        }

        public void asignarArticulo(Articulo unArticulo)
        {
            this.articulo = unArticulo;
            Nombre = unArticulo.Nombre;
            Precio = "$ " + unArticulo.Precio;
           cargarImagen(unArticulo.UrlImagen);
        }

        public string Nombre
        {
            get => lblNombreProducto.Text;
            set => lblNombreProducto.Text = value;
        }

        public string Precio
        {
            get => lblPrecioProducto.Text;
            set => lblPrecioProducto.Text = value;
        }

        private void lblPrecioProducto_Click(object sender, EventArgs e)
        {
            abrirVentanaInfoArticulo();
        }

        private void TarjetaProducto_Click_1(object sender, EventArgs e)
        {
            abrirVentanaInfoArticulo();
        }

        private void lblNombreProducto_Click(object sender, EventArgs e)
        {
            abrirVentanaInfoArticulo();
        }

        private void abrirVentanaInfoArticulo()
        {
            frmAgregarArticulo frmAgregarArticulo = new frmAgregarArticulo(articulo);
            frmAgregarArticulo.ShowDialog();
        }
    }
}

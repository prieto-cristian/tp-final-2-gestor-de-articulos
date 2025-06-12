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
        public event EventHandler NotificarCambios;
        private Articulo articulo = null;
        public TarjetaProducto()
        {
            InitializeComponent();
        }
        public TarjetaProducto(Articulo articulo)
        {
            this.articulo = articulo;
            InitializeComponent();
            Nombre = articulo.Nombre;
            Precio = "$ " + articulo.Precio.ToString();
            cargarImagen(articulo.UrlImagen);
        }

        // Uso de LoadAsync para mejorar la carga al momento de filtrar los articulos.
        private void cargarImagen(string urlImagen)
        {
            pbxImagenProducto.LoadAsync(urlImagen);
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


        // En esta seccion se agrega el evento click en los distintos controles,
        // simulando que la tarjeta se pueda abrir desde cualquier parte del rectangulo.
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

        // Metodo para abrir la informacion del articulo clickeado
        private void abrirVentanaInfoArticulo()
        {
            frmAgregarArticulo frmAgregarArticulo = new frmAgregarArticulo(articulo);
            frmAgregarArticulo.ShowDialog();
            NotificarCambios?.Invoke(this, EventArgs.Empty);
        }
    }
}

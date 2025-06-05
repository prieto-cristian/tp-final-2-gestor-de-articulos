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
    public partial class frmListadoArticulos : Form
    {
        public frmListadoArticulos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void frmListadoArticulos_Load(object sender, EventArgs e)
        {
            string urlImagen = "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/004.png";
            string nombreProducto = "Charmander";
            double precio = 555;

            for (int i = 0; i < 10; i++) {
                Articulo auxArticulo = new Articulo(urlImagen, precio, nombreProducto);
                TarjetaProducto producto = new TarjetaProducto();
                producto.asignarArticulo(auxArticulo);
                flpListadoProductos.Controls.Add(producto);
            }
        }
    }
}

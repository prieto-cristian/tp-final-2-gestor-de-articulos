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
using negocio;

namespace presentacion
{
    public partial class frmListadoArticulos : Form
    {
        private ArticuloNegocio NegocioArticulo = null;
        List<Articulo> articulos = null;
        public frmListadoArticulos()
        {
            InitializeComponent();
            this.NegocioArticulo = new ArticuloNegocio();
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
            ListarArticulos();
            CargarFiltros();
        }

        private void ListarArticulos()
        {
            articulos = NegocioArticulo.listarArticulos();

            foreach (Articulo articulo in articulos)
            {
                TarjetaProducto producto = new TarjetaProducto(articulo);
                producto.NotificarCambios += (s, args) =>
                {
                    LimpiarArticulos();
                    ListarArticulos();
                };
                flpListadoProductos.Controls.Add(producto);
            }
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            frmAgregarArticulo frmAgregarArticulo = new frmAgregarArticulo();
            frmAgregarArticulo.ShowDialog();
            LimpiarArticulos();
            ListarArticulos();
        }
        private void LimpiarArticulos()
        {
            flpListadoProductos.Controls.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            panelBusqueda.BorderStyle = BorderStyle.FixedSingle;
        }

        private void panel3_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            panelBusqueda.BorderStyle = BorderStyle.None;
        }

        private void CargarFiltros()
        {
            // Cargar el combo box que indica el orden por precios
            cbxOrden.Items.AddRange(new object[] { "Menor precio", "Mayor precio"});
            cbxOrden.SelectedIndex = 0;
        }
    }
}

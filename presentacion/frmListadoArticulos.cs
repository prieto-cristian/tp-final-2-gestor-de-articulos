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
        FiltroArticulo filtroArticulo = new FiltroArticulo();
        private ArticuloNegocio NegocioArticulo = null;
        List<Articulo> articulos = null;
        private string TEXTO_HASTA = "Hasta $";
        private string SIGNO_DOLAR = "$";
        private string TEXTO_MAS_DE = "Más de $";
        private string A_MINUSCULA = " a ";
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
            // Se desuscribe al combo box de SelectedChanged para que no liste los articulos
            // al momento de mostrar la ventana. Se vuelve a suscribir una vez Cargados los
            // filtros
            DesuscribirSelectedChangeDeLosComboBox();
            CargarFiltros();
            SuscribirseAlSelectedChangeDeLosComboBox();

            // Lista los articulos
            ListarArticulos();
        }

        private void SuscribirseAlSelectedChangeDeLosComboBox()
        {
            cbxFiltroCategorias.SelectedValueChanged += cbxFiltroCategorias_SelectedValueChanged;
            cbxFiltroMarcas.SelectedValueChanged += cbxFiltroMarcas_SelectedValueChanged;
            cbxOrden.SelectedValueChanged += cbxOrden_SelectedValueChanged;
        }

        private void DesuscribirSelectedChangeDeLosComboBox()
        {
            cbxFiltroCategorias.SelectedValueChanged -= cbxFiltroCategorias_SelectedValueChanged;
            cbxFiltroMarcas.SelectedValueChanged -= cbxFiltroMarcas_SelectedValueChanged;
            cbxOrden.SelectedValueChanged -= cbxOrden_SelectedValueChanged;
        }

        private void ListarArticulos()
        {
            articulos = NegocioArticulo.listarArticulos(filtroArticulo);

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

            // Cargue las marcas y categorias de la base de datos al combo box
            MarcaNegocio negocioMarca = new MarcaNegocio();
            CategoriaNegocio negocioCategoria = new CategoriaNegocio();

            List<Marca> listadoMarcas = negocioMarca.listarMarcas();
            List<Categoria> listadoCategorias = negocioCategoria.listarCategorias();

            cbxFiltroCategorias.DisplayMember = "Descripcion";
            cbxFiltroCategorias.ValueMember = "Id";
            cbxFiltroCategorias.DataSource = negocioCategoria.listarCategorias();
            cbxFiltroCategorias.SelectedIndex = -1;

            cbxFiltroMarcas.DisplayMember = "Descripcion";
            cbxFiltroMarcas.ValueMember = "Id";
            cbxFiltroMarcas.DataSource = negocioMarca.listarMarcas();
            cbxFiltroMarcas.SelectedIndex = -1;

            // Cargar los filtros por rango de precio
            filtroArticulo.PorRangoDePrecios = NegocioArticulo.obtenerRangosDePrecios();
            lblProductosPrecioBajo.Text = TEXTO_HASTA + filtroArticulo.PorRangoDePrecios.PrecioInferior;

            lblProductosConPrecioMedio.Text = SIGNO_DOLAR + filtroArticulo.PorRangoDePrecios.PrecioInferior + A_MINUSCULA + SIGNO_DOLAR + filtroArticulo.PorRangoDePrecios.PreccioSuperior;
            lblProductosConPrecioAlto.Text = TEXTO_MAS_DE + filtroArticulo.PorRangoDePrecios.PreccioSuperior;
        }

        private void cbxOrden_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbxOrden_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxOrden.Text == "Mayor precio")
            {
                filtroArticulo.OrdenarPor = "DESC";
            }
            else
            {
                filtroArticulo.OrdenarPor = "ASC";
            }
            LimpiarArticulos();
            ListarArticulos();
        }

        private void cbxOrden_Leave(object sender, EventArgs e)
        {
            
        }

        private void cbxFiltroMarcas_SelectedValueChanged(object sender, EventArgs e)
        {
            filtroArticulo.marcaAFiltrar = (Marca)cbxFiltroMarcas.SelectedItem;

            LimpiarArticulos();
            ListarArticulos();
        }

        private void cbxFiltroCategorias_SelectedValueChanged(object sender, EventArgs e)
        {
            filtroArticulo.categoriaAFiltrar = (Categoria)cbxFiltroCategorias.SelectedItem;

            LimpiarArticulos();
            ListarArticulos();
        }

        private void panelFiltroAvanzado_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblProductosPrecioBajo_Click(object sender, EventArgs e)
        {
            // Filtrar los productos con el precio hasta.
            filtroArticulo.TipoDeRangoPrecio = 1;
            LimpiarArticulos();
            ListarArticulos();
        }

        private void lblProductosConPrecioMedio_Click(object sender, EventArgs e)
        {
            filtroArticulo.TipoDeRangoPrecio = 2;
            LimpiarArticulos();
            ListarArticulos();
        }

        private void lblProductosConPrecioAlto_Click(object sender, EventArgs e)
        {
            filtroArticulo.TipoDeRangoPrecio = 3;
            LimpiarArticulos();
            ListarArticulos();
        }

        private void btnBuscarProductosPorRango_Click(object sender, EventArgs e)
        {
            filtroArticulo.TipoDeRangoPrecio = 2;
            filtroArticulo.PorRangoDePrecios = new RangoPrecios();
            filtroArticulo.PorRangoDePrecios.PrecioInferior = double.Parse(txtMinimo.Text);
            filtroArticulo.PorRangoDePrecios.PreccioSuperior = double.Parse(txtMaximo.Text);
            LimpiarArticulos();
            ListarArticulos();
        }

        // No necesita limpiar y listar la lista. Esto se hace desde el evento Selected
        private void btnLimpiarFiltroDeMarca_Click(object sender, EventArgs e)
        {
            filtroArticulo.marcaAFiltrar = null;
            cbxFiltroMarcas.SelectedIndex = -1;
        }

        // No necesita limpiar y listar la lista. Esto se hace desde el evento Selected
        private void btnLimpiarFiltroCategoria_Click(object sender, EventArgs e)
        {
            filtroArticulo.categoriaAFiltrar = null;
            cbxFiltroCategorias.SelectedIndex = -1;
        }

        private void btnLimpiarFiltroDePrecios_Click(object sender, EventArgs e)
        {
            filtroArticulo.TipoDeRangoPrecio = null;
            txtMaximo.Text = "";
            txtMinimo.Text = "";
            LimpiarArticulos();
            ListarArticulos();
        }
    }
}

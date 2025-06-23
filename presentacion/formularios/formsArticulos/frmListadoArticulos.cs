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
        private ErrorProvider PrecioMinimoErrorProvider;
        private ErrorProvider PrecioMayorErrorProvider;
        private Label etiquetaActualDelFiltroPrecios = null;
        public frmListadoArticulos()
        {
            InitializeComponent();
            this.NegocioArticulo = new ArticuloNegocio();

            // Cree y configure los ErrorProvider para la entrada de datos.
            PrecioMinimoErrorProvider = new ErrorProvider();
            PrecioMinimoErrorProvider.SetIconAlignment(this.txtMinimo, ErrorIconAlignment.MiddleRight);
            PrecioMinimoErrorProvider.SetIconPadding(this.txtMinimo, 2);
            PrecioMinimoErrorProvider.BlinkRate = 200;
            PrecioMinimoErrorProvider.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;

            PrecioMayorErrorProvider = new ErrorProvider();
            PrecioMayorErrorProvider.SetIconAlignment(this.txtMaximo, ErrorIconAlignment.MiddleRight);
            PrecioMayorErrorProvider.SetIconPadding(this.txtMaximo, 2);
            PrecioMayorErrorProvider.BlinkRate = 200;
            PrecioMayorErrorProvider.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;
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
            filtroArticulo.cadenaDeTextoABuscar = txtBuscador.Text;
            LimpiarArticulos();
            ListarArticulos();
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
            cbxOrden.Items.AddRange(new object[] { "Menor precio", "Mayor precio" });
            cbxOrden.SelectedIndex = 0;

            // Cargue las marcas y categorias de la base de datos al combo box
            MarcaNegocio negocioMarca = new MarcaNegocio();
            CategoriaNegocio negocioCategoria = new CategoriaNegocio();

            List<Marca> listadoMarcas = negocioMarca.listarMarcas();
            List<Categoria> listadoCategorias = negocioCategoria.ListarCategorias();

            cbxFiltroCategorias.DisplayMember = "Descripcion";
            cbxFiltroCategorias.ValueMember = "Id";
            cbxFiltroCategorias.DataSource = negocioCategoria.ListarCategorias();
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
            if(etiquetaActualDelFiltroPrecios != lblProductosPrecioBajo)
            {
                // Filtrar los productos con el precio hasta.
                LimpiarEstilosEtiquetaRangoPrecio();
                filtroArticulo.TipoDeRangoPrecio = 1;
                LimpiarArticulos();
                ListarArticulos();
                etiquetaActualDelFiltroPrecios = lblProductosPrecioBajo;
                Font fuente = new Font(lblProductosPrecioBajo.Font.FontFamily,11, FontStyle.Bold);
                lblProductosPrecioBajo.Font = fuente;
            }

        }

        private void lblProductosConPrecioMedio_Click(object sender, EventArgs e)
        {
            if(etiquetaActualDelFiltroPrecios != lblProductosConPrecioMedio)
            {
                LimpiarEstilosEtiquetaRangoPrecio();
                filtroArticulo.TipoDeRangoPrecio = 2;
                LimpiarArticulos();
                ListarArticulos();
                etiquetaActualDelFiltroPrecios = lblProductosConPrecioMedio;
                Font fuente = new Font(lblProductosConPrecioMedio.Font.FontFamily, 11, FontStyle.Bold);
                lblProductosConPrecioMedio.Font = fuente;
            }
        }

        private void lblProductosConPrecioAlto_Click(object sender, EventArgs e)
        {
            if (etiquetaActualDelFiltroPrecios != lblProductosConPrecioAlto) {
                LimpiarEstilosEtiquetaRangoPrecio();
                filtroArticulo.TipoDeRangoPrecio = 3;
                LimpiarArticulos();
                ListarArticulos();
                etiquetaActualDelFiltroPrecios = lblProductosConPrecioAlto;
                Font fuente = new Font(lblProductosConPrecioAlto.Font.FontFamily, 11, FontStyle.Bold);
                lblProductosConPrecioAlto.Font = fuente;
            }
        }

        private void btnBuscarProductosPorRango_Click(object sender, EventArgs e)
        {
            filtroArticulo.TipoDeRangoPrecio = 2;
            filtroArticulo.PorRangoDePrecios = new RangoPrecios();
            try
            {
                
                if (!ValidadorFormularios.NoEsVacio(txtMinimo.Text))
                {
                    PrecioMinimoErrorProvider.SetError(txtMinimo, "El campo no puede estar vacío");
                }
                else if (!ValidadorFormularios.NoEsVacio(txtMaximo.Text))
                {
                    PrecioMayorErrorProvider.SetError(txtMaximo, "El campo no puede estar vacío");
                }
                else
                {
                    if (PrecioMinimoErrorProvider.GetError(txtMinimo) == String.Empty &&
                    PrecioMayorErrorProvider.GetError(txtMaximo) == String.Empty)
                    {
                        filtroArticulo.PorRangoDePrecios.PrecioInferior = double.Parse(txtMinimo.Text);
                        filtroArticulo.PorRangoDePrecios.PreccioSuperior = double.Parse(txtMaximo.Text);
                        LimpiarArticulos();
                        ListarArticulos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
            LimpiarEstilosEtiquetaRangoPrecio();
            etiquetaActualDelFiltroPrecios = null;
            filtroArticulo.TipoDeRangoPrecio = null;
            txtMaximo.Text = "";
            txtMinimo.Text = "";
            LimpiarArticulos();
            ListarArticulos();
        }

        private void txtBuscador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                filtroArticulo.cadenaDeTextoABuscar = txtBuscador.Text;
                LimpiarArticulos();
                ListarArticulos();
            }
        }

        private void txtMinimo_Validated(object sender, EventArgs e)
        {
            ValidarLosRangosDePrecio(PrecioMinimoErrorProvider, txtMinimo);
        }

        private void txtMaximo_Validated(object sender, EventArgs e)
        {
            ValidarLosRangosDePrecio(PrecioMayorErrorProvider, txtMaximo);
        }

        private void ValidarLosRangosDePrecio(ErrorProvider errorProvider, TextBox textBox)
        {
            if (!ValidadorFormularios.PrecioValido(textBox.Text))
            {
                errorProvider.SetError(textBox, "Ingrese solo números");
            }
            else
            {
                errorProvider.SetError(textBox, String.Empty);
            }
        }

        // Coloca los estilos como estaban antes de haberle dado click
        private void LimpiarEstilosEtiquetaRangoPrecio()
        {
            if(etiquetaActualDelFiltroPrecios != null)
            {
                Font fuente = new Font(etiquetaActualDelFiltroPrecios.Font.FontFamily, 10, FontStyle.Regular);
                etiquetaActualDelFiltroPrecios.Font = fuente;
            }
        }
    }
}

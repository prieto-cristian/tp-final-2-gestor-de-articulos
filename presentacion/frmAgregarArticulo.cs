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

            CargarImagen(unArticulo.UrlImagen);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo nuevoArticulo = new Articulo();
            // Obtener los datos de la Ventana
            nuevoArticulo.CodigoDeArticulo = txtCodigoArticulo.Text;
            nuevoArticulo.Descripcion = txtDescripcion.Text;
            nuevoArticulo.Precio = double.Parse(txtPrecio.Text);
            nuevoArticulo.MarcaDelArticulo = (Marca)cbxMarca.SelectedItem;
            nuevoArticulo.CategoriaDelArticulo = (Categoria)cbxCategoria.SelectedItem;
            nuevoArticulo.Nombre = txtNombre.Text;
            nuevoArticulo.UrlImagen = txtUrlImagen.Text;

            negocio.GuardarArticulo(nuevoArticulo);
            Close();
        }

        private void frmAgregarArticulo_Load(object sender, EventArgs e)
        {
            // Cargar Marcas
            CargarMarcas();
            CargarCategorias();
        }
        private void CargarMarcas()
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            cbxMarca.DataSource = marcaNegocio.listarMarcas();
            cbxMarca.ValueMember = "Id";
            cbxMarca.DisplayMember = "Descripcion";
            cbxMarca.SelectedIndex = -1;
        }

        private void CargarCategorias()
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            cbxCategoria.DataSource = categoriaNegocio.listarCategorias();
            cbxCategoria.ValueMember = "Id";
            cbxCategoria.DisplayMember = "Descripcion";
            cbxCategoria.SelectedIndex = -1;
        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            CargarImagen(txtUrlImagen.Text);
        }

        private void CargarImagen(string url)
        {
            try
            {
                pbxImagen.Load(url);
            }
            catch (Exception ex)
            {
                pbxImagen.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRW1WFWLAdUk4Uf4vzvwezXvAFnh6eCjY5oHw&s");
            }
        }
    }
}

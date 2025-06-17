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
        private Articulo articuloActual = null;
        public frmAgregarArticulo()
        {
            InitializeComponent();
            btnEliminar.Visible = false;
        }

        public frmAgregarArticulo(Articulo unArticulo)
        {
            InitializeComponent();
            Text = "Modificar Artículo";
            btnCrear.Text = "Modificar";
            lblTitulo.Text = "Modificar Artículo";
            this.articuloActual = unArticulo;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            if(this.articuloActual == null)
            {
                articuloActual = new Articulo();
            }
            // Obtener los datos de la Ventana
            articuloActual.CodigoDeArticulo = txtCodigoArticulo.Text;
            articuloActual.Descripcion = txtDescripcion.Text;
            articuloActual.Precio = double.Parse(txtPrecio.Text);
            articuloActual.MarcaDelArticulo = (Marca)cbxMarca.SelectedItem;
            articuloActual.CategoriaDelArticulo = (Categoria)cbxCategoria.SelectedItem;
            articuloActual.Nombre = txtNombre.Text;
            articuloActual.UrlImagen = txtUrlImagen.Text;

            if(articuloActual.Id != 0) {
                negocio.ModificarArticulo(articuloActual);
            }
            else
            {
                negocio.GuardarArticulo(articuloActual);
            }
            Close();
        }

        private void frmAgregarArticulo_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            CargarMarcas();
            if (this.articuloActual != null)
            {
                // Cargar los datos del articulo en la ventana
                txtNombre.Text = articuloActual.Nombre;
                txtPrecio.Text = articuloActual.Precio.ToString();
                txtCodigoArticulo.Text = articuloActual.CodigoDeArticulo;
                txtUrlImagen.Text = articuloActual.UrlImagen;
                txtDescripcion.Text = articuloActual.Descripcion;

                cbxMarca.SelectedValue = articuloActual.MarcaDelArticulo.Id;
                cbxCategoria.SelectedValue = articuloActual.CategoriaDelArticulo.Id;
                CargarImagen(articuloActual.UrlImagen);
            }
        }
        private void CargarMarcas()
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            cbxMarca.DisplayMember = "Descripcion";
            cbxMarca.ValueMember = "Id";
            cbxMarca.DataSource = marcaNegocio.listarMarcas();
            cbxMarca.SelectedIndex = -1;
        }

        private void CargarCategorias(bool esParaNuevoArticulo = false)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            cbxCategoria.DisplayMember = "Descripcion";
            cbxCategoria.ValueMember = "Id";
            cbxCategoria.DataSource = categoriaNegocio.listarCategorias();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            negocio.EliminarEsteArticulo(articuloActual.Id);
            Close();
        }
    }
}

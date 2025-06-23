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
        private ErrorProvider codigoArticuloErrorProvider;
        private ErrorProvider nombreErrorProvider;
        private ErrorProvider precioErrorProvider;

        public frmAgregarArticulo()
        {
            InitializeComponent();
            btnEliminar.Visible = false;
            CargarErrorsProviders();

            // Indique a los errors providers que los campos se encuentran vacios. Para que la aplicacion arranque asi
            codigoArticuloErrorProvider.SetError(this.txtCodigoArticulo, "El codigo es obligatorio");
            nombreErrorProvider.SetError(this.txtNombre, "El nombre es obligatorio");
            precioErrorProvider.SetError(this.txtPrecio, "El precio es obligatorio");
        }

        public frmAgregarArticulo(Articulo unArticulo)
        {
            InitializeComponent();
            Text = "Modificar Artículo";
            btnCrear.Text = "Modificar";
            lblTitulo.Text = "Modificar Artículo";
            this.articuloActual = unArticulo;
            CargarErrorsProviders();
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
            try
            {
                // Obtener los datos de la Ventana
                if (CamposObligatoriosRellenados())
                {
                    articuloActual.CodigoDeArticulo = txtCodigoArticulo.Text;
                    articuloActual.Descripcion = txtDescripcion.Text;
                    articuloActual.Precio = double.Parse(txtPrecio.Text);
                    articuloActual.MarcaDelArticulo = (Marca)cbxMarca.SelectedItem;
                    articuloActual.CategoriaDelArticulo = (Categoria)cbxCategoria.SelectedItem;
                    articuloActual.Nombre = txtNombre.Text;
                    articuloActual.UrlImagen = txtUrlImagen.Text;

                    if (articuloActual.Id != 0)
                    {
                        negocio.ModificarArticulo(articuloActual);
                    }
                    else
                    {
                        negocio.GuardarArticulo(articuloActual);
                    }
                    Close();
                }
                else
                {
                    MessageBox.Show("Debe completar los campos obligatorios (Codigo, Nombre, Precio).", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
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

                if(articuloActual.MarcaDelArticulo != null)
                {
                    cbxMarca.SelectedValue = articuloActual.MarcaDelArticulo.Id;
                }
                if(articuloActual.CategoriaDelArticulo != null)
                {
                    cbxCategoria.SelectedValue = articuloActual.CategoriaDelArticulo.Id;
                }

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
            cbxCategoria.DataSource = categoriaNegocio.ListarCategorias();
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
                pbxImagen.LoadAsync(url);
            }
            catch (Exception ex)
            {
                pbxImagen.Image = Properties.Resources.default_image;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            negocio.EliminarEsteArticulo(articuloActual.Id);
            Close();
        }


        private void CargarErrorsProviders()
        {
            codigoArticuloErrorProvider = new ErrorProvider();
            codigoArticuloErrorProvider.SetIconAlignment(this.txtCodigoArticulo, ErrorIconAlignment.MiddleRight);
            codigoArticuloErrorProvider.SetIconPadding(this.txtCodigoArticulo, 2);
            codigoArticuloErrorProvider.BlinkRate = 200;
            codigoArticuloErrorProvider.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;
            
            nombreErrorProvider = new ErrorProvider();
            nombreErrorProvider.SetIconAlignment(this.txtNombre, ErrorIconAlignment.MiddleRight);
            nombreErrorProvider.SetIconPadding(this.txtNombre, 2);
            nombreErrorProvider.BlinkRate = 200;
            nombreErrorProvider.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;

            precioErrorProvider = new ErrorProvider();
            precioErrorProvider.SetIconAlignment(this.txtPrecio, ErrorIconAlignment.MiddleRight);
            precioErrorProvider.SetIconPadding(this.txtPrecio, 2);
            precioErrorProvider.BlinkRate= 200;
            precioErrorProvider.BlinkStyle |= ErrorBlinkStyle.BlinkIfDifferentError;

            
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            if (!ValidadorFormularios.NoEsVacio(txtPrecio.Text))
            {
                precioErrorProvider.SetError(this.txtPrecio, "El precio es obligatorio");
            }
            else if (!ValidadorFormularios.SoloNumeros(txtPrecio.Text))
            {
                precioErrorProvider.SetError(this.txtPrecio, "Solo se admiten números");
            }
            else
            {
                precioErrorProvider.SetError(this.txtPrecio, String.Empty);
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (!ValidadorFormularios.NoEsVacio(txtNombre.Text))
            {
                nombreErrorProvider.SetError(this.txtNombre, "El nombre es obligatorio");
            }
            else if (!ValidadorFormularios.TieneAlMenosUnCaracter(txtNombre.Text))
            {
                nombreErrorProvider.SetError(this.txtNombre, "Debe tener caracteres");
            }
            else
            {
                nombreErrorProvider.SetError(this.txtNombre, String.Empty);
            }
        }

        private void txtCodigoArticulo_TextChanged(object sender, EventArgs e)
        {
            if (!ValidadorFormularios.NoEsVacio(txtCodigoArticulo.Text))
            {
                codigoArticuloErrorProvider.SetError(this.txtCodigoArticulo, "El codigo es obligatorio");
            }
            else if (!ValidadorFormularios.SinEspacios(txtCodigoArticulo.Text))
            {
                codigoArticuloErrorProvider.SetError(this.txtCodigoArticulo, "No puede contener espacios");
            }
            else
            {
                codigoArticuloErrorProvider.SetError(this.txtCodigoArticulo, String.Empty);
            }
        }

        private bool CamposObligatoriosRellenados()
        {
            // Checkear los 3 campos obligatorios: nombre, codigo , precio.
            // Si los errorProviders estan vacios, quiere decir que los campos estan completos y validados
            if(codigoArticuloErrorProvider.GetError(this.txtCodigoArticulo) == String.Empty &&
                nombreErrorProvider.GetError(this.txtNombre) == String.Empty &&
                precioErrorProvider.GetError(this.txtPrecio) == String.Empty)
            {
                return true;
            }

            return false;
        }

    }
}

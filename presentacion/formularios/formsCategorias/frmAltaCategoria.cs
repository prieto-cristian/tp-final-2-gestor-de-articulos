using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion.formularios.formsCategorias
{
    public partial class frmAltaCategoria : Form
    {
        private ErrorProvider txtDescripcionErrorProvider;
        private CategoriaNegocio negocio;
        private Categoria categoriaSeleccionada = null;
        public frmAltaCategoria()
        {
            InitializeComponent();
            CargarYConfigurarErrorProvider();
            this.negocio = new CategoriaNegocio();
        }

        public frmAltaCategoria(Categoria categoria)
        {
            InitializeComponent();
            CargarYConfigurarErrorProvider();
            this.negocio = new CategoriaNegocio();
            this.categoriaSeleccionada = categoria;
            Text = "Modificar Categoria";
            btnCrear.Text = "Modificar";
            txtDescripcion.Text = categoria.Descripcion;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (!ValidadorFormularios.NoEsVacio(txtDescripcion.Text))
            {
                txtDescripcionErrorProvider.SetError(txtDescripcion, "El campo no puede estar vacio");
            }
            else if (!ValidadorFormularios.TieneAlMenosUnCaracter(txtDescripcion.Text))
            {
                txtDescripcionErrorProvider.SetError(txtDescripcion, "El campo debe tener al menos 1 caracter");
            }
            else
            {
                try
                {
                    if (categoriaSeleccionada != null)
                    {
                        negocio.ModificarCategoria(categoriaSeleccionada.Id, txtDescripcion.Text);
                    }
                    else
                    {
                        negocio.CrearCategoria(txtDescripcion.Text);
                    }
                    Close();
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        private void CargarYConfigurarErrorProvider()
        {
            txtDescripcionErrorProvider = new ErrorProvider();
            txtDescripcionErrorProvider.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;
            txtDescripcionErrorProvider.SetIconAlignment(txtDescripcion, ErrorIconAlignment.MiddleRight);
            txtDescripcionErrorProvider.BlinkRate = 200;
            txtDescripcionErrorProvider.SetIconPadding(txtDescripcion, 2);
        }
    }
}

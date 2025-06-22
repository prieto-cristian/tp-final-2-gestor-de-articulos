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
using dominio;

namespace presentacion.formularios.formsMarcas
{
    public partial class frmAltaMarca : Form
    {
        private Marca marcaAModificar = null;
        private ErrorProvider txtDescripcionErrorProvider; 
        public frmAltaMarca()
        {
            InitializeComponent();
            CrearYConfigurarErrorsProviders();
        }

        private void CrearYConfigurarErrorsProviders()
        {
            // Cree y configure los ErrorProvider para la entrada de datos.
            txtDescripcionErrorProvider = new ErrorProvider();
            txtDescripcionErrorProvider.SetIconAlignment(this.txtDescripcionMarca, ErrorIconAlignment.MiddleRight);
            txtDescripcionErrorProvider.SetIconPadding(this.txtDescripcionMarca, 2);
            txtDescripcionErrorProvider.BlinkRate = 200;
            txtDescripcionErrorProvider.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;
        }

        public frmAltaMarca(Marca marca)
        {
            InitializeComponent();
            Text = "Modificación de Ventana";
            btnCrear.Text = "Modificar";
            this.marcaAModificar = marca;
            txtDescripcionMarca.Text = marca.Descripcion;
            CrearYConfigurarErrorsProviders();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                if (!ValidadorFormularios.NoEsVacio(txtDescripcionMarca.Text))
                {
                    txtDescripcionErrorProvider.SetError(txtDescripcionMarca, "El campo no puede estar vacío");
                }
                else if (!ValidadorFormularios.TieneAlMenosUnCaracter(txtDescripcionMarca.Text))
                {
                    txtDescripcionErrorProvider.SetError(txtDescripcionMarca, "Debe tener al menos 1 caracter");
                }
                else
                {
                    if(marcaAModificar == null)
                    {
                        negocio.GuardarMarca(txtDescripcionMarca.Text);
                    }
                    else
                    {
                        negocio.ModificarMarca(marcaAModificar.Id, txtDescripcionMarca.Text);
                    }
                    Close();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

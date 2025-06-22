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
using presentacion.formularios.formsCategorias;

namespace presentacion
{
    public partial class frmListadoCategoria : Form
    {
        private CategoriaNegocio negocio;
        public frmListadoCategoria()
        {
            InitializeComponent();
            this.negocio = new CategoriaNegocio();
        }

        private void frmListadoCategoria_Load(object sender, EventArgs e)
        {
            ListarCategorias();
        }
        private void ListarCategorias()
        {
            List<Categoria> listaCategorias = negocio.listarCategorias();
            dgvCategorias.DataSource = listaCategorias;
            dgvCategorias.Columns["Id"].Visible = false;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            frmAltaCategoria frmAltaCategoria = new frmAltaCategoria();
            frmAltaCategoria.ShowDialog();
            ListarCategorias();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(dgvCategorias.CurrentRow != null)
            {
                Categoria categoria = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                frmAltaCategoria modificarCategoria = new frmAltaCategoria(categoria);
                modificarCategoria.ShowDialog();
                ListarCategorias();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias != null)
            {
                Categoria categoria = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                try
                {
                    if (categoria.CantidadDeArticulosAsociados > 0)
                    {
                        DialogResult resultado = MessageBox.Show("La categoria '"+ categoria.Descripcion + "' tiene articulos asociados, quiere eliminarla?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (resultado == DialogResult.Yes) {
                            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
                            negocio.EliminarCategoria(categoria.Id);
                            articuloNegocio.DesvincularCategoria(categoria.Id);
                        }
                    }
                    else
                    {
                        negocio.EliminarCategoria(categoria.Id);
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    ListarCategorias();
                }
            }
        }
    }
}

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
using presentacion.formularios.formsMarcas;

namespace presentacion
{
    public partial class frmListadoMarcas : Form
    {
        public frmListadoMarcas()
        {
            InitializeComponent();
        }

        private void frmListadoMarcas_Load(object sender, EventArgs e)
        {
            // Traer las marcas y listarlas en el data grid view.
            MarcaNegocio negocio = new MarcaNegocio();
            List<Marca> marcas = negocio.listarMarcas();

            dgvMarcas.DataSource = marcas;
            dgvMarcas.Columns["Id"].Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAltaMarca frmAltaMarca = new frmAltaMarca();
            frmAltaMarca.ShowDialog();
            ActualizarListado();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            frmAltaMarca frmAltaMarca = new frmAltaMarca();
            frmAltaMarca.ShowDialog();
            ActualizarListado();
        }

        private void ActualizarListado()
        {
            MarcaNegocio negocio = new MarcaNegocio();
            List<Marca> marcas = negocio.listarMarcas();
            dgvMarcas.DataSource = marcas;
            dgvMarcas.Columns["Id"].Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Marca marcaAMoficar = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
            frmAltaMarca frmModificacion = new frmAltaMarca(marcaAMoficar);
            frmModificacion.ShowDialog();
            ActualizarListado();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Si la marca no tiene articulos asociados se borra directamente sino pregunta
            if(dgvMarcas.CurrentRow != null)
            {
                MarcaNegocio negocio = new MarcaNegocio();
                Marca marcaAEliminar = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                if(marcaAEliminar.CantidadDeArticulosAsociados > 0)
                {
                    DialogResult respuesta = MessageBox.Show("La marca esta asociada a mas de 1 articulo, quiere eliminarla?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes) {
                        negocio.EliminarMarca(marcaAEliminar.Id);
                        ArticuloNegocio articuloNegocio = new ArticuloNegocio();
                        articuloNegocio.DesvincularMarca(marcaAEliminar.Id);
                    }
                }
                else
                {
                    negocio.EliminarMarca(marcaAEliminar.Id);
                }
                ActualizarListado();
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            if (txtFiltro.Text.Length > 2)
            {
                MarcaNegocio negocio = new MarcaNegocio();
                List<Marca> marcas = negocio.listarMarcas(txtFiltro.Text);
                dgvMarcas.DataSource = marcas;
                dgvMarcas.Columns["Id"].Visible = false;

            }
            else
            {
                ActualizarListado();
            }
        }
    }
}

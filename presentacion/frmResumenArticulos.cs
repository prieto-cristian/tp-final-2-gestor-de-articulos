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
    public partial class frmResumenArticulos : Form
    {
        public frmResumenArticulos()
        {
            InitializeComponent();
        }

        private void frmResumenArticulos_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo articuloMasBarato = negocio.ObtenerArticuloMasBarato();
            Articulo articuloMasCaro = negocio.ObtenerArticuloMasCaro();


            tpArticuloMasBarato.asignarArticulo(articuloMasBarato);
            tpArticuloMasCaro.asignarArticulo(articuloMasCaro);

            // Mostrar la cantidad de articulos que hay guardados en base de datos
            lblNumeroArticulos.Text = negocio.ContarArticulos().ToString();
        }
    }
}

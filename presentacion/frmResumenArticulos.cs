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
            Articulo articulo_1 = new Articulo("https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/373.png",
                2882.1283,
                "Metagross");

            Articulo articulo_2 = new Articulo("https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/376.png",
                123.2,
                "Salamance");

            tpArticuloMasBarato.asignarArticulo(articulo_2);
            tpArticuloMasCaro.asignarArticulo(articulo_1);
        }
    }
}

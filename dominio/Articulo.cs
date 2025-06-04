using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    internal class Articulo
    {
        public int Id { get; set; }
        public int CodigoDeArticulo { get; set; }
        public int Nombre { get; set; }
        public string Descripcion { get; set; }
        public Marca MarcaDelArticulo { get; set; }
        public Categoria CategoriaDelArticulo { get; set; }
        public string UrlImagen { get; set; }
        public double Precio { get; set; }


    }
}

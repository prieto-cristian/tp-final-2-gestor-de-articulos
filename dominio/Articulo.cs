using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        public int Id { get; set; }
        public string CodigoDeArticulo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Marca MarcaDelArticulo { get; set; }
        public Categoria CategoriaDelArticulo { get; set; }
        public string UrlImagen { get; set; }
        public double Precio { get; set; }

        public Articulo() { }
        public Articulo(string url, double precio, string nombre)
        {
            this.UrlImagen = url;
            this.Precio = precio;
            this.Nombre = nombre;
        }

    }
}

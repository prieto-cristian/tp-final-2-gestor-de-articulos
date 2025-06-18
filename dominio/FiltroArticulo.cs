using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class FiltroArticulo
    {
        public string OrdenarPor { get; set; } = "ASC";
        public string cadenaDeTextoABuscar { get; set; } = "";
        public Marca marcaAFiltrar { get; set; }
        public Categoria categoriaAFiltrar { get; set; }
        public RangoPrecios PorRangoDePrecios { get; set; }
        // TipoDeRangoPrecio tiene 4 posibilidades.
        // 1: productos con precio menor o igual al precio inferior
        // 2: productos con precio entre los 2 precios
        // 3: productoso con precio mayor al superior
        // NULL : sin filtro de precio
        public int? TipoDeRangoPrecio   { get; set; }
    }
}

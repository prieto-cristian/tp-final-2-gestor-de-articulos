using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Categoria
    {
        public int Id { get; set; }
        [DisplayName("Categoria")]
        public string Descripcion { get; set; }
        [DisplayName("Cantidad de Articulos asociados")]
        public int CantidadDeArticulosAsociados {  get; set; }
        public override string ToString()
        {
            return Descripcion;
        }
    }
}

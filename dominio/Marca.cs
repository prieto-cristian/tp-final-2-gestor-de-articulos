using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Marca
    {
        public int Id { get; set; }
        [DisplayName("Marcas")]
        public string Descripcion {  get; set; }
        [DisplayName("Cantidad de Articulos Asociados")]        
        
        public int CantidadDeArticulosAsociados {  get; set; }
        public override string ToString()
        {
            return Descripcion;
        }
    }
}

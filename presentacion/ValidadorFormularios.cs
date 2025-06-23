using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presentacion
{
    public static class ValidadorFormularios
    {
        public static bool PrecioValido(string texto)
        {
            try
            {
                double precioValido = double.Parse(texto);
                return true;
            }
            catch (Exception ex) { 
                return false;
            }
        }
        public static bool SinEspacios(string texto)
        {
            foreach (char c in texto) {
                if (char.IsWhiteSpace(c))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool NoEsVacio(string texto) { 
            return !string.IsNullOrEmpty(texto);
        }

        public static bool TieneAlMenosUnCaracter(string texto) {
            foreach (char c in texto) {
                if (!char.IsWhiteSpace(c))
                {
                    return true;
                }
            }
            return false;
        }
    }
}

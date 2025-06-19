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
        public static bool SoloNumeros(string texto)
        {
            foreach (char c in texto) {
                if (!(char.IsNumber(c)))
                {
                    return false;
                }
            }
            return true;
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

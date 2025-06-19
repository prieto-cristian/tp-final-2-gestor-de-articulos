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
        public static bool EsTextoValido(string texto)
        {
            if ((string.IsNullOrEmpty(texto)) || (string.IsNullOrWhiteSpace(texto)))
            {
                return false;
            }
            return true;
        }

    }
}

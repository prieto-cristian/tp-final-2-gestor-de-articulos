using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class MarcaNegocio{
        private AccesoADatos datos;

        public MarcaNegocio()
        {
            this.datos = new AccesoADatos();
        }

        public List<Marca> listarMarcas()
        {
            string consultaSQL = "Select Id, Descripcion from MARCAS";
            List<Marca> marcas = new List<Marca>();
            try
            {
                datos.setearConsulta(consultaSQL);
                datos.ejecutarAccion();
                while (datos.Lector.Read())
                {
                    Marca auxMarca = new Marca();
                    auxMarca.Id = (int)datos.Lector["Id"];
                    auxMarca.Descripcion = (string)datos.Lector["Descripcion"];

                    marcas.Add(auxMarca);
                }
                return marcas;
            }
            catch (Exception ex) { throw ex; }
            finally { datos.cerrarConexion(); }
        }
    }
}

using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class CategoriaNegocio
    {
        private AccesoADatos datos = null;


        public List<Categoria> listarCategorias()
        {
            string consultaSQL = "SELECT Id, Descripcion FROM CATEGORIAS";
            datos = new AccesoADatos();
            try
            {
                List<Categoria> categorias = new List<Categoria>();
                datos.setearConsulta(consultaSQL);
                datos.ejecutarAccion();
                while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    categorias.Add(aux);
                }

                return categorias;
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}

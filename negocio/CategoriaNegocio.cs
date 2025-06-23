using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class CategoriaNegocio
    {
        private AccesoADatos datos = null;


        public List<Categoria> ListarCategorias()
        {
            string consultaSQL = "SELECT    C.Id,    C.Descripcion,     COUNT(A.Id) AS CantidadArticulos FROM CATEGORIAS C LEFT JOIN ARTICULOS A ON A.IdCategoria = C.Id GROUP BY C.Id, C.Descripcion ORDER BY CantidadArticulos DESC";
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
                    aux.CantidadDeArticulosAsociados = (int)datos.Lector["CantidadArticulos"];
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

        public void CrearCategoria(string descripcion)
        {
            string consultaSQL = "insert into CATEGORIAS (Descripcion) Values (@Descripcion)";
            try
            {
                datos = new AccesoADatos();
                datos.setearConsulta(consultaSQL);
                datos.parametrizar("@Descripcion", descripcion);
                datos.ejecutarAccion();
            }
            catch(Exception ex) { throw ex; }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void ModificarCategoria(int id, string descripcion) {
            string consultaSQL = "update CATEGORIAS set Descripcion = @Descripcion Where Id = @Id";
            try
            {
                datos = new AccesoADatos();
                datos.setearConsulta(consultaSQL);
                datos.parametrizar("@Descripcion", descripcion);
                datos.parametrizar("@Id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex) { throw ex; }
            finally { datos.cerrarConexion(); }
        }
        public void EliminarCategoria(int id)
        {
            string consultaSQL = "DELETE FROM CATEGORIAS WHERE Id = @Id";
            try
            {
                datos = new AccesoADatos();
                datos.setearConsulta(consultaSQL);
                datos.parametrizar("@Id", id);
                datos.ejecutarAccion();
            }
            catch( Exception ex) { throw ex; }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public List<Categoria> ListarCategorias(string fragmento)
        {
            string consultaSQL = "SELECT C.Id, C.Descripcion, COUNT(A.Id) AS CantidadArticulos FROM CATEGORIAS C LEFT JOIN ARTICULOS A ON A.IdCategoria = C.Id WHERE C.Descripcion LIKE '%' + @Fragmento + '%' GROUP BY C.Id, C.Descripcion ORDER BY CantidadArticulos DESC;";
            try
            {
                datos = new AccesoADatos();
                datos.setearConsulta(consultaSQL);
                datos.parametrizar("@Fragmento", fragmento);
                datos.ejecutarAccion();
                List<Categoria> categorias = new List<Categoria>();
                while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Id = (int)datos.Lector["Id"];
                    aux.CantidadDeArticulosAsociados = (int)datos.Lector["CantidadArticulos"];

                    categorias.Add(aux);
                }
                return categorias;
            }
            catch (Exception ex) { throw ex; }
            finally { datos.cerrarConexion(); }
        }
    }
}

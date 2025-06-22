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
            string consultaSQL = "SELECT    M.Id,    M.Descripcion,     COUNT(A.Id) AS CantidadArticulos FROM MARCAS M LEFT JOIN ARTICULOS A ON A.IdMarca = M.Id GROUP BY M.Id, M.Descripcion ORDER BY CantidadArticulos DESC;";
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
                    auxMarca.CantidadDeArticulosAsociados = (int)datos.Lector["CantidadArticulos"];
                    marcas.Add(auxMarca);
                }
                return marcas;
            }
            catch (Exception ex) { throw ex; }
            finally { datos.cerrarConexion(); }
        }

        public string MarcaConMasArticulos()
        {
            string consultaSQL = "SELECT TOP 1 M.Descripcion FROM MARCAS M JOIN ARTICULOS A ON M.Id = A.idMarca GROUP BY M.Id, M.Descripcion ORDER BY COUNT(*) DESC;";
            try
            {
                datos.setearConsulta(consultaSQL);
                datos.ejecutarAccion();
                string resultado = "";
                while (datos.Lector.Read())
                {
                    resultado = (string)datos.Lector["Descripcion"];
                }
                return resultado;
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void GuardarMarca(string descripcion)
        {
            string consultarSQL = "insert into MARCAS (Descripcion) VALUES (@Descripcion)";
            try
            {
                datos.setearConsulta(consultarSQL);
                datos.parametrizar("@Descripcion", descripcion);
                datos.ejecutarAccion();
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void ModificarMarca(int id, string nuevaDescripcion)
        {
            string consultaSQL = "update MARCAS set Descripcion = @Descripcion WHERE Id = @Id";
            try
            {
                datos.setearConsulta(consultaSQL);
                datos.parametrizar("@Descripcion", nuevaDescripcion);
                datos.parametrizar("@Id", id);
                datos.ejecutarAccion();
            }
            catch(Exception ex) { throw ex; }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void EliminarMarca(int id)
        {
            string consultaSQL = "DELETE FROM MARCAS WHERE Id = @Id";
            try
            {
                datos.setearConsulta(consultaSQL);
                datos.parametrizar("@Id", id);
                datos.ejecutarAccion();
            }
            catch(Exception e) { throw e; }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}

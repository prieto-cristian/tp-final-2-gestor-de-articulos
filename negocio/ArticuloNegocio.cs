using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {
        private AccesoADatos datos;
        public ArticuloNegocio()
        {
            this.datos = new AccesoADatos();
        }
        public List<Articulo> listarArticulos()
        {
            string consultaSQL = "select A.Id, A.Codigo, A.Descripcion, A.ImagenUrl, A.Nombre, A.Precio, M.Id idMarca, M.Descripcion descripcionMarca, C.Id idCategoria, C.Descripcion descripcionCategorias From ARTICULOS A, MARCAS M, CATEGORIAS C WHERE A.IdMarca = M.Id AND A.IdCategoria = C.Id";
            List<Articulo> articulos = new List<Articulo>();
            try
            {
                datos.setearConsulta(consultaSQL);
                datos.ejecutarAccion();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Precio = Decimal.ToDouble((decimal)datos.Lector["Precio"]);
                    aux.UrlImagen = (string)datos.Lector["ImagenUrl"];
                    aux.CodigoDeArticulo = (string)datos.Lector["Codigo"];

                    Marca auxMarca = new Marca();
                    auxMarca.Id = (int)datos.Lector["idMarca"];
                    auxMarca.Descripcion = (string)datos.Lector["descripcionMarca"];

                    Categoria auxCategoria = new Categoria();
                    auxCategoria.Id = (int)datos.Lector["idCategoria"];
                    auxCategoria.Descripcion = (string)datos.Lector["descripcionCategorias"];

                    aux.MarcaDelArticulo = auxMarca;
                    aux.CategoriaDelArticulo = auxCategoria;

                    articulos.Add(aux);
                }
                return articulos;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}

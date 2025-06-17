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
        public List<Articulo> listarArticulos(FiltroArticulo filtroActivo)
        {
            string consultaSQL = "SELECT A.Id, A.Codigo, A.Descripcion, A.ImagenUrl, A.Nombre, A.Precio, M.Id AS idMarca, M.Descripcion AS descripcionMarca, C.Id AS idCategoria, C.Descripcion AS descripcionCategorias FROM ARTICULOS A, MARCAS M, CATEGORIAS C WHERE A.IdMarca = M.Id AND A.IdCategoria = C.Id AND (@IdMarcaAFiltrar IS NULL OR M.Id = @IdMarcaAFiltrar) AND (@IdCategoriaAFiltrar IS NULL OR C.Id = @IdCategoriaAFiltrar) ORDER BY A.Precio ";
            consultaSQL += filtroActivo.OrdenarPor;
            
            List<Articulo> articulos = new List<Articulo>();
            try
            {
                datos.setearConsulta(consultaSQL);
                if(filtroActivo.marcaAFiltrar != null)
                {
                    datos.parametrizar("@IdMarcaAFiltrar", filtroActivo.marcaAFiltrar.Id);
                }
                else
                {
                    datos.parametrizar("@IdMarcaAFiltrar");
                }

                if(filtroActivo.categoriaAFiltrar != null)
                {
                    datos.parametrizar("@IdCategoriaAFiltrar", filtroActivo.categoriaAFiltrar.Id);
                }
                else
                {
                    datos.parametrizar("@IdCategoriaAFiltrar");
                }
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

        public void GuardarArticulo(Articulo unArticulo)
        {
            string consultaSQL = "insert into ARTICULOS (Codigo, Descripcion, ImagenUrl, Nombre, Precio, IdMarca, IdCategoria) VALUES (@Codigo, @Descripcion, @ImagenUrl, @Nombre,@Precio, @IdMarca, @IdCategoria)";
            try
            {
                datos.setearConsulta(consultaSQL);
                datos.parametrizar("@Codigo", unArticulo.CodigoDeArticulo);
                datos.parametrizar("@Descripcion", unArticulo.Descripcion);
                datos.parametrizar("@ImagenUrl", unArticulo.UrlImagen);
                datos.parametrizar("@Nombre", unArticulo.Nombre);
                datos.parametrizar("@Precio", (decimal)unArticulo.Precio);
                datos.parametrizar("@IdMarca", unArticulo.MarcaDelArticulo.Id);
                datos.parametrizar("@IdCategoria", unArticulo.CategoriaDelArticulo.Id);

                datos.guardar();
            }
            catch(Exception ex) { throw ex; }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void ModificarArticulo(Articulo unArticulo)
        {
            string consultaSQL = "UPDATE ARTICULOS SET Codigo = @Codigo, Nombre = @Nombre,Descripcion = @Descripcion,IdMarca = @IdMarca, IdCategoria = @IdCategoria,ImagenUrl = @UrlImagen, Precio = @Precio WHERE Id = @Id";
            try
            {
                datos.setearConsulta(consultaSQL);
                datos.parametrizar("@Codigo", unArticulo.CodigoDeArticulo);
                datos.parametrizar("@Nombre", unArticulo.Nombre);
                datos.parametrizar("@Descripcion", unArticulo.Descripcion);
                datos.parametrizar("@IdMarca", unArticulo.MarcaDelArticulo.Id);
                datos.parametrizar("@IdCategoria", unArticulo.CategoriaDelArticulo.Id);
                datos.parametrizar("@UrlImagen", unArticulo.UrlImagen);
                datos.parametrizar("@Precio", unArticulo.Precio);
                datos.parametrizar("@Id", unArticulo.Id);

                datos.ejecutarAccion();
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                datos.cerrarConexion();
            }


        }

        public void EliminarEsteArticulo(int Id)
        {
            string consultaSQL = "DELETE FROM ARTICULOS WHERE Id = @Id";
            try
            {
                datos.setearConsulta(consultaSQL);
                datos.parametrizar("@Id", Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                datos.cerrarConexion();
            }
        }
        
        public Articulo ObtenerArticuloMasBarato()
        {
            string consultaSQL = "select TOP 1 A.Id, A.Codigo, A.Descripcion, A.ImagenUrl, A.Nombre, A.Precio, M.Id idMarca, M.Descripcion descripcionMarca, C.Id idCategoria, C.Descripcion descripcionCategorias From ARTICULOS A, MARCAS M, CATEGORIAS C WHERE A.IdMarca = M.Id AND A.IdCategoria = C.Id ORDER BY Precio ASC";
            Articulo aux = new Articulo();
            try
            {
                datos.setearConsulta(consultaSQL);
                datos.ejecutarAccion();

                while (datos.Lector.Read())
                {
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

                    aux.CategoriaDelArticulo = auxCategoria;
                    aux.MarcaDelArticulo = auxMarca;
                }

                return aux;
            }
            catch(Exception ex) { throw ex; }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public Articulo ObtenerArticuloMasCaro()
        {
            string consultaSQL = "select TOP 1 A.Id, A.Codigo, A.Descripcion, A.ImagenUrl, A.Nombre, A.Precio, M.Id idMarca, M.Descripcion descripcionMarca, C.Id idCategoria, C.Descripcion descripcionCategorias From ARTICULOS A, MARCAS M, CATEGORIAS C WHERE A.IdMarca = M.Id AND A.IdCategoria = C.Id ORDER BY Precio DESC";
            Articulo aux = new Articulo();
            try
            {
                datos.setearConsulta(consultaSQL);
                datos.ejecutarAccion();

                while (datos.Lector.Read())
                {
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

                    aux.CategoriaDelArticulo = auxCategoria;
                    aux.MarcaDelArticulo = auxMarca;
                }

                return aux;
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public int ContarArticulos()
        {
            string consultaSQL = "Select COUNT(*) Cantidad from ARTICULOS";
            try
            {
                datos.setearConsulta(consultaSQL);
                datos.ejecutarAccion();
                int resultado = 0;
                while (datos.Lector.Read()) { 
                    resultado = (int)datos.Lector["Cantidad"];
                }
                return resultado;
            }
            catch(Exception ex) { throw ex; }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}

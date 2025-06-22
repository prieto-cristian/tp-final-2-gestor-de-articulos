using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
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
            string consultaSQL = "SELECT A.Id, A.Codigo, A.Descripcion, A.ImagenUrl, A.Nombre, A.Precio, M.Id AS idMarca, M.Descripcion AS descripcionMarca, C.Id AS idCategoria, C.Descripcion AS descripcionCategorias FROM ARTICULOS A LEFT JOIN MARCAS M ON A.IdMarca = M.Id LEFT JOIN CATEGORIAS C ON A.IdCategoria = C.Id WHERE (@IdMarcaAFiltrar IS NULL OR M.Id = @IdMarcaAFiltrar) AND (@IdCategoriaAFiltrar IS NULL OR C.Id = @IdCategoriaAFiltrar) AND ( @TipoDeRango IS NULL OR (@TipoDeRango = 1 AND A.Precio <= @PrecioInferior) OR (@TipoDeRango = 2 AND A.Precio > @PrecioInferior AND A.Precio <= @PrecioSuperior) OR (@TipoDeRango = 3 AND A.Precio > @PrecioSuperior) ) AND (@TextoNombre IS NULL OR A.Nombre LIKE '%' + @TextoNombre + '%') ORDER BY A.Precio ";
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
                if (filtroActivo.TipoDeRangoPrecio != null)
                {
                    datos.parametrizar("@TipoDeRango", filtroActivo.TipoDeRangoPrecio);
                    if(filtroActivo.TipoDeRangoPrecio == 1)
                    {
                        datos.parametrizar("@PrecioInferior", filtroActivo.PorRangoDePrecios.PrecioInferior);
                        datos.parametrizar("@PrecioSuperior");
                    }
                    else if(filtroActivo.TipoDeRangoPrecio == 2)
                    {
                        datos.parametrizar("@PrecioInferior", filtroActivo.PorRangoDePrecios.PrecioInferior);
                        datos.parametrizar("@PrecioSuperior", filtroActivo.PorRangoDePrecios.PreccioSuperior);
                    }
                    else
                    {
                        datos.parametrizar("@PrecioSuperior", filtroActivo.PorRangoDePrecios.PreccioSuperior);
                        datos.parametrizar("@PrecioInferior");
                    }
                }
                else
                {
                    datos.parametrizar("@TipoDeRango");
                    datos.parametrizar("@PrecioInferior");
                    datos.parametrizar("@PrecioSuperior");
                }
                if(filtroActivo.cadenaDeTextoABuscar == "")
                {
                    datos.parametrizar("@TextoNombre");
                }
                else
                {
                    datos.parametrizar("@TextoNombre", filtroActivo.cadenaDeTextoABuscar);
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

                    if (!(datos.Lector["idMarca"] is DBNull))
                    {
                        Marca auxMarca = new Marca();
                        auxMarca.Id = (int)datos.Lector["idMarca"];
                        auxMarca.Descripcion = (string)datos.Lector["descripcionMarca"];
                        aux.MarcaDelArticulo = auxMarca;
                    }

                    if (!(datos.Lector["idCategoria"] is DBNull))
                    {
                        Categoria auxCategoria = new Categoria();
                        auxCategoria.Id = (int)datos.Lector["idCategoria"];
                        auxCategoria.Descripcion = (string)datos.Lector["descripcionCategorias"];
                        aux.CategoriaDelArticulo = auxCategoria;
                    }

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
                datos.parametrizar("@Precio", (decimal)unArticulo.Precio);
                datos.parametrizar("@Nombre", unArticulo.Nombre);
                datos.parametrizar("@Descripcion", unArticulo.Descripcion);
                datos.parametrizar("@ImagenUrl", unArticulo.UrlImagen);
                if(unArticulo.MarcaDelArticulo != null)
                {
                    datos.parametrizar("@IdMarca", unArticulo.MarcaDelArticulo.Id);

                }
                else
                {
                    datos.parametrizar("@IdMarca");
                }
                if(unArticulo.CategoriaDelArticulo != null)
                {
                    datos.parametrizar("@IdCategoria", unArticulo.CategoriaDelArticulo.Id);
                }
                else
                {
                    datos.parametrizar("@IdCategoria");
                }
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
                if (unArticulo.MarcaDelArticulo != null)
                {
                    datos.parametrizar("@IdMarca", unArticulo.MarcaDelArticulo.Id);

                }
                else
                {
                    datos.parametrizar("@IdMarca");
                }
                if (unArticulo.CategoriaDelArticulo != null)
                {
                    datos.parametrizar("@IdCategoria", unArticulo.CategoriaDelArticulo.Id);
                }
                else
                {
                    datos.parametrizar("@IdCategoria");
                }
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
            string consultaSQL = "SELECT TOP 1 A.Id, A.Codigo, A.Descripcion, A.ImagenUrl, A.Nombre, A.Precio, M.Id AS idMarca, M.Descripcion AS descripcionMarca, C.Id AS idCategoria, C.Descripcion AS descripcionCategorias FROM ARTICULOS A LEFT JOIN MARCAS M ON A.IdMarca = M.Id LEFT JOIN CATEGORIAS C ON A.IdCategoria = C.Id ORDER BY A.Precio ASC";
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

                    if (!(datos.Lector["idMarca"] is DBNull))
                    {
                        Marca auxMarca = new Marca();
                        auxMarca.Id = (int)datos.Lector["idMarca"];
                        auxMarca.Descripcion = (string)datos.Lector["descripcionMarca"];
                        aux.MarcaDelArticulo = auxMarca;
                    }

                    if (!(datos.Lector["idCategoria"] is DBNull))
                    {
                        Categoria auxCategoria = new Categoria();
                        auxCategoria.Id = (int)datos.Lector["idCategoria"];
                        auxCategoria.Descripcion = (string)datos.Lector["descripcionCategorias"];
                        aux.CategoriaDelArticulo = auxCategoria;
                    }
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
            string consultaSQL = "SELECT TOP 1 \r\n    A.Id, \r\n    A.Codigo, \r\n    A.Descripcion, \r\n    A.ImagenUrl, \r\n    A.Nombre, \r\n    A.Precio, \r\n    M.Id AS idMarca, \r\n    M.Descripcion AS descripcionMarca, \r\n    C.Id AS idCategoria, \r\n    C.Descripcion AS descripcionCategorias\r\nFROM ARTICULOS A\r\nLEFT JOIN MARCAS M ON A.IdMarca = M.Id\r\nLEFT JOIN CATEGORIAS C ON A.IdCategoria = C.Id\r\nORDER BY A.Precio DESC";
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

                    if (!(datos.Lector["idMarca"] is DBNull))
                    {
                        Marca auxMarca = new Marca();
                        auxMarca.Id = (int)datos.Lector["idMarca"];
                        auxMarca.Descripcion = (string)datos.Lector["descripcionMarca"];
                        aux.MarcaDelArticulo = auxMarca;
                    }

                    if (!(datos.Lector["idCategoria"] is DBNull) )
                    {
                        Categoria auxCategoria = new Categoria();
                        auxCategoria.Id = (int)datos.Lector["idCategoria"];
                        auxCategoria.Descripcion = (string)datos.Lector["descripcionCategorias"];
                        aux.CategoriaDelArticulo = auxCategoria;
                    }
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

        // Metodo que se utilizar para el filtro por rango de precios.
        public RangoPrecios obtenerRangosDePrecios()
        {
            string consultaSQL = "SELECT TOP 1 PERCENTILE_CONT(0.33) WITHIN GROUP (ORDER BY Precio) OVER () AS PrecioInferior, PERCENTILE_CONT(0.66) WITHIN GROUP (ORDER BY Precio) OVER () AS PrecioSuperior FROM ARTICULOS";
            try
            {
                RangoPrecios rangoAux = new RangoPrecios();
                datos.setearConsulta(consultaSQL);
                datos.ejecutarAccion();
                while (datos.Lector.Read())
                {
                    rangoAux.PrecioInferior = (double)datos.Lector["PrecioInferior"];
                    rangoAux.PreccioSuperior = (double)datos.Lector["PrecioSuperior"];
                }
                return rangoAux;
            }
            catch(Exception ex) { throw ex; }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void DesvincularMarca(int IdMarcaADesvincular)
        {
            string consultaSQL = "update ARTICULOS set IdMarca = NULL WHERE IdMarca = @IdMarca";
            try
            {
                datos.setearConsulta(consultaSQL);
                datos.parametrizar("@IdMarca", IdMarcaADesvincular);
                datos.ejecutarAccion();
            }
            catch( Exception ex) { throw ex; }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void DesvincularCategoria(int IdCategoria) {
            string consultaSQL = "update ARTICULOS set IdCategoria = NULL WHERE IdCategoria = @IdCategoria";
            try
            {
                datos.setearConsulta(consultaSQL);
                datos.parametrizar("@IdCategoria", IdCategoria);
                datos.ejecutarAccion();
            }catch( Exception ex) { throw ex; }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}

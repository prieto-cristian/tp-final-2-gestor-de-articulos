using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    internal class AccesoADatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public SqlDataReader Lector { get { return this.lector; } }

        public AccesoADatos() {
            this.conexion = new SqlConnection("server=.\\SQLEXPRESS; Database=CATALOGO_DB; Integrated Security=true;");
            this.comando = new SqlCommand();
            comando.Connection = conexion;
        }

        
        public void setearConsulta(string consultaSQL)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consultaSQL;
        }

        public void ejecutarAccion()
        {
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void cerrarConexion()
        {
            if(lector != null)
            {
                lector.Close();
            }
            conexion.Close();
        }

        public void guardar() {
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void parametrizar(string nombreParametro, object valor) { 
            comando.Parameters.AddWithValue(nombreParametro, valor);
        }
    }
}

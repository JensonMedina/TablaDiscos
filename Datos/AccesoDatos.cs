using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    public class AccesoDatos
    {
        private SqlConnection Conexion = new SqlConnection();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader Lector;
        public SqlDataReader lector
        {
            get { return Lector; }
        }
        public AccesoDatos()
        {
            Conexion = new SqlConnection("Server=.\\SQLEXPRESS; database=DISCOS_DB; integrated security=true");
            Comando = new SqlCommand();
        }
        public void SetConsulta(string Consulta)
        {
            Comando.CommandType = System.Data.CommandType.Text;
            Comando.CommandText = Consulta;
        }
        public void SetParametros(string Nombre, object Valor)
        {
            Comando.Parameters.AddWithValue(Nombre, Valor);
        }
        public void EjecutarLectura()
        {
            Comando.Connection = Conexion;
            try
            {
                Conexion.Open();
                Lector = Comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void EjecutarAccion()
        {
            Comando.Connection = Conexion;
            try
            {
                Conexion.Open();
                Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CerrarConexion()
        {
            if (Lector != null)
                Lector.Close();
            Conexion.Close();
        }
    }
}

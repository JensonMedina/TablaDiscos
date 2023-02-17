using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Datos
{
    public class TipoEdicionDatos
    {
        public List<TipoEdicion>Listar()
        {
            List<TipoEdicion> ListaTipoEdicion = new List<TipoEdicion>();
            AccesoDatos Datos = new AccesoDatos();
            try
            {
                string Consulta = "select Id, Descripcion from TIPOSEDICION";
                Datos.SetConsulta(Consulta);
                Datos.EjecutarLectura();
                while (Datos.lector.Read())
                {
                    TipoEdicion aux = new TipoEdicion();
                    aux.Id = (int)Datos.lector["Id"];
                    aux.Descripcion = (string)Datos.lector["Descripcion"];
                    ListaTipoEdicion.Add(aux);
                }
                return ListaTipoEdicion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Datos.CerrarConexion();
            }
        }
    }
}

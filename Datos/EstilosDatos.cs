using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Datos
{
    public class EstilosDatos
    {
        public List<Estilos>Listar()
        {
            List<Estilos> ListaEstilos = new List<Estilos>();
            AccesoDatos Datos = new AccesoDatos();
            try
            {
                string Consulta = "select Id, Descripcion from ESTILOS";
                Datos.SetConsulta(Consulta);
                Datos.EjecutarLectura();
                while (Datos.lector.Read())
                {
                    Estilos aux = new Estilos();
                    aux.Id = (int)Datos.lector["Id"];
                    aux.Descripcion = (string)Datos.lector["Descripcion"];
                    ListaEstilos.Add(aux);
                }
                return ListaEstilos;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Datos
{
    public class DiscosDatos
    {

        public List<Discos> Listar()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Discos> lista = new List<Discos>();
            try
            {
                string Consulta = "select  D.Id, D.Titulo, D.FechaLanzamiento Fecha, D.CantidadCanciones Canciones, D.UrlImagenTapa Imagen, E.Descripcion Estilo, T.Descripcion Edicion, D.IdEstilo, D.IdTipoEdicion from DISCOS D, ESTILOS E, TIPOSEDICION T where E.Id = D.IdEstilo And T.Id = D.IdTipoEdicion";
                datos.SetConsulta(Consulta);
                datos.EjecutarLectura();
                while (datos.lector.Read())
                {
                    Discos aux = new Discos();
                    aux.Id = (int)datos.lector["Id"];
                    aux.Titulo = (string)datos.lector["Titulo"];
                    aux.FechaLanzamiento = (DateTime)datos.lector["Fecha"];
                    aux.CantidadCanciones = (int)datos.lector["Canciones"];
                    if (!(datos.lector["Imagen"] is DBNull))
                        aux.UrlImagen = (string)datos.lector["Imagen"];
                    aux.Estilos = new Estilos();
                    aux.Estilos.Id = (int)datos.lector["IdEstilo"];
                    aux.Estilos.Descripcion = (string)datos.lector["Estilo"];
                    aux.Edicion = new TipoEdicion();
                    aux.Edicion.Id = (int)datos.lector["IdTipoEdicion"];
                    aux.Edicion.Descripcion = (string)datos.lector["Edicion"];
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public void Agregar(Discos Nuevo)
        {
            AccesoDatos Datos = new AccesoDatos();
            try
            {
                string Consulta = "insert into DISCOS (Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa,IdEstilo, IdTipoEdicion ) values (@Titulo, @Fecha, @Canciones, @Imagen, @IdEstilo, @IdTipoEdicion)";
                Datos.SetConsulta(Consulta);
                Datos.SetParametros("@Titulo", Nuevo.Titulo);
                Datos.SetParametros("@Fecha", Nuevo.FechaLanzamiento);
                Datos.SetParametros("@Canciones", Nuevo.CantidadCanciones);
                Datos.SetParametros("@Imagen", Nuevo.UrlImagen);
                Datos.SetParametros("@IdEstilo", Nuevo.Estilos.Id);
                Datos.SetParametros("@IdTipoEdicion", Nuevo.Edicion.Id);
                Datos.EjecutarAccion();
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
        public void Modificar(Discos Modificado)
        {
            AccesoDatos Datos = new AccesoDatos();
            try
            {
                String Consulta = "update DISCOS set Titulo = @Titulo, FechaLanzamiento = @Fecha, CantidadCanciones = @Canciones, UrlImagenTapa = @Imagen, IdEstilo = @Estilo, IdTipoEdicion = @Edicion where Id = @Id";
                Datos.SetConsulta(Consulta);
                Datos.SetParametros("@Titulo", Modificado.Titulo );
                Datos.SetParametros("@Fecha", Modificado.FechaLanzamiento);
                Datos.SetParametros("@Canciones", Modificado.CantidadCanciones);
                Datos.SetParametros("@Imagen", Modificado.UrlImagen);
                Datos.SetParametros("@Estilo", Modificado.Estilos.Id);
                Datos.SetParametros("@Edicion", Modificado.Edicion.Id);
                Datos.SetParametros("@Id" , Modificado.Id);
                Datos.EjecutarAccion();
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

        public List<Discos> Filtrar(string Campo, string Criterio, string Filtro)
        {
            List<Discos> Lista = new List<Discos>();
            AccesoDatos Datos = new AccesoDatos();
            try
            {
                string Consulta = "select  D.Id, D.Titulo, D.FechaLanzamiento Fecha, D.CantidadCanciones Canciones, D.UrlImagenTapa Imagen, E.Descripcion Estilo, T.Descripcion Edicion, D.IdEstilo, D.IdTipoEdicion from DISCOS D, ESTILOS E, TIPOSEDICION T where E.Id = D.IdEstilo And T.Id = D.IdTipoEdicion And ";
                if(Campo == "Titulo")
                {
                    switch (Criterio)
                    {
                        case "Comienza con":
                            Consulta += "Titulo like '" + Filtro + "%' ";
                            break;
                        case "Termina con":
                            Consulta += "Titulo like '%" + Filtro + "'";
                            break;
                        default:
                            Consulta += "Titulo like '%" + Filtro + "%'";
                            break;
                    }
                }
                else if (Campo == "Cantidad de canciones")
                {
                    switch (Criterio)
                    {
                        case "Mayor a":
                            Consulta += "CantidadCanciones > " + Filtro;
                            break;
                        case "Menor a":
                            Consulta += "CantidadCanciones < " + Filtro;
                            break;
                        default:
                            Consulta += "CantidadCanciones = " + Filtro;
                            break;
                    }
                }
                else if(Campo == "Estilo")
                {
                    switch (Criterio)
                    {
                        case "Comienza con":
                            Consulta += "E.Descripcion like '" + Filtro + "%' ";
                            break;
                        case "Termina con":
                            Consulta += "E.Descripcion like '%" + Filtro + "'";
                            break;
                        default:
                            Consulta += "E.Descripcion like '%" + Filtro + "%'";
                            break;
                    }
                }
                else
                {
                    switch (Criterio)
                    {
                        case "Comienza con":
                            Consulta += "T.Descripcion like '" + Filtro + "%' ";
                            break;
                        case "Termina con":
                            Consulta += "T.Descripcion like '%" + Filtro + "'";
                            break;
                        default:
                            Consulta += "T.Descripcion like '%" + Filtro + "%'";
                            break;
                    }
                }
                Datos.SetConsulta(Consulta);
                Datos.EjecutarLectura();

                while(Datos.lector.Read())
                {
                    Discos aux = new Discos();
                    aux.Id = (int)Datos.lector["Id"];
                    aux.Titulo = (string)Datos.lector["Titulo"];
                    aux.FechaLanzamiento = (DateTime)Datos.lector["Fecha"];
                    aux.CantidadCanciones = (int)Datos.lector["Canciones"];
                    if (!(Datos.lector["Imagen"] is DBNull))
                        aux.UrlImagen = (string)Datos.lector["Imagen"];
                    aux.Estilos = new Estilos();
                    aux.Estilos.Id = (int)Datos.lector["IdEstilo"];
                    aux.Estilos.Descripcion = (string)Datos.lector["Estilo"];
                    aux.Edicion = new TipoEdicion();
                    aux.Edicion.Id = (int)Datos.lector["IdTipoEdicion"];
                    aux.Edicion.Descripcion = (string)Datos.lector["Edicion"];
                    Lista.Add(aux);
                }
                return Lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Eliminar(int Id)
        {
            AccesoDatos Datos = new AccesoDatos();
            try
            {
                Datos.SetConsulta("delete from DISCOS where Id = @Id");
                Datos.SetParametros("@Id", Id);
                Datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}

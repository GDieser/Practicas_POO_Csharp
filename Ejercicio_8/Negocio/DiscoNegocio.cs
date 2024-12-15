using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class DiscoNegocio
    {
        public List<Disco> listar()
        {
            List<Disco> discos = new List<Disco>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=DESKTOP-O2NKURA\\SQLEXPRESS01; database=DISCOS_DB2; Integrated Security=True; TrustServerCertificate=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select D.Id, Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, E.Descripcion As EstiloDescripcion, T.Descripcion As TipoDescripcion, E.Id As IdEstilo, T.Id As IdTipo From DISCOS D, ESTILOS E, TIPOSEDICION T Where E.Id = D.IdEstilo And D.IdTipoEdicion = T.Id";

                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Disco aux = new Disco();

                    aux.IdDisco = (int)lector["Id"];
                    aux.Titulo = (string)lector["Titulo"];
                    //Transformamos a String
                    DateTime fecha = (DateTime)lector["FechaLanzamiento"];
                    aux.FechaLanzamiento = fecha.ToString("yyyy-MM-dd");
                    //aux.FechaLanzamiento = (DateTime)lector["FechaLanzamiento"];

                    aux.CantidadCanciones = (int)lector["CantidadCanciones"];

                    //Opciones para registros nulos

                    //if(!(lector.IsDBNull(lector.GetOrdinal("UrlImagenTapa"))))
                    //    aux.UrlImagen = (string)lector["UrlImagenTapa"];

                    if (!(lector["UrlImagenTapa"] is DBNull))
                        aux.UrlImagen = (string)lector["UrlImagenTapa"];

                    //Estilo, composicion (instanciamos)

                    aux.EstiloDisco = new Estilo();
                    aux.EstiloDisco.Descripcion = (string)lector["EstiloDescripcion"];
                    aux.EstiloDisco.IdEstilo = (int)lector["IdEstilo"];

                    aux.Tipo = new TipoEdicion();
                    aux.Tipo.Descripcion = (string)lector["TipoDescripcion"];
                    aux.Tipo.IdTipo = (int)lector["IdTipo"];

                    discos.Add(aux);
                }

                conexion.Close();
                return discos;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void agregar(Disco disco)
        {
            AccesoDatos dato = new AccesoDatos();

            try
            {
                dato.setConsulta("Insert Into DISCOS Values ('" + disco.Titulo + "', '" + disco.FechaLanzamiento + "', " + disco.CantidadCanciones + ", '" + disco.UrlImagen + "', " + disco.IdEstilo + ", " + disco.IdTipoEdicion + ")");
                dato.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                dato.cerrarConexion();
            }

        }

        public void modificar(Disco disco)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta("UPDATE DISCOS SET  Titulo = @titulo, FechaLanzamiento = @fecha, CantidadCanciones = @canciones, UrlImagenTapa = @url, IdEstilo = @idestilo, IdTipoEdicion = @idtipo WHERE Id = @id");
                datos.setParametro("@titulo", disco.Titulo);
                datos.setParametro("@fecha", disco.FechaLanzamiento);
                datos.setParametro("@canciones", disco.CantidadCanciones);
                datos.setParametro("@url", disco.UrlImagen);
                datos.setParametro("@idestilo", disco.IdEstilo);
                datos.setParametro("@idtipo", disco.IdTipoEdicion);
                datos.setParametro("@id", disco.IdDisco);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }

        public void eliminarFisico(int idDisco)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setConsulta("DELETE FROM DISCOS WHERE Id = @idDisco");
                datos.setParametro("@idDisco", idDisco);
                datos.ejecutarAccion();

                datos.cerrarConexion();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }


}

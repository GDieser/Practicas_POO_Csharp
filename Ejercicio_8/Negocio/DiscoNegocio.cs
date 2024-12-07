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
                comando.CommandText = "Select Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, E.Descripcion, T.Descripcion  From DISCOS D, ESTILOS E, TIPOSEDICION T Where E.Id = D.IdEstilo And D.IdTipoEdicion = T.Id";

                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while(lector.Read())
                {
                    Disco aux = new Disco();

                    aux.Titulo = (string)lector["Titulo"];
                    //Transformamos a String
                    DateTime fecha =  (DateTime)lector["FechaLanzamiento"];
                    aux.FechaLanzamiento = fecha.ToString("yyyy/mm/dd");

                    aux.CantidadCanciones = (int)lector["CantidadCanciones"];
                    aux.UrlImagen = (string)lector["UrlImagenTapa"];

                    //Estilo, composicion (instanciamos)
                    aux.EstiloDisco = new Estilo();
                    aux.EstiloDisco.Descripcion = (string)lector["Descripcion"];

                    aux.Tipo = new TipoEdicion();
                    aux.Tipo.Descripcion = (string)lector["Descripcion"];

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
    }
}

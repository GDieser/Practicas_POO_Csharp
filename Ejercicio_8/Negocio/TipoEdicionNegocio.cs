using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class TipoEdicionNegocio
    {
        public List<TipoEdicion> listar()
        {
			List<TipoEdicion> lista = new List<TipoEdicion>();

			AccesoDatos acceso = new AccesoDatos();

			try
			{
				acceso.setConsulta("Select Id, Descripcion From TIPOSEDICION");
				acceso.ejecutarConsulta();

				while (acceso.Lector.Read())
				{
					TipoEdicion aux = new TipoEdicion();

					aux.IdTipo = (int)acceso.Lector["Id"];
					aux.Descripcion = (string)acceso.Lector["Descripcion"];

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
				acceso.cerrarConexion();
			}
        }
    }
}

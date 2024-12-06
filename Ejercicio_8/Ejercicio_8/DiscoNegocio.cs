using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;


namespace Ejercicio_8
{
    internal class DiscoNegocio
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
                comando.CommandText = "Select Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa From DISCOS";

                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while(lector.Read())
                {
                    Disco aux = new Disco();

                    aux.Titulo = (string)lector["Titulo"];

                    DateTime fecha =  (DateTime)lector["FechaLanzamiento"];
                    aux.FechaLanzamiento = fecha.ToString("yyyy/mm/dd");

                    aux.CantidadCanciones = (int)lector["CantidadCanciones"];
                    aux.UrlImagen = (string)lector["UrlImagenTapa"];

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

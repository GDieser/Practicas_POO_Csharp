using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Disco
    {
        public string Titulo { get; set; }

        public string FechaLanzamiento { get; set; }

        public int CantidadCanciones { get; set; }

        public string UrlImagen { get; set; }

        public int IdEstilo { get; set; }

        public int IdTipoEdicion { get; set; }

        public Estilo EstiloDisco { get; set; }
        public TipoEdicion Tipo { get; set; }
    }
}

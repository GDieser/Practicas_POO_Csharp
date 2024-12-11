using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Disco
    {
        public int IdDisco { get; set; }
        public string Titulo { get; set; }

        [DisplayName("Lanzamiento")]
        public string FechaLanzamiento { get; set; }

        [DisplayName("Canciones")]
        public int CantidadCanciones { get; set; }

        public string UrlImagen { get; set; }

        public int IdEstilo { get; set; }

        public int IdTipoEdicion { get; set; }

        [DisplayName("Estilo Disco")]
        public Estilo EstiloDisco { get; set; }

        [DisplayName("Tipo")]
        public TipoEdicion Tipo { get; set; }
    }
}

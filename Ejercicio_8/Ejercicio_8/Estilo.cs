using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    internal class Estilo
    {
        public int IdEstilo { get; set; }
        public string Descripcion { get; set; }

        //Sobreescribimos el metodo
        public override string ToString()
        {
            return Descripcion;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public void presentarse()
        {
            Console.WriteLine("Hola mi nombre es: " + Nombre + " y mi edad es: " +Edad);
        }
    }
}

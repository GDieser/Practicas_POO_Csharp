using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Persona1
    {
        private string nombre;
        private int edad;

        public Persona1(string nombre, int edad)
        {
            this.nombre = nombre;

            this.edad = edad;
        }

        public void presentarse()
        {
            Console.WriteLine("Hola mi nombre es: " + nombre + " y mi edad es: " + edad);
        }
    }
}

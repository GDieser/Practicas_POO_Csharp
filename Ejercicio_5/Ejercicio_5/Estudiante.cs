using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    internal class Estudiante
    {
        private string nombre;
        private double nota;

        public Estudiante(string nombre, double nota)
        {
            this.nombre = nombre;
            this.nota = nota;
        }
        public string getNombre()
        {
            return nombre;
        }
        public double getNota() 
        {
            return nota; 
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Vehiculo
    {
        public string Marca { get; set; }
        public int Velocidad { get; set; }

        public void acelerar(int cantidad)
        {
            this.Velocidad += cantidad;
        }

        public void frenar(int cantidad)
        {
            this.Velocidad -= cantidad;
        }

        public void mostrarEstado()
        {
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Velocidad: " + Velocidad);
        }
    }
}

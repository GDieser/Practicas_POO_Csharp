using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    internal class Animal
    {
        private string Nombre;
        private string Raza;
        private float Peso;
        private float Altura;

        public Animal(string nombre, string raza, float peso, float altura)
        {
            Nombre = nombre;
            Raza = raza;
            Peso = peso;
            Altura = altura;
        }

        public string getNombre() { return Nombre; }
        public string getRaza() { return Raza; }
        public float getPeso() { return Peso; }
        public float getAltura() { return Altura; }

    }
}

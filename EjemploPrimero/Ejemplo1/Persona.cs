using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Persona
    {
        private int _edad;
        private float _sueldo;
        private string _nombre;

        public Persona(string nombre) 
        {
            this._nombre = nombre;
        }

        public void setNombre(string nombre)
        {
            this._nombre = nombre;
        }

        public void setEdad(int edad)
        {
            _edad = edad; 
        }

        public int getEdad()
        {
            return _edad;
        }

        public string saludar()
        {
            return _nombre; 
        }


    }
}

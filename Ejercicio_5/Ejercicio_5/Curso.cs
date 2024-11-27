using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Ejercicio_5
{
    internal class Curso
    {
        private List<Estudiante> estudiantes;

        public Curso()
        {
            estudiantes = new List<Estudiante>();
        }

        public void agregarEstudiante(string nombre, double nota)
        {
            Estudiante estudiante = new Estudiante(nombre, nota);

            estudiantes.Add(estudiante);
        }

        public void mostrarEstudiante()
        {
            foreach (var item in estudiantes)
            {
                Estudiante estudiante = item as Estudiante;
                Console.WriteLine("Nombre: " + estudiante.getNombre());
            }
        }

        public void calcularPromedio()
        {
            double promedio = 0;


            foreach (var item in estudiantes)
            {
                promedio += item.getNota();
            }

            promedio = promedio / estudiantes.Count;

            Console.WriteLine("Promedio: " + promedio);
        }
    }
}
